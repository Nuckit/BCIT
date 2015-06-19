<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Company.aspx.cs" Inherits="Company" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
                <asp:TemplateField HeaderText="CompanyName" SortExpression="CompanyName">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("CompanyName") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCompany" ControlToValidate="TextBox1" runat="server" ErrorMessage="Company cannot be blank"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("CompanyName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="ContactName" HeaderText="ContactName" SortExpression="ContactName" />
                <asp:BoundField DataField="ContactTitle" HeaderText="ContactTitle" SortExpression="ContactTitle" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString1 %>" DeleteCommand="DELETE FROM [Customers] WHERE [CustomerID] = @CustomerID" InsertCommand="INSERT INTO [Customers] ([CustomerID], [CompanyName], [ContactName], [ContactTitle], [Country]) VALUES (@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Country)" SelectCommand="SELECT [CustomerID], [CompanyName], [ContactName], [ContactTitle], [Country] FROM [Customers]" UpdateCommand="UPDATE [Customers] SET [CompanyName] = @CompanyName, [ContactName] = @ContactName, [ContactTitle] = @ContactTitle, [Country] = @Country WHERE [CustomerID] = @CustomerID">
            <DeleteParameters>
                <asp:Parameter Name="CustomerID" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="CustomerID" Type="String" />
                <asp:Parameter Name="CompanyName" Type="String" />
                <asp:Parameter Name="ContactName" Type="String" />
                <asp:Parameter Name="ContactTitle" Type="String" />
                <asp:Parameter Name="Country" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="CompanyName" Type="String" />
                <asp:Parameter Name="ContactName" Type="String" />
                <asp:Parameter Name="ContactTitle" Type="String" />
                <asp:Parameter Name="Country" Type="String" />
                <asp:Parameter Name="CustomerID" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        
    </form>
</body>
</html>
