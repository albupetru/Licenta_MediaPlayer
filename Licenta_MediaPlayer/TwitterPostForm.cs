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

                /*var chunk = Upload.CreateChunkedUploader(); //Create an instance of the ChunkedUploader class (I believe this is the only way to get this object)

                using (FileStream fs = System.IO.File.OpenRead(path))
                {
                        chunk.Init("video/mp4",(int)fs.Length); //Important! When initialized correctly, your "chunk" object will now have a type long "MediaId"
                        byte[] buffer = new byte[video1.Length]; //Your chunk MUST be 5MB or less or else the Append function will fail silently.
                         int bytesRead = 0;

                         while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                         {
                             byte[] copy = new byte[bytesRead];
                             Buffer.BlockCopy(buffer, 0, copy, 0, bytesRead);
                             TimeSpan s = new TimeSpan();

                             chunk.Append(copy, chunk.NextSegmentIndex.ToString()); //The library says the NextSegment Parameter is optional, however I wasn't able to get it to work if I left it out. 
                         }
                     }
                     var media = chunk.Complete();*/


                //panelWait.InvokeIfRequired(t => t.BringToFront());
                //label1.InvokeIfRequired(t => t.BringToFront());
                //panelWait.InvokeIfRequired(t => t.Visible = true);
                //label1.InvokeIfRequired(t => t.Visible = true);

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
