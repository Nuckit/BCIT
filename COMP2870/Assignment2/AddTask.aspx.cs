using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddTask : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var repository = TaskRepository.Instance;
            DropDownListCategories.DataSource = repository.GetCategories();
            DropDownListCategories.DataTextField = "Value";
            DropDownListCategories.DataValueField = "Key";
            DropDownListCategories.DataBind();

            CalendarStartTime.SelectedDate = CalendarStartTime.TodaysDate;
            CalendarDueDate.SelectedDate = CalendarDueDate.TodaysDate;
        }

        LabelResults.Text = string.Empty;
    }

    protected void ButtonAddTask_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            var task = new Task
            {
                Name = TextBoxName.Text,
                CategoryId = Convert.ToInt32(DropDownListCategories.SelectedValue),
                StartDate = CalendarStartTime.SelectedDate,
                DueDate = CalendarDueDate.SelectedDate,
                Completed = CheckBoxIsCompleted.Checked,
                Priority = Convert.ToInt32(TextBoxPriority.Text),
                PercentComplete = Convert.ToInt16(TextBoxPercentComplete.Text)
            };

            var validator = new TaskValidator();

            if (validator.Validate(task))
            {
                var repository = TaskRepository.Instance;
                repository.AddTask(task);
                LabelResults.Text = "Successfully added task";
                BulletedListErrorMessages.Items.Clear();
            }
            else
            {
                BulletedListErrorMessages.DataSource = validator.ErrorMessages;
                BulletedListErrorMessages.DataBind();
            }
        }
    }
}