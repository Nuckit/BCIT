using System;
using System.Web.UI;

public partial class CompletedTasks : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TaskList taskList = Session[typeof(TaskList).Name] as TaskList;

        foreach (var task in taskList.GetCompletedTasks())
        {
            BulletedListTasks.Items.Add(string.Format("Name: {0}, Category: {1}", task.Name, task.Category));
        }
    }
}