<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactViewer.aspx.cs" Inherits="ContactVeiwer" MasterPageFile="MasterPage-ContactFile.master" %>

<asp:Content ID="ContentContactEdit" ContentPlaceHolderID="ContentPlaceHolderContactDetails" runat="Server">
        <asp:Panel ID="PanelContactImage" runat="server">
            <asp:Image ID="ImageContact" ImageUrl="images/ProfilePlaceholderSuit-300px.png" runat="server" />

            
        </asp:Panel>

        <asp:Panel ID="PanelName" GroupingText="Name" runat="server">
            <asp:Literal ID="LiteralPrefixName" Visible="True" runat="server"></asp:Literal>
            <asp:Label ID="LabelPrefixName" runat="server" AssociatedControlID="TextBoxPrefixName" Visible="False" Text="PrefixName:"></asp:Label>
            


            <asp:Literal ID="LiteralFirstName" Visible="True" runat="server"></asp:Literal>
            <asp:Label ID="LabelFirstName" runat="server" AssociatedControlID="TextBoxFirstName" Visible="False" Text="FirstName:"></asp:Label>


            <asp:Literal ID="LiteralLastName" Visible="True" runat="server"></asp:Literal>
            <asp:Label ID="LabelLastName" runat="server" AssociatedControlID="TextBoxLastName" Visible="False" Text="LastName:"></asp:Label>


            <asp:Literal ID="LiteralSuffixName" Visible="True" runat="server"></asp:Literal>
            <asp:Label ID="LabelSuffixName" runat="server" AssociatedControlID="TextBoxSuffixName" Visible="False" Text="SuffixName:"></asp:Label>
        </asp:Panel>

        <asp:Panel ID="PanelCompanyInformation" GroupingText="Company Information" runat="server">
            <asp:Literal ID="LiteralCompany" Visible="True" runat="server"></asp:Literal>
            <asp:Label ID="LabelCompany" runat="server" AssociatedControlID="TextBoxCompany" Visible="False" Text="Company:"></asp:Label>

            <asp:Literal ID="LiteralJobTitle" Visible="True" runat="server"></asp:Literal>
            <asp:Label ID="LabelJobTitle" runat="server" AssociatedControlID="TextBoxJobTitle" Visible="False" Text="JobTitle:"></asp:Label>
        </asp:Panel>

        <asp:Panel ID="PanelOnlineConact" GroupingText="Online Contact" runat="server">
            <asp:Literal ID="LiteralEmailAddress" Visible="True" runat="server"></asp:Literal>
            <asp:Label ID="LabelEmailAddress" runat="server" AssociatedControlID="TextBoxEmailAddress" Visible="False" Text="EmailAddress:"></asp:Label>


            <asp:Literal ID="LiteralTwitterHandle" Visible="True" runat="server"></asp:Literal>
            <asp:Label ID="LabelTwitterHandle" runat="server" AssociatedControlID="TextBoxTwitterHandle" Visible="False" Text="TwitterHandle:"></asp:Label>


            <asp:Literal ID="LiteralWebsiteURL" Visible="True" runat="server"></asp:Literal>
            <asp:Label ID="LabelWebsiteURL" runat="server" AssociatedControlID="TextBoxWebsiteURL" Visible="False" Text="WebsiteURL:"></asp:Label>
        </asp:Panel>

        <asp:Panel ID="PanelPhoneNumber" GroupingText="Phone Number" runat="server">

            <asp:Literal ID="LiteralPhoneNumber" Visible="True" runat="server"></asp:Literal>
            <asp:Label ID="LabelPhoneNumber" runat="server" AssociatedControlID="TextBoxPhoneNumber" Visible="False" Text="PhoneNumber:"></asp:Label>

        </asp:Panel>

        <asp:Panel ID="PanelAddress" GroupingText="Address" runat="server">
            <asp:Literal ID="LiteralAddressLine1" Visible="True" runat="server"></asp:Literal>
            <asp:Label ID="LabelAddressLine1" runat="server" AssociatedControlID="TextBoxAddressLine1" Visible="False" Text="AddressLine1:"></asp:Label>

            <asp:Literal ID="LiteralAddressLine2" Visible="True" runat="server"></asp:Literal>
            <asp:Label ID="LabelAddressLine2" runat="server" AssociatedControlID="TextBoxAddressLine2" Visible="False" Text="AddressLine2:"></asp:Label>

            <asp:Literal ID="LiteralAddressLine3" Visible="True" runat="server"></asp:Literal>
            <asp:Label ID="LabelAddressLine3" runat="server" AssociatedControlID="TextBoxAddressLine3" Visible="False" Text="AddressLine3:"></asp:Label>

            <asp:Literal ID="LiteralAddressCity" Visible="True" runat="server"></asp:Literal>
            <asp:Label ID="LabelAddressCity" runat="server" AssociatedControlID="TextBoxAddressCity" Visible="False" Text="AddressCity:"></asp:Label>

            <asp:Literal ID="LiteralAddressStateProvince" Visible="True" runat="server"></asp:Literal>
            <asp:Label ID="LabelAddressStateProvince" runat="server" AssociatedControlID="TextBoxAddressStateProvince" Visible="False" Text="AddressStateProvince:"></asp:Label>

            <asp:Literal ID="LiteralAddressPostalCode" Visible="True" runat="server"></asp:Literal>
            <asp:Label ID="LabelAddressPostalCode" runat="server" AssociatedControlID="TextBoxAddressPostalCode" Visible="False" Text="AddressPostalCode:"></asp:Label>

            <asp:Literal ID="LiteralAddressCountry" Visible="True" runat="server"></asp:Literal>
            <asp:Label ID="LabelAddressCountry" runat="server" AssociatedControlID="TextBoxAddressCountry" Visible="False" Text="AddressCountry:"></asp:Label>
        </asp:Panel>

        <asp:Panel ID="PanelButtons" runat="server">
            <asp:Button ID="ButtonEdit" runat="server" Text="Edit Contact" OnClick="ButtonEdit_Click" />
            <asp:Button ID="ButtonScheduleMeeting" runat="server" Text="Schedule Meeting" OnClick="ButtonScheduleMeeting_Click" />
        </asp:Panel>
    </asp:Content>