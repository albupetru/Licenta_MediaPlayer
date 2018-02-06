using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using System.Web.Script.Serialization;
using System.Drawing.Drawing2D;
using System.Net;
using System.IO;
using System.Dynamic;
using System.Threading;

namespace Licenta_MediaPlayer
{
    public partial class FacebookPostForm : Form
    {
        string clientToken = string.Empty;
        string uploadFilePath = string.Empty;

        public FacebookPostForm(string token, string filePath)
        {
            uploadFilePath = filePath;
            InitializeComponent();
            clientToken = token;
        }

        private void FacebookPostForm_Load(object sender, EventArgs e)
        {
            panelWait.SendToBack();
            comboBox.SelectedIndex = 0;
            if (clientToken != null)
                GetUserDetails();
        }

        private void GetUserDetails()
        {
            FacebookClient fb = null;
            object data = null;
            DVO.UserDvo user = null;
            try
            {
                fb = new FacebookClient(clientToken);
                data = fb.Get("/me?fields=devices,first_name,gender,installed,last_name,link,locale,location");
                user = new DVO.UserDvo();
                user = new JavaScriptSerializer().Deserialize<DVO.UserDvo>(data.ToString());
                this.Text = "Post to " + user.first_name +"'s Facebook";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                fb = null;
                data = null;
                user = null;
            }

        }

        private void button_post_Click(object sender, EventArgs e)
        {
            var fb = new FacebookClient(clientToken);

            dynamic parameters = new ExpandoObject();
            parameters.source = new FacebookMediaObject { ContentType = "video", FileName = Path.GetFileName(uploadFilePath) }.SetValue(File.ReadAllBytes(uploadFilePath));
            parameters.description = richTextBoxDesc.Text;
            dynamic t = new ExpandoObject();

            if (comboBox.SelectedIndex == 0)
                t.value = "ALL_FRIENDS";
            else if (comboBox.SelectedIndex == 1)
                t.value = "FRIENDS_OF_FRIENDS"; // privacy e obiect ce are unul din campuri value; referinta https://developers.facebook.com/docs/graph-api/reference/v2.10/post
            else if (comboBox.SelectedIndex == 2)
                t.value = "EVERYONE";
            else t.value = "SELF";

            parameters.privacy = t;

            //WaitForm wt = new WaitForm();
            //wt.Show();
            panelWait.Show();
            panelWait.BringToFront();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                dynamic result = fb.Post("/me/videos", parameters); // HANDLE THE ERRORS!!!!
                MessageBox.Show("Video has been added to timeline!");
            }).Start();
            //MessageBox.Show("wait");
            
            //wt.Close();
            panelWait.Hide();
            panelWait.SendToBack();
            //new Thread(() =>
            //{
                //Thread.Sleep(2000);
                //MessageBox.Show("Video has been added to timeline!");
            //}).Start();
            this.Close();
        }
    }

}
