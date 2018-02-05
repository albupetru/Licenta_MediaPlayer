namespace Licenta_MediaPlayer
{
    partial class OptionsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsWindow));
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.textBoxSaveFolder = new System.Windows.Forms.TextBox();
            this.groupBoxRecording = new System.Windows.Forms.GroupBox();
            this.labelSaveFolder = new System.Windows.Forms.Label();
            this.buttonBrowseSave = new System.Windows.Forms.Button();
            this.groupBoxSocial = new System.Windows.Forms.GroupBox();
            this.labelTwitterAccLink = new System.Windows.Forms.Label();
            this.checkBoxTwitterAccLink = new System.Windows.Forms.CheckBox();
            this.buttonTwitterAccSet = new System.Windows.Forms.Button();
            this.groupBoxRecording.SuspendLayout();
            this.groupBoxSocial.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(293, 226);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(212, 226);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(75, 23);
            this.buttonAbort.TabIndex = 1;
            this.buttonAbort.Text = "Abort";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // textBoxSaveFolder
            // 
            this.textBoxSaveFolder.Enabled = false;
            this.textBoxSaveFolder.Location = new System.Drawing.Point(76, 19);
            this.textBoxSaveFolder.Name = "textBoxSaveFolder";
            this.textBoxSaveFolder.Size = new System.Drawing.Size(224, 20);
            this.textBoxSaveFolder.TabIndex = 2;
            // 
            // groupBoxRecording
            // 
            this.groupBoxRecording.Controls.Add(this.labelSaveFolder);
            this.groupBoxRecording.Controls.Add(this.buttonBrowseSave);
            this.groupBoxRecording.Controls.Add(this.textBoxSaveFolder);
            this.groupBoxRecording.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRecording.Name = "groupBoxRecording";
            this.groupBoxRecording.Size = new System.Drawing.Size(356, 54);
            this.groupBoxRecording.TabIndex = 3;
            this.groupBoxRecording.TabStop = false;
            this.groupBoxRecording.Text = "Recording";
            // 
            // labelSaveFolder
            // 
            this.labelSaveFolder.AutoSize = true;
            this.labelSaveFolder.Location = new System.Drawing.Point(6, 23);
            this.labelSaveFolder.Name = "labelSaveFolder";
            this.labelSaveFolder.Size = new System.Drawing.Size(64, 13);
            this.labelSaveFolder.TabIndex = 4;
            this.labelSaveFolder.Text = "Save Folder";
            // 
            // buttonBrowseSave
            // 
            this.buttonBrowseSave.Location = new System.Drawing.Point(306, 19);
            this.buttonBrowseSave.Name = "buttonBrowseSave";
            this.buttonBrowseSave.Size = new System.Drawing.Size(30, 20);
            this.buttonBrowseSave.TabIndex = 5;
            this.buttonBrowseSave.Text = "...";
            this.buttonBrowseSave.UseVisualStyleBackColor = true;
            this.buttonBrowseSave.Click += new System.EventHandler(this.buttonBrowseSave_Click);
            // 
            // groupBoxSocial
            // 
            this.groupBoxSocial.Controls.Add(this.buttonTwitterAccSet);
            this.groupBoxSocial.Controls.Add(this.checkBoxTwitterAccLink);
            this.groupBoxSocial.Controls.Add(this.labelTwitterAccLink);
            this.groupBoxSocial.Location = new System.Drawing.Point(12, 73);
            this.groupBoxSocial.Name = "groupBoxSocial";
            this.groupBoxSocial.Size = new System.Drawing.Size(356, 52);
            this.groupBoxSocial.TabIndex = 4;
            this.groupBoxSocial.TabStop = false;
            this.groupBoxSocial.Text = "Social";
            // 
            // labelTwitterAccLink
            // 
            this.labelTwitterAccLink.AutoSize = true;
            this.labelTwitterAccLink.Location = new System.Drawing.Point(6, 23);
            this.labelTwitterAccLink.Name = "labelTwitterAccLink";
            this.labelTwitterAccLink.Size = new System.Drawing.Size(112, 13);
            this.labelTwitterAccLink.TabIndex = 0;
            this.labelTwitterAccLink.Text = "Twitter account linked";
            // 
            // checkBoxTwitterAccLink
            // 
            this.checkBoxTwitterAccLink.AutoSize = true;
            this.checkBoxTwitterAccLink.Enabled = false;
            this.checkBoxTwitterAccLink.Location = new System.Drawing.Point(124, 23);
            this.checkBoxTwitterAccLink.Name = "checkBoxTwitterAccLink";
            this.checkBoxTwitterAccLink.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTwitterAccLink.TabIndex = 1;
            this.checkBoxTwitterAccLink.UseVisualStyleBackColor = true;
            // 
            // buttonTwitterAccSet
            // 
            this.buttonTwitterAccSet.Location = new System.Drawing.Point(254, 18);
            this.buttonTwitterAccSet.Name = "buttonTwitterAccSet";
            this.buttonTwitterAccSet.Size = new System.Drawing.Size(82, 23);
            this.buttonTwitterAccSet.TabIndex = 2;
            this.buttonTwitterAccSet.Text = "Link account";
            this.buttonTwitterAccSet.UseVisualStyleBackColor = true;
            this.buttonTwitterAccSet.Click += new System.EventHandler(this.buttonTwitterAccSet_Click);
            // 
            // OptionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 261);
            this.Controls.Add(this.groupBoxSocial);
            this.Controls.Add(this.groupBoxRecording);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsWindow_Load);
            this.groupBoxRecording.ResumeLayout(false);
            this.groupBoxRecording.PerformLayout();
            this.groupBoxSocial.ResumeLayout(false);
            this.groupBoxSocial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.TextBox textBoxSaveFolder;
        private System.Windows.Forms.GroupBox groupBoxRecording;
        private System.Windows.Forms.Label labelSaveFolder;
        private System.Windows.Forms.Button buttonBrowseSave;
        private System.Windows.Forms.GroupBox groupBoxSocial;
        private System.Windows.Forms.Button buttonTwitterAccSet;
        private System.Windows.Forms.CheckBox checkBoxTwitterAccLink;
        private System.Windows.Forms.Label labelTwitterAccLink;
    }
}