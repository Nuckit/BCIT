<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Categories.aspx.cs" Inherits="Categories" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CategoryID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" InsertVisible="False" ReadOnly="True" SortExpression="CategoryID" />
                <asp:BoundField DataField="CategoryName" HeaderText="CategoryName" SortExpression="CategoryName" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString1 %>" SelectCommand="SELECT * FROM [Categories] WHERE ([CategoryID] = @CategoryID)">
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="0" Name="CategoryID" QueryStringField="Id" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
