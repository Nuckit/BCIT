<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CompletedTasks.aspx.cs" Inherits="CompletedTasks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderTitle" Runat="Server">
        <h3>Completed Tasks</h3>    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
            <asp:GridView ID="GridViewTasks" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Category" HeaderText="Category" />
                    <asp:BoundField DataField="StartDate" HeaderText="Start Date" />
                    <asp:BoundField DataField="DueDate" HeaderText="Due Date" />
                    <asp:BoundField DataField="Priority" HeaderText="Priority" />                    
                </Columns>
        </asp:GridView>
        <asp:HyperLink ID="HyperLinkBack" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>
</asp:Content>

