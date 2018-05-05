using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContactFile;

public partial class MeetingScheduler : System.Web.UI.Page


{
    private const string ContactViewerPageUrl = "ContactViewer.aspx";

    private ContactInformation currentContact;

    private MeetingInformation currentMeeeting;

    protected void Page_Load(object sender, EventArgs e)
    {
        currentContact = ContactInformation.GetCurrent();
        if (!IsPostBack)
        {
            CalendarStartDate.SelectedDate = DateTime.Now;
            CalendarEndDate.SelectedDate = DateTime.Now;

            TextBoxStartTime.Text = CalendarStartDate.SelectedDate.ToShortTimeString();


            TextBoxEndTime.Text = CalendarStartDate.SelectedDate.ToShortTimeString();
        }
        TextBoxStartDate.Text = CalendarStartDate.SelectedDate.ToShortDateString();
        TextBoxEndDate.Text = CalendarEndDate.SelectedDate.ToShortDateString();

    }

    protected void ButtonDiscard_Click(object sender, EventArgs e)
    {
        HttpContext.Current.Response.Redirect(url: ContactViewerPageUrl);
    }

}