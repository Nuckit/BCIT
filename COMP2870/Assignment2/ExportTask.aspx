<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExportTask.aspx.cs" Inherits="ExportTask" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Export Tasks to XML</h3>
    </div>
        <asp:Button ID="ButtonExportTasks" runat="server" OnClick="ButtonExportTasks_Click" Text="Export Tasks" />
        <br />
        <br />
        <asp:Button ID="ButtonViewXml" runat="server" OnClick="ButtonViewXml_Click" Text="View XML" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLinkBack" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>
        <p>
            <asp:Label ID="LabelResults" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
