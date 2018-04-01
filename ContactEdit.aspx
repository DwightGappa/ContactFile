<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactEdit.aspx.cs" Inherits="ContactEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmContactInformation" runat="server">
        <asp:Panel ID="PanelContactImage" runat="server">
            <asp:Image ID="ImageContact" ImageUrl="images/ProfilePlaceholderSuit-300px.png" runat="server" />

            <asp:Label ID="LabelImageFileURL" runat="server" AssociatedControlID="TextBoxImageFileURL"  Text="Image URL:"></asp:Label>
            <asp:TextBox ID="TextBoxImageFileURL" runat="server" ></asp:TextBox>
        </asp:Panel>

        <asp:Panel ID="PanelName" GroupingText="Name" runat="server">
            <asp:Label ID="LabelPrefixName" runat="server" AssociatedControlID="TextBoxPrefixName"  Text="PrefixName:"></asp:Label>
            <asp:TextBox ID="TextBoxPrefixName" runat="server" ></asp:TextBox>


            <asp:Label ID="LabelFirstName" runat="server" AssociatedControlID="TextBoxFirstName"  Text="FirstName:"></asp:Label>
            <asp:TextBox ID="TextBoxFirstName" runat="server" ></asp:TextBox>


            <asp:Label ID="LabelLastName" runat="server" AssociatedControlID="TextBoxLastName"  Text="LastName:"></asp:Label>
            <asp:TextBox ID="TextBoxLastName" runat="server" ></asp:TextBox>


            <asp:Label ID="LabelSuffixName" runat="server" AssociatedControlID="TextBoxSuffixName"  Text="SuffixName:"></asp:Label>
            <asp:TextBox ID="TextBoxSuffixName" runat="server" ></asp:TextBox>
        </asp:Panel>

        <asp:Panel ID="PanelCompanyInformation" GroupingText="Company Information" runat="server">
            <asp:Label ID="LabelCompany" runat="server" AssociatedControlID="TextBoxCompany"  Text="Company:"></asp:Label>
            <asp:TextBox ID="TextBoxCompany" runat="server" ></asp:TextBox>

            <asp:Label ID="LabelJobTitle" runat="server" AssociatedControlID="TextBoxJobTitle"  Text="JobTitle:"></asp:Label>
            <asp:TextBox ID="TextBoxJobTitle" runat="server" ></asp:TextBox>
        </asp:Panel>

        <asp:Panel ID="PanelOnlineConact" GroupingText="Online Contact" runat="server">
            <asp:Label ID="LabelEmailAddress" runat="server" AssociatedControlID="TextBoxEmailAddress"  Text="EmailAddress:"></asp:Label>
            <asp:TextBox ID="TextBoxEmailAddress" runat="server" ></asp:TextBox>


            <asp:Label ID="LabelTwitterHandle" runat="server" AssociatedControlID="TextBoxTwitterHandle"  Text="TwitterHandle:"></asp:Label>
            <asp:TextBox ID="TextBoxTwitterHandle" runat="server" ></asp:TextBox>


            <asp:Label ID="LabelWebsiteURL" runat="server" AssociatedControlID="TextBoxWebsiteURL"  Text="WebsiteURL:"></asp:Label>
            <asp:TextBox ID="TextBoxWebsiteURL" runat="server" ></asp:TextBox>
        </asp:Panel>

        <asp:Panel ID="PanelPhoneNumber" GroupingText="Phone Number" runat="server">

            <asp:Label ID="LabelPhoneNumber" runat="server" AssociatedControlID="TextBoxPhoneNumber"  Text="PhoneNumber:"></asp:Label>
            <asp:TextBox ID="TextBoxPhoneNumber" runat="server" ></asp:TextBox>

        </asp:Panel>

        <asp:Panel ID="PanelAddress" GroupingText="Address" runat="server">
            <asp:Label ID="LabelAddressLine1" runat="server" AssociatedControlID="TextBoxAddressLine1"  Text="AddressLine1:"></asp:Label>
            <asp:TextBox ID="TextBoxAddressLine1" runat="server" ></asp:TextBox>

            <asp:Label ID="LabelAddressLine2" runat="server" AssociatedControlID="TextBoxAddressLine2"  Text="AddressLine2:"></asp:Label>
            <asp:TextBox ID="TextBoxAddressLine2" runat="server" ></asp:TextBox>

            <asp:Label ID="LabelAddressLine3" runat="server" AssociatedControlID="TextBoxAddressLine3"  Text="AddressLine3:"></asp:Label>
            <asp:TextBox ID="TextBoxAddressLine3" runat="server" ></asp:TextBox>

            <asp:Label ID="LabelAddressCity" runat="server" AssociatedControlID="TextBoxAddressCity"  Text="AddressCity:"></asp:Label>
            <asp:TextBox ID="TextBoxAddressCity" runat="server" ></asp:TextBox>

            <asp:Label ID="LabelAddressStateProvince" runat="server" AssociatedControlID="TextBoxAddressStateProvince"  Text="AddressStateProvince:"></asp:Label>
            <asp:TextBox ID="TextBoxAddressStateProvince" runat="server" ></asp:TextBox>

            <asp:Label ID="LabelAddressPostalCode" runat="server" AssociatedControlID="TextBoxAddressPostalCode"  Text="AddressPostalCode:"></asp:Label>
            <asp:TextBox ID="TextBoxAddressPostalCode" runat="server" ></asp:TextBox>

            <asp:Label ID="LabelAddressCountry" runat="server" AssociatedControlID="TextBoxAddressCountry"  Text="AddressCountry:"></asp:Label>
            <asp:TextBox ID="TextBoxAddressCountry" runat="server" ></asp:TextBox>
        </asp:Panel>

        <asp:Panel ID="PanelButtons" runat="server">
            <asp:Button ID="ButtonEdit" runat="server" Enabled="False" Text="Edit Contact"/>
            <asp:Button ID="ButtonSave" runat="server"  Text="Save Contact" OnClick="ButtonSave_Click" />
            <asp:Button ID="ButtonDelete" runat="server"  Text="Delete Contact" OnClick="ButtonDelete_Click" OnClientClick="return confirm('Are you sure you want to delete the current contact?');"/>
            <asp:Button ID="ButtonReset" runat="server"  Text="Reset Form" OnClientClick="this.form.reset();return false;" />
        </asp:Panel>


    </form>
</body>
</html>
