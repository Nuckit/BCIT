<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListViewDemo1.aspx.cs" Inherits="ListViewDemo1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ListView Demo1</title>
</head>
<body>
 <p style="background-color:InfoBackground">This page displays a ListView where the ItemTemplate and AlternatingItemTemplate are specified. The ListView is bound to a DataSource that selects all the employee records  </p>
    <form id="form1" runat="server">
  
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" >
      
        
        <ItemTemplate>
        <div style="border: solid 1px black">
        <%# Eval("TitleOfCourtesy")%> <%# Eval("FirstName")%>, <%# Eval("LastName")%>
        </div>    
        </ItemTemplate>
        
        <AlternatingItemTemplate>
        <div style="border: solid 1px black; background-color: #C0C0C0;">
        <%# Eval("TitleOfCourtesy")%> <%# Eval("FirstName")%>, <%# Eval("LastName")%>
        </div>    
        </AlternatingItemTemplate>
        
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
