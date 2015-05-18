<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ClientInfo.aspx.cs" Inherits="ClientInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%
            Response.Write(string.Format("<b>Server Name:</b> {0}<br>", Server.MachineName));
            Response.Write(string.Format("<b>Browser Name:</b> {0}<br>", Request.Browser.Browser));
            Response.Write(string.Format("<b>Client IP Address:</b> {0}<br>", Request.UserHostAddress));
            Response.Write(string.Format("<b>Current Time:</b> {0}<br>", DateTime.Now));
             %>    
    </div>
    </form>
</body>
</html>
