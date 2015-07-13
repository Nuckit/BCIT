<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:LoginName ID="LoginName1" runat="server" FormatString="User: {0}" />
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
        <br />
        <br/>
        <asp:LoginView ID="LoginView1" runat="server">
            <LoggedInTemplate>
                You are not an admin user!
                <br/>
            </LoggedInTemplate>
            <RoleGroups>
                <asp:RoleGroup Roles="Administrators">
                    <ContentTemplate>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/Home.aspx">Admin page</asp:HyperLink>
                    </ContentTemplate>
                </asp:RoleGroup>
            </RoleGroups>
            
        </asp:LoginView>
        

        
    </div>
    </form>
</body>
</html>
