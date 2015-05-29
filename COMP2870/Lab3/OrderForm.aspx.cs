using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP;

public partial class OrderForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Order order = new Order
        {
            FlowerType = DropDownListFlowers.SelectedValue,
            Address = TextBoxAddress.Text,
            Email = TextBoxEmail.Text,
            Title = RadioButtonListTitles.SelectedValue,
            RecipientName = TextBoxRecipientName.Text,
            AreFlowersWrapped = CheckBoxWrapFlowers.Checked
        };

        Application.Lock();
        Session.Add(global_asax.OrderKey, order);
        Application.UnLock();

        Response.Redirect("OrderConfirmation.aspx");
    }
}