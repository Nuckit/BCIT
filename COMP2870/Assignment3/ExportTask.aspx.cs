using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ExportTask : System.Web.UI.Page
{
    private string XmlPath
    {
        get { return Server.MapPath("Tasks.xml"); }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonExportTasks_Click(object sender, EventArgs e)
    {
        var repository = TaskRepository.Instance;
        DataSet tasks = repository.ExportTasks();
        tasks.WriteXml(XmlPath);
        LabelResults.Text = "Tasks successfully exported";
    }
    protected void ButtonViewXml_Click(object sender, EventArgs e)
    {
        Response.Redirect("Tasks.xml");
    }
}