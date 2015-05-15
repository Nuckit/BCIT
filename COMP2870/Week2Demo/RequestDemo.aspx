<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RequestDemo</title>
</head>
<body>
<form id="HtmlForm" runat="server">
    <div>
        <%
            Response.Write("<h3>Browser: " + Request.Browser.Browser + "</h3><br>");
            Response.Write("<h3>Platform: " + Request.Browser.Platform + "</h3><br>");
            Response.Write("<h3>IP: " + Request.UserHostAddress + "</h3><br>");
             %>
    </div>
</form>
</body>
</html>
