using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AJAX_AJAXDemo1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Demonstrate Full Page Life cycle
        //Label2.Text = "Full Page Life Cycle " + DateTime.Now.ToString();        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "Current time is " + DateTime.Now.ToLongTimeString();
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = "Selected Date is " + Calendar1.SelectedDate;
    }
}
