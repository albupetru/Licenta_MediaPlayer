using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;
using Tweetinvi.Core.Public.Models.Enum;
using Tweetinvi.Core.Web;

namespace Licenta_MediaPlayer
{

    public partial class TwitterPinWindow : Form
    {
        IAuthenticationContext authenticationContext;

        public TwitterPinWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Thread(() =>
            {
                string userToken = "";
                string userSecret = "";
                Thread.CurrentThread.IsBackground = true;
                // Ask the user to enter the pin code given by Twitter
                var pinCode = textBox1.Text;

                // With this pin code it is now possible to get the credentials back from Twitter
                var userCredentials = AuthFlow.CreateCredentialsFromVerifierCode(pinCode, authenticationContext);
                try
                {
                    userToken = userCredentials.AccessToken; userSecret = userCredentials.AccessTokenSecret;
                    OptionsWindow ow = new OptionsWindow(userToken, userSecret);
                    ow.Show();
                    //this.InvokeIfRequired(t => t.Close());
                    this.Close();
                }
                catch (NullReferenceException et)
                {
                    startAuth();
                    Thread.Sleep(1000); // ca sa apara messageboxu peste browser
                    MessageBox.Show("Invalid PIN! Try again!");
                }
                //catch { /*tratat alte exceptii*/}              

            }//).Start();

        }

        private void twitterPinWindow_Load(object sender, EventArgs e)
        {
            startAuth();
        }

        private void startAuth()
        {
            // Create a new set of credentials for the application.
            var appCredentials = new TwitterCredentials("xr9OavmMSTkLpjPQ9SINZHgr5", "B4BlN8ngBk7Gnzhn247lVx8L9ITlKaYeHVFAMf7NjZeuvw4ko0");

            // Init the authentication process and store the related `AuthenticationContext`.
            authenticationContext = AuthFlow.InitAuthentication(appCredentials);

            // Go to the URL so that Twitter authenticates the user and gives him a PIN code.
            Process.Start(authenticationContext.AuthorizationURL);
        }
    }
}
