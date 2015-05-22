using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CurrencyConverter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnConvert_Click(object sender, EventArgs e)
    {
        string currency = TextBoxCurrencyCad.Text;
        LabelCurrencyUsd.Text = string.Format(" {0} USD", Convert.ToDouble(currency) *1.2);
        
    }
}