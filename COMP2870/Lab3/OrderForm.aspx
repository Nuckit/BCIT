<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderForm.aspx.cs" Inherits="OrderForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Form</title>
</head>
<body>
<h3>Order Form</h3>
    <form id="form1" runat="server">
    <div>
    
        Flower:
        <asp:DropDownList ID="DropDownListFlowers" runat="server">
            <asp:ListItem>Roses</asp:ListItem>
            <asp:ListItem>Orchids</asp:ListItem>
            <asp:ListItem>Violets</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Address: <asp:TextBox ID="TextBoxAddress" runat="server" Rows="3" TextMode="MultiLine"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress" runat="server" ControlToValidate="TextBoxAddress" ErrorMessage="Address cannot be empty">*</asp:RequiredFieldValidator>
        <br />
        <br />
        Email:
        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Email cannot be empty">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Email must be valid" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
    </div>
        <p>
            Title: <asp:RadioButtonList ID="RadioButtonListTitles" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Mr.</asp:ListItem>
                <asp:ListItem>Ms.</asp:ListItem>
                <asp:ListItem>Mrs.</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <p>
            Recipient Name:
            <asp:TextBox ID="TextBoxRecipientName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorRecipientName" runat="server" ControlToValidate="TextBoxRecipientName" ErrorMessage="Recipient name must not be empty">*</asp:RequiredFieldValidator>
        </p>
        <p>
            Wrap flowers?
            <asp:CheckBox ID="CheckBoxWrapFlowers" runat="server" />
        </p>
        <p>
            <asp:Button ID="ButtonSubmitOrder" runat="server" OnClick="Button1_Click" Text="Submit Order" />
        </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
