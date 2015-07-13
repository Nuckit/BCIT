using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_RemoveUserFromRole : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string user = Request["User"];

        if (user != null)
        {
            LabelUser.Text = user;
            Button1.Enabled = true;

            if (!IsPostBack)
            {
                DropDownList1.DataSource = Roles.GetRolesForUser(user);
                DropDownList1.DataBind();
            }
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
            string role = DropDownList1.SelectedValue;
            Roles.RemoveUserFromRole(user, role);
            LabelResults.Text = string.Format("Removed user {0} from role {1}", user, role);
        }
        catch (Exception ex)
        {
            LabelResults.Text = ex.Message;
        }
    }
}