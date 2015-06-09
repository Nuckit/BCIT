<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchTask.aspx.cs" Inherits="SearchTask" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Pick a task to edit:
        <asp:DropDownList ID="DropDownListTasks" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListTasks_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
    
    </div>
        <asp:Label ID="LabelNoPendingTasks" runat="server"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLinkGoBack" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>
    </form>
</body>
</html>
