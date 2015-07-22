<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AJAXDemo5.aspx.cs" Inherits="AJAX_AJAXDemo5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AJAX Demo 5</title>
</head>
<body>
    <form id="form1" runat="server">
    <p style="background-color:InfoBackground">This Page demonstrates the use of the a Timer Control which triggers an AJAX request. On the server the XMLDataSource 
    retrieves the latest RSS feed for Google Top News and updates the GridView that is being used to display the titles of all the recent links posted to delicious
    </p>
     <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" EnableCaching="false" XPath="rss/channel/item" DataFile="http://feeds.delicious.com/v2/rss/recent"></asp:XmlDataSource>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            
        <asp:GridView ID="GridView1" runat="server" DataSourceID="XmlDataSource1" 
                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                GridLines="None">
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <Columns>
               
                <asp:TemplateField HeaderText="Recent Delicious Links">
                <ItemTemplate>
                <asp:Label runat="server" ID="lblTitle" Text='<%# XPath("title") %>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
               
            </Columns>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#999999" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            </asp:GridView>
        
        <asp:Timer ID="Timer1" runat="server" Interval="5000" ontick="Timer1_Tick">
        </asp:Timer>
            
        </ContentTemplate>
        
        </asp:UpdatePanel>
    </div>
   
    </form>
</body>
</html>
