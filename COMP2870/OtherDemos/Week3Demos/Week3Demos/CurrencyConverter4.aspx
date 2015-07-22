<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CurrencyConverter4.aspx.cs" Inherits="CurrencyConverter4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  <h4>US Dollars to Canadian.</h4>
Convert:&nbsp;
        <asp:TextBox ID="tbAmount" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </p>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </form>
</body>
</html>
