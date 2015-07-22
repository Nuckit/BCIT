<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LinkButtonDemo.aspx.cs" Inherits="LinkButtonDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Show Time</asp:LinkButton>
        <p>
            <asp:Label ID="lblTime" runat="server"></asp:Label>
        </p>
        <a href="CurrencyConverter2.aspx">Example of hyperlink</a>
    </form>
</body>
</html>
