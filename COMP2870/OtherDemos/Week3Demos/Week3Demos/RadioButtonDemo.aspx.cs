using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RadioButtonDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {        
        string msg = "You will be served ";
        if (rbChinese.Checked)
            msg += "Chinese food";
        else if (rbFrench.Checked)
            msg += "French food";
        else if (rbItalian.Checked)
            msg += "Italian Food";

        lblMsg.Text = msg;


        lblMsg2.Text = rblCountries.SelectedValue;

    }
}