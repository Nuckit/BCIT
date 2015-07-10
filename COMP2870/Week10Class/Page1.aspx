<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page1.aspx.cs" Inherits="Page1" Theme="Theme1"%>

<%@ Register src="CalendarControl.ascx" tagname="CalendarControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label Text="this text should be red" runat="server" />
        <br />
        <asp:Label Text="this text should be black" runat="server" EnableTheming="False"/>
    </div>
        <uc1:CalendarControl ID="CalendarControl1" runat="server" EnableTheming="False"/>
    </form>
</body>
</html>
