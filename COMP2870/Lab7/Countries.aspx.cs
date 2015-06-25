using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Countries : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void OnDatabaseUpdate(object sender, DetailsViewDeletedEventArgs e)
    {
        GridView1.DataBind();
    }
    protected void OnDatabaseUpdate(object sender, DetailsViewInsertedEventArgs e)
    {
        GridView1.DataBind();
    }
    protected void OnDatabaseUpdate(object sender, DetailsViewUpdatedEventArgs e)
    {
        GridView1.DataBind();
    }
}