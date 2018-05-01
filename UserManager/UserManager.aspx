<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage-ContactFile.master" AutoEventWireup="true" CodeFile="UserManager.aspx.cs" Inherits="UserManager_UserManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMainContent" runat="Server">

    <asp:Panel ID="PanelUserList" runat="server" GroupingText="Contact File Users">
        <asp:GridView ID="GridViewUsers" runat="server" AutoGenerateColumns="False" DataKeyNames="UserName" OnSelectedIndexChanged="GridViewUsers_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="UserName" HeaderText="User Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:CommandField ShowSelectButton="true" />
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <!-- End #PanelUserList -->

    <asp:Panel ID="PanelUserManagementButtons" runat="server">
        <asp:Button ID="ButtonCreateNewUser" runat="server" Text="Create New User" />
        <asp:Button ID="ButtonEditSelectedUser" runat="server" Text="Edit Selected User" />
        <asp:Button ID="ButtonDeleteSeletedUser" runat="server" Text="Delete Selected User" />
    </asp:Panel>
    <!-- End #PanelUserManagementButtons -->

    <asp:Panel ID="PanelUserDetails" runat="server" GroupingText="User Details">
        <asp:FormView ID="FormViewUserDetails" runat="server">
            <ItemTemplate>
                <asp:Table ID="TableUserDetails" runat="server">

                    <asp:TableRow>
                        <asp:TableHeaderCell>
                            <asp:Label ID="LabelUserName" runat="server" Text="User Name:" AssociatedControlID="LiteralUserName" />
                        </asp:TableHeaderCell><asp:TableCell>
                            <asp:Literal ID="LiteralUserName" runat="server" Text='<%# Bind("UserName") %>' />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableHeaderCell>
                            <asp:Label ID="LabelEmail" runat="server" Text="Email:" AssociatedControlID="LiteralEmail" />
                        </asp:TableHeaderCell><asp:TableCell>
                            <asp:Literal ID="LiteralEmail" runat="server" Text='<%# Bind("Email") %>' />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableHeaderCell>
                            <asp:Label ID="LabelIsApproved" runat="server" Text="User Enabled:" AssociatedControlID="LiteralIsApproved" />
                        </asp:TableHeaderCell><asp:TableCell>
                            <asp:Literal ID="LiteralIsApproved" runat="server" Text='<%# Bind("IsApproved") %>' />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableHeaderCell>
                            <asp:Label ID="LabelIsLockedOut" runat="server" Text="Account Locked Out:" AssociatedControlID="LiteralIsLockedOut" />
                        </asp:TableHeaderCell><asp:TableCell>
                            <asp:Literal ID="LiteralIsLockedOut" runat="server" Text='<%# Bind("IsLockedOut") %>' />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableHeaderCell>
                            <asp:Label ID="LabelCreationDate" runat="server" Text="Date Created:" AssociatedControlID="LiteralCreationDate" />
                        </asp:TableHeaderCell><asp:TableCell>
                            <asp:Literal ID="LiteralCreationDate" runat="server" Text='<%# Bind("CreationDate") %>' />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableHeaderCell>
                            <asp:Label ID="LabelLastLastLoginDate" runat="server" Text="Last Login:" AssociatedControlID="LiteralLastLastLoginDate" />
                        </asp:TableHeaderCell><asp:TableCell>
                            <asp:Literal ID="LiteralLastLastLoginDate" runat="server" Text='<%# Bind("LastLoginDate") %>' />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </ItemTemplate>
            <EditItemTemplate>

                <asp:Table ID="TableUserDetails" runat="server">

                    <asp:TableRow>
                        <asp:TableHeaderCell>
                            <asp:Label ID="LabelUserName" runat="server" Text="User Name:" AssociatedControlID="LiteralUserName" />
                        </asp:TableHeaderCell><asp:TableCell>
                            <asp:Literal ID="LiteralUserName" runat="server" Text='<%# Bind("UserName") %>' />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableHeaderCell>
                            <asp:Label ID="LabelEmail" runat="server" Text="Email:" AssociatedControlID="LiteralEmail" />
                        </asp:TableHeaderCell><asp:TableCell>
                            <asp:Literal ID="LiteralEmail" runat="server" Text='<%# Bind("Email") %>' />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableHeaderCell>
                            <asp:Label ID="LabelIsApproved" runat="server" Text="User Enabled:" AssociatedControlID="LiteralIsApproved" />
                        </asp:TableHeaderCell><asp:TableCell>
                            <asp:Literal ID="LiteralIsApproved" runat="server" Text='<%# Bind("IsApproved") %>' />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableHeaderCell>
                            <asp:Label ID="LabelIsLockedOut" runat="server" Text="Account Locked Out:" AssociatedControlID="LiteralIsLockedOut" />
                        </asp:TableHeaderCell><asp:TableCell>
                            <asp:Literal ID="LiteralIsLockedOut" runat="server" Text='<%# Bind("IsLockedOut") %>' />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableHeaderCell>
                            <asp:Label ID="LabelCreationDate" runat="server" Text="Date Created:" AssociatedControlID="LiteralCreationDate" />
                        </asp:TableHeaderCell><asp:TableCell>
                            <asp:Literal ID="LiteralCreationDate" runat="server" Text='<%# Bind("CreationDate") %>' />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableHeaderCell>
                            <asp:Label ID="LabelLastLastLoginDate" runat="server" Text="Last Login:" AssociatedControlID="LiteralLastLastLoginDate" />
                        </asp:TableHeaderCell><asp:TableCell>
                            <asp:Literal ID="LiteralLastLastLoginDate" runat="server" Text='<%# Bind("LastLoginDate") %>' />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </EditItemTemplate>
        </asp:FormView>
        <asp:Table ID="TableUserRoles" runat="server">
            <asp:TableRow>
                <asp:TableHeaderCell>
                    <asp:Label ID="LabelUserRoles" runat="server" Text="Assigned Roles:" AssociatedControlID="ListViewUserRoles"></asp:Label></asp:TableHeaderCell>
                <asp:TableCell>
                    <asp:ListView ID="ListViewUserRoles" runat="server">
                        <ItemTemplate>
                            <%# Container.DataItem %>
                        </ItemTemplate>
                    </asp:ListView>
                </asp:TableCell>

            </asp:TableRow>
        </asp:Table>

    </asp:Panel>

</asp:Content>
