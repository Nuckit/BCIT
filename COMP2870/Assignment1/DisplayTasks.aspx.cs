using System;
using System.Web.UI;

public partial class DisplayTasks : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TaskList taskList = Session[typeof(TaskList).Name] as TaskList;
        BulletedListTasks.DataSource = taskList.GetTasks();
        BulletedListTasks.DataBind();
    }
}