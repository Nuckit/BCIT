<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Regions</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3>Regions</h3></div>
        
        Add Region <asp:TextBox ID="TextBoxAdd" runat="server"></asp:TextBox><asp:Button ID="ButtonAdd" runat="server" Text="Add" OnClick="ButtonAdd_Click" /><br/>
        Edit Region. Id: <asp:TextBox ID="TextBoxEditId" runat="server"></asp:TextBox> Name: <asp:TextBox ID="TextBoxEditRegion" runat="server"></asp:TextBox><asp:Button ID="ButtonEdit" runat="server" Text="Edit" OnClick="ButtonEdit_Click" /><br/>
        Delete Region. Id: <asp:TextBox ID="TextBoxDelete" runat="server"></asp:TextBox><asp:Button ID="ButtonDelete" runat="server" Text="Delete" OnClick="ButtonDelete_Click" /><br/>
        <asp:Button ID="ButtonDisplay" runat="server" Text="Display/Refresh" OnClick="ButtonDisplay_Click" /><br/>
        <asp:Label ID="LabelResults" runat="server"></asp:Label>

        <asp:GridView ID="GridViewRegions" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
