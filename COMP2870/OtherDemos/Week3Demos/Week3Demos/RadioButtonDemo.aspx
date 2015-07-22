<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RadioButtonDemo.aspx.cs" Inherits="RadioButtonDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Select your meal preference:
        
    </div>
        <asp:RadioButton GroupName="MealPref" ID="rbItalian" runat="server" Text="Italian" />
        <asp:RadioButton GroupName="MealPref" ID="rbFrench" runat="server" Text="French" />
        <asp:RadioButton GroupName="MealPref" ID="rbChinese" runat="server" Text="Chinese" />
        <p>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </p>
        <asp:Label ID="lblMsg" runat="server"></asp:Label>

      
        <asp:radiobuttonlist runat="server" ID="rblCountries">
         <asp:ListItem Text="Canadian"></asp:ListItem>
         <asp:ListItem Text="Mexican"></asp:ListItem>
        </asp:radiobuttonlist>

          <asp:Label Text="" ID="lblMsg2" runat="server" />
    </form>
</body>
</html>

