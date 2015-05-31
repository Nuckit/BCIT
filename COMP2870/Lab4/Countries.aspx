<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Countries.aspx.cs" Inherits="Countries" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Countries</h3>
        <p>
            <asp:Label ID="LabelCountryName" runat="server" Text="Country Name: "></asp:Label>
            <asp:TextBox ID="TextBoxCountryName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="LabelPopulation" runat="server" Text="Population: "></asp:Label>
            <asp:TextBox ID="TextBoxPopulation" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="LabelCapital" runat="server" Text="Capital City: "></asp:Label>
            <asp:TextBox ID="TextBoxCapitalCity" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ButtonAddCountry" runat="server" OnClick="ButtonAddCountry_Click" Text="Add Country" />
        </p>
        <p>
            <asp:Button ID="ButtonCreateXml" runat="server" OnClick="ButtonCreateXml_Click" Text="Create XML" />
        </p>
    </div>
        <asp:Xml ID="XmlCountriesView" runat="server"></asp:Xml>
    </form>
</body>
</html>
