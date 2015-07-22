<%@ Application Language="C#" %>

<script runat="server">
    private const string DefaultAdminUser = "instructor";
    private const string DefaultJDoeUser = "jdoe";
    private const string DefaultPassword = "abc!123";
    private const string AdminRole = "admin";
    private const string UserRole = "user";
    
    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        
        CreateUsersAndRoles();
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

    private void CreateUsersAndRoles()
    {        
        if (!Roles.RoleExists(AdminRole))
        {
            Roles.CreateRole(AdminRole);
        }

        if (!Roles.RoleExists(UserRole))
        {
            Roles.CreateRole(UserRole);
        }

        if (Membership.GetUser(DefaultAdminUser) == null)
        {
            Membership.CreateUser(DefaultAdminUser, DefaultPassword);            
        }

        if (!Roles.IsUserInRole(DefaultAdminUser, AdminRole))
        {
            Roles.AddUserToRole(DefaultAdminUser, AdminRole);
        }

        if (Membership.GetUser(DefaultJDoeUser) == null)
        {
            Membership.CreateUser(DefaultJDoeUser, DefaultPassword);
            Roles.AddUserToRole(DefaultJDoeUser, UserRole);
        }

        if (!Roles.IsUserInRole(DefaultJDoeUser, UserRole))
        {
            Roles.AddUserToRole(DefaultJDoeUser, UserRole);
        }        
    }
       
</script>
