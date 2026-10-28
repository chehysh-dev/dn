<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationAd.Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>AdRotator Control Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>AdRotator Control Demo</h2>
        <p>Refresh the page or click the button to see a different advertisement:</p>
        <div>
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/XMLFile.xml"
                Height="120px" Width="468px" />
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Show Another Ad" />
        </div>
    </form>
</body>
</html>
