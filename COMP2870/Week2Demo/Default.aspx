<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Welcome to my first asp.net website</h1>
        <% 
            Response.Write("<h3>");
            Response.Write("The current time is : " + DateTime.Now);
            Response.Write("</h3>");
             %>
    </div>
    </form>
</body>
</html>
