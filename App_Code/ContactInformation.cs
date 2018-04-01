using System;
using System.Web;


/// <summary>
/// Summary description for ContactInformation
/// </summary>
[Serializable]
public class ContactInformation
{
    public const string DefaultImageURL = "images/ProfilePlaceholderSuit-300px.png";

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

    private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    private string addressCity;

    private string addressCountry;

    private string addressLine1;

    private string addressLine2;

    private string addressLine3;

    private string addressPostalCode;

    private string addressStateProvince;

    private string company;

    private string emailAddress;

    private string imageFileURL;

    private string jobTitle;

    private string firstName;

    private string lastName;

    private string phoneNumber;

    private string prefixName;

    private string suffixName;

    private string twitterHandle;

    private string websiteURL;

    public string AddressCity
    {
        get
        {
            return addressCity;
        }

        set
        {
            addressCity = value;
        }
    }

    public string AddressCountry
    {
        get
        {
            return addressCountry;
        }

        set
        {
            addressCountry = value;
        }
    }

    public string AddressLine1
    {
        get
        {
            return addressLine1;
        }

        set
        {
            addressLine1 = value;
        }
    }

    public string AddressLine2
    {
        get
        {
            return addressLine2;
        }

        set
        {
            addressLine2 = value;
        }
    }

    public string AddressLine3
    {
        get
        {
            return addressLine3;
        }

        set
        {
            addressLine3 = value;
        }
    }

    public string AddressPostalCode
    {
        get
        {
            return addressPostalCode;
        }

        set
        {
            addressPostalCode = value;
        }
    }

    public string AddressStateProvince
    {
        get
        {
            return addressStateProvince;
        }

        set
        {
            addressStateProvince = value;
        }
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

    public string EmailAddress
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

    public string ImageFileURL
    {
        get
        {
            return imageFileURL;
        }

        set
        {
            imageFileURL = value;
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

    public string FirstName
    {
        get
        {
            return firstName;
        }

        set
        {
            firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return lastName;
        }

        set
        {
            lastName = value;
        }
    }

    public string PhoneNumber
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

    public string PrefixName
    {
        get
        {
            return prefixName;
        }

        set
        {
            prefixName = value;
        }
    }

    public string SuffixName
    {
        get
        {
            return suffixName;
        }

        set
        {
            suffixName = value;
        }
    }

    public string TwitterHandle
    {
        get
        {
            return twitterHandle;
        }

        set
        {
            twitterHandle = value;
        }
    }

    public string WebsiteURL
    {
        get
        {
            return websiteURL;
        }

        set
        {
            websiteURL = value;
        }
    }

    public ContactInformation()
    {
        imageFileURL = DefaultImageURL;
    }
}

