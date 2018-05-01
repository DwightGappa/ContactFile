<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div class="page">
    <form id="form1" runat="server">
        <div>
            <h1>Contact File</h1>
            <asp:Login runat="server"></asp:Login>
            <a href="UserManager/CreateUser.aspx">Regsiter</a>
        </div>
        
    </form>
    </div>
</body>
</html>

