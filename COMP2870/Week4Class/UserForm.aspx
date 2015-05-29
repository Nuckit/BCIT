<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserForm.aspx.cs" Inherits="UserForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Name:
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorName" ControlToValidate="TextBoxName" ValidationExpression="\w+" runat="server" ErrorMessage="Name must only contain alphanumeric characters">*</asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" ControlToValidate="TextBoxName" runat="server" ErrorMessage="Name cannot be empty">*</asp:RequiredFieldValidator>
        <br />
    
    </div>
        Age:
        <asp:TextBox ID="TextBoxAge" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidatorAge" runat="server" ControlToValidate="TextBoxAge" MinimumValue="18" MaximumValue="65" ErrorMessage="Age must be between 18 and 65">*</asp:RangeValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorAge" ControlToValidate="TextBoxAge" runat="server" ErrorMessage="Age cannot be empty">*</asp:RequiredFieldValidator>
        <br />
        <br />
        Email:
        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Email must be valid" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" ControlToValidate="TextBoxEmail" runat="server" ErrorMessage="Email cannot be empty">*</asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
        <br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary" runat="server" />
        <br />
        <asp:Label ID="LabelStatus" runat="server"></asp:Label>
    </form>
</body>
</html>
