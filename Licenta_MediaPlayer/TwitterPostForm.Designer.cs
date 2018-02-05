namespace Licenta_MediaPlayer
{
    partial class TwitterPostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwitterPostForm));
            this.panelWait = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_desc = new System.Windows.Forms.Label();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.button_post = new System.Windows.Forms.Button();
            this.panelWait.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWait
            // 
            this.panelWait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.panelWait.Controls.Add(this.label1);
            this.panelWait.Location = new System.Drawing.Point(58, 74);
            this.panelWait.Name = "panelWait";
            this.panelWait.Size = new System.Drawing.Size(332, 122);
            this.panelWait.TabIndex = 15;
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
            // label_desc
            // 
            this.label_desc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_desc.Location = new System.Drawing.Point(9, 12);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(101, 36);
            this.label_desc.TabIndex = 12;
            this.label_desc.Text = "Say something  about this: ";
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDesc.Location = new System.Drawing.Point(156, 12);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(285, 212);
            this.richTextBoxDesc.TabIndex = 11;
            this.richTextBoxDesc.Text = "";
            // 
            // button_post
            // 
            this.button_post.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.button_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_post.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_post.Location = new System.Drawing.Point(323, 264);
            this.button_post.Name = "button_post";
            this.button_post.Size = new System.Drawing.Size(118, 28);
            this.button_post.TabIndex = 8;
            this.button_post.Text = "Post on Twitter";
            this.button_post.UseVisualStyleBackColor = false;
            this.button_post.Click += new System.EventHandler(this.button_post_Click);
            // 
            // TwitterPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.panelWait);
            this.Controls.Add(this.label_desc);
            this.Controls.Add(this.richTextBoxDesc);
            this.Controls.Add(this.button_post);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TwitterPostForm";
            this.Text = "SociaPlayer";
            this.Load += new System.EventHandler(this.TwitterPostForm_Load);
            this.panelWait.ResumeLayout(false);
            this.panelWait.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWait;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_desc;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.Button button_post;
    }
}