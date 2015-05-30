using ASP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderConfirmation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Order order = Session[global_asax.OrderKey] as Order;
        LabelFlowerType.Text = string.Format("Flower Type: {0}", order.FlowerType);
        LabelAddress.Text = string.Format("Address: {0}", order.Address);
        LabelEmail.Text = string.Format("Email: {0}", order.Email);
        LabelTitle.Text = string.Format("Title: {0}", order.Title);
        LabelRecipientName.Text = string.Format("Recipient Name: {0}", order.RecipientName);
        LabelFlowersWrapped.Text = string.Format("Flowers are wrapped: {0}", order.AreFlowersWrapped ? "Yes" : "No");
    }
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        Session.Remove(global_asax.OrderKey);
        Response.Redirect("OrderForm.aspx");
    }
}