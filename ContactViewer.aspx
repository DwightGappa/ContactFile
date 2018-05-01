<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactViewer.aspx.cs" Inherits="ContactVeiwer" MasterPageFile="MasterPage-ContactFile.master" %>

<asp:Content ID="ContentContactEdit" ContentPlaceHolderID="ContentPlaceHolderMainContent" runat="Server">
        <asp:Panel ID="PanelContactImage" runat="server">
            <asp:Image ID="ImageContact" ImageUrl="images/ProfilePlaceholderSuit-300px.png" runat="server" />

            
        </asp:Panel>

        <asp:Panel ID="PanelName" GroupingText="Name" runat="server">
            <asp:Literal ID="LiteralContactName"  runat="server"></asp:Literal>
            <asp:Label ID="LabelContactName" runat="server" AssociatedControlID="LiteralContactName" Visible="False" Text="ContactName:"></asp:Label>
        </asp:Panel>

        <asp:Panel ID="PanelCompanyInformation" GroupingText="Company Information" runat="server">
            <asp:Literal ID="LiteralCompany"  runat="server"></asp:Literal>
            <asp:Label ID="LabelCompany" runat="server" AssociatedControlID="LiteralCompany" Visible="False" Text="Company:"></asp:Label>

            <asp:Literal ID="LiteralJobTitle"  runat="server"></asp:Literal>
            <asp:Label ID="LabelJobTitle" runat="server" AssociatedControlID="LiteralJobTitle" Visible="False" Text="JobTitle:"></asp:Label>
        </asp:Panel>

        <asp:Panel ID="PanelOnlineConact" GroupingText="Online Contact" runat="server">
            <asp:Literal ID="LiteralEmailAddress"  runat="server"></asp:Literal>
            <asp:Label ID="LabelEmailAddress" runat="server" AssociatedControlID="LiteralEmailAddress" Visible="False" Text="EmailAddress:"></asp:Label>

            <asp:Label ID="LabelSkyperUserName" runat="server" Visible="False" Text="SkyperUserName:"></asp:Label>
            <asp:Literal ID="LiteralSkyperUserName" runat="server"></asp:Literal>

            <asp:Literal ID="LiteralTwitterUserName"  runat="server"></asp:Literal>
            <asp:Label ID="LabelTwitterUserName" runat="server" AssociatedControlID="LiteralTwitterUserName" Visible="False" Text="TwitterUserName:"></asp:Label>


            <asp:Literal ID="LiteralWebsiteURL"  runat="server"></asp:Literal>
            <asp:Label ID="LabelWebsiteURL" runat="server" AssociatedControlID="LiteralWebsiteURL" Visible="False" Text="WebsiteURL:"></asp:Label>
        </asp:Panel>

        <asp:Panel ID="PanelPhoneNumber" GroupingText="Phone Number" runat="server">

            <asp:Literal ID="LiteralPhoneNumber"  runat="server"></asp:Literal>
            <asp:Label ID="LabelPhoneNumber" runat="server" AssociatedControlID="LiteralPhoneNumber" Visible="False" Text="PhoneNumber:"></asp:Label>

            <asp:Label ID="LabelPhoneNumberExtension" runat="server" AssociatedControlID="LiteralPhoneNumberExtension" Visible="False" Text="Extension:"></asp:Label>
            <asp:Literal ID="LiteralPhoneNumberExtension" runat="server"></asp:Literal>

        </asp:Panel>

        <asp:Panel ID="PanelAddress" GroupingText="Address" runat="server">
            <asp:Literal ID="LiteralAddressLine1"  runat="server"></asp:Literal>
            <asp:Label ID="LabelAddressLine1" runat="server" AssociatedControlID="LiteralAddressLine1" Visible="False" Text="AddressLine1:"></asp:Label>

            <asp:Literal ID="LiteralAddressLine2"  runat="server"></asp:Literal>
            <asp:Label ID="LabelAddressLine2" runat="server" AssociatedControlID="LiteralAddressLine2" Visible="False" Text="AddressLine2:"></asp:Label>

            <asp:Literal ID="LiteralAddressLine3"  runat="server"></asp:Literal>
            <asp:Label ID="LabelAddressLine3" runat="server" AssociatedControlID="LiteralAddressLine3" Visible="False" Text="AddressLine3:"></asp:Label>

            <asp:Literal ID="LiteralAddressCity"  runat="server"></asp:Literal>
            <asp:Label ID="LabelAddressCity" runat="server" AssociatedControlID="LiteralAddressCity" Visible="False" Text="AddressCity:"></asp:Label>

            <asp:Literal ID="LiteralAddressStateProvince"  runat="server"></asp:Literal>
            <asp:Label ID="LabelAddressStateProvince" runat="server" AssociatedControlID="LiteralAddressStateProvince" Visible="False" Text="AddressStateProvince:"></asp:Label>

            <asp:Literal ID="LiteralAddressPostalCode"  runat="server"></asp:Literal>
            <asp:Label ID="LabelAddressPostalCode" runat="server" AssociatedControlID="LiteralAddressPostalCode" Visible="False" Text="AddressPostalCode:"></asp:Label>

            <asp:Literal ID="LiteralAddressCountry"  runat="server"></asp:Literal>
            <asp:Label ID="LabelAddressCountry" runat="server" AssociatedControlID="LiteralAddressCountry" Visible="False" Text="AddressCountry:"></asp:Label>
        </asp:Panel>

        <asp:Panel ID="PanelButtons" runat="server">
            <asp:Button ID="ButtonEdit" runat="server" Text="Edit Contact" OnClick="ButtonEdit_Click" />
            <asp:Button ID="ButtonScheduleMeeting" runat="server" Text="Schedule Meeting" OnClick="ButtonScheduleMeeting_Click" />
        </asp:Panel>
    </asp:Content>