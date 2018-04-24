using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace ContactFile
{
    /// <summary>
    /// Summary description for ContactFileHelper
    /// </summary>
    public static class ContactFileHelper
    {

        public const string ContactViewerPageUrl = "~/ContactViewer.aspx";

        public const string ContactEditPageUrl = "~/ContactEdit.aspx";

        public const string DefaultImageURL = "~/images/ProfilePlaceholderSuit-300px.png";

        public const string ScheduleMeetingPageUrl = "MeetingScheduler.aspx";

        public const string UploadedUserImagesDirectory = "~/Uploaded_User_Images/";

        public static Uri ConvertStringToUri(string uriString)
        {
            if (!string.IsNullOrEmpty(uriString))
            {
                return new Uri(uriString, UriKind.RelativeOrAbsolute);
            }
            else
            {
                return null;
            }
        }

        public static MailAddress ConvertStringToMailAddress(string emailAddressString)
        {
            if (!string.IsNullOrEmpty(emailAddressString))
            {
                return new MailAddress(emailAddressString);
            }
            else
            {
                return null;
            }
        }
              
    }

}
