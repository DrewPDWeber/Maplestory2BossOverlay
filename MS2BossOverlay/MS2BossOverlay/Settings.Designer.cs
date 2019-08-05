namespace MS2BossOverlay
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topmostCheckBox = new System.Windows.Forms.CheckBox();
            this.timerUpDown = new System.Windows.Forms.NumericUpDown();
            this.bossUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTipper = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timerUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // topmostCheckBox
            // 
            this.topmostCheckBox.AutoSize = true;
            this.topmostCheckBox.Location = new System.Drawing.Point(179, 15);
            this.topmostCheckBox.Name = "topmostCheckBox";
            this.topmostCheckBox.Size = new System.Drawing.Size(15, 14);
            this.topmostCheckBox.TabIndex = 0;
            this.topmostCheckBox.UseVisualStyleBackColor = true;
            this.topmostCheckBox.CheckedChanged += new System.EventHandler(this.TopmostCheckBox_CheckedChanged);
            // 
            // timerUpDown
            // 
            this.timerUpDown.Location = new System.Drawing.Point(159, 38);
            this.timerUpDown.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.timerUpDown.Name = "timerUpDown";
            this.timerUpDown.Size = new System.Drawing.Size(50, 20);
            this.timerUpDown.TabIndex = 1;
            this.timerUpDown.ValueChanged += new System.EventHandler(this.TimerUpDown_ValueChanged);
            // 
            // bossUpDown
            // 
            this.bossUpDown.Location = new System.Drawing.Point(159, 66);
            this.bossUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.bossUpDown.Name = "bossUpDown";
            this.bossUpDown.Size = new System.Drawing.Size(50, 20);
            this.bossUpDown.TabIndex = 2;
            this.bossUpDown.ValueChanged += new System.EventHandler(this.BossUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timer Offset";
            this.toolTipper.SetToolTip(this.label1, "Add X minutes to timer to sync with maplestory2 servers");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Boss Offset";
            this.toolTipper.SetToolTip(this.label2, "How early in minutes to show when a boss is spawning IE 3 minutes");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Keep Top Most";
            this.toolTipper.SetToolTip(this.label3, "Keep this application above every other process");
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 105);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bossUpDown);
            this.Controls.Add(this.timerUpDown);
            this.Controls.Add(this.topmostCheckBox);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timerUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox topmostCheckBox;
        private System.Windows.Forms.NumericUpDown timerUpDown;
        private System.Windows.Forms.NumericUpDown bossUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTipper;
    }
}