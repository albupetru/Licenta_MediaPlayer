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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.myVlcControl = new Vlc.DotNet.Forms.VlcControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_play = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.trackBarElapsed = new System.Windows.Forms.TrackBar();
            this.button_volume = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.label_elapsed = new System.Windows.Forms.Label();
            this.label_toElapse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_record = new System.Windows.Forms.Button();
            this.button_share = new System.Windows.Forms.Button();
            this.button_fullscreen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTime = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelRec = new System.Windows.Forms.Panel();
            this.label_rec_duration = new System.Windows.Forms.Label();
            this.label_recd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myVlcControl)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarElapsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.panelTime.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelRec.SuspendLayout();
            this.SuspendLayout();
            // 
            // myVlcControl
            // 
            this.myVlcControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myVlcControl.BackColor = System.Drawing.Color.Black;
            this.myVlcControl.Location = new System.Drawing.Point(0, 27);
            this.myVlcControl.Name = "myVlcControl";
            this.myVlcControl.Size = new System.Drawing.Size(764, 385);
            this.myVlcControl.Spu = -1;
            this.myVlcControl.TabIndex = 5;
            this.myVlcControl.Text = "vlcControl2";
            this.myVlcControl.VlcLibDirectory = null;
            this.myVlcControl.VlcMediaplayerOptions = null;
            this.myVlcControl.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.OnVlcControlNeedsLibDirectory);
            this.myVlcControl.EndReached += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerEndReachedEventArgs>(this.myVlcControl_EndReached);
            this.myVlcControl.LengthChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerLengthChangedEventArgs>(this.OnVlcMediaLengthChanged);
            this.myVlcControl.Paused += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPausedEventArgs>(this.OnVlcPaused);
            this.myVlcControl.Playing += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPlayingEventArgs>(this.OnVlcPlaying);
            this.myVlcControl.PositionChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs>(this.OnVlcPositionChanged);
            this.myVlcControl.Stopped += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerStoppedEventArgs>(this.OnVlcStopped);
            this.myVlcControl.Click += new System.EventHandler(this.myVlcControl_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.openToolStripMenuItem.Text = "Open file...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button_play
            // 
            this.button_play.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_play.Location = new System.Drawing.Point(164, 25);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(60, 30);
            this.button_play.TabIndex = 7;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_stop
            // 
            this.button_stop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stop.Location = new System.Drawing.Point(230, 25);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(60, 30);
            this.button_stop.TabIndex = 8;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // trackBarElapsed
            // 
            this.trackBarElapsed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarElapsed.AutoSize = false;
            this.trackBarElapsed.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarElapsed.Location = new System.Drawing.Point(134, 5);
            this.trackBarElapsed.Maximum = 0;
            this.trackBarElapsed.Name = "trackBarElapsed";
            this.trackBarElapsed.Size = new System.Drawing.Size(611, 27);
            this.trackBarElapsed.TabIndex = 10;
            this.trackBarElapsed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarElapsed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBarElapsed_MouseDown);
            this.trackBarElapsed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarElapsed_MouseUp);
            // 
            // button_volume
            // 
            this.button_volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_volume.Location = new System.Drawing.Point(494, 25);
            this.button_volume.Name = "button_volume";
            this.button_volume.Size = new System.Drawing.Size(60, 30);
            this.button_volume.TabIndex = 11;
            this.button_volume.Text = "Mute";
            this.button_volume.UseVisualStyleBackColor = true;
            this.button_volume.Click += new System.EventHandler(this.button_volume_Click);
            this.button_volume.MouseEnter += new System.EventHandler(this.button_volume_MouseEnter);
            this.button_volume.MouseLeave += new System.EventHandler(this.button_volume_MouseLeave);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVolume.AutoSize = false;
            this.trackBarVolume.Location = new System.Drawing.Point(559, 25);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(186, 32);
            this.trackBarVolume.TabIndex = 12;
            this.trackBarVolume.Value = 100;
            this.trackBarVolume.ValueChanged += new System.EventHandler(this.trackBarVolume_ValueChanged);
            // 
            // label_elapsed
            // 
            this.label_elapsed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_elapsed.AutoSize = true;
            this.label_elapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_elapsed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_elapsed.Location = new System.Drawing.Point(0, 6);
            this.label_elapsed.Name = "label_elapsed";
            this.label_elapsed.Size = new System.Drawing.Size(57, 13);
            this.label_elapsed.TabIndex = 13;
            this.label_elapsed.Text = "00:00:00";
            // 
            // label_toElapse
            // 
            this.label_toElapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_toElapse.AutoSize = true;
            this.label_toElapse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_toElapse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_toElapse.Location = new System.Drawing.Point(73, 6);
            this.label_toElapse.Name = "label_toElapse";
            this.label_toElapse.Size = new System.Drawing.Size(57, 13);
            this.label_toElapse.TabIndex = 14;
            this.label_toElapse.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(59, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "/";
            // 
            // button_record
            // 
            this.button_record.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_record.ForeColor = System.Drawing.Color.Red;
            this.button_record.Location = new System.Drawing.Point(296, 25);
            this.button_record.Name = "button_record";
            this.button_record.Size = new System.Drawing.Size(60, 30);
            this.button_record.TabIndex = 16;
            this.button_record.Text = "Record";
            this.button_record.UseVisualStyleBackColor = true;
            this.button_record.Click += new System.EventHandler(this.button_record_Click);
            // 
            // button_share
            // 
            this.button_share.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_share.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_share.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_share.Location = new System.Drawing.Point(362, 25);
            this.button_share.Name = "button_share";
            this.button_share.Size = new System.Drawing.Size(60, 30);
            this.button_share.TabIndex = 17;
            this.button_share.Text = "Share";
            this.button_share.UseVisualStyleBackColor = true;
            this.button_share.Click += new System.EventHandler(this.button_share_Click);
            // 
            // button_fullscreen
            // 
            this.button_fullscreen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_fullscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fullscreen.Location = new System.Drawing.Point(428, 25);
            this.button_fullscreen.Name = "button_fullscreen";
            this.button_fullscreen.Size = new System.Drawing.Size(60, 30);
            this.button_fullscreen.TabIndex = 18;
            this.button_fullscreen.Text = "Fullscr";
            this.button_fullscreen.UseVisualStyleBackColor = true;
            this.button_fullscreen.Click += new System.EventHandler(this.button_fullscreen_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(30, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(65, 52);
            this.panel1.TabIndex = 19;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // panelTime
            // 
            this.panelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTime.BackColor = System.Drawing.Color.Black;
            this.panelTime.Controls.Add(this.label_toElapse);
            this.panelTime.Controls.Add(this.label2);
            this.panelTime.Controls.Add(this.label_elapsed);
            this.panelTime.Location = new System.Drawing.Point(9, 5);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(130, 23);
            this.panelTime.TabIndex = 20;
            this.panelTime.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTime_Paint);
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottom.Controls.Add(this.panelRec);
            this.panelBottom.Controls.Add(this.trackBarVolume);
            this.panelBottom.Controls.Add(this.button_stop);
            this.panelBottom.Controls.Add(this.button_record);
            this.panelBottom.Controls.Add(this.button_fullscreen);
            this.panelBottom.Controls.Add(this.button_share);
            this.panelBottom.Controls.Add(this.button_volume);
            this.panelBottom.Controls.Add(this.button_play);
            this.panelBottom.Controls.Add(this.panelTime);
            this.panelBottom.Controls.Add(this.trackBarElapsed);
            this.panelBottom.Location = new System.Drawing.Point(0, 407);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(764, 70);
            this.panelBottom.TabIndex = 21;
            // 
            // panelRec
            // 
            this.panelRec.BackColor = System.Drawing.Color.Red;
            this.panelRec.Controls.Add(this.label_rec_duration);
            this.panelRec.Controls.Add(this.label_recd);
            this.panelRec.Location = new System.Drawing.Point(9, 33);
            this.panelRec.Name = "panelRec";
            this.panelRec.Size = new System.Drawing.Size(130, 24);
            this.panelRec.TabIndex = 21;
            this.panelRec.Visible = false;
            // 
            // label_rec_duration
            // 
            this.label_rec_duration.AutoSize = true;
            this.label_rec_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rec_duration.ForeColor = System.Drawing.Color.White;
            this.label_rec_duration.Location = new System.Drawing.Point(79, 6);
            this.label_rec_duration.Name = "label_rec_duration";
            this.label_rec_duration.Size = new System.Drawing.Size(32, 13);
            this.label_rec_duration.TabIndex = 1;
            this.label_rec_duration.Text = "0:00";
            // 
            // label_recd
            // 
            this.label_recd.AutoSize = true;
            this.label_recd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_recd.ForeColor = System.Drawing.Color.White;
            this.label_recd.Location = new System.Drawing.Point(14, 6);
            this.label_recd.Name = "label_recd";
            this.label_recd.Size = new System.Drawing.Size(59, 13);
            this.label_recd.TabIndex = 0;
            this.label_recd.Text = "Duration:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(764, 476);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.myVlcControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "SociaPlayer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.DoubleClick += new System.EventHandler(this.MainWindow_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.myVlcControl)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarElapsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelRec.ResumeLayout(false);
            this.panelRec.PerformLayout();
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
        private System.Windows.Forms.TrackBar trackBarElapsed;
        private System.Windows.Forms.Button button_volume;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label label_elapsed;
        private System.Windows.Forms.Label label_toElapse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button button_record;
        private System.Windows.Forms.Button button_share;
        private System.Windows.Forms.Button button_fullscreen;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelRec;
        private System.Windows.Forms.Label label_rec_duration;
        private System.Windows.Forms.Label label_recd;
    }
}