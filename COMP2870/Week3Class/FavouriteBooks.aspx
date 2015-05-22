<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FavouriteBooks.aspx.cs" Inherits="FavouriteBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Favourite Books<br />
        <br />
        <asp:TextBox ID="TextBoxBook" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonAddBook" runat="server" OnClick="Button1_Click" Text="Add" />
        <asp:Button ID="ButtonViewAll" runat="server" OnClick="ButtonViewAll_Click" Text="View All" />
        <br />
        <br />
        <asp:Label ID="LabelAddedMessage" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
