<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImageButtonDemo.aspx.cs" Inherits="ImageButtonDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/pups.jpg" OnClick="ImageButton1_Click" />
    </form>
</body>
</html>
