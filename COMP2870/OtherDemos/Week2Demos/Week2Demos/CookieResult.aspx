<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CookieResult.aspx.cs" Inherits="CookieResult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%
        if (Request.Cookies["TASKS"] != null)
        {
            HttpCookie hc = Request.Cookies["TASKS"];
            Response.Write("<h3>Cookie exists</h3><br/>");
            string task = hc["TASK_TO_DO"];
            Response.Write("<h3>Task to do " + task + " </h3><br/>");
        }
        else
            Response.Write("<h3>Cookie doesnot  exists....</h3>");
            
        
        
     %>
    </div>
    </form>
</body>
</html>
