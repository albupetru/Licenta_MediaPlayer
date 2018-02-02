namespace Licenta_MediaPlayer
{
    partial class FacebookPostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookPostForm));
            this.button_post = new System.Windows.Forms.Button();
            this.label_priv = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.label_desc = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.richTextBoxTitle = new System.Windows.Forms.RichTextBox();
            this.panelWait = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelWait.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_post
            // 
            this.button_post.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_post.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_post.Location = new System.Drawing.Point(320, 265);
            this.button_post.Name = "button_post";
            this.button_post.Size = new System.Drawing.Size(118, 28);
            this.button_post.TabIndex = 0;
            this.button_post.Text = "Post on Facebook";
            this.button_post.UseVisualStyleBackColor = false;
            this.button_post.Click += new System.EventHandler(this.button_post_Click);
            // 
            // label_priv
            // 
            this.label_priv.AutoSize = true;
            this.label_priv.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_priv.Location = new System.Drawing.Point(6, 233);
            this.label_priv.Name = "label_priv";
            this.label_priv.Size = new System.Drawing.Size(141, 18);
            this.label_priv.TabIndex = 1;
            this.label_priv.Text = "Who should see this: ";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Friends",
            "Friends of Friends",
            "Everyone",
            "Just me"});
            this.comboBox.Location = new System.Drawing.Point(153, 232);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 23);
            this.comboBox.TabIndex = 2;
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDesc.Location = new System.Drawing.Point(153, 66);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(285, 143);
            this.richTextBoxDesc.TabIndex = 3;
            this.richTextBoxDesc.Text = "";
            // 
            // label_desc
            // 
            this.label_desc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_desc.Location = new System.Drawing.Point(6, 66);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(101, 36);
            this.label_desc.TabIndex = 4;
            this.label_desc.Text = "Say something  about this: ";
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(6, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(108, 36);
            this.label_title.TabIndex = 5;
            this.label_title.Text = "Give your video a title:";
            // 
            // richTextBoxTitle
            // 
            this.richTextBoxTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTitle.Location = new System.Drawing.Point(153, 12);
            this.richTextBoxTitle.Name = "richTextBoxTitle";
            this.richTextBoxTitle.Size = new System.Drawing.Size(285, 26);
            this.richTextBoxTitle.TabIndex = 6;
            this.richTextBoxTitle.Text = "";
            // 
            // panelWait
            // 
            this.panelWait.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelWait.Controls.Add(this.label1);
            this.panelWait.Location = new System.Drawing.Point(55, 75);
            this.panelWait.Name = "panelWait";
            this.panelWait.Size = new System.Drawing.Size(332, 122);
            this.panelWait.TabIndex = 7;
            this.panelWait.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please wait while the video is being uploaded!";
            // 
            // FacebookPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.panelWait);
            this.Controls.Add(this.richTextBoxTitle);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_desc);
            this.Controls.Add(this.richTextBoxDesc);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label_priv);
            this.Controls.Add(this.button_post);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacebookPostForm";
            this.Text = "Post to Facebook";
            this.Load += new System.EventHandler(this.FacebookPostForm_Load);
            this.panelWait.ResumeLayout(false);
            this.panelWait.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_post;
        private System.Windows.Forms.Label label_priv;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.Label label_desc;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.RichTextBox richTextBoxTitle;
        private System.Windows.Forms.Panel panelWait;
        private System.Windows.Forms.Label label1;
    }
}