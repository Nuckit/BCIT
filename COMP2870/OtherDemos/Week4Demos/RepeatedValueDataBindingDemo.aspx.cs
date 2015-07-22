using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RepeatedValueDataBindingDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //foreach (Product p in Product.GetSampleProducts())
        //    ddlProducts.Items.Add(p.ToString());
        ddlProducts.DataSource = Product.GetSampleProducts();
        ddlProducts.DataBind();
    }
}