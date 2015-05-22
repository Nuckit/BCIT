using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP;

public partial class DisplayFavourites : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<string> books = Session[global_asax.BooksCollectionKey] as List<string>;

        foreach (string book in books)
        {
            BulletedListAllBooks.Items.Add(book);
        }
    }
    protected void ButtonBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("FavouriteBooks.aspx");
    }
}