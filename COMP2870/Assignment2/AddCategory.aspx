<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddCategory.aspx.cs" Inherits="AddCategory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Add a Task Category</h3>
        <p>Current Categories</p>
        <asp:BulletedList ID="BulletedListCategories" runat="server">
        </asp:BulletedList>
    </div>
        <asp:TextBox ID="TextBoxAddCategory" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator" ControlToValidate="TextBoxAddCategory" runat="server" ErrorMessage="Category cannot be empty">*</asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="ButtonAddCategory" runat="server" Text="Add New Category" OnClick="ButtonAddCategory_Click" />
        <br />
        <br/>
        <asp:HyperLink ID="HyperLinkBack" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>

</body>
</html>
