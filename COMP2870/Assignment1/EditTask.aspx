<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditTask.aspx.cs" Inherits="EditTask" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h3>Edit task</h3>
    <form id="form1" runat="server">
        Name<br />
        <asp:TextBox ID="TextBoxName" runat="server" ReadOnly="True"></asp:TextBox>
        &nbsp;<asp:Label ID="LabelCannotFindTask" runat="server" ForeColor="#FF3300"></asp:Label>
        <br/>
        <br/>
        Category<br/>    
        <asp:DropDownList ID="DropDownListCategories" runat="server">
        </asp:DropDownList>
        <br/>
        <br/>
        Completed
        <asp:CheckBox ID="CheckBoxIsCompleted" runat="server" />
        <br />
        <br />
        <asp:Button ID="ButtonEditTask" runat="server" Text="Submit" OnClick="ButtonEditTask_Click"/>
        <br />
        <br />
        <asp:HyperLink ID="HyperLinkBack" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>
    </div>        
        <br />
        <br />
        <asp:Label ID="LabelAddResults" runat="server"></asp:Label>
    </form>
</body>
</html>
