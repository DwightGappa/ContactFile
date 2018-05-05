using System;
using System.Collections.Generic;
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

        private string company;

        private int contactID;

        private readonly DateTimeOffset dateCreated;

        private readonly DateTimeOffset dateModifed;

        private MailAddress emailAddress;

        private Guid guid;

        private Uri imageFileURI = ContactFileHelper.ConvertStringToUri((ContactFileHelper.DefaultImageURL));

        private string jobTitle;

        private string contactName;

        private string contactNotes;

        private SkypeOnlineUserName skypeUserName;

        private TimeZoneInfo timeZone;

        private TwitterOnlineUserName twitterUserName;

        private Uri websiteURL;

        public string CompanyName
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

        public int ContactID
        {
            get
            {
                return contactID;
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

        public string ContactNotes
        {
            get
            {
                return this.contactNotes;
            }

            set
            {
                this.contactNotes = value;
            }
        }

        public Guid ContactGuid
        {
            get { return this.guid; }
        }

        public DateTimeOffset DateCreated
        {
            get
            {
                return this.dateCreated;
            }
        }

        public DateTimeOffset DateModifed
        {
            get
            {
                return this.dateModifed;
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

            set
            {
                if (value == null)
                {
                    imageFileURI = ContactFileHelper.ConvertStringToUri((ContactFileHelper.DefaultImageURL));
                }
                this.imageFileURI = value;
            }
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

        public List<MeetingInformation> MeetingsList;

        public List<PhysicalAddress> PhysicalAddressesList;

        public List<PhoneNumber> PhoneNumberList;


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

        public TimeZoneInfo TimeZone
        {
            get
            {
                return this.timeZone;
            }

            set
            {
                this.timeZone = value;
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

        public Uri WebSiteURL
        {
            get
            { return websiteURL; }

            set
            { websiteURL = value; }
        }

        

        public ContactInformation()
        {
            this.guid = Guid.NewGuid();
        }

        public ContactInformation(int id, Guid existingContactGuid, DateTimeOffset contactCreationDate, DateTimeOffset contactLastModifed)
        {
            this.dateCreated = contactCreationDate;
            this.dateModifed = contactLastModifed;
            this.guid = existingContactGuid;
        }

    }
}

