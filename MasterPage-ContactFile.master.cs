using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContactFile;


public partial class MasterPage_ContactFile : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void LoginStatus1_LoggedOut(object sender, EventArgs e)
    {
        Response.Redirect("~");
    }
}
