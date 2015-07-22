<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QueryStringResult.aspx.cs" Inherits="QueryStringResult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%
        Response.Write("<h3> Query : " + Request.QueryString["q"] + " </h3>");
        Response.Write("<br/>");
        Response.Write("<h3> Topic : " + Request.QueryString["topic"] + " </h3>");
     %>
    </div>
    </form>
</body>
</html>
