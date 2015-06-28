using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TasksByCategory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var repository = TaskRepository.Instance;
            DropDownListCategories.DataSource = repository.GetCategories();
            DropDownListCategories.DataValueField = "Value";            
            DropDownListCategories.DataBind();
            GridViewTasks.DataSource = repository.GetTasksByCategory(DropDownListCategories.SelectedValue);
            GridViewTasks.DataBind();
        }
    }
    protected void DropDownListCategories_SelectedIndexChanged(object sender, EventArgs e)
    {
        var repository = TaskRepository.Instance;
        GridViewTasks.DataSource = repository.GetTasksByCategory(DropDownListCategories.SelectedValue);
        GridViewTasks.DataBind();
    }
}