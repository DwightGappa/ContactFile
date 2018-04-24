<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactEdit.aspx.cs" Inherits="ContactEditor" MasterPageFile="MasterPage-ContactFile.master" %>

<asp:Content ID="ContentContactEdit" ContentPlaceHolderID="ContentPlaceHolderContactDetails" runat="Server">
    <asp:Panel ID="PanelContactImage" runat="server" CssClass="grid-parent">
        <asp:Image ID="ImageContact" ImageUrl="images/ProfilePlaceholderSuit-300px.png" runat="server" />

        <asp:Label ID="LabelImageFileURL" runat="server" AssociatedControlID="FileUploadImageFile" Text="Image URL:" CssClass=""></asp:Label>
        <asp:FileUpload ID="FileUploadImageFile" runat="server" />
    </asp:Panel>

    <asp:Panel ID="PanelName" GroupingText="Name" runat="server">
        <asp:Label ID="LabelContactName" runat="server" AssociatedControlID="TextBoxContactName" Text="Name:"></asp:Label>
        <asp:TextBox ID="TextBoxContactName" runat="server"></asp:TextBox>
    </asp:Panel>

    <asp:Panel ID="PanelCompanyInformation" GroupingText="Company Information" runat="server">
        <asp:Label ID="LabelCompany" runat="server" AssociatedControlID="TextBoxCompany" Text="Company:"></asp:Label>
        <asp:TextBox ID="TextBoxCompany" runat="server"></asp:TextBox>

        <asp:Label ID="LabelJobTitle" runat="server" AssociatedControlID="TextBoxJobTitle" Text="JobTitle:"></asp:Label>
        <asp:TextBox ID="TextBoxJobTitle" runat="server"></asp:TextBox>
    </asp:Panel>

    <asp:Panel ID="PanelOnlineConact" GroupingText="Online Contact" runat="server">
        <asp:Label ID="LabelEmailAddress" runat="server" AssociatedControlID="TextBoxEmailAddress" Text="EmailAddress:"></asp:Label>
        <asp:TextBox ID="TextBoxEmailAddress" runat="server"></asp:TextBox>

        <asp:Label ID="LabelSkyperUserName" runat="server" AssociatedControlID="TextBoxSkypeUserName" Text="SkyperUserName:"></asp:Label>
        <asp:TextBox ID="TextBoxSkypeUserName" runat="server"></asp:TextBox>

        <asp:Label ID="LabelTwitterUserName" runat="server" AssociatedControlID="TextBoxTwitterUserName" Text="TwitterUserName:"></asp:Label>
        <asp:TextBox ID="TextBoxTwitterUserName" runat="server"></asp:TextBox>


        <asp:Label ID="LabelWebsiteURL" runat="server" AssociatedControlID="TextBoxWebsiteURL" Text="WebsiteURL:"></asp:Label>
        <asp:TextBox ID="TextBoxWebsiteURL" runat="server"></asp:TextBox>
    </asp:Panel>

    <asp:Panel ID="PanelPhoneNumber" GroupingText="Phone Number" runat="server">

        <asp:Label ID="LabelPhoneNumber" runat="server" AssociatedControlID="TextBoxPhoneNumber" Text="PhoneNumber:"></asp:Label>
        <asp:TextBox ID="TextBoxPhoneNumber" runat="server"></asp:TextBox>

        <asp:Label ID="LabelPhoneNumberExtension" runat="server" AssociatedControlID="TextBoxPhoneNumberExtension" Text="Extension:"></asp:Label>
        <asp:TextBox ID="TextBoxPhoneNumberExtension" runat="server"></asp:TextBox>

    </asp:Panel>

    <asp:Panel ID="PanelAddress" GroupingText="Address" runat="server">
        <asp:Label ID="LabelAddressLine1" runat="server" AssociatedControlID="TextBoxAddressLine1" Text="AddressLine1:"></asp:Label>
        <asp:TextBox ID="TextBoxAddressLine1" runat="server"></asp:TextBox>

        <asp:Label ID="LabelAddressLine2" runat="server" AssociatedControlID="TextBoxAddressLine2" Text="AddressLine2:"></asp:Label>
        <asp:TextBox ID="TextBoxAddressLine2" runat="server"></asp:TextBox>

        <asp:Label ID="LabelAddressLine3" runat="server" AssociatedControlID="TextBoxAddressLine3" Text="AddressLine3:"></asp:Label>
        <asp:TextBox ID="TextBoxAddressLine3" runat="server"></asp:TextBox>

        <asp:Label ID="LabelAddressCity" runat="server" AssociatedControlID="TextBoxAddressCity" Text="AddressCity:"></asp:Label>
        <asp:TextBox ID="TextBoxAddressCity" runat="server"></asp:TextBox>

        <asp:Label ID="LabelAddressStateProvince" runat="server" AssociatedControlID="TextBoxAddressStateProvince" Text="AddressStateProvince:"></asp:Label>
        <asp:TextBox ID="TextBoxAddressStateProvince" runat="server"></asp:TextBox>

        <asp:Label ID="LabelAddressPostalCode" runat="server" AssociatedControlID="TextBoxAddressPostalCode" Text="AddressPostalCode:"></asp:Label>
        <asp:TextBox ID="TextBoxAddressPostalCode" runat="server"></asp:TextBox>

        <asp:Label ID="LabelAddressCountry" runat="server" AssociatedControlID="TextBoxAddressCountry" Text="AddressCountry:"></asp:Label>
        <asp:TextBox ID="TextBoxAddressCountry" runat="server"></asp:TextBox>
    </asp:Panel>

    <asp:Panel ID="PanelButtons" runat="server">
        <asp:Button ID="ButtonEdit" runat="server" Enabled="False" Text="Edit Contact" />
        <asp:Button ID="ButtonSave" runat="server" Text="Save Contact" OnClick="ButtonSave_Click" />
        <asp:Button ID="ButtonDelete" runat="server" Text="Delete Contact" OnClick="ButtonDelete_Click" OnClientClick="return confirm('Are you sure you want to delete the current contact?');" />
        <asp:Button ID="ButtonReset" runat="server" Text="Reset Form" OnClientClick="this.form.reset();return false;" />
    </asp:Panel>
</asp:Content>
