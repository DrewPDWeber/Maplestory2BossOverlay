namespace MS2BossOverlay
{
    partial class Form1
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
            this.timerLabel = new System.Windows.Forms.Label();
            this.UI_Updater = new System.Windows.Forms.Timer(this.components);
            this.helpButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Panel();
            this.worldBossPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.debugButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(162, 60);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(91, 20);
            this.timerLabel.TabIndex = 3;
            this.timerLabel.Text = "Timer Label";
            // 
            // UI_Updater
            // 
            this.UI_Updater.Interval = 1000;
            this.UI_Updater.Tick += new System.EventHandler(this.UI_Updater_Tick);
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(359, 52);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(60, 21);
            this.helpButton.TabIndex = 11;
            this.helpButton.Text = "About";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MS2BossOverlay.Properties.Resources.panel;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 54);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(146, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(135, 20);
            this.topLabel.TabIndex = 6;
            this.topLabel.Text = "MS2 Boss Timer";
            this.topLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopLabel_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::MS2BossOverlay.Properties.Resources.close;
            this.closeButton.Location = new System.Drawing.Point(381, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(27, 27);
            this.closeButton.TabIndex = 7;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // worldBossPanel
            // 
            this.worldBossPanel.Location = new System.Drawing.Point(0, 82);
            this.worldBossPanel.Name = "worldBossPanel";
            this.worldBossPanel.Size = new System.Drawing.Size(416, 375);
            this.worldBossPanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Active Bosses";
            // 
            // debugButton
            // 
            this.debugButton.Location = new System.Drawing.Point(278, 52);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(75, 23);
            this.debugButton.TabIndex = 13;
            this.debugButton.Text = "debug";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Visible = false;
            this.debugButton.Click += new System.EventHandler(this.DebugButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 80);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.debugButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.worldBossPanel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.timerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer UI_Updater;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Panel closeButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Panel worldBossPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button debugButton;
    }
}

