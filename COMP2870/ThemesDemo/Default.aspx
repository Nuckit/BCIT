<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Theme="Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label Text="Sample Text" runat="server" />
        <br />
         <asp:Label Text="Try to override Foreground color" ForeColor="Blue" runat="server" />
      <br />
         <asp:Label Text="Red Label" SkinID="Red" runat="server" />
        <br />
        <asp:Label Text="I don't want a green label" EnableTheming="false" runat="server" />

        <h1>This header gets its color from the Demo theme</h1>
        <asp:Label Text="The color comes from the cssClass blueLabel" SkinID="Blue" runat="server" />
    </div>
    </form>
</body>
</html>
