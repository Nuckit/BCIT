using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddRole : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            string role = TextBox1.Text;
            try
            {
                Roles.CreateRole(role);
                Label1.Text = "Added role " + role;
            }
            catch (Exception ex)
            {
                Label1.Text = "Error: " + ex.Message;
            }
            
        }
    }
}