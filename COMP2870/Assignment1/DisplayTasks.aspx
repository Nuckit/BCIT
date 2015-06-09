<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DisplayTasks.aspx.cs" Inherits="DisplayTasks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>All Tasks</h3>
    </div>
        <asp:BulletedList ID="BulletedListTasks" runat="server">
        </asp:BulletedList>
        <asp:HyperLink ID="HyperLinkBack" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>
    </form>
</body>
</html>
