﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsByCategory.aspx.cs" Inherits="ProductsByCategory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownListCategories" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListCategories_SelectedIndexChanged">
        </asp:DropDownList>
    
        <br />
    
    </div>
        <asp:GridView ID="GridViewProducts" runat="server">
        </asp:GridView>
    </form>
</body>
</html>