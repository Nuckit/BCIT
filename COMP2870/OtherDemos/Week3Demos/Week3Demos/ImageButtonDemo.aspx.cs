using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ImageButtonDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        //Redirect to images of puppies....
        Response.Redirect("https://www.google.ca/search?q=puppies&espv=2&biw=1024&bih=599&source=lnms&tbm=isch&sa=X&ei=7pheVbHEIIuZoQThjYCQBQ&ved=0CAYQ_AUoAQ");
    }
}