using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContactFile;



public partial class ContactVeiwer : System.Web.UI.Page
{
    

   

    private ContactInformation currentContact;

    private void EnablecontactEntryViewModeControls(bool enablementState)
    {
        EnableFormOutputLiterals(enablementState);
        ButtonEdit.Enabled = enablementState;
    }

    private void EnableFormLabels(bool enablementState)
    {
        LabelAddressCountry.Visible = enablementState;
        LabelAddressLine1.Visible = enablementState;
        LabelAddressLine2.Visible = enablementState;
        LabelAddressLine3.Visible = enablementState;
        LabelAddressPostalCode.Visible = enablementState;
        LabelAddressStateProvince.Visible = enablementState;
        LabelCompany.Visible = enablementState;
        LabelContactName.Visible = enablementState;
        LabelEmailAddress.Visible = enablementState;
        LabelJobTitle.Visible = enablementState;
        LabelPhoneNumber.Visible = enablementState;
        LabelPhoneNumberExtension.Visible = enablementState;
        LabelSkyperUserName.Visible = enablementState;
        LabelTwitterUserName.Visible = enablementState;
        LabelWebsiteURL.Visible = enablementState;
        LabelAddressCity.Visible = enablementState;
    }



    private void EnableFormOutputLiterals(bool enablementState)
    {
        LiteralAddressCity.Visible = enablementState;
        LiteralAddressLine1.Visible = enablementState;
        LiteralAddressLine2.Visible = enablementState;
        LiteralAddressLine3.Visible = enablementState;
        LiteralAddressPostalCode.Visible = enablementState;
        LiteralAddressStateProvince.Visible = enablementState;
        LiteralCompany.Visible = enablementState;
        LiteralContactName.Visible = enablementState;
        LiteralEmailAddress.Visible = enablementState;
        LiteralJobTitle.Visible = enablementState;
        LiteralPhoneNumber.Visible = enablementState;
        LiteralPhoneNumberExtension.Visible = enablementState;
        LiteralTwitterUserName.Visible = enablementState;
        LiteralWebsiteURL.Visible = enablementState;
        LiteralAddressCountry.Visible = enablementState;
    }


    private void SetFormOutputLiteralsFromContactInformation()
    {
        ImageContact.ImageUrl = Convert.ToString(currentContact.ImageFileURI);
        try
        {
            LiteralAddressCity.Text = Convert.ToString(currentContact.PhysicalAddressesList[0].City);
            LiteralAddressCountry.Text = Convert.ToString(currentContact.PhysicalAddressesList[0].Country);
            LiteralAddressLine1.Text = Convert.ToString(currentContact.PhysicalAddressesList[0].Line1);
            LiteralAddressLine2.Text = Convert.ToString(currentContact.PhysicalAddressesList[0].Line2);
            LiteralAddressLine3.Text = Convert.ToString(currentContact.PhysicalAddressesList[0].Line3);
            LiteralAddressPostalCode.Text = Convert.ToString(currentContact.PhysicalAddressesList[0].PostalCode);
            LiteralAddressStateProvince.Text = Convert.ToString(currentContact.PhysicalAddressesList[0].StateProvince);
        }
        catch 
        {
            LiteralAddressCity.Text = "";
            LiteralAddressCountry.Text = "";
            LiteralAddressLine1.Text = "";
            LiteralAddressLine2.Text = "";
            LiteralAddressLine3.Text = "";
            LiteralAddressPostalCode.Text = "";
            LiteralAddressStateProvince.Text = "";
        }
        LiteralCompany.Text = Convert.ToString(currentContact.CompanyName);
        LiteralContactName.Text = Convert.ToString(currentContact.ContactName);
        LiteralEmailAddress.Text = Convert.ToString(currentContact.EmailAddress);
        LiteralJobTitle.Text = Convert.ToString(currentContact.JobTitle);
        try
        {
            LiteralPhoneNumber.Text = Convert.ToString(currentContact.PhoneNumberList[0].Number);
            LiteralPhoneNumberExtension.Text = Convert.ToString(currentContact.PhoneNumberList[0].Extension);
        }
        catch 
        {
            LiteralPhoneNumber.Text = "";
            LiteralPhoneNumberExtension.Text = "";
        }
        LiteralSkyperUserName.Text = Convert.ToString(currentContact.SkypeUserName);
        LiteralTwitterUserName.Text = Convert.ToString(currentContact.TwitterUserName);
        LiteralWebsiteURL.Text = Convert.ToString(currentContact.WebSiteURL);
        
    }



    protected void Page_Load(object sender, EventArgs e)
    {


        currentContact = ContactInformation.GetCurrent();
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