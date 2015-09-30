﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PendingTasks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var repository = TaskRepository.Instance;
        GridViewTasks.DataSource = repository.GetPendingTasks().Where(task => task.UserName == User.Identity.Name);        
        GridViewTasks.DataBind();        
    }
}