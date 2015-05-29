using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string flowerType = DropDownListFlowers.SelectedValue;
        string address = TextBoxAddress.Text;
        string email = TextBoxEmail.Text;
        string title = RadioButtonListTitles.SelectedValue;
        string recipientName = TextBoxRecipientName.Text;
        bool areFlowersWrapped = CheckBoxWrapFlowers.Checked;


    }
}