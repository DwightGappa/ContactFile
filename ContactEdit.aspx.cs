using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContactFile;



public partial class ContactEditor : System.Web.UI.Page
{
    private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    private ContactInformation currentContact;

    

   
    private void ResetInputTextBoxes()
    {
        TextBoxAddressCity.Text = null;
        TextBoxAddressCountry.Text = null;
        TextBoxAddressLine1.Text = null;
        TextBoxAddressLine2.Text = null;
        TextBoxAddressLine3.Text = null;
        TextBoxAddressPostalCode.Text = null;
        TextBoxAddressStateProvince.Text = null;
        TextBoxCompany.Text = null;
        TextBoxEmailAddress.Text = null;
        TextBoxFirstName.Text = null;
        TextBoxImageFileURL.Text = ContactInformation.DefaultImageURL;
        TextBoxJobTitle.Text = null;
        TextBoxLastName.Text = null;
        TextBoxPhoneNumber.Text = null;
        TextBoxPrefixName.Text = null;
        TextBoxSuffixName.Text = null;
        TextBoxTwitterHandle.Text = null;
        TextBoxWebsiteURL.Text = null;
    }

    

    private void SetContactInformationFromInputTextBoxes()
    {
        currentContact.AddressCity = Convert.ToString(TextBoxAddressCity.Text.Trim());
        currentContact.AddressCountry = Convert.ToString(TextBoxAddressCountry.Text.Trim());
        currentContact.AddressLine1 = Convert.ToString(TextBoxAddressLine1.Text.Trim());
        currentContact.AddressLine2 = Convert.ToString(TextBoxAddressLine2.Text.Trim());
        currentContact.AddressLine3 = Convert.ToString(TextBoxAddressLine3.Text.Trim());
        currentContact.AddressPostalCode = Convert.ToString(TextBoxAddressPostalCode.Text.Trim());
        currentContact.AddressStateProvince = Convert.ToString(TextBoxAddressStateProvince.Text.Trim());
        currentContact.Company = Convert.ToString(TextBoxCompany.Text.Trim());
        currentContact.EmailAddress = Convert.ToString(TextBoxEmailAddress.Text.Trim());
        currentContact.FirstName = Convert.ToString(TextBoxFirstName.Text.Trim());
        currentContact.ImageFileURL = Convert.ToString(TextBoxImageFileURL.Text.Trim());
        currentContact.JobTitle = Convert.ToString(TextBoxJobTitle.Text.Trim());
        currentContact.LastName = Convert.ToString(TextBoxLastName.Text.Trim());
        currentContact.PhoneNumber = Convert.ToString(TextBoxPhoneNumber.Text.Trim());
        currentContact.PrefixName = Convert.ToString(TextBoxPrefixName.Text.Trim());
        currentContact.SuffixName = Convert.ToString(TextBoxSuffixName.Text.Trim());
        currentContact.TwitterHandle = Convert.ToString(TextBoxTwitterHandle.Text.Trim());
        currentContact.WebsiteURL = Convert.ToString(TextBoxWebsiteURL.Text.Trim());
    }

    private void SetInputTextBoxesFromContactInformation()
    {
        TextBoxAddressCity.Text = Convert.ToString(currentContact.AddressCity);
        TextBoxAddressCountry.Text = Convert.ToString(currentContact.AddressCountry);
        TextBoxAddressLine1.Text = Convert.ToString(currentContact.AddressLine1);
        TextBoxAddressLine2.Text = Convert.ToString(currentContact.AddressLine2);
        TextBoxAddressLine3.Text = Convert.ToString(currentContact.AddressLine3);
        TextBoxAddressPostalCode.Text = Convert.ToString(currentContact.AddressPostalCode);
        TextBoxAddressStateProvince.Text = Convert.ToString(currentContact.AddressStateProvince);
        TextBoxCompany.Text = Convert.ToString(currentContact.Company);
        TextBoxEmailAddress.Text = Convert.ToString(currentContact.EmailAddress);
        TextBoxFirstName.Text = Convert.ToString(currentContact.FirstName);
        if (currentContact.ImageFileURL == null)
        {
            ImageContact.ImageUrl = ContactInformation.DefaultImageURL;
            TextBoxImageFileURL.Text = ContactInformation.DefaultImageURL;
        }
        else
        {
            ImageContact.ImageUrl = Convert.ToString(currentContact.ImageFileURL);
            TextBoxImageFileURL.Text = Convert.ToString(currentContact.ImageFileURL);
        }
        TextBoxJobTitle.Text = Convert.ToString(currentContact.JobTitle);
        TextBoxLastName.Text = Convert.ToString(currentContact.LastName);
        TextBoxPhoneNumber.Text = Convert.ToString(currentContact.PhoneNumber);
        TextBoxPrefixName.Text = Convert.ToString(currentContact.PrefixName);
        TextBoxSuffixName.Text = Convert.ToString(currentContact.SuffixName);
        TextBoxTwitterHandle.Text = Convert.ToString(currentContact.TwitterHandle);
        TextBoxWebsiteURL.Text = Convert.ToString(currentContact.WebsiteURL);
    }

   
    protected void Page_Load(object sender, EventArgs e)
    {


        currentContact = ContactInformation.GetCurrent();
        if (!IsPostBack)
        {
            SetInputTextBoxesFromContactInformation();
        }
        

    }

    protected void ButtonSave_Click(object sender, EventArgs e)
    {
        SetContactInformationFromInputTextBoxes();

        currentContact.SaveCurrent();
        HttpContext.Current.Response.Redirect(url: ContactFileHelper.ContactViewerPageUrl);
    }


    protected void ButtonDelete_Click(object sender, EventArgs e)
    {
        currentContact.DeleteCurrent();
        ResetInputTextBoxes();


    }
}