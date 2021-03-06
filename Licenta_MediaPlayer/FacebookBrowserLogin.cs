﻿using Facebook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Licenta_MediaPlayer
{
    public partial class FacebookBrowserLogin : Form
    {
        string uploadFilePath = string.Empty;
        public FacebookBrowserLogin(string filePath)
        {
            WinInetHelper.SupressCookiePersist();
            uploadFilePath = filePath;
            InitializeComponent();
        }

        private void FacebookBrowserLogin_Load(object sender, EventArgs e)
        {
            Uri Fb = GenerateLoginUrl("1806768799636244", "public_profile,user_birthday,publish_actions,user_posts,user_about_me,user_location,user_status");
            webBrowser.Navigate(Fb);
        }

        private Uri GenerateLoginUrl(string appId, string extendedPermissions)
        {
            dynamic parameters = new ExpandoObject();
            parameters.client_id = appId;
            parameters.redirect_uri = "https://www.facebook.com/connect/login_success.html";

            // The requested response: an access token (token), an authorization code (code), or both (code token).
            parameters.response_type = "token";

            // list of additional display modes can be found at http://developers.facebook.com/docs/reference/dialogs/#display
            //parameters.display = "popup";

            // add the 'scope' parameter only if we have extendedPermissions.
            if (!string.IsNullOrWhiteSpace(extendedPermissions))
                parameters.scope = extendedPermissions;

            // generate the login url
            var fb = new FacebookClient();
            return fb.GetLoginUrl(parameters);
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

            try
            {
                // whenever the browser navigates to a new url, try parsing the url.
                // the url may be the result of OAuth 2.0 authentication.

                var fb = new FacebookClient();
                FacebookOAuthResult oauthResult;
                if (fb.TryParseOAuthCallbackUrl(e.Url, out oauthResult))
                {
                    // The url is the result of OAuth 2.0 authentication
                    if (oauthResult.IsSuccess)
                    {
                        var accesstoken = oauthResult.AccessToken;
                        //webBrowser.Hide();
                        FacebookPostForm fpf = new FacebookPostForm(accesstoken.ToString(), uploadFilePath);
                        fpf.Show();
                        WinInetHelper.EndBrowserSession();
                        this.Hide();                     
                    }
                    else
                    {
                        var errorDescription = oauthResult.ErrorDescription;
                        var errorReason = oauthResult.ErrorReason;
                    }
                }
                else
                {
                    // The url is NOT the result of OAuth 2.0 authentication.
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }

        }
    }


}

