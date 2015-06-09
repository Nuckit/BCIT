<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExportTasks.aspx.cs" Inherits="ExportTasks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="ButtonExportTasks" runat="server" OnClick="ButtonExportTasks_Click" Text="Export Tasks to XML" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLinkGoBack" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>
    </form>
</body>
</html>
