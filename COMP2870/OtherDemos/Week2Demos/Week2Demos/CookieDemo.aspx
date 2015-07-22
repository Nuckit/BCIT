<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CookieDemo.aspx.cs" Inherits="CookieDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%
        if (Request.Cookies["TASKS"] == null)
        {
            //This is the first time a browser makes the request
            HttpCookie hc = new HttpCookie("TASKS");
            hc["TASK_TO_DO"] = "Assignment 1";
            hc["DUE_DATE"] = DateTime.Now.AddDays(21).ToString();

            hc.Expires = DateTime.Now.AddDays(21);

            Response.Cookies.Add(hc);
            Response.Write("<h3>Cookie created....</h3>");
        }
        else
            Response.Write("<h3>Cookie already exists....</h3>");
        
        
     %>
    </div>
    </form>
</body>
</html>
