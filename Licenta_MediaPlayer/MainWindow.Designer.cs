namespace Licenta_MediaPlayer
{
    partial class MainWindow
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
            this.myVlcControl = new Vlc.DotNet.Forms.VlcControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_play = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.trackBarElapsed = new System.Windows.Forms.TrackBar();
            this.button_volume = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.myVlcControl)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarElapsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // myVlcControl
            // 
            this.myVlcControl.BackColor = System.Drawing.Color.Black;
            this.myVlcControl.Location = new System.Drawing.Point(0, 27);
            this.myVlcControl.Name = "myVlcControl";
            this.myVlcControl.Size = new System.Drawing.Size(670, 361);
            this.myVlcControl.Spu = -1;
            this.myVlcControl.TabIndex = 5;
            this.myVlcControl.Text = "vlcControl2";
            this.myVlcControl.VlcLibDirectory = null;
            this.myVlcControl.VlcMediaplayerOptions = null;
            this.myVlcControl.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.OnVlcControlNeedsLibDirectory);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(12, 393);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(43, 23);
            this.button_play.TabIndex = 7;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(110, 393);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(43, 23);
            this.button_stop.TabIndex = 8;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(61, 393);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(43, 23);
            this.button_pause.TabIndex = 9;
            this.button_pause.Text = "Pause";
            this.button_pause.UseVisualStyleBackColor = true;
            // 
            // trackBarElapsed
            // 
            this.trackBarElapsed.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarElapsed.Location = new System.Drawing.Point(160, 394);
            this.trackBarElapsed.Name = "trackBarElapsed";
            this.trackBarElapsed.Size = new System.Drawing.Size(417, 45);
            this.trackBarElapsed.TabIndex = 10;
            // 
            // button_volume
            // 
            this.button_volume.Location = new System.Drawing.Point(594, 395);
            this.button_volume.Name = "button_volume";
            this.button_volume.Size = new System.Drawing.Size(75, 23);
            this.button_volume.TabIndex = 11;
            this.button_volume.Text = "Volume";
            this.button_volume.UseVisualStyleBackColor = true;
            this.button_volume.Click += new System.EventHandler(this.button_volume_Click);
            this.button_volume.MouseEnter += new System.EventHandler(this.button_volume_MouseEnter);
            this.button_volume.MouseLeave += new System.EventHandler(this.button_volume_MouseLeave);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.AutoSize = false;
            this.trackBarVolume.Location = new System.Drawing.Point(616, 276);
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolume.Size = new System.Drawing.Size(32, 113);
            this.trackBarVolume.TabIndex = 12;
            this.trackBarVolume.Visible = false;
            this.trackBarVolume.MouseLeave += new System.EventHandler(this.trackBarVolume_MouseLeave);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 420);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.button_volume);
            this.Controls.Add(this.trackBarElapsed);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.myVlcControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.myVlcControl)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarElapsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Vlc.DotNet.Forms.VlcControl myVlcControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.TrackBar trackBarElapsed;
        private System.Windows.Forms.Button button_volume;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TrackBar trackBarVolume;
    }
}