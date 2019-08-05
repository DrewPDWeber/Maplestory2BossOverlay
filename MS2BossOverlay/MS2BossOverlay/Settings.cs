using System;
using System.Windows.Forms;

namespace MS2BossOverlay
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            timerUpDown.Value = Properties.Settings.Default.TimerOffset;
            bossUpDown.Value = Properties.Settings.Default.BossOffset;
            topmostCheckBox.Checked = Properties.Settings.Default.Topmost;
        }

        private void TimerUpDown_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TimerOffset = (int)timerUpDown.Value;
            Properties.Settings.Default.Save();
        }

        private void BossUpDown_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BossOffset = (int)bossUpDown.Value;
            Properties.Settings.Default.Save();
        }

        private void TopmostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Topmost = topmostCheckBox.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
