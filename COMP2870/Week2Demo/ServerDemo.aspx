<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Title</title>
</head>
<body>
<form id="HtmlForm" runat="server">
    <div>
        <%
            Response.Write("<h3>Server name: " + Server.MachineName + "</h3><br>");
            string msg = "use <b> and <i> to highlight your text";
            Response.Write(Server.HtmlEncode(msg));
            Response.Write("That was a sample message");
        %>
    </div>
</form>
</body>
</html>
