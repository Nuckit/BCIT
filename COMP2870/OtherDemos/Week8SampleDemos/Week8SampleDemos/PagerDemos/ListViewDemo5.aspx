<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListViewDemo5.aspx.cs" Inherits="ListViewDemos_ListViewDemo5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ListViewDemo5</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString1 %>" 
        SelectCommand="SELECT [ProductName], [CategoryName], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [ReorderLevel], [Discontinued] FROM [Alphabetical list of products]">
    </asp:SqlDataSource>
    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
        <ItemTemplate>
            <tr style="background-color: #FFFBD6;color: #333333;">
                <td>
                    <asp:Label ID="ProductNameLabel" runat="server" 
                        Text='<%# Eval("ProductName") %>' />
                </td>
                <td>
                    <asp:Label ID="CategoryNameLabel" runat="server" 
                        Text='<%# Eval("CategoryName") %>' />
                </td>
                <td>
                    <asp:Label ID="QuantityPerUnitLabel" runat="server" 
                        Text='<%# Eval("QuantityPerUnit") %>' />
                </td>
                <td>
                    <asp:Label ID="UnitPriceLabel" runat="server" Text='<%# Eval("UnitPrice") %>' />
                </td>
                <td>
                    <asp:Label ID="UnitsInStockLabel" runat="server" 
                        Text='<%# Eval("UnitsInStock") %>' />
                </td>
                <td>
                    <asp:Label ID="UnitsOnOrderLabel" runat="server" 
                        Text='<%# Eval("UnitsOnOrder") %>' />
                </td>
                <td>
                    <asp:Label ID="ReorderLevelLabel" runat="server" 
                        Text='<%# Eval("ReorderLevel") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="DiscontinuedCheckBox" runat="server" 
                        Checked='<%# Eval("Discontinued") %>' Enabled="false" />
                </td>
            </tr>
        </ItemTemplate>
        <AlternatingItemTemplate>
            <tr style="background-color: #FAFAD2;color: #284775;">
                <td>
                    <asp:Label ID="ProductNameLabel" runat="server" 
                        Text='<%# Eval("ProductName") %>' />
                </td>
                <td>
                    <asp:Label ID="CategoryNameLabel" runat="server" 
                        Text='<%# Eval("CategoryName") %>' />
                </td>
                <td>
                    <asp:Label ID="QuantityPerUnitLabel" runat="server" 
                        Text='<%# Eval("QuantityPerUnit") %>' />
                </td>
                <td>
                    <asp:Label ID="UnitPriceLabel" runat="server" Text='<%# Eval("UnitPrice") %>' />
                </td>
                <td>
                    <asp:Label ID="UnitsInStockLabel" runat="server" 
                        Text='<%# Eval("UnitsInStock") %>' />
                </td>
                <td>
                    <asp:Label ID="UnitsOnOrderLabel" runat="server" 
                        Text='<%# Eval("UnitsOnOrder") %>' />
                </td>
                <td>
                    <asp:Label ID="ReorderLevelLabel" runat="server" 
                        Text='<%# Eval("ReorderLevel") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="DiscontinuedCheckBox" runat="server" 
                        Checked='<%# Eval("Discontinued") %>' Enabled="false" />
                </td>
            </tr>
        </AlternatingItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" 
                style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                <tr>
                    <td>
                        No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" 
                        Text="Insert" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                        Text="Clear" />
                </td>
                <td>
                    <asp:TextBox ID="ProductNameTextBox" runat="server" 
                        Text='<%# Bind("ProductName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CategoryNameTextBox" runat="server" 
                        Text='<%# Bind("CategoryName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="QuantityPerUnitTextBox" runat="server" 
                        Text='<%# Bind("QuantityPerUnit") %>' />
                </td>
                <td>
                    <asp:TextBox ID="UnitPriceTextBox" runat="server" 
                        Text='<%# Bind("UnitPrice") %>' />
                </td>
                <td>
                    <asp:TextBox ID="UnitsInStockTextBox" runat="server" 
                        Text='<%# Bind("UnitsInStock") %>' />
                </td>
                <td>
                    <asp:TextBox ID="UnitsOnOrderTextBox" runat="server" 
                        Text='<%# Bind("UnitsOnOrder") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ReorderLevelTextBox" runat="server" 
                        Text='<%# Bind("ReorderLevel") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="DiscontinuedCheckBox" runat="server" 
                        Checked='<%# Bind("Discontinued") %>' />
                </td>
            </tr>
        </InsertItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table ID="itemPlaceholderContainer" runat="server" border="1" 
                            style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr runat="server" style="background-color: #FFFBD6;color: #333333;">
                                <th runat="server">
                                    ProductName</th>
                                <th runat="server">
                                    CategoryName</th>
                                <th runat="server">
                                    QuantityPerUnit</th>
                                <th runat="server">
                                    UnitPrice</th>
                                <th runat="server">
                                    UnitsInStock</th>
                                <th runat="server">
                                    UnitsOnOrder</th>
                                <th runat="server">
                                    ReorderLevel</th>
                                <th runat="server">
                                    Discontinued</th>
                            </tr>
                            <tr ID="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" 
                        style="text-align: center;background-color: #FFCC66;font-family: Verdana, Arial, Helvetica, sans-serif;color: #333333;">
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <EditItemTemplate>
            <tr style="background-color: #FFCC66;color: #000080;">
                <td>
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" 
                        Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                        Text="Cancel" />
                </td>
                <td>
                    <asp:TextBox ID="ProductNameTextBox" runat="server" 
                        Text='<%# Bind("ProductName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CategoryNameTextBox" runat="server" 
                        Text='<%# Bind("CategoryName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="QuantityPerUnitTextBox" runat="server" 
                        Text='<%# Bind("QuantityPerUnit") %>' />
                </td>
                <td>
                    <asp:TextBox ID="UnitPriceTextBox" runat="server" 
                        Text='<%# Bind("UnitPrice") %>' />
                </td>
                <td>
                    <asp:TextBox ID="UnitsInStockTextBox" runat="server" 
                        Text='<%# Bind("UnitsInStock") %>' />
                </td>
                <td>
                    <asp:TextBox ID="UnitsOnOrderTextBox" runat="server" 
                        Text='<%# Bind("UnitsOnOrder") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ReorderLevelTextBox" runat="server" 
                        Text='<%# Bind("ReorderLevel") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="DiscontinuedCheckBox" runat="server" 
                        Checked='<%# Bind("Discontinued") %>' />
                </td>
            </tr>
        </EditItemTemplate>
        <SelectedItemTemplate>
            <tr style="background-color: #FFCC66;font-weight: bold;color: #000080;">
                <td>
                    <asp:Label ID="ProductNameLabel" runat="server" 
                        Text='<%# Eval("ProductName") %>' />
                </td>
                <td>
                    <asp:Label ID="CategoryNameLabel" runat="server" 
                        Text='<%# Eval("CategoryName") %>' />
                </td>
                <td>
                    <asp:Label ID="QuantityPerUnitLabel" runat="server" 
                        Text='<%# Eval("QuantityPerUnit") %>' />
                </td>
                <td>
                    <asp:Label ID="UnitPriceLabel" runat="server" Text='<%# Eval("UnitPrice") %>' />
                </td>
                <td>
                    <asp:Label ID="UnitsInStockLabel" runat="server" 
                        Text='<%# Eval("UnitsInStock") %>' />
                </td>
                <td>
                    <asp:Label ID="UnitsOnOrderLabel" runat="server" 
                        Text='<%# Eval("UnitsOnOrder") %>' />
                </td>
                <td>
                    <asp:Label ID="ReorderLevelLabel" runat="server" 
                        Text='<%# Eval("ReorderLevel") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="DiscontinuedCheckBox" runat="server" 
                        Checked='<%# Eval("Discontinued") %>' Enabled="false" />
                </td>
            </tr>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" 
        QueryStringField="PageNum">
        <Fields>
            <asp:NextPreviousPagerField ShowFirstPageButton="True" 
                ShowLastPageButton="True" />
        </Fields>
    </asp:DataPager>
    </form>
</body>
</html>
