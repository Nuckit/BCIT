<%@ Application Language="C#" %>

<script runat="server">
    public const string ActiveBrowserSessionsKey = "ActiveBrowserSessions";

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        Application.Add(ActiveBrowserSessionsKey, new Dictionary<string, ClientBrowser>());       
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started
        Uri urlReferrer = Request.UrlReferrer;
        
        ClientBrowser clientBrowser = new ClientBrowser
        {
            Name = Request.Browser.Browser,
            Platform = Request.UserAgent,
            ClientIpAddress = Request.UserHostAddress,
            IsMobile = Request.Browser.IsMobileDevice,
            UrlReferrer = urlReferrer != null ? urlReferrer.AbsolutePath : "N/A",
            SessionCreatedAt = DateTime.Now
        };

        Dictionary<string, ClientBrowser> clientBrowsers = GetActiveBrowserSessions();
        clientBrowsers.Add(Session.SessionID, clientBrowser);
    }

    void Session_End(object sender, EventArgs e)
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.
        Dictionary<string, ClientBrowser> clientBrowsers = GetActiveBrowserSessions();
        clientBrowsers.Remove(Session.SessionID);
    }

    private Dictionary<string, ClientBrowser> GetActiveBrowserSessions()
    {
        return (Dictionary<string, ClientBrowser>)Application.Get(ActiveBrowserSessionsKey);
    }        
</script>
