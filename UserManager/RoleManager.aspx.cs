using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class RoleManager_RoleManager : System.Web.UI.Page
{
   

    private void AddRolesToGridview()
    {
        
        GridViewRoles.DataSource = Roles.GetAllRoles();
        GridViewRoles.DataBind();
    }



    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            AddRolesToGridview();
        }

    }

    protected void GridViewRoles_SelectedIndexChanged(object sender, EventArgs e)
    {
        PanelAddRole.Visible = false;
        LabelRoleUsers.Visible = true;
        ButtonDeleteSeletedRole.Enabled = true;
        string[] roles = Roles.GetAllRoles();
        LabelRoleUsers.Text = String.Format("Users in {0}:", roles[GridViewRoles.SelectedIndex]);
        GridViewRoleUsers.DataSource = Roles.GetUsersInRole(roles[GridViewRoles.SelectedIndex]);
        GridViewRoleUsers.DataBind();
    }

    protected void ButtonAddRole_Click(object sender, EventArgs e)
    {
        string newRoleName = TextBoxRoleToAdd.Text.Trim();

        if (!Roles.RoleExists(newRoleName))
            // Create the role
            Roles.CreateRole(newRoleName);
        AddRolesToGridview();
        TextBoxRoleToAdd.Text = string.Empty;
        PanelAddRole.Visible = false;
    }




    protected void ButtonCreateNewRole_Click(object sender, EventArgs e)
    {
        PanelAddRole.Visible = true;
    }

    protected void ButtonDeleteSeletedRole_Click(object sender, EventArgs e)
    {
        string[] roles = Roles.GetAllRoles();
        Roles.DeleteRole(roles[GridViewRoles.SelectedIndex], false);
        AddRolesToGridview();
        LabelRoleUsers.Visible = false;
    }
}




