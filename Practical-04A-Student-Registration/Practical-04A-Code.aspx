<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Student Registration Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Student Registration Form</h2>
            <hr />
        </div>
        <asp:Label Text="Student Name:" runat="server" />
        <asp:TextBox ID="txtName" runat="server" Width="200px" /><br />

        <asp:Label Text="Gender:" runat="server" /><br />
        <asp:RadioButton ID="rbMale" GroupName="gender" Text="Male" runat="server" />
        <asp:RadioButton ID="rbFemale" GroupName="gender" Text="Female" runat="server" /><br />

        <asp:Label Text="Course:" runat="server" />
        <asp:DropDownList ID="ddlCourse" runat="server">
            <asp:ListItem Text="Select Course" Value="" />
            <asp:ListItem Text="BSc IT" Value="BSc IT" />
            <asp:ListItem Text="BSc CS" Value="BSc CS" />
            <asp:ListItem Text="BCA" Value="BCA" />
        </asp:DropDownList><br />

        <asp:Label Text="Date of Birth:" runat="server" />
        <asp:Calendar ID="calDOB" runat="server" /><br />

        <asp:CheckBox ID="chkTerms" runat="server" Text="I accept Terms and Conditions" /><br />

        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        &nbsp;&nbsp;
        <asp:Button ID="btnClear" runat="server" Text="Clear" />
        <br /><br />
        <asp:Label ID="lblOutput" runat="server" ForeColor="Green" Font-Bold="true" />
    </form>
</body>
</html>
