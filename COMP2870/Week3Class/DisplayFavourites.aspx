<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DisplayFavourites.aspx.cs" Inherits="DisplayFavourites" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Current Favourite Books</div>
        <asp:BulletedList ID="BulletedListAllBooks" runat="server">
        </asp:BulletedList>
        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Back" />
    </form>
</body>
</html>
