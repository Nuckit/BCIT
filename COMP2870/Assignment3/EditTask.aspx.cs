using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditTask : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int taskId = Convert.ToInt32(Request["taskId"]);
        var repository = TaskRepository.Instance;
        Task task = repository.GetTask(taskId);

        if (task == null || task.UserName != User.Identity.Name)
        {
            LabelResults.Text = string.Format("Cannot find task with id '{0}' or this task does not belong to you", taskId);
            ButtonEditTask.Enabled = false;
        }
        else
        {
            TextBoxName.Text = task.Name;

            if (!IsPostBack)
            {
                DropDownListCategories.DataSource = repository.GetCategories();
                DropDownListCategories.DataTextField = "Value";
                DropDownListCategories.DataValueField = "Key";
                DropDownListCategories.DataBind();

                CalendarStartTime.SelectedDate = task.StartDate;                
                CalendarDueDate.SelectedDate = task.DueDate;

                DropDownListPriority.DataSource = TaskRepository.GetValidPriorities();
                DropDownListPriority.DataBind();

                TextBoxPercentComplete.Text = task.PercentComplete.ToString();

                bool isCompleted = task.Completed;
                CheckBoxIsCompleted.Checked = isCompleted;
                ButtonEditTask.Enabled = !isCompleted;
            }

            TextBoxStartDate.Text = CalendarStartTime.SelectedDate.ToLongDateString();
            TextBoxDueDate.Text = CalendarDueDate.SelectedDate.ToLongDateString();
        }

        
    }
    protected void CheckBoxIsCompleted_CheckedChanged(object sender, EventArgs e)
    {
        bool isChecked = CheckBoxIsCompleted.Checked;

        if (isChecked)
        {
            TextBoxPercentComplete.Text = "100";            
        }

        TextBoxPercentComplete.Enabled = !isChecked;

    }
    protected void ButtonEditTask_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            try
            {
                // Need to retrieve the task again in case there are multiple tabs open on the browser.
                // This ensures that the task actually still exists and was not already edited to 'completed' status.
                int taskId = Convert.ToInt32(Request["taskId"]);
                var repository = TaskRepository.Instance;
                Task task = repository.GetTask(taskId);

                if (task == null || task.Completed)
                {
                    throw new Exception(string.Format("Could not edit task with id '{0}'. It does not exist or is already in the completed status", taskId));
                }

                if (task.UserName != User.Identity.Name)
                {
                    throw new Exception("You cannot edit a task that does not belong to you!");
                }

                task.CategoryId = Convert.ToInt32(DropDownListCategories.SelectedValue);
                task.StartDate = CalendarStartTime.SelectedDate;
                task.DueDate = CalendarDueDate.SelectedDate;
                task.Completed = CheckBoxIsCompleted.Checked;
                task.Priority = Convert.ToInt32(DropDownListPriority.Text);
                task.PercentComplete = Convert.ToInt16(TextBoxPercentComplete.Text);

                var validator = new TaskValidator();

                if (validator.Validate(task))
                {
                    repository.UpdateTask(task);
                    ButtonEditTask.Enabled = !task.Completed;
                    LabelResults.Text = "Successfully edited task";
                    BulletedListErrorMessages.Items.Clear();
                }
                else
                {
                    BulletedListErrorMessages.DataSource = validator.ErrorMessages;
                    BulletedListErrorMessages.DataBind();
                }
                
            }
            catch (Exception ex)
            {
                LabelResults.Text = ex.Message;
            }
        }
    }
    protected void CalendarStartTime_SelectionChanged(object sender, EventArgs e)
    {
        TextBoxStartDate.Text = CalendarStartTime.SelectedDate.ToLongDateString();
    }
    protected void CalendarDueDate_SelectionChanged(object sender, EventArgs e)
    {
        TextBoxDueDate.Text = CalendarDueDate.SelectedDate.ToLongDateString();
    }
}