using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContactFile;



public partial class ContactVeiwer : System.Web.UI.Page
{
    private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

   

    private ContactInformation contact;

    private void EnablecontactEntryViewModeControls(bool enablementState)
    {
        EnableFormOutputLiterals(enablementState);
        ButtonEdit.Enabled = enablementState;
    }

    private void EnableFormLabels(bool enablementState)
    {
        LabelAddressCity.Visible = enablementState;
        LabelAddressCountry.Visible = enablementState;
        LabelAddressLine1.Visible = enablementState;
        LabelAddressLine2.Visible = enablementState;
        LabelAddressLine3.Visible = enablementState;
        LabelAddressPostalCode.Visible = enablementState;
        LabelAddressStateProvince.Visible = enablementState;
        LabelCompany.Visible = enablementState;
        LabelEmailAddress.Visible = enablementState;
        LabelFirstName.Visible = enablementState;
        LabelJobTitle.Visible = enablementState;
        LabelLastName.Visible = enablementState;
        LabelPhoneNumber.Visible = enablementState;
        LabelPrefixName.Visible = enablementState;
        LabelSuffixName.Visible = enablementState;
        LabelTwitterHandle.Visible = enablementState;
        LabelWebsiteURL.Visible = enablementState;
    }



    private void EnableFormOutputLiterals(bool enablementState)
    {
        LiteralAddressCity.Visible = enablementState;
        LiteralAddressCountry.Visible = enablementState;
        LiteralAddressLine1.Visible = enablementState;
        LiteralAddressLine2.Visible = enablementState;
        LiteralAddressLine3.Visible = enablementState;
        LiteralAddressPostalCode.Visible = enablementState;
        LiteralAddressStateProvince.Visible = enablementState;
        LiteralCompany.Visible = enablementState;
        LiteralEmailAddress.Visible = enablementState;
        LiteralFirstName.Visible = enablementState;
        LiteralJobTitle.Visible = enablementState;
        LiteralLastName.Visible = enablementState;
        LiteralPhoneNumber.Visible = enablementState;
        LiteralPrefixName.Visible = enablementState;
        LiteralSuffixName.Visible = enablementState;
        LiteralTwitterHandle.Visible = enablementState;
        LiteralWebsiteURL.Visible = enablementState;
    }


    private void SetFormOutputLiteralsFromContactInformation()
    {
        LiteralAddressCity.Text = Convert.ToString(contact.AddressCity);
        LiteralAddressCountry.Text = Convert.ToString(contact.AddressCountry);
        LiteralAddressLine1.Text = Convert.ToString(contact.AddressLine1);
        LiteralAddressLine2.Text = Convert.ToString(contact.AddressLine2);
        LiteralAddressLine3.Text = Convert.ToString(contact.AddressLine3);
        LiteralAddressPostalCode.Text = Convert.ToString(contact.AddressPostalCode);
        LiteralAddressStateProvince.Text = Convert.ToString(contact.AddressStateProvince);
        LiteralCompany.Text = Convert.ToString(contact.Company);
        LiteralEmailAddress.Text = Convert.ToString(contact.EmailAddress);
        LiteralFirstName.Text = Convert.ToString(contact.FirstName);
        ImageContact.ImageUrl = Convert.ToString(contact.ImageFileURL);
        LiteralJobTitle.Text = Convert.ToString(contact.JobTitle);
        LiteralLastName.Text = Convert.ToString(contact.LastName);
        LiteralPhoneNumber.Text = Convert.ToString(contact.PhoneNumber);
        LiteralPrefixName.Text = Convert.ToString(contact.PrefixName);
        LiteralSuffixName.Text = Convert.ToString(contact.SuffixName);
        LiteralTwitterHandle.Text = Convert.ToString(contact.TwitterHandle);
        LiteralWebsiteURL.Text = Convert.ToString(contact.WebsiteURL);
    }



    protected void Page_Load(object sender, EventArgs e)
    {


        contact = ContactInformation.GetCurrent();
        SetFormOutputLiteralsFromContactInformation();
        EnablecontactEntryViewModeControls(true);
    }

    protected void ButtonEdit_Click(object sender, EventArgs e)
    {
        HttpContext.Current.Response.Redirect(url: ContactFileHelper.ContactEditPageUrl);
    }



    protected void ButtonScheduleMeeting_Click(object sender, EventArgs e)
    {
        HttpContext.Current.Response.Redirect(url: ContactFileHelper.ScheduleMeetingPageUrl);
    }
}