<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListViewDemo5.aspx.cs" Inherits="ListViewDemos_ListViewDemo5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <asp:ListView
        ID="lvPhotos"
        GroupItemCount="3"
        runat="server">
        <LayoutTemplate>
            <asp:Placeholder id="groupPlaceholder" runat="server" />
        </LayoutTemplate>
        <GroupTemplate>
            <div>
               <asp:Placeholder id="itemPlaceholder" runat="server" />
            </div>
        </GroupTemplate>
        <ItemTemplate>
            <asp:Image  runat="server"  id="imPhoto" ImageUrl='<%# Container.DataItem %>'
                Width="200px"  />
        </ItemTemplate>
    </asp:ListView>
    </form>
</body>
</html>
