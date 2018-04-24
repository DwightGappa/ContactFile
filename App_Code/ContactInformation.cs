using System;
using System.Web;
using System.Net.Mail;

/// <summary>
/// Summary description for ContactInformation
/// </summary>
/// 


namespace ContactFile
{


    [Serializable]
    public class ContactInformation
    {

        public static ContactInformation GetCurrent()
        {
            var contact = HttpContext.Current.Session["CurrentContact"] as ContactInformation;
            if (HttpContext.Current.Session["CurrentContact"] == null)
            {
                contact = new ContactInformation();

            }
            return contact;

        }

        public void DeleteCurrent()
        {
            HttpContext.Current.Session["CurrentContact"] = null;
        }


        public void SaveCurrent()
        {
            HttpContext.Current.Session["CurrentContact"] = this;
        }

        public static void SetCurrent(ContactInformation contact)
        {
            HttpContext.Current.Session["CurrentContact"] = contact;
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private PhysicalAddress address;

        private string company;

        private MailAddress emailAddress;

        private Guid guid;

        private Uri imageFileURI;

        private string jobTitle;

        private string contactName;

        private PhoneNumber phoneNumber;

        private SkypeOnlineUserName skypeUserName;

        private TwitterOnlineUserName twitterUserName;

        private Uri websiteURL;

        public PhysicalAddress Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string Company
        {
            get
            {
                return company;
            }

            set
            {
                company = value;
            }
        }

        public MailAddress EmailAddress
        {
            get
            {
                return emailAddress;
            }

            set
            {
                emailAddress = value;
            }
        }
        
        public Uri ImageFileURI
        {
            get { return this.imageFileURI; }

            set { this.imageFileURI = value; }
        }

        public string JobTitle
        {
            get
            {
                return jobTitle;
            }

            set
            {
                jobTitle = value;
            }
        }

        public string ContactName
        {
            get
            {
                return contactName;
            }

            set
            {
                contactName = value;
            }
        }

        public PhoneNumber PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public SkypeOnlineUserName SkypeUserName
        {
            get
            {
                return skypeUserName;
            }

            set
            {
                skypeUserName = value;
            }
        }

        public TwitterOnlineUserName TwitterUserName
        {
            get
            {
                return this.twitterUserName;
            }

            set
            {
               this.twitterUserName = value;
            }
        }

        public Uri WebsiteURL
        {
            get
            { return websiteURL; }

            set
            { websiteURL = value; }
        }

        public ContactInformation()
        {
            this.address = new PhysicalAddress();
            this.phoneNumber = new PhoneNumber();
            this.skypeUserName = new SkypeOnlineUserName();
            this.twitterUserName = new TwitterOnlineUserName();
            this.guid = Guid.NewGuid();
            imageFileURI = ContactFileHelper.ConvertStringToUri((ContactFileHelper.DefaultImageURL));
        }

        public Guid GetGuid()
        { return this.guid; }
    }
}

