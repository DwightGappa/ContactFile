using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class UserManager_UserManager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridViewUsers.DataSource = Membership.GetAllUsers();
        GridViewUsers.DataBind();
    }

    protected void GridViewUsers_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        List<MembershipUser> list = new List<MembershipUser>();
        list.Add(Membership.GetUser(GridViewUsers.SelectedValue.ToString()));
        FormViewUserDetails.DataSource = list;
        FormViewUserDetails.DataBind();
        TableUserRoles.Visible = true;
        ListViewUserRoles.DataSource = Roles.GetRolesForUser(GridViewUsers.SelectedValue.ToString());
        ListViewUserRoles.DataBind();



    }
}