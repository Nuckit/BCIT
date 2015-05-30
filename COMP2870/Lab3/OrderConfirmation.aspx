<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmation.aspx.cs" Inherits="OrderConfirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Confirmation</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Order Details</h3>
    
        <asp:Label ID="LabelFlowerType" runat="server"></asp:Label>
        <br />
        <asp:Label ID="LabelAddress" runat="server"></asp:Label>
        <br />
        <asp:Label ID="LabelEmail" runat="server"></asp:Label>
        <br />
        <asp:Label ID="LabelTitle" runat="server"></asp:Label>
        <br />
        <asp:Label ID="LabelRecipientName" runat="server"></asp:Label>
        <br />
        <asp:Label ID="LabelFlowersWrapped" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonSubmit" runat="server" OnClick="ButtonSubmit_Click" Text="Submit Order" />
        <br />
        <asp:HyperLink ID="HyperLinkGoBack" runat="server" NavigateUrl="OrderForm.aspx">Go Back</asp:HyperLink>    
    </div>
    </form>
</body>
</html>
