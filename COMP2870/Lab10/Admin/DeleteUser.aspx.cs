using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_DeleteUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string user = Request["User"];

        if (user != null)
        {
            LabelUser.Text = Request["User"];
            Button1.Enabled = true;
        }
        else
        {
            LabelUser.Text = "{No user selected}";
            Button1.Enabled = false;
        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string user = LabelUser.Text;
            if (user == User.Identity.Name)
            {
                throw new Exception("Cannot delete yourself");
            }
            Membership.DeleteUser(user);
            LabelResults.Text = "Successfully deleted user " + user;
        }
        catch (Exception ex)
        {
            LabelResults.Text = ex.Message;
        }
    }
}