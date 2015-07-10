using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LabelName.Text = "User: " + User.Identity.Name;
        LabelInfo.Text = "Auth type: " + User.Identity.AuthenticationType;
    }
}