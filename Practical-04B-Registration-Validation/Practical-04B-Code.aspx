<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationValidation.WebForm1" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Registration with Validation</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Registration with Validation</h2>

        Name:
        <asp:TextBox ID="txtName" runat="server" />
        <asp:RequiredFieldValidator ControlToValidate="txtName" ErrorMessage="Name is required!" ForeColor="Red" runat="server" />
        <br /><br />

        Age:
        <asp:TextBox ID="txtAge" runat="server" />
        <asp:RequiredFieldValidator ControlToValidate="txtAge" ErrorMessage="Age required!" ForeColor="Red" runat="server" />
        <asp:RangeValidator ControlToValidate="txtAge" Type="Integer" MinimumValue="18" MaximumValue="60"
            ErrorMessage="Age must be 18-60" ForeColor="Red" runat="server" />
        <br /><br />

        Email:
        <asp:TextBox ID="txtEmail" runat="server" />
        <asp:RegularExpressionValidator ControlToValidate="txtEmail"
            ValidationExpression="^[\w\.\-]+@([\w\-]+\.)+[\w\-]{2,4}$"
            ErrorMessage="Invalid Email!" ForeColor="Red" runat="server" />
        <br /><br />

        Password:
        <asp:TextBox ID="txtPass" TextMode="Password" runat="server" />
        <asp:RequiredFieldValidator ControlToValidate="txtPass" ErrorMessage="Password required!" ForeColor="Red" runat="server" />
        <br /><br />

        Confirm:
        <asp:TextBox ID="txtConfirm" TextMode="Password" runat="server" />
        <asp:CompareValidator ControlToValidate="txtConfirm" ControlToCompare="txtPass"
            ErrorMessage="Passwords do not match!" ForeColor="Red" runat="server" />
        <br /><br />

        <asp:Button ID="btnReg" Text="Register" runat="server" OnClick="btnReg_Click" Height="31px" />
        <br /><br />

        <asp:ValidationSummary runat="server" ForeColor="Red" HeaderText="The following errors occurred:" />
        <asp:Label ID="lblMsg" runat="server" ForeColor="Green" Font-Bold="true" />
    </form>
</body>
</html>
