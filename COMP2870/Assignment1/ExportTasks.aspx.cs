using System;
using System.Web.UI;

public partial class ExportTasks : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonExportTasks_Click(object sender, EventArgs e)
    {
        TaskList taskList = Session[typeof(TaskList).Name] as TaskList;
        string xmlPath = Server.MapPath("Tasks.xml");
        taskList.WriteToXml(xmlPath);
        Response.ContentType = "application/xml";
        Response.WriteFile(xmlPath);
        Response.End();
    }
}