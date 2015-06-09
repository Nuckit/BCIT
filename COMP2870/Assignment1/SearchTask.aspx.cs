using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

public partial class SearchTask : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            TaskList taskList = Session[typeof(TaskList).Name] as TaskList;
            List<Task> pendingTasks = taskList.GetPendingTasks();

            if (pendingTasks.Any())
            {
                DropDownListTasks.DataSource = taskList.GetPendingTasks();
                DropDownListTasks.DataValueField = "Name";
                DropDownListTasks.DataBind();
                DropDownListTasks.Items.Insert(0, "Select");
            }
            else
            {
                LabelNoPendingTasks.Text = "No pending tasks are available for editing";
            }
        }        
    }
    protected void DropDownListTasks_SelectedIndexChanged(object sender, EventArgs e)
    {        
        Response.Redirect(string.Format("EditTask.aspx?Task={0}", DropDownListTasks.SelectedValue));
    }
}