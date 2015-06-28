using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddCategory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopulateBulletedListCategories();        
        }
    }
    protected void ButtonAddCategory_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            var repository = TaskRepository.Instance;
            repository.AddCategory(TextBoxAddCategory.Text);
            PopulateBulletedListCategories();
        }
    }

    private void PopulateBulletedListCategories()
    {
        var repository = TaskRepository.Instance;
        BulletedListCategories.DataSource = repository.GetCategories();
        BulletedListCategories.DataValueField = "Value";
        BulletedListCategories.DataBind();   
    }
}