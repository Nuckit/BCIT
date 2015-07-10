<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:LoginName ID="LoginName1" runat="server" FormatString="User: {0}" />
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
        <div></div>
        <asp:HyperLink ID="HyperLink1" NavigateUrl="Secure/Salary.aspx" runat="server">Salary Info</asp:HyperLink>
    </form>
</body>
</html>
