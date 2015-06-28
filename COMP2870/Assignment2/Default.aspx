<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<h1>Ricky's ToDo List</h1>
    <hr/>
    <h4>This is a simple web site that keeps track of your tasks.</h4>    
    <form id="form1" runat="server">
    <div>    
        <asp:HyperLink ID="HyperLink1" NavigateUrl="DisplayTasks.aspx" runat="server">List your tasks</asp:HyperLink>    
        <br />
        <asp:HyperLink ID="HyperLink2" NavigateUrl="AddTask.aspx" runat="server">Add a new task</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink3" NavigateUrl="PendingTasks.aspx" runat="server">Show your pending tasks</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink4" NavigateUrl="CompletedTasks.aspx" runat="server">Show your completed tasks</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink5" NavigateUrl="ExportTask.aspx" runat="server">Export tasks to an XML file</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink6" NavigateUrl="TasksByCategory.aspx" runat="server">View tasks by category</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink7" NavigateUrl="AddCategory.aspx" runat="server">Add a task category</asp:HyperLink>
    </div>

    </form>
</body>
</html>
