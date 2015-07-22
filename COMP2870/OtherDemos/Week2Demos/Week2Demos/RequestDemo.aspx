<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RequestDemo.aspx.cs" Inherits="RequestDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%
        Response.Write("<h3> Browser : " + Request.Browser.Browser + "</h3>");
        Response.Write("<br/>");
        Response.Write("<h3> Platform : " + Request.Browser.Platform + "</h3>");
        Response.Write("<br/>");
        Response.Write("<h3> Platform : " + Request.UserHostAddress + "</h3>");
    %>
    </div>
    </form>
</body>
</html>
