using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

public partial class AJAX_PlainAJAX : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmitPostback_Click(object sender, EventArgs e)
    {
        Thread.Sleep(2000);//Simulate a long running operation
        Label1.Text = string.Format("(PostBack) Time is : {0}", DateTime.Now.ToLongTimeString());
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lblMessage.Text = string.Format("(PostBack) Time is : {0}", DateTime.Now.ToLongTimeString());
    }

}
