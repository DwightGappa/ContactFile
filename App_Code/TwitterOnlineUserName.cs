

/// <summary>
/// Stores a Twitter username
/// </summary>
/// 
namespace ContactFile
{
    using System;
    using System.Text.RegularExpressions;

    public class TwitterOnlineUserName : OnlineUserName
    {
        public TwitterOnlineUserName()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public TwitterOnlineUserName(string newUserName)
        {
            UserName = newUserName;
        }

        private const int miniumUserNameLength = 1;

        private const int maxiumUserNameLength = 15;


        public override string GetUserNameRegExString()
        {
            // Twitter username regex taken from http://kagan.mactane.org/blog/2009/09/22/what-characters-are-allowed-in-twitter-usernames/comment-page-1/
            return @"^[a-zA-Z0-9_]{" + TwitterOnlineUserName.miniumUserNameLength + "," + TwitterOnlineUserName.maxiumUserNameLength + "}$";
        }

        public override bool IsValid(string nameToValidte)
        {
            Regex regex = new Regex(this.GetUserNameRegExString());
            return regex.IsMatch(nameToValidte);
        }

        public override string GetServiceName()
        {
            return "Twitter";    
        }
    }
}
