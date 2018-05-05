<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage-ContactFile.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMainContent" runat="Server">
    <asp:Panel ID="PanelGridViewContacts" runat="server" ScrollBars="Auto" CssClass="contact-list">
        <asp:ObjectDataSource ID="ObjectDataSourceContactFile" runat="server" TypeName="ContactFile.Database.DatabaseHelper" SelectMethod="GetContacts"></asp:ObjectDataSource>
        <asp:GridView ID="GridViewContacts" runat="server" AutoGenerateColumns="False" DataKeyNames="ContactID" AllowSorting="True" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" EnablePersistedSelection="True" DataSourceID="ObjectDataSourceContactFile">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775"></AlternatingRowStyle>
            <Columns>

                <asp:ButtonField ButtonType="Link" CommandName="Select" DataTextField="ContactName" HeaderText="Name" />


                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" SortExpression="EmailAddress"></asp:BoundField>
                <asp:BoundField DataField="SkypeUserName" HeaderText="SkypeUserName" SortExpression="SkypeUserName"></asp:BoundField>
                <asp:BoundField DataField="TwitterUserName" HeaderText="TwitterUserName" SortExpression="TwitterUserName"></asp:BoundField>

                <asp:BoundField DataField="GUID" ReadOnly="True" SortExpression="GUID" Visible="False"></asp:BoundField>
            </Columns>
            <EditRowStyle BackColor="#999999"></EditRowStyle>

            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></FooterStyle>

            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></HeaderStyle>

            <PagerStyle HorizontalAlign="Center" BackColor="#284775" ForeColor="White"></PagerStyle>

            <RowStyle BackColor="#F7F6F3" ForeColor="#333333"></RowStyle>

            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

            <SortedAscendingCellStyle BackColor="#E9E7E2"></SortedAscendingCellStyle>

            <SortedAscendingHeaderStyle BackColor="#506C8C"></SortedAscendingHeaderStyle>

            <SortedDescendingCellStyle BackColor="#FFFDF8"></SortedDescendingCellStyle>

            <SortedDescendingHeaderStyle BackColor="#6F8DAE"></SortedDescendingHeaderStyle>
        </asp:GridView>

    </asp:Panel>
    <!-- End div .contact-list -->
</asp:Content>
