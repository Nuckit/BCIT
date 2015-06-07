using System;
using System.Web.UI;

public partial class ProductsByCategory : Page
{
    private static readonly Repository Repository = new Repository();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownListCategories.DataSource = Repository.GetCategories();
            DropDownListCategories.DataValueField = "Name";
            DropDownListCategories.DataBind();
            UpdateGridViewProducts();
        }
    }
    protected void DropDownListCategories_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateGridViewProducts();
    }

    private void UpdateGridViewProducts()
    {
        string category = DropDownListCategories.SelectedValue;
        GridViewProducts.DataSource = Repository.GetProductsByCategory(category);
        GridViewProducts.DataBind();
    }
}