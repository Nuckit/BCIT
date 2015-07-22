<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LoginUserControl.ascx.cs" Inherits="LoginUserControl" %>
<asp:LoginView ID="LoginView" runat="server">
    <AnonymousTemplate>

        Please Login
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
    </AnonymousTemplate>
    <LoggedInTemplate>  
        <asp:LoginName ID="LoginName1" runat="server" FormatString="User: {0}" /><br/>
        <asp:Label ID="LabelTime" runat="server" Text='<%# DateTime.Now %>'></asp:Label> 
        <br/>
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
    </LoggedInTemplate>
</asp:LoginView>

