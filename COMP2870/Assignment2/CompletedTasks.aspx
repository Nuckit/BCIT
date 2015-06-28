<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CompletedTasks.aspx.cs" Inherits="CompletedTasks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Completed Tasks</h3>
    </div>
        <asp:GridView ID="GridViewTasks" runat="server">
        </asp:GridView>
        <asp:HyperLink ID="HyperLinkBack" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>
    </form>
</body>
</html>
