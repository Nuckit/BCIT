<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CalendarAjax.aspx.cs" Inherits="CalendarAjax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                <br />
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
