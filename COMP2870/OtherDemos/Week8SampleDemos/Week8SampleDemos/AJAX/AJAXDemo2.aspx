<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AJAXDemo2.aspx.cs" Inherits="AJAX_AJAXDemo2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AJAX Demo2</title>
</head>
<body>
    <form id="form1" runat="server">
    <p style="background-color:InfoBackground">This page has three UpdatePanels and their UpdateMode is set to conditional. To see the effect of the UpdateMode remove the UpdateMode
    attribute on the first UpdatePanel and observe the top label which displays the time. The default behavior is that on asynch postbacks all update panels are updated.</p>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server"  style="border:2px solid red" UpdateMode="Conditional" >
        <ContentTemplate>
           <asp:Label runat="server" ID="lblUP1Time" Text='<%# DateTime.Now.ToLongTimeString() %>'></asp:Label>
           <br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="ProductName" HeaderText="ProductName" 
                        SortExpression="ProductName" />
                    <asp:BoundField DataField="CategoryName" HeaderText="CategoryName" 
                        SortExpression="CategoryName" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" 
                        SortExpression="UnitPrice" />
                    <asp:BoundField DataField="UnitsInStock" HeaderText="UnitsInStock" 
                        SortExpression="UnitsInStock" />
                    <asp:BoundField DataField="UnitsOnOrder" HeaderText="UnitsOnOrder" 
                        SortExpression="UnitsOnOrder" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString1 %>" 
                SelectCommand="SELECT [ProductName], [CategoryName], [UnitPrice], [UnitsInStock], [UnitsOnOrder] FROM [Alphabetical list of products]">
            </asp:SqlDataSource>
        </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <hr />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server"  style="border:2px solid green" UpdateMode="Conditional" >
            <ContentTemplate>
                <asp:Label ID="lblTime" runat="server" Font-Bold="True" Font-Size="Large" 
                    ForeColor="Red"></asp:Label>&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="GetTime" 
                    onclick="Button1_Click" />
            </ContentTemplate>
        </asp:UpdatePanel>
        
        <br />
        <hr />
        <asp:UpdatePanel ID="UpdatePanel3" runat="server"  style="border:2px solid red" UpdateMode="Conditional" >
            <ContentTemplate>
                <asp:GridView ID="GridView2" runat="server" AllowSorting="True" 
                    AutoGenerateColumns="False" DataKeyNames="OrderID" 
                    DataSourceID="SqlDataSource2">
                    <Columns>
                        <asp:BoundField DataField="OrderID" HeaderText="OrderID" InsertVisible="False" 
                            ReadOnly="True" SortExpression="OrderID" />
                        <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" 
                            SortExpression="CustomerID" />
                        <asp:BoundField DataField="OrderDate" DataFormatString="{0:d}" 
                            HeaderText="OrderDate" SortExpression="OrderDate" />
                    </Columns>
                </asp:GridView>
                <asp:Label runat="server" ID="lblUP3Time" Text='<%# DateTime.Now.ToLongTimeString() %>'></asp:Label>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString1 %>" 
                    SelectCommand="SELECT TOP 10 * FROM ORDERS"></asp:SqlDataSource>
            </ContentTemplate>
        
        </asp:UpdatePanel>
        
    </div>
    </form>
</body>
</html>
