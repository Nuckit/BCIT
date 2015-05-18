<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BrowserStats.aspx.cs" Inherits="BrowserStats" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Current Active Browser Sessions</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%
            Dictionary<string, ClientBrowser> clientBrowsers = (Dictionary<string, ClientBrowser>) Application.Get(global_asax.ActiveBrowserSessionsKey);

            foreach (var clientBrowser in clientBrowsers)
            {
                Response.Write(clientBrowser.Value + "<br>");
            }        
         %>
    </div>
    </form>
</body>
</html>
