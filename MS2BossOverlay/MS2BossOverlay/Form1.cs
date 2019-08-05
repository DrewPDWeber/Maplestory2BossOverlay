using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MS2BossOverlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // ReSharper disable once IdentifierTypo
        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        BossStructure[] _bosses;
        private void Form1_Load(object sender, EventArgs e)
        {
            var genBossStruct = new Bosses();
            _bosses = genBossStruct.Decode(WebClient.GetBosses());

            UI_Updater.Enabled = true;

        }

        private int _requester = 9;
        private void UI_Updater_Tick(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Topmost)
                TopMost = true;

            timerLabel.Text = DateTime.UtcNow.AddMinutes(Properties.Settings.Default.TimerOffset).ToString("mm:ss") ;

            _requester++;
            if (_requester <= 10) return; 

            GenerateBossPanels();
            _requester = 0;
            
    
        }

        private void GenerateBossPanels()
        {
            var row = 1;
            var column = 0;
            var tt = new ToolTip();
            worldBossPanel.Controls.Clear();
            foreach (var boss in _bosses)
            {
                if (!IsCurrent(boss)) continue;

                var wb = new GroupBox { Size = new Size(175, 100),Location = new Point(35 + column * 175, (row-1) * 90) };

                var name = new Label {Text = boss.Name, Location = new Point(50, 25), Font = new Font("Arial", 7) };

                var map = new Label {Text = boss.Map, Location = new Point(50, 45), Font = new Font("Arial", 7)};
                map.Click += (s, e) => 
                {
                    Clipboard.SetText(string.Join(string.Empty, s.ToString().Skip(34)));
                };

                var time = new Label
                {
                    Text = + boss.Minutes + @"-" + (boss.Minutes + boss.Open), Location = new Point(50, 65),
                    Font = new Font("Arial", 7)
                };

                var img = new PictureBox
                {
                    Image = WebClient.GetBossImage(boss.Name.ToLower()),
                    Location = new Point(0*column, 30),
                    Size = new Size(50, 50),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                wb.Controls.Add(name);
                wb.Controls.Add(map);
                wb.Controls.Add(time);
                wb.Controls.Add(img);

                tt.SetToolTip(name,"This is the name of the world boss");
                tt.SetToolTip(map, "Click the map text to copy to clipboard");
                tt.SetToolTip(time, "Time the boss is active");
                tt.SetToolTip(img, "What the boss \"should\" look like");
                worldBossPanel.Controls.Add(wb);

                if ((column++) == 1)
                {
                    row++;
                    column = 0;
                }
            }

            //MessageBox.Show(row.ToString());
    
            Height = row == 1 && column == 0 ? 80 : column == 0 ? 80 + ((row-1)*100) : 80 + (row * 100);
        }

        private bool IsCurrent(BossStructure boss)
        {
            //var nowMinutes = 5;
            var nowMinutes = int.Parse(DateTime.UtcNow.ToString("mm")) + Properties.Settings.Default.TimerOffset;
            var start = boss.Minutes - Properties.Settings.Default.BossOffset;
            var end = boss.Minutes + boss.Open;

            if (end <= 60) return nowMinutes >= start && nowMinutes <= end;
            if (nowMinutes > 15) return nowMinutes >= start && nowMinutes <= end;

            end -= 60;
            if (nowMinutes <= end)
            {
                return true;
            }

            return nowMinutes >= start && nowMinutes <= end;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            UI_Updater.Enabled = false;
            Close();
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }

        private void TopLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"A project created mainly for myself. Hover your mouse over text to view tips. Click the help button to open the github page for updates or to view the source code",
                @"About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                0,
                helpFilePath: "https://github.com/ImSpare/Maplestory2BossOverlay"
            );

        }

        private void DebugButton_Click(object sender, EventArgs e)
        {
            foreach (var boss in _bosses)
            {
                if(IsCurrent(boss))
                    MessageBox.Show(boss.Name);
            }
        }
        private Settings settingsForm;
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            settingsForm?.Close();

            settingsForm = new Settings();
            settingsForm.Show();
        }
    }
}
