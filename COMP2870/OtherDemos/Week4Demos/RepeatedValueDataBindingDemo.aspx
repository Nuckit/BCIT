<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RepeatedValueDataBindingDemo.aspx.cs" Inherits="RepeatedValueDataBindingDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h4>Select a Product</h4>
        <asp:DropDownList ID="ddlProducts" DataTextField="Name"  DataValueField="ID" runat="server">            
        </asp:DropDownList>
    </form>
</body>
</html>
