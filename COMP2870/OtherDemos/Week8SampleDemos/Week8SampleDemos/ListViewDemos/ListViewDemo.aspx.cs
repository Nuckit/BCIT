using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListViewDemos_ListViewDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ListView1.DataSource = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            ListView1.DataBind();
        }
    }
}