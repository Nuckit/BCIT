<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DisplayUsers.aspx.cs" Inherits="Admin_DisplayUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="UserName" DataNavigateUrlFormatString="AddUserToRoles.aspx?User={0}" Text="Add role" />
                <asp:HyperLinkField DataNavigateUrlFields="UserName" DataNavigateUrlFormatString="RemoveUserFromRole.aspx?User={0}" Text="Remove role" />
                <asp:HyperLinkField DataNavigateUrlFields="UserName" DataNavigateUrlFormatString="DeleteUser.aspx?User={0}" Text="Delete user" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
