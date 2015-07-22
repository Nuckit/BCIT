<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label runat="server" Text='<%# "Currently logged in User : " + User.Identity.Name %>'></asp:Label>
<br />
<asp:Label runat="server" Text='<%# "Authentication Type : " + User.Identity.AuthenticationType %>'></asp:Label>
    </div>
        Click here to logout: 
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
    </form>
    <p>
        <a href="Secure/SalaryInfo.aspx">SalaryInfo.aspx</a></p>
</body>
</html>
