using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace Licenta_MediaPlayer
{
    public partial class TwitterPostForm : Form
    {
        string consumerKey = string.Empty;
        string consumerSecret = string.Empty;
        string userToken = string.Empty;
        string userSecret = string.Empty;
        string filePath = string.Empty;
        bool isGif = false;

        public TwitterPostForm(string consumerKey, string consumerSecret, string userToken, string userSecret, string filePath, bool isGif)
        {
            this.consumerKey = consumerKey;
            this.consumerSecret = consumerSecret;
            this.userToken = userToken;
            this.userSecret = userSecret;
            this.filePath = filePath;
            this.isGif = isGif;
            InitializeComponent();
        }

        private void TwitterPostForm_Load(object sender, EventArgs e)
        {
            panelWait.SendToBack();
        }

        private void button_post_Click(object sender, EventArgs e)
        {
            //new Thread(() =>// s-ar putea sa nu fie necesar thread
            {
                //Thread.CurrentThread.IsBackground = true;
                panelWait.BringToFront(); label1.BringToFront();
                panelWait.Visible = true; label1.Visible = true;
                // Use the user credentials in your application
                Auth.SetUserCredentials(consumerKey, consumerSecret, userToken, userSecret);

                var video1 = System.IO.File.ReadAllBytes(filePath);

                string mediaCategory = "tweet_video";
                if (isGif)
                    mediaCategory = "tweet_gif";

                var media = Upload.UploadVideo(video1, "video/mp4", mediaCategory);

                //var media = Upload.UploadVideo(video1);
                /*if (!media.HasBeenUploaded)
                {
                    MessageBox.Show("nimic fraiere!");
                    return;
                }*/
              
                Upload.WaitForMediaProcessingToGetAllMetadata(media);

                string tweetText="";
                richTextBoxDesc.InvokeIfRequired(t => tweetText = t.Text);// daca folosesc threaduri tre sa dau invoke in lucrul cu interfata*/

                var tweet = Tweet.PublishTweet(tweetText, new PublishTweetOptionalParameters
                {
                    Medias = new List<IMedia> { media }
                });
                panelWait.InvokeIfRequired(t => t.Visible = false);
                label1.InvokeIfRequired(t => t.Visible = false);
                panelWait.InvokeIfRequired(t => t.SendToBack());
                label1.InvokeIfRequired(t => t.SendToBack());

            }//).Start();

            MessageBox.Show("Video has been tweeted!");
            this.Close();
        }

    }
}
