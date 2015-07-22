<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AJAXDemo3.aspx.cs" Inherits="AJAX_AJAXDemo3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AJAX Demo 3</title>
</head>
<body>
  <p style="background-color:InfoBackground">This page demonstrates the use of Triggers collection of an UpdatePanel 
      (shown below with a red border). This allows for controls outside the update panel to 
  trigger an asynchronous postback. Sometimes you might have a page where the control that triggers the asynch postback is outside the Update Panel but changing the control is critical to updating the contents
   inside the UpdatePanel </p>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            DataSourceID="SqlDataSource2" DataTextField="CategoryName" 
            DataValueField="CategoryName">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString1 %>" 
            SelectCommand="SELECT [CategoryID], [CategoryName] FROM [Categories]">
        </asp:SqlDataSource>
        <br />
        <p style="background:gray">
        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean cursus lectus ac ligula auctor in ultricies nisi aliquam. Proin vel sapien diam, ultricies consectetur justo. Nulla facilisi. Aliquam varius consectetur tellus, nec lobortis metus vehicula eget. Nulla facilisi. Proin rutrum rutrum est, quis iaculis justo dapibus ut. Nulla feugiat vehicula adipiscing. Sed id lectus ipsum. Mauris eget ante ipsum. Maecenas risus leo, dignissim vel blandit in, rhoncus non dui. Curabitur dignissim dapibus vestibulum. Ut enim neque, tincidunt sit amet condimentum id, egestas in sem. Donec suscipit, nisi in aliquet molestie, odio augue dignissim enim, id mollis dui turpis ut diam. Suspendisse vitae neque sit amet magna lacinia blandit egestas et metus. Aenean quis est sit amet felis rhoncus molestie. Curabitur tincidunt felis eget ante ultrices viverra. Duis quis velit odio, a luctus magna. Curabitur ut felis libero. Suspendisse semper ligula eu massa lacinia sollicitudin. Phasellus et orci ante.

Phasellus semper tincidunt mi a adipiscing. Morbi et felis ut mauris vulputate tristique. In lobortis velit vel arcu vulputate vehicula. Pellentesque et magna libero, vitae lacinia lorem. Mauris sed leo at odio interdum facilisis a quis metus. Maecenas nulla dui, placerat et tincidunt quis, rutrum at justo. Cras placerat, dui at laoreet faucibus, lorem ante accumsan ipsum, at sollicitudin urna elit in nunc. Vivamus sit amet placerat lacus. Ut eget arcu elit. Duis tempor hendrerit adipiscing. Mauris sed nulla vel felis vulputate ultricies. Cras at elit sed diam blandit vehicula eu eget enim. Integer sem augue, euismod ut ultrices eu, ornare vel lacus.

Proin ultrices libero vel ligula mattis quis egestas mauris rutrum. Cras faucibus sollicitudin varius. In convallis sapien sed nisl faucibus sit amet ultricies erat tristique. Mauris id nisi vel nisi rutrum pharetra vel in magna. Nullam sed tortor nulla, ac adipiscing diam. Pellentesque imperdiet nulla vel libero dapibus vel tempor ligula condimentum. Praesent quis blandit leo. Sed ut adipiscing augue. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Suspendisse varius, nulla in interdum blandit, tellus ipsum placerat velit, eget eleifend arcu orci ac metus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Quisque odio nisi, elementum fermentum commodo vitae, placerat ut tellus. Aliquam congue porta lorem, ac tempus est convallis quis. Pellentesque aliquet, nisl vel porta vulputate, lectus velit iaculis sem, venenatis adipiscing est ante eu odio. Phasellus et sem ligula, a pretium mi. Sed vulputate nisl non velit porta sollicitudin. Nullam auctor, eros at sagittis commodo, nisi lacus commodo libero, ac pulvinar orci nisl a libero. Vestibulum auctor tellus vitae nibh blandit a porttitor dolor suscipit. Aenean iaculis molestie est ac lacinia.
</p>
    
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" style="border:1px solid red">
        <ContentTemplate>
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
                
                SelectCommand="SELECT [ProductName], [CategoryName], [UnitPrice], [UnitsInStock], [UnitsOnOrder] FROM [Alphabetical list of products] WHERE ([CategoryName] = @CategoryName)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="CategoryName" 
                        PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </ContentTemplate>
          
          
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="DropDownList1" EventName="SelectedIndexChanged" />
            </Triggers>
          
          
        </asp:UpdatePanel>       
        
    
    </form>
</body>
</html>
