<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PendingTasks.aspx.cs" Inherits="PendingTasks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderTitle" Runat="Server">
        <h3>Pending Tasks</h3>    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
            <asp:GridView ID="GridViewTasks" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="TaskId" DataNavigateUrlFormatString="EditTask.aspx?taskId={0}" Text="Edit" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Category" HeaderText="Category" />
                    <asp:BoundField DataField="StartDate" HeaderText="Start Date" />
                    <asp:BoundField DataField="DueDate" HeaderText="Due Date" />
                    <asp:BoundField DataField="Priority" HeaderText="Priority" /> 
                <asp:BoundField DataField="PercentComplete" HeaderText="Percent Complete" />           
            </Columns>
        </asp:GridView>
        <asp:HyperLink ID="HyperLink1" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>
</asp:Content>

