<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddTask.aspx.cs" Inherits="AddTask" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderTitle" Runat="Server">
        <h3>Add a new task</h3>    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">

            
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    Name<br />
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" ControlToValidate="TextBoxName" runat="server" ErrorMessage="Name must not be empty">*</asp:RequiredFieldValidator>
        <br/>
        <br/>
        Category<br/>    
        <asp:DropDownList ID="DropDownListCategories" runat="server">
        </asp:DropDownList>       
        <br />
        <br />
        Start Date<br/>
        <asp:Calendar ID="CalendarStartTime" runat="server"></asp:Calendar>
        <br />
        Due Date<asp:Calendar ID="CalendarDueDate" runat="server"></asp:Calendar>
        <br/>
        Completed
        <asp:CheckBox ID="CheckBoxIsCompleted" runat="server" />
        <br />
        <br />
        Priority<br />
        <asp:DropDownList ID="DropDownListPriority" runat="server"></asp:DropDownList>
        <br />
        <br />
        Percent Complete<br />
        <asp:TextBox ID="TextBoxPercentComplete" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPercentComplete" runat="server" ControlToValidate="TextBoxPercentComplete" ErrorMessage="Percent complete is required">*</asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidatorPercentComplete" runat="server" ControlToValidate="TextBoxPercentComplete" ErrorMessage="Percent must be an integer value between 0 and 100" MaximumValue="100" MinimumValue="0" Type="Integer">*</asp:RangeValidator>
        <br />

                        <asp:BulletedList ID="BulletedListErrorMessages" runat="server">
        </asp:BulletedList>
                                </ContentTemplate>
                </asp:UpdatePanel>
               <asp:Button ID="ButtonAddTask" runat="server" Text="Add Task" OnClick="ButtonAddTask_Click" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLinkBack" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink> 
         
        <asp:ValidationSummary ID="ValidationSummary" runat="server" />
    <br/>
        <asp:Label ID="LabelResults" runat="server"></asp:Label>


</asp:Content>

