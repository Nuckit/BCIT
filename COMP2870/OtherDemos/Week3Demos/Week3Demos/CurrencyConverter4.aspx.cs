﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CurrencyConverter4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string amount = tbAmount.Text;
        decimal convertedValue = Convert.ToDecimal(amount) * 1.10m;
        lblMessage.Text = "Converted value : " + convertedValue;

    }
}