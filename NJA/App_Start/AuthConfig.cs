using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using NJA.Models;

namespace NJA
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            //OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "",
            //    consumerSecret: "");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "781648338584410",
                appSecret: "6af453c318d87aa47aa54e389fc3633e");//Oauthtst

            OAuthWebSecurity.RegisterGoogleClient();
            OAuthWebSecurity.RegisterClient(new GooglePlusClient("678729948838-9c983nugsv5sv40lrfa77gr1aid5hh7i.apps.googleusercontent.com", "fRMUOb4XBr9nisnkHeX6BYrf"), "Google+", null);
        }
    }
}
