<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ServerDemo.aspx.cs" Inherits="ServerDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%
        
        Response.Write("<h3> Server Name : " + Server.MachineName + "</h3>");
        Response.Write("<br/>");

        string msg = "Use <b> and <i> tags to highlight your text";

        Response.Write(Server.HtmlEncode(msg));
        Response.Write("<br/>");
        Response.Write("This is a sample message");
     %>
    </div>
    </form>
</body>
</html>
