<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MeetingScheduler.aspx.cs" Inherits="MeetingScheduler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="styles\main.css" />
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            


            <div class="group">
                <asp:Panel ID="PanelMeetingStart" runat="server" GroupingText="Meeting Start" CssClass="SchedulerDateTimeEntry">

                    <asp:Calendar ID="CalendarStartDate" runat="server"></asp:Calendar>

                    <asp:Label ID="LabelStartDate" runat="server" Text="Start Date" AssociatedControlID="TextBoxStartDate"></asp:Label>
                    <asp:TextBox ID="TextBoxStartDate" runat="server"></asp:TextBox>

                    <asp:Label ID="LabelStartTime" runat="server" Text="Start Time" AssociatedControlID="TextBoxStartTime"></asp:Label>
                    <asp:TextBox ID="TextBoxStartTime" runat="server"></asp:TextBox>
                </asp:Panel>


                <asp:Panel ID="Panel1" runat="server" GroupingText="Meeting End" CssClass="SchedulerDateTimeEntry">

                    <asp:Calendar ID="CalendarEndDate" runat="server"></asp:Calendar>

                    <asp:Label ID="LabelEndDate" runat="server" Text="End Date" AssociatedControlID="TextBoxEndDate"></asp:Label>
                    <asp:TextBox ID="TextBoxEndDate" runat="server"></asp:TextBox>

                    <asp:Label ID="LabelEndTime" runat="server" Text="End Time" AssociatedControlID="TextBoxEndTime"></asp:Label>
                    <asp:TextBox ID="TextBoxEndTime" runat="server"></asp:TextBox>
                </asp:Panel>
            </div>


            <asp:Label ID="LabelMeetingSummary" runat="server" Text="Summary:" AssociatedControlID="TextBoxMeetingSummary"></asp:Label>
            <asp:TextBox ID="TextBoxMeetingSummary" runat="server"></asp:TextBox>

            <asp:Label ID="LabelMeetingLocation" runat="server" Text="Location:" AssociatedControlID="TextBoxMeetingLocation"></asp:Label>
            <asp:TextBox ID="TextBoxMeetingLocation" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="LabelMeetingDescritpion" runat="server" Text="Description:" AssociatedControlID="TextBoxMeetingDescritpion"></asp:Label>
            <asp:TextBox ID="TextBoxMeetingDescritpion" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:Panel ID="PanelValidationErrors" runat="server">
                <asp:ValidationSummary ID="ValidationSummaryMeetingScheduler" runat="server" CssClass="ValidationError" />
            </asp:Panel>
            <asp:Panel ID="PanelButtons" runat="server">
                <asp:Button ID="ButtonSaveMeeting" runat="server" Text="Save Current Meeting" />
                <asp:Button ID="ButtonDiscard" runat="server" Text="Discard Current Meeting" OnClick="ButtonDiscard_Click" OnClientClick="return confirm('Are you sure you want to discard the current meeting?');" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
