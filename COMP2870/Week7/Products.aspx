<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                <asp:BoundField DataField="CategoryID" Visible="False" HeaderText="CategoryID" SortExpression="CategoryID" />
                <asp:HyperLinkField DataNavigateUrlFields="CategoryID" DataNavigateUrlFormatString="Categories.aspx?Id={0}" HeaderText="Category" Text="Go" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString1 %>" SelectCommand="SELECT [ProductID], [ProductName], [CategoryID] FROM [Products]"></asp:SqlDataSource>
    </form>
</body>
</html>
