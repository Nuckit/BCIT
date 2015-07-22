<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TasksByCategory.aspx.cs" Inherits="TasksByCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderTitle" Runat="Server">
        <h3>Tasks By Category</h3>    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
      
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                Category <asp:DropDownList ID="DropDownListCategories" runat="server" OnSelectedIndexChanged="DropDownListCategories_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
                <br />
                <asp:GridView ID="GridViewTasks" runat="server" AutoGenerateColumns="False">
                     <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="StartDate" HeaderText="Start Date" />
                    <asp:BoundField DataField="DueDate" HeaderText="Due Date" />
                    <asp:BoundField DataField="Priority" HeaderText="Priority" />       
                    <asp:BoundField DataField="PercentComplete" HeaderText="Percent Complete" />              
                </Columns>
                </asp:GridView>
            </ContentTemplate>        
        </asp:UpdatePanel>
        <br/>
        <asp:HyperLink ID="HyperLinkBack" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>
</asp:Content>
