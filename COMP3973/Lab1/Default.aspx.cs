using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private static readonly Repository Repository = Repository.Instance;

    protected void Page_Load(object sender, EventArgs e)
    {
        RefreshRegions();
    }

    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        string regionDescription = TextBoxAdd.Text;
        int regionId = Repository.AddRegion(regionDescription);
        LabelResults.Text = string.Format("Successfully added region '{0}' with ID '{1}'", regionId, regionDescription);
    }

    protected void ButtonEdit_Click(object sender, EventArgs e)
    {
        int regionId = Convert.ToInt32(TextBoxEditId.Text);
        string regionDescription = TextBoxEditRegion.Text;
        Repository.UpdateRegion(regionId, regionDescription);
        LabelResults.Text = string.Format("Successfully updated region ID '{0}' to description '{1}'", regionId, regionDescription);
    }

    protected void ButtonDelete_Click(object sender, EventArgs e)
    {
        int regionId = Convert.ToInt32(TextBoxDelete.Text);
        Repository.DeleteRegion(regionId);
        LabelResults.Text = string.Format("Successfully deleted region with ID '{0}'", regionId);
    }

    protected void ButtonDisplay_Click(object sender, EventArgs e)
    {
        RefreshRegions();
    }

    private void RefreshRegions()
    {
        GridViewRegions.DataSource = Repository.GetRegions();
        GridViewRegions.DataBind();
        LabelResults.Text = string.Empty;
    }
}