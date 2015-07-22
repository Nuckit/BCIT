<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs"  Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Welcome to my first ASP.NET website</h1>

      
    <%
        Response.Write("<h3>");
        Response.Write("Current Time is : " + DateTime.Now);
        Response.Write("</h3>");

        int counter = 0;
        try
        {
            Application.Lock();
            counter = (int)Application["HOMEPAGE_HIT_COUNT"];
            Application["HOMEPAGE_HIT_COUNT"] = ++counter;    
        }
        finally
        {
            Application.UnLock();
        }
            
        
        Response.Write("HIT COUNT " + counter);
     %>
    </div>
    </form>
</body>
</html>
