using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

public partial class MasterPage_ContactFile : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridViewContacts_SelectedIndexChanged(object sender, EventArgs e)
    {
               
    }
}
