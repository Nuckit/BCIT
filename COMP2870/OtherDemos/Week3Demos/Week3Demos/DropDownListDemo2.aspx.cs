using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DropDownListDemo2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            foreach (string cc in GetCreditCardTypes())
                ddlCreditCard.Items.Add(cc);
        }
        
    }

    private List<string> GetCreditCardTypes()
    {

        return new List<string> { "VISA", "Mastercard", "American Express" };
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lblMsg.Text = "You will pay with : " + ddlCreditCard.SelectedValue;
    }
}