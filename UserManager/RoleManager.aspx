<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage-ContactFile.master" AutoEventWireup="true" CodeFile="RoleManager.aspx.cs" Inherits="RoleManager_RoleManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMainContent" runat="Server">




    <asp:Panel ID="PanelRoleList" runat="server" GroupingText="Contact File Roles">
        <!-- Taken from  https://docs.microsoft.com/en-us/aspnet/web-forms/overview/older-versions-security/roles/creating-and-managing-roles-cs -->


        <asp:GridView ID="GridViewRoles" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridViewRoles_SelectedIndexChanged" AllowPaging="True">
            <Columns>
                <asp:TemplateField HeaderText="Role">
                    <ItemTemplate>
                        <%# Container.DataItem %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowSelectButton="true" />
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <!-- End #PanelGridVewRoles -->

    <asp:Panel ID="PanelRoleManagementButtons" runat="server">
        <asp:Button ID="ButtonCreateNewRole" runat="server" Text="Create New Role" OnClick="ButtonCreateNewRole_Click" />
        <asp:Button ID="ButtonEditSelectedRole" runat="server" Text="Edit Selected Role" Enabled="false" />
        <asp:Button ID="ButtonDeleteSeletedRole" runat="server" Text="Delete Selected Role" Enabled="false" OnClick="ButtonDeleteSeletedRole_Click" />
    </asp:Panel><!-- End #PanelRoleManagementButtons -->

    <asp:Panel ID="PanelRoleDetails" runat="server">
        <asp:Panel ID="PanelAddRole" runat="server" Visible="false">
            <asp:Label ID="LabelRoleToAdd" runat="server" Text="New Role Name:" AssociatedControlID="TextBoxRoleToAdd"></asp:Label>
            <asp:TextBox ID="TextBoxRoleToAdd" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonAddRole" runat="server" Text="Add Role" OnClick="ButtonAddRole_Click" />
        </asp:Panel><!-- End #PanelAddRole -->

        <asp:Label ID="LabelRoleUsers" Text="" runat="server" AssociatedControlID="GridViewRoleUsers" Visible="false" />
        <asp:GridView ID="GridViewRoleUsers" runat="server" AllowPaging="True">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <%# Container.DataItem %>
                    </ItemTemplate>
                    <EditItemTemplate>
                        
                    </EditItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <!-- End #PanelRoleDetails -->










</asp:Content>
