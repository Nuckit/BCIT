<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DropDownListDemo2.aspx.cs" Inherits="DropDownListDemo2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:DropDownList ID="ddlCreditCard" runat="server">          
        </asp:DropDownList>
        <asp:Button Text="Submit" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" />
        <asp:Label Text="" runat="server" ID="lblMsg" />
    </form>
</body>
</html>
