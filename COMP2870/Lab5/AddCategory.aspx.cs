using System;
using System.Web.UI;

public partial class AddCategory : Page
{
    private static readonly Repository Repository = new Repository();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonAddCategory_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            Category category = new Category
            {
                Name = TextBoxCategoryName.Text,
                Description = TextBoxDescription.Text
            };

            Repository.AddCategory(category);
            LabelAddResults.Text = "Added category " + category.Name;
        }
    }
}