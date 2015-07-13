<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Admin_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:HyperLink ID="HyperLink1" NavigateUrl="AddRole.aspx" runat="server">Add Role</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" NavigateUrl="CreateUser.aspx" runat="server">Create User</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink3" NavigateUrl="DisplayUsers.aspx" runat="server">Display Users</asp:HyperLink>
    </form>
</body>
</html>
