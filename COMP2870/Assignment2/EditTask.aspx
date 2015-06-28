<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditTask.aspx.cs" Inherits="EditTask" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Edit Task</h3>
    Name<br />
        <asp:TextBox ID="TextBoxName" runat="server" Enabled="False"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" ControlToValidate="TextBoxName" runat="server" ErrorMessage="Name must not be empty">*</asp:RequiredFieldValidator>
        <br/>
        <br/>
        Category<br/>    
        <asp:DropDownList ID="DropDownListCategories" runat="server">
        </asp:DropDownList>       
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                Start Date<br/>
                <asp:TextBox ID="TextBoxStartDate" runat="server" Enabled="False"></asp:TextBox>
                <br />
                <asp:Calendar ID="CalendarStartTime" runat="server" OnSelectionChanged="CalendarStartTime_SelectionChanged"></asp:Calendar>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                Due Date<br />
                <asp:TextBox ID="TextBoxDueDate" runat="server" Enabled="False"></asp:TextBox>
                <asp:Calendar ID="CalendarDueDate" runat="server" OnSelectionChanged="CalendarDueDate_SelectionChanged"></asp:Calendar>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
            <ContentTemplate>
                Completed
                <asp:CheckBox ID="CheckBoxIsCompleted" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBoxIsCompleted_CheckedChanged" />
        <br />
        <br />
                Priority<br />
                <asp:TextBox ID="TextBoxPriority" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPriority" runat="server" ControlToValidate="TextBoxPriority" ErrorMessage="Priority is required">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidatorPriority" runat="server" ControlToValidate="TextBoxPriority" ErrorMessage="Priority must be an integer between 1 and 3" MaximumValue="3" MinimumValue="1" Type="Integer">*</asp:RangeValidator>
        <br />
        <br />
                Percent Complete<br />
                <asp:TextBox ID="TextBoxPercentComplete" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPercentComplete" runat="server" ControlToValidate="TextBoxPercentComplete" ErrorMessage="Percent complete is required">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidatorPercentComplete" runat="server" ControlToValidate="TextBoxPercentComplete" ErrorMessage="Percent must be an integer value between 0 and 100" MaximumValue="100" MinimumValue="0" Type="Integer">*</asp:RangeValidator>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br/>
        <br />
        <asp:Button ID="ButtonEditTask" runat="server" Text="Edit Task" OnClick="ButtonEditTask_Click" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLinkBack" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>
    </div>        
        <asp:ValidationSummary ID="ValidationSummary" runat="server" />
        <asp:Label ID="LabelResults" runat="server"></asp:Label>
        <asp:BulletedList ID="BulletedListErrorMessages" runat="server">
        </asp:BulletedList>

    </form>
</body>
</html>
