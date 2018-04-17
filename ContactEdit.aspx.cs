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
        TextBoxAddressCountry.Text = null;
        TextBoxAddressLine1.Text = null;
        TextBoxAddressLine2.Text = null;
        TextBoxAddressLine3.Text = null;
        TextBoxAddressPostalCode.Text = null;
        TextBoxAddressStateProvince.Text = null;
        TextBoxCompany.Text = null;
        TextBoxContactName.Text = null;
        TextBoxEmailAddress.Text = null;
        TextBoxImageFileURL.Text = ContactFileHelper.DefaultImageURL;
        TextBoxJobTitle.Text = null;
        TextBoxPhoneNumber.Text = null;
        TextBoxPhoneNumberExtension.Text = null;
        TextBoxTwitterUserName.Text = null;
        TextBoxWebsiteURL.Text = null;
        TextBoxAddressCity.Text = null;
    }



    private void SetContactInformationFromInputTextBoxes()
    {
        currentContact.Address.City = Convert.ToString(TextBoxAddressCity.Text.Trim());
        currentContact.Address.Country = Convert.ToString(TextBoxAddressCountry.Text.Trim());
        currentContact.Address.Line1 = Convert.ToString(TextBoxAddressLine1.Text.Trim());
        currentContact.Address.Line2 = Convert.ToString(TextBoxAddressLine2.Text.Trim());
        currentContact.Address.Line3 = Convert.ToString(TextBoxAddressLine3.Text.Trim());
        currentContact.Address.PostalCode = Convert.ToString(TextBoxAddressPostalCode.Text.Trim());
        currentContact.Address.StateProvince = Convert.ToString(TextBoxAddressStateProvince.Text.Trim());
        currentContact.Company = Convert.ToString(TextBoxCompany.Text.Trim());
        currentContact.ContactName = Convert.ToString(TextBoxContactName.Text.Trim());
        currentContact.EmailAddress = ContactFileHelper.ConvertStringToMailAddress(TextBoxEmailAddress.Text.Trim());
        currentContact.ImageFileURI = ContactFileHelper.ConvertStringToUri(TextBoxImageFileURL.Text.Trim());
        currentContact.JobTitle = Convert.ToString(TextBoxJobTitle.Text.Trim());
        currentContact.PhoneNumber.Number = Convert.ToString(TextBoxPhoneNumber.Text.Trim());
        currentContact.PhoneNumber.Extension = Convert.ToString(TextBoxPhoneNumberExtension.Text.Trim());
        currentContact.SkypeUserName.UserName = Convert.ToString(TextBoxSkypeUserName.Text.Trim());
        currentContact.TwitterUserName.UserName = Convert.ToString(TextBoxTwitterUserName.Text.Trim());
        currentContact.WebsiteURL = ContactFileHelper.ConvertStringToUri(TextBoxWebsiteURL.Text.Trim());
    }

    private void SetInputTextBoxesFromContactInformation()
    {
        TextBoxAddressCity.Text = Convert.ToString(currentContact.Address.City);
        TextBoxAddressCountry.Text = Convert.ToString(currentContact.Address.Country);
        TextBoxAddressLine1.Text = Convert.ToString(currentContact.Address.Line1);
        TextBoxAddressLine2.Text = Convert.ToString(currentContact.Address.Line2);
        TextBoxAddressLine3.Text = Convert.ToString(currentContact.Address.Line3);
        TextBoxAddressPostalCode.Text = Convert.ToString(currentContact.Address.PostalCode);
        TextBoxAddressStateProvince.Text = Convert.ToString(currentContact.Address.StateProvince);
        TextBoxCompany.Text = Convert.ToString(currentContact.Company);
        TextBoxContactName.Text = Convert.ToString(currentContact.ContactName);
        TextBoxEmailAddress.Text = Convert.ToString(currentContact.EmailAddress);
        if (currentContact.ImageFileURI == null)
        {
            ImageContact.ImageUrl = ContactFileHelper.DefaultImageURL;
            TextBoxImageFileURL.Text = ContactFileHelper.DefaultImageURL;
        }
        else
        {
            ImageContact.ImageUrl = Convert.ToString(currentContact.ImageFileURI);
            TextBoxImageFileURL.Text = Convert.ToString(currentContact.ImageFileURI);
        }
        TextBoxJobTitle.Text = Convert.ToString(currentContact.JobTitle);
        TextBoxPhoneNumber.Text = Convert.ToString(currentContact.PhoneNumber.Number);
        TextBoxPhoneNumberExtension.Text = Convert.ToString(currentContact.PhoneNumber.Extension);
        TextBoxSkypeUserName.Text = Convert.ToString(currentContact.SkypeUserName);
        TextBoxTwitterUserName.Text = Convert.ToString(currentContact.TwitterUserName);
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