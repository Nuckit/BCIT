using System;
using System.Web.UI;

public partial class DisplayTasks : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var repository = TaskRepository.Instance;
        GridViewTasks.DataSource = repository.GetTasks();
        GridViewTasks.DataBind();
    }
}