using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CurrencyConverter3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_ServerClick(object sender, EventArgs e)
    {
        //Get a reference to the text input
        string amount = tbAmount.Value;
        decimal calculatedValue = Convert.ToDecimal(amount) * 1.10m;
        spResult.InnerText = "Calcuated Amount : " + calculatedValue;

    }
}