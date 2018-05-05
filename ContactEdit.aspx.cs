using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContactFile;




public partial class ContactEditor : System.Web.UI.Page
{

    private ContactInformation currentContact;



    private void ResetInputTextBoxes()
    {
        TextBoxAddressCountry.Text = null;
        TextBoxAddressLine1.Text = null;
        TextBoxAddressLine2.Text = null;
        TextBoxAddressLine3.Text = null;
        TextBoxAddressPostalCode.Text = null;
        TextBoxAddressStateProvince.Text = null;
        TextBoxCompanyName.Text = null;
        TextBoxContactName.Text = null;
        TextBoxEmailAddress.Text = null;
        FileUploadImageFile.Dispose();
        TextBoxJobTitle.Text = null;
        TextBoxPhoneNumber.Text = null;
        TextBoxPhoneNumberExtension.Text = null;
        TextBoxTwitterUserName.Text = null;
        TextBoxWebsiteURL.Text = null;
        TextBoxAddressCity.Text = null;
    }

    private Uri SaveUploadedImage()
    {
        
        try
        {
            string uploadedImageFileExtension = Path.GetExtension(FileUploadImageFile.FileName);
            Guid contactGuid = currentContact.ContactGuid;
            string uploadedIamgeFileNameToSaveAs = Path.ChangeExtension(contactGuid.ToString(), uploadedImageFileExtension);
            string userImagesfileSystemDirectory = Server.MapPath(ContactFileHelper.UploadedUserImagesDirectory);
            FileUploadImageFile.SaveAs(Path.Combine(userImagesfileSystemDirectory, uploadedIamgeFileNameToSaveAs));
            Uri savedImagePathURL = new Uri(Path.Combine(ContactFileHelper.UploadedUserImagesDirectory, uploadedIamgeFileNameToSaveAs), UriKind.Relative);
            return savedImagePathURL;
        }
        catch
        {
            return null;
        }


    }

    private void SetContactInformationFromInputTextBoxes()
    {
        PhysicalAddress contactAddress = new PhysicalAddress();

        contactAddress.City = Convert.ToString(TextBoxAddressCity.Text.Trim());
        contactAddress.Country = Convert.ToString(TextBoxAddressCountry.Text.Trim());
        contactAddress.Line1 = Convert.ToString(TextBoxAddressLine1.Text.Trim());
        contactAddress.Line2 = Convert.ToString(TextBoxAddressLine2.Text.Trim());
        contactAddress.Line3 = Convert.ToString(TextBoxAddressLine3.Text.Trim());
        contactAddress.PostalCode = Convert.ToString(TextBoxAddressPostalCode.Text.Trim());
        contactAddress.StateProvince = Convert.ToString(TextBoxAddressStateProvince.Text.Trim());

        try
        {
            currentContact.PhysicalAddressesList.Add(contactAddress);
        }
        catch (Exception)
        {

        }
 
        currentContact.CompanyName = Convert.ToString(TextBoxCompanyName.Text.Trim());
        currentContact.ContactName = Convert.ToString(TextBoxContactName.Text.Trim());
        currentContact.EmailAddress = ContactFileHelper.ConvertStringToMailAddress(TextBoxEmailAddress.Text.Trim());
        currentContact.JobTitle = Convert.ToString(TextBoxJobTitle.Text.Trim());

        PhoneNumber contactPhoneNumber = new PhoneNumber();

        contactPhoneNumber.Number = Convert.ToString(TextBoxPhoneNumber.Text.Trim());
        contactPhoneNumber.Extension = Convert.ToString(TextBoxPhoneNumberExtension.Text.Trim());

        try
        {
            currentContact.PhoneNumberList.Add(contactPhoneNumber);

        }
        catch 
        {

           
        }

        try
        {
            
            currentContact.SkypeUserName = new SkypeOnlineUserName (Convert.ToString(TextBoxSkypeUserName.Text.Trim()));
        }
        catch
        {
            currentContact.SkypeUserName = null;
        }
        try
        {

            currentContact.TwitterUserName = new TwitterOnlineUserName(Convert.ToString(TextBoxTwitterUserName.Text.Trim()));
        }
        catch
        {
            currentContact.TwitterUserName = null;
        }
        currentContact.WebSiteURL = ContactFileHelper.ConvertStringToUri(TextBoxWebsiteURL.Text.Trim());
    }

    private void SetInputTextBoxesFromContactInformation()
    {
        try
        {
            TextBoxAddressCountry.Text = Convert.ToString(currentContact.PhysicalAddressesList[0].Country);
            TextBoxAddressLine1.Text = Convert.ToString(currentContact.PhysicalAddressesList[0].Line1);
            TextBoxAddressLine2.Text = Convert.ToString(currentContact.PhysicalAddressesList[0].Line2);
            TextBoxAddressLine3.Text = Convert.ToString(currentContact.PhysicalAddressesList[0].Line3);
            TextBoxAddressPostalCode.Text = Convert.ToString(currentContact.PhysicalAddressesList[0].PostalCode);
            TextBoxAddressStateProvince.Text = Convert.ToString(currentContact.PhysicalAddressesList[0].StateProvince);
        }
        catch
        {
            TextBoxAddressCountry.Text = "";
            TextBoxAddressLine1.Text = "";
            TextBoxAddressLine2.Text = "";
            TextBoxAddressLine3.Text = "";
            TextBoxAddressPostalCode.Text = "";
            TextBoxAddressStateProvince.Text = "";
        }
        TextBoxCompanyName.Text = Convert.ToString(currentContact.CompanyName);
        TextBoxContactName.Text = Convert.ToString(currentContact.ContactName);
        TextBoxEmailAddress.Text = Convert.ToString(currentContact.EmailAddress);
        if (currentContact.ImageFileURI != null)
        {
            ImageContact.ImageUrl = Convert.ToString(currentContact.ImageFileURI);
        }
        else
        {
            ImageContact.ImageUrl = ContactFileHelper.DefaultImageURL;
        }
        TextBoxJobTitle.Text = Convert.ToString(currentContact.JobTitle);
        try
        {
            TextBoxPhoneNumber.Text = Convert.ToString(currentContact.PhoneNumberList[0].Number);
            TextBoxPhoneNumberExtension.Text = Convert.ToString(currentContact.PhoneNumberList[0].Extension);
        }
        catch
        {
            TextBoxPhoneNumber.Text = "";
            TextBoxPhoneNumberExtension.Text = "";
        }
        TextBoxSkypeUserName.Text = Convert.ToString(currentContact.SkypeUserName);
        TextBoxTwitterUserName.Text = Convert.ToString(currentContact.TwitterUserName);
        TextBoxWebsiteURL.Text = Convert.ToString(currentContact.WebSiteURL);
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
        if (FileUploadImageFile.HasFile)
        {
            currentContact.ImageFileURI = SaveUploadedImage();
        }
        currentContact.SaveCurrent();

        HttpContext.Current.Response.Redirect(url: ContactFileHelper.ContactViewerPageUrl);
    }


    protected void ButtonDelete_Click(object sender, EventArgs e)
    {
        currentContact.DeleteCurrent();
        ResetInputTextBoxes();


    }
}