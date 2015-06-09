<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddTask.aspx.cs" Inherits="AddTask" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h3>Add a new task</h3>
    <div>
        Name<br />
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" ControlToValidate="TextBoxName" runat="server" ErrorMessage="Name must not be empty">*</asp:RequiredFieldValidator>
        <br/>
        <br/>
        Category<br/>    
        <asp:DropDownList ID="DropDownListCategories" runat="server">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCategory" ControlToValidate="DropDownListCategories" InitialValue="Select" runat="server" ErrorMessage="Category must be selected">*</asp:RequiredFieldValidator>
        <br/>
        <br/>
        Completed
        <asp:CheckBox ID="CheckBoxIsCompleted" runat="server" />
        <br />
        <br />
        <asp:Button ID="ButtonAddTask" runat="server" Text="Add Task" OnClick="ButtonAddTask_Click" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLinkBack" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>
    </div>        
        <asp:ValidationSummary ID="ValidationSummary" runat="server" />
        <asp:Label ID="LabelAddResults" runat="server"></asp:Label>
    </form>
</body>
</html>
