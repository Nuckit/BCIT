using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListViewDemos_ListViewDemo5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //List<string> photos = new List<string>();
            //for (int i = 1; i <= 8; i++)
            //    photos.Add(string.Format("~/images/{0}.jpg", i));
            //lvPhotos.DataSource = photos;
            var dir = Directory.GetFiles(Server.MapPath("~/images"));
            var photoQuery = from p in dir
                             select string.Format("~/images/{0}", Path.GetFileName(p));

            lvPhotos.DataSource = photoQuery;
            lvPhotos.DataBind();
        }
    }
}