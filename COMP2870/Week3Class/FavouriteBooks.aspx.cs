using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP;

public partial class FavouriteBooks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string book = TextBoxBook.Text;

        if (!string.IsNullOrEmpty(book))
        {
            List<string> books = Session[global_asax.BooksCollectionKey] as List<string>;

            if (books != null)
            {
                books.Add(book);
                LabelAddedMessage.Text = string.Format("Added new favourite book '{0}'", book);
            }
        }
    }
    protected void ButtonViewAll_Click(object sender, EventArgs e)
    {
        Response.Redirect("DisplayFavourites.aspx");
    }
}