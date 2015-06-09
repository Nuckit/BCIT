using System;
using System.Web.UI;

public partial class PendingTasks : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TaskList taskList = Session[typeof(TaskList).Name] as TaskList;

        foreach (var task in taskList.GetPendingTasks())
        {
            BulletedListTasks.Items.Add(string.Format("Name: {0}, Category: {1}", task.Name, task.Category));
        }
    }
}