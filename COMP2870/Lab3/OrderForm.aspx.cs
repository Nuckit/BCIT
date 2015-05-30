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
        Order order = Session[global_asax.OrderKey] as Order;
        if (order != null)
        {
            DropDownListFlowers.SelectedValue = order.FlowerType;
            TextBoxAddress.Text = order.Address;
            TextBoxEmail.Text = order.Email;
            RadioButtonListTitles.SelectedValue = order.Title;
            TextBoxRecipientName.Text = order.RecipientName;
            CheckBoxWrapFlowers.Checked = order.AreFlowersWrapped;
        }
        else
        {
            RadioButtonListTitles.SelectedIndex = 0;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (IsValid)
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

            Session.Add(global_asax.OrderKey, order);

            Response.Redirect("OrderConfirmation.aspx");   
        }     
    }
}