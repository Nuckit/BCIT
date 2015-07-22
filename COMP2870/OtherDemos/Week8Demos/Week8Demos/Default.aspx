<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="lvCars" runat="server" ItemPlaceholderID="itemContainer">
            <LayoutTemplate>
                <ul>
                <asp:PlaceHolder runat="server" ID="itemContainer"></asp:PlaceHolder>
                </ul>
            </LayoutTemplate>
            <ItemTemplate>
                <li>Car : <%# Container.DataItem %></li>
            </ItemTemplate>
        </asp:ListView>
    </div>
    </form>
</body>
</html>
