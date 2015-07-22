using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

public partial class AJAX_AJAXDemo2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataBind();       
        lblTime.Text = DateTime.Now.ToLongTimeString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        lblTime.Text = DateTime.Now.ToLongTimeString();
    }
}
