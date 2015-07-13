<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddUserToRoles.aspx.cs" Inherits="Admin_AddUserToRoles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
    
    </div>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
        <br />
        <br />
        <asp:Label ID="LabelResults" runat="server"></asp:Label>
    </form>
</body>
</html>
