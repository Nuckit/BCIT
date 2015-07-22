<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ResponseDemo.aspx.cs" Inherits="ResponseDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <%
            Response.Redirect("http://www.bcit.ca");
          %>
    </div>
    </form>
</body>
</html>
