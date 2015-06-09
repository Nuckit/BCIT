using System;
using System.Web.UI;

public partial class EditTask : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string taskName = Request.QueryString["Task"];
        TaskList taskList = Session[typeof(TaskList).Name] as TaskList;
        Task task = taskList.GetTask(taskName);

        if (task == null)
        {
            LabelCannotFindTask.Text = string.Format("Cannot find task with name '{0}'", taskName);
            ButtonEditTask.Enabled = false;
        }
        else
        {
            TextBoxName.Text = taskName;
            
            if (!IsPostBack)
            {
                DropDownListCategories.DataSource = Application["Categories"];
                DropDownListCategories.DataBind();
                DropDownListCategories.SelectedValue = task.Category;
                bool isTaskCompleted = task.TaskStatus == Task.Status.Completed;
                CheckBoxIsCompleted.Checked = isTaskCompleted;
                ButtonEditTask.Enabled = !isTaskCompleted;
            }            
        }
    }
    protected void ButtonEditTask_Click(object sender, EventArgs e)
    {
        try
        {
            // Need to retrieve the task again in case there are multiple tabs open on the browser.
            // This ensures that the task actually still exists and was not already edited to 'completed' status.
            TaskList taskList = Session[typeof(TaskList).Name] as TaskList;
            string taskName = TextBoxName.Text;
            Task task = taskList.GetTask(taskName);

            if (task == null || task.TaskStatus == Task.Status.Completed)
            {
                throw new Exception(string.Format("Could not edit task with name '{0}'. It does not exist or is already in the completed status", taskName));
            }

            task.Category = DropDownListCategories.SelectedValue;
            bool isTaskCompleted = CheckBoxIsCompleted.Checked;
            task.TaskStatus = isTaskCompleted ? Task.Status.Completed : Task.Status.Pending;
            ButtonEditTask.Enabled = !isTaskCompleted;
            LabelAddResults.Text = string.Format("Successfully edited task [{0}]", task);
        }
        catch (Exception ex)
        {
            LabelAddResults.Text = ex.Message;
        }
    }
}