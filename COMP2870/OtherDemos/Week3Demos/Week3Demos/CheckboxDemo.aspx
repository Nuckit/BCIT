<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckboxDemo.aspx.cs" Inherits="CheckboxDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:CheckBox ID="cbDelivery" Text="Express Delivery?" TextAlign="Left" runat="server" />
    </div>
        <asp:Button Text="Submit" runat="server" OnClick="Unnamed1_Click" />
        <br />
        <asp:Label Text="" ID="lblMsg" runat="server" />
    </form>
</body>
</html>
