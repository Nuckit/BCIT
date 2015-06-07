<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddCategory.aspx.cs" Inherits="AddCategory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Category Name:
        <asp:TextBox ID="TextBoxCategoryName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCategoryName" ControlToValidate="TextBoxCategoryName" runat="server" ErrorMessage="Category name must not be empty">*</asp:RequiredFieldValidator>
        <br />
        Description:
        <asp:TextBox ID="TextBoxDescription" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorDescription" runat="server" ControlToValidate="TextBoxDescription" ErrorMessage="Description must not be empty">*</asp:RequiredFieldValidator>
        <p>
            <asp:Button ID="ButtonAddCategory" runat="server" OnClick="ButtonAddCategory_Click" Text="Add Category" />
        </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <asp:Label ID="LabelAddResults" runat="server"></asp:Label>
    </form>
</body>
</html>
