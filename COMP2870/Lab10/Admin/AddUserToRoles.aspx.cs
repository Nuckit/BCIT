using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddUserToRoles : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string user = Request["User"];

        if (user != null)
        {
            Label1.Text = Request["User"];
            Button1.Enabled = true;

            if (!IsPostBack)
            {
                DropDownList1.DataSource = Roles.GetAllRoles();
                DropDownList1.DataBind();
            }
        }
        else
        {
            Label1.Text = "{No user selected}";
            Button1.Enabled = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string user = Label1.Text;
            string role = DropDownList1.SelectedValue;
            Roles.AddUserToRole(user, role);
            LabelResults.Text = string.Format("Added user {0} to role {1}", user, role);
        }
        catch (Exception ex)
        {
            LabelResults.Text = ex.Message;
        }
    }
}