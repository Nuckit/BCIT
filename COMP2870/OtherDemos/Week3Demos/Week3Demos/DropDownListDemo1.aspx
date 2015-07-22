<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DropDownListDemo1.aspx.cs" Inherits="DropDownListDemo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:DropDownList ID="ddlCreditCard" runat="server">
            <asp:ListItem Text="VISA" Value="1"></asp:ListItem>
            <asp:ListItem>Mastercard</asp:ListItem>
            <asp:ListItem>American Express</asp:ListItem>
        </asp:DropDownList>
        <asp:Button Text="Submit" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" />
        <asp:Label Text="" runat="server" ID="lblMsg" />
    </form>
</body>
</html>
