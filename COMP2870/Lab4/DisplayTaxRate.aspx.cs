﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DisplayTaxRate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LabelTaxRate.Text = string.Format("Tax rate: {0}", ConfigurationManager.AppSettings["TaxRate"]);
    }
}