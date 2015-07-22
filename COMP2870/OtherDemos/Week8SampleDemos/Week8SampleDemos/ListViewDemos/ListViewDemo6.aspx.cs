using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListViewDemos_ListViewDemo6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var dir = Directory.GetFiles(Server.MapPath("~/images"));
        var photoQuery = from p in dir
                         select string.Format("~/images/{0}", Path.GetFileName(p));

        lvPhotos.DataSource = photoQuery;
        lvPhotos.DataBind();
    }
}