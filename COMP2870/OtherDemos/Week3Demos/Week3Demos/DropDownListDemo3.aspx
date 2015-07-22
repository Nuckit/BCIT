<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DropDownListDemo3.aspx.cs" Inherits="DropDownListDemo3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <asp:DropDownList ID="ddlCreditCard" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCreditCard_SelectedIndexChanged">
            <asp:ListItem>VISA</asp:ListItem>
            <asp:ListItem>Mastercard</asp:ListItem>
            <asp:ListItem>American Express</asp:ListItem>
        </asp:DropDownList>     
        <p>
        <asp:Label Text="" runat="server" ID="lblMsg" />
        </p>
    </form>
</body>
</html>
