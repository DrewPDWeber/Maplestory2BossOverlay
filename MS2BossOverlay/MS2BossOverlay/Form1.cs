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

        /*
        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }
        */

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
            _bosses = genBossStruct.decode(WebClient.GetBosses());

            UI_Updater.Enabled = true;

        }

        private int _requester = 9;
        private void UI_Updater_Tick(object sender, EventArgs e)
        {
            TopMost = true;
            timerLabel.Text = DateTime.UtcNow.ToString("mm:ss");

            _requester++;
            if (_requester <= 10) return; // every 10 seconds generate panels

            GenerateBossPanels();
            _requester = 0;
            
    
        }

        private void GenerateBossPanels()
        {
            var row = 0;
            var column = 0;
            var tt = new ToolTip();
            worldBossPanel.Controls.Clear(); //clear current bosses
            foreach (var boss in _bosses)
            {
                if (IsCurrent(boss))
                {
                    var wb = new GroupBox { Size = new Size(200, 100),Location = new Point(5+ column * 200, row * 90) };

                    var name = new Label {Text = @"Name:" + boss.name, Location = new Point(75, 30)};

                    var map = new Label {Text = @"Map:" + boss.map, Location = new Point(75, 52)};
                    map.Click += (s, e) => 
                    {
                        Clipboard.SetText(string.Join(string.Empty, s.ToString().Skip(38)));
                    };

                    var time = new Label
                    {
                        Text = @"Time:" + boss.minutes + @"-" + (boss.minutes + boss.open), Location = new Point(75, 74)
                    };

                    var img = new PictureBox
                    {
                        Image = WebClient.GetBossImage(boss.name.ToLower()),
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
                        column = 0;
                        row++;
                    }
                }
            }

            Height = row == 0 && column == 0 ? 80 : 80 + (row * 100);
        }

        private bool IsCurrent(BossStructure boss)
        {
            var nowMinutes = int.Parse(DateTime.UtcNow.ToString("mm"));
            var start = boss.minutes-2;
            var end = boss.minutes + boss.open;

            if (end > 60)
            {
                if (nowMinutes <= 15)
                {
                    end -= 60;
                    if (nowMinutes <= end)
                    {
                        return true;
                    }
                }
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
            GenerateBossPanels();
        }

        private void DebugButton_Click(object sender, EventArgs e)
        {
            foreach (var boss in _bosses)
            {
                if(IsCurrent(boss))
                    MessageBox.Show(boss.name);
            }
        }
    }
}
