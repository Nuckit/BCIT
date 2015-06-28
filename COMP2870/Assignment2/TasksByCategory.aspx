<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TasksByCategory.aspx.cs" Inherits="TasksByCategory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Tasks By Category<asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        </h3>
    </div>       
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:DropDownList ID="DropDownListCategories" runat="server" OnSelectedIndexChanged="DropDownListCategories_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
                <br />
                <asp:GridView ID="GridViewTasks" runat="server">
                </asp:GridView>
            </ContentTemplate>        
        </asp:UpdatePanel>
        <br/>
        <asp:HyperLink ID="HyperLinkBack" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>
    </form>
</body>
</html>
