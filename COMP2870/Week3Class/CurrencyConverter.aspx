<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CurrencyConverter.aspx.cs" Inherits="CurrencyConverter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Currency Converter<br />
    
    </div>
        <asp:TextBox ID="TextBoxCurrencyCad" runat="server">0</asp:TextBox>
&nbsp;CAD<br />
        <br />
        <asp:Button ID="BtnConvert" runat="server" OnClick="BtnConvert_Click" Text="Convert" />
        <p>
            <asp:Label ID="LabelCurrencyUsd" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
