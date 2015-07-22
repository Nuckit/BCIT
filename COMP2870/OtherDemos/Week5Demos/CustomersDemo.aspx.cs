using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomersDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var rep = new NWindRepository();
        gvCustomers.DataSource = rep.GetCustomers();
        gvCustomers.DataBind();
    }
}