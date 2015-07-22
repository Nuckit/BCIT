<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CommandDemo.aspx.cs" Inherits="CommandDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList runat="server" AutoPostBack="True" ID="ddlCountries" OnSelectedIndexChanged="Unnamed1_SelectedIndexChanged">
            <asp:ListItem Text="Select" />
            <asp:ListItem Text="UK" />
            <asp:ListItem Text="USA" />
             <asp:ListItem Text="Canada" />
        </asp:DropDownList>
    </div>
        <asp:GridView runat="server" ID="gvSuppliers"></asp:GridView>
    </form>
</body>
</html>
