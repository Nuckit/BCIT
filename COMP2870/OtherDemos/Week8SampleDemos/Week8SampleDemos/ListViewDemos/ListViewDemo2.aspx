<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListViewDemo2.aspx.cs" Inherits="ListViewDemo2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ListView Demo2</title>
</head>
<body>
 <p style="background-color:InfoBackground">This page displays a ListView with a LayoutTemplate. The LayoutTemplate encloses a HTML table and acts as a top level container for all 
 the item templates that follow  </p>
    <form id="form1" runat="server">
    
     <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
     
        <LayoutTemplate>
        <table>
        <thead>
        <tr><th>Employee Name</th><th>Address</th><th>City</th><th>Postal Code</th>                        
        </tr>        
        </thead>
        <tbody>
        <!-- This is where the Item Templates will be inserted  -->
        <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
        <!-- Done with Item Templates  -->
        </tbody>
        </table>                
        </LayoutTemplate>
        
        <ItemTemplate>
       <tr>
       <td><%# Eval("TitleOfCourtesy")%> <%# Eval("FirstName")%>, <%# Eval("LastName")%></td>
       <td><%# Eval("Address")%></td>
       <td><%# Eval("City")%></td>
       <td><%# Eval("PostalCode")%></td>
       </tr>
        </ItemTemplate>               
        
        <EmptyDataTemplate>
        There are no records 
        </EmptyDataTemplate>
        
        </asp:ListView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString1 %>" 
            SelectCommand="SELECT [EmployeeID], [LastName], [FirstName], [Title], [TitleOfCourtesy], [Address], [City], [PostalCode], [Country] FROM [Employees]"></asp:SqlDataSource>
 
    </form>
</body>
</html>
