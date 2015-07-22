<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TextboxDemo.aspx.cs" Inherits="TextboxDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        Password:
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
        <p>
            Multiline Textbox:<asp:TextBox ID="TextBox2" runat="server" Columns="60" Rows="4" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
    </form>
</body>
</html>
