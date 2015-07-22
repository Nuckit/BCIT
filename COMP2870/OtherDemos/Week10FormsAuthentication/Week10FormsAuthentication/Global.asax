<%@ Application Language="C#" %>

<script runat="server">


    static string ADMINISTRATORS = "Administrators";
    
    void Application_Start(object sender, EventArgs e) 
    {
        ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        
        var user = Membership.GetUser("jdoe");
        if (user == null)
            Membership.CreateUser("jdoe", "abc!123", "jdoe@me.com");

        if (!Roles.RoleExists(ADMINISTRATORS))
            Roles.CreateRole(ADMINISTRATORS);

        if (Membership.GetUser("admin") == null)
        {
            Membership.CreateUser("admin", "abc!123", "admin@me.com");
            Roles.AddUserToRole("admin", ADMINISTRATORS);
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
