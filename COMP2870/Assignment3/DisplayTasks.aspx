<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DisplayTasks.aspx.cs" Inherits="DisplayTasks" %>
<%@ Register TagPrefix="Custom" Namespace="CustomParameters" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderTitle" Runat="Server">
        <h3>All Tasks</h3>    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    
    <asp:ListView ID="ListViewTasks" runat="server" DataSourceID="SqlDataSource">
        <AlternatingItemTemplate>
            <tr style="background-color:#FFF8DC;">
                <td>
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                </td>
                <td>
                    <asp:Label ID="CategoryLabel" runat="server" Text='<%# Eval("Category") %>' />
                </td>
                <td>
                    <asp:Label ID="StartDateLabel" runat="server" Text='<%# Eval("StartDate") %>' />
                </td>
                <td>
                    <asp:Label ID="DueDateLabel" runat="server" Text='<%# Eval("DueDate") %>' />
                </td>
                <td>
                    <asp:Label ID="PercentCompleteLabel" runat="server" Text='<%# Eval("PercentComplete") %>' />
                </td>
                <td>
                    <asp:Label ID="PriorityLabel" runat="server" Text='<%# Eval("Priority") %>' />
                </td>
            </tr>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <tr style="background-color:#008A8C;color: #FFFFFF;">
                <td>
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                </td>
                <td>
                    <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CategoryTextBox" runat="server" Text='<%# Bind("Category") %>' />
                </td>
                <td>
                    <asp:TextBox ID="StartDateTextBox" runat="server" Text='<%# Bind("StartDate") %>' />
                </td>
                <td>
                    <asp:TextBox ID="DueDateTextBox" runat="server" Text='<%# Bind("DueDate") %>' />
                </td>
                <td>
                    <asp:TextBox ID="PercentCompleteTextBox" runat="server" Text='<%# Bind("PercentComplete") %>' />
                </td>
                <td>
                    <asp:TextBox ID="PriorityTextBox" runat="server" Text='<%# Bind("Priority") %>' />
                </td>
            </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                </td>
                <td>
                    <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CategoryTextBox" runat="server" Text='<%# Bind("Category") %>' />
                </td>
                <td>
                    <asp:TextBox ID="StartDateTextBox" runat="server" Text='<%# Bind("StartDate") %>' />
                </td>
                <td>
                    <asp:TextBox ID="DueDateTextBox" runat="server" Text='<%# Bind("DueDate") %>' />
                </td>
                <td>
                    <asp:TextBox ID="PercentCompleteTextBox" runat="server" Text='<%# Bind("PercentComplete") %>' />
                </td>
                <td>
                    <asp:TextBox ID="PriorityTextBox" runat="server" Text='<%# Bind("Priority") %>' />
                </td>
            </tr>
        </InsertItemTemplate>
        <ItemTemplate>
            <tr style="background-color:#DCDCDC;color: #000000;">
                <td>
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                </td>
                <td>
                    <asp:Label ID="CategoryLabel" runat="server" Text='<%# Eval("Category") %>' />
                </td>
                <td>
                    <asp:Label ID="StartDateLabel" runat="server" Text='<%# Eval("StartDate") %>' />
                </td>
                <td>
                    <asp:Label ID="DueDateLabel" runat="server" Text='<%# Eval("DueDate") %>' />
                </td>
                <td>
                    <asp:Label ID="PercentCompleteLabel" runat="server" Text='<%# Eval("PercentComplete") %>' />
                </td>
                <td>
                    <asp:Label ID="PriorityLabel" runat="server" Text='<%# Eval("Priority") %>' />
                </td>
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                <th runat="server">Name</th>
                                <th runat="server">Category</th>
                                <th runat="server">StartDate</th>
                                <th runat="server">DueDate</th>
                                <th runat="server">PercentComplete</th>
                                <th runat="server">Priority</th>
                            </tr>
                            <tr id="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;"></td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                <td>
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                </td>
                <td>
                    <asp:Label ID="CategoryLabel" runat="server" Text='<%# Eval("Category") %>' />
                </td>
                <td>
                    <asp:Label ID="StartDateLabel" runat="server" Text='<%# Eval("StartDate") %>' />
                </td>
                <td>
                    <asp:Label ID="DueDateLabel" runat="server" Text='<%# Eval("DueDate") %>' />
                </td>
                <td>
                    <asp:Label ID="PercentCompleteLabel" runat="server" Text='<%# Eval("PercentComplete") %>' />
                </td>
                <td>
                    <asp:Label ID="PriorityLabel" runat="server" Text='<%# Eval("Priority") %>' />
                </td>
            </tr>
        </SelectedItemTemplate>
            </asp:ListView>
        <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT t.Name, c.[Name] 'Category', t.[StartDate], t.[DueDate], t.[PercentComplete], t.[Priority]  FROM [Task] t JOIN [Category] c ON t.CategoryId = c.CategoryId WHERE (t.[Username] = @Username)">
            <SelectParameters>
                <Custom:UsernameParameter Name="UserName"/>
            </SelectParameters>
    </asp:SqlDataSource>
        <asp:HyperLink ID="HyperLinkBack" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>
</asp:Content>
