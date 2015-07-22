<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddCategory.aspx.cs" Inherits="AddCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderTitle" Runat="Server">
        <h3>Add a Task Category</h3>    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
            <p>Current Categories</p>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:BulletedList ID="BulletedListCategories" runat="server">
            </asp:BulletedList>
                    <asp:TextBox ID="TextBoxAddCategory" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBoxAddCategory" runat="server" ErrorMessage="Category cannot be empty">*</asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Add New Category" OnClick="ButtonAddCategory_Click" />
        <br />
        </ContentTemplate>
            </asp:UpdatePanel> 
  <br/>

        <br/>
        <asp:HyperLink ID="HyperLink1" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>
        <asp:ValidationSummary ID="ValidationSummary2" runat="server" />
</asp:Content>
