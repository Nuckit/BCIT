<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SessionDemo.aspx.cs" Inherits="SessionDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%
        Response.Write("My Session ID " + Session.SessionID);
        List<string> books = Session["MY_WISH_LIST"] as List<string>;
        foreach (string b in books)
            Response.Write(b + "<br/>");
     %>
    </div>
    </form>
</body>
</html>
