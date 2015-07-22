using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DropDownListDemo3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ddlCreditCard_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblMsg.Text = "You will pay with " + ddlCreditCard.SelectedValue;
    }
}