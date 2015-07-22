<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListViewDemo3.aspx.cs" Inherits="ListViewDemos_ListViewDemo3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>List View Demo3</title>
</head>
<body>
 <p style="background-color:InfoBackground">This page displays a ListView that supports both the insertion and updating capabilities.</p>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString1 %>" 
            DeleteCommand="DELETE FROM [Employees] WHERE [EmployeeID] = @EmployeeID" 
            InsertCommand="INSERT INTO [Employees] ([LastName], [FirstName], [Address], [City], [Country], [PostalCode]) VALUES (@LastName, @FirstName, @Address, @City, @Country, @PostalCode)" 
            SelectCommand="SELECT [EmployeeID], [LastName], [FirstName], [Address], [City], [Country], [PostalCode] FROM [Employees]" 
            UpdateCommand="UPDATE [Employees] SET [LastName] = @LastName, [FirstName] = @FirstName, [Address] = @Address, [City] = @City, [Country] = @Country, [PostalCode] = @PostalCode WHERE [EmployeeID] = @EmployeeID">
            <DeleteParameters>
                <asp:Parameter Name="EmployeeID" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="Address" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="Country" Type="String" />
                <asp:Parameter Name="PostalCode" Type="String" />
                <asp:Parameter Name="EmployeeID" Type="Int32" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="Address" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="Country" Type="String" />
                <asp:Parameter Name="PostalCode" Type="String" />
            </InsertParameters>
        </asp:SqlDataSource>
    </div>
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="EmployeeID" 
        DataSourceID="SqlDataSource1" InsertItemPosition="LastItem">
        <ItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                <td>
                    <asp:Label ID="EmployeeIDLabel" runat="server" 
                        Text='<%# Eval("EmployeeID") %>' />
                </td>
                <td>
                    <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
                </td>
                <td>
                    <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
                </td>
                <td>
                    <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                </td>
                <td>
                    <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                </td>
                <td>
                    <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                </td>
                <td>
                    <asp:Label ID="PostalCodeLabel" runat="server" 
                        Text='<%# Eval("PostalCode") %>' />
                </td>
            </tr>
        </ItemTemplate>
        <AlternatingItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                <td>
                    <asp:Label ID="EmployeeIDLabel" runat="server" 
                        Text='<%# Eval("EmployeeID") %>' />
                </td>
                <td>
                    <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
                </td>
                <td>
                    <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
                </td>
                <td>
                    <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                </td>
                <td>
                    <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                </td>
                <td>
                    <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                </td>
                <td>
                    <asp:Label ID="PostalCodeLabel" runat="server" 
                        Text='<%# Eval("PostalCode") %>' />
                </td>
            </tr>
        </AlternatingItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="">
                <tr>
                    <td>
                        No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <tr style="">
                <td>
                <asp:LinkButton ID="InsertButton" runat="server" CommandName="Insert" Text="Insert"></asp:LinkButton>
                   <asp:LinkButton ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel"></asp:LinkButton>                   
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="LastNameTextBox" runat="server" 
                        Text='<%# Bind("LastName") %>' />
                    <asp:RequiredFieldValidator runat="server" ID="rfvLastNameInsert" Text="*" ForeColor="Red" ControlToValidate="LastNameTextBox"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="FirstNameTextBox" runat="server" 
                        Text='<%# Bind("FirstName") %>' />
                      <asp:RequiredFieldValidator runat="server" ID="rfvFirstNameInsert" Text="*" ForeColor="Red" ControlToValidate="FirstNameTextBox"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                </td>
                <td>
                    <asp:TextBox ID="PostalCodeTextBox" runat="server" 
                        Text='<%# Bind("PostalCode") %>' />
                </td>
            </tr>
        </InsertItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table ID="itemPlaceholderContainer" runat="server" border="0" style="">
                            <tr runat="server" style="">
                                <th runat="server">
                                </th>
                                <th runat="server">
                                    EmployeeID</th>
                                <th runat="server">
                                    LastName</th>
                                <th runat="server">
                                    FirstName</th>
                                <th runat="server">
                                    Address</th>
                                <th runat="server">
                                    City</th>
                                <th runat="server">
                                    Country</th>
                                <th runat="server">
                                    PostalCode</th>
                            </tr>
                            <tr ID="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="">
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <EditItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" 
                        Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                        Text="Cancel" />
                </td>
                <td>
                    <asp:Label ID="EmployeeIDLabel1" runat="server" 
                        Text='<%# Eval("EmployeeID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="LastNameTextBox" runat="server" 
                        Text='<%# Bind("LastName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="FirstNameTextBox" runat="server" 
                        Text='<%# Bind("FirstName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                </td>
                <td>
                    <asp:TextBox ID="PostalCodeTextBox" runat="server" 
                        Text='<%# Bind("PostalCode") %>' />
                </td>
            </tr>
        </EditItemTemplate>
        <SelectedItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                <td>
                    <asp:Label ID="EmployeeIDLabel" runat="server" 
                        Text='<%# Eval("EmployeeID") %>' />
                </td>
                <td>
                    <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
                </td>
                <td>
                    <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
                </td>
                <td>
                    <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                </td>
                <td>
                    <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                </td>
                <td>
                    <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                </td>
                <td>
                    <asp:Label ID="PostalCodeLabel" runat="server" 
                        Text='<%# Eval("PostalCode") %>' />
                </td>
            </tr>
        </SelectedItemTemplate>
    </asp:ListView>
    </form>
</body>
</html>
