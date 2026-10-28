<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieDemo.aspx.cs" Inherits="CookieApplication.CookieDemo" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Cookie Demonstration</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Demonstration of Session and Persistent Cookies</h2>
        <div>
            User Name:
            <asp:TextBox ID="txtName" runat="server" />
            <br /><br />
            <asp:Button ID="btnSave" Text="Save Cookie" runat="server" OnClick="btnSave_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="btnShow" Text="Show Cookies" runat="server" OnClick="btnShow_Click" />
            <br /><br />
            <asp:Label ID="lblOutput" runat="server" Font-Bold="true" ForeColor="Blue" />
        </div>
    </form>
</body>
</html>
