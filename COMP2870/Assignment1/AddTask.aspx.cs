using System;
using System.Web.UI;

public partial class AddTask : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownListCategories.DataSource = Application.Get("Categories");
            DropDownListCategories.DataBind();
            DropDownListCategories.Items.Insert(0, "Select");
        }
    }
    protected void ButtonAddTask_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            Task task = new Task(TextBoxName.Text)
            {                
                Category = DropDownListCategories.SelectedValue,
                TaskStatus = CheckBoxIsCompleted.Checked ? Task.Status.Completed : Task.Status.Pending
            };

            try
            {
                TaskList taskList = Session[typeof(TaskList).Name] as TaskList;
                taskList.AddTask(task);
                LabelAddResults.Text = string.Format("Successfully added Task [{0}]", task);
            }
            catch (Exception ex)
            {
                LabelAddResults.Text = ex.Message;
            }
        }
    }
}