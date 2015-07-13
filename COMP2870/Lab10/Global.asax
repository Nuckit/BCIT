<%@ Application Language="C#" %>

<script runat="server">

    private const string Administrators = "Administrators";
    private const string DefaultAdminUser = "admin";
    private const string DefaultAdminPassword = "abc!123";    

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        if (!Roles.RoleExists(Administrators))
        {
            Roles.CreateRole(Administrators);
        }
        
        if (Membership.GetUser(DefaultAdminUser) == null)
        {
            Membership.CreateUser(DefaultAdminUser, DefaultAdminPassword);
        }
        
        if (!Roles.IsUserInRole(DefaultAdminUser, Administrators))
        {
            Roles.AddUserToRole(DefaultAdminUser, Administrators);
        }

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

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
