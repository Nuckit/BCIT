<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AJAXDemo4.aspx.cs" Inherits="AJAX_AJAXDemo4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AJAX Demo4</title>
    <style type="text/css">
        .auto-style2 {
            width: 66px;
            height: 66px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <p style="background-color:InfoBackground">This AJAX Page demonstrates the use of UpdateProgress Control which can be used to provide feedback to the user when 
    a long running operation is invoked by the user. The long running operation in this example is simulated using Thread.Sleep method </p>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Button ID="Button1" runat="server" Text="Execute Long Running Operation" 
                onclick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </ContentTemplate>
        </asp:UpdatePanel>
    </div>
   
       
   
        <asp:UpdateProgress ID="UpdateProgress1" runat="server">
            <ProgressTemplate>
           
                <img alt="wait" class="auto-style2" src="waiting2.gif" />
           
            </ProgressTemplate>
        </asp:UpdateProgress>
   
       
   
    </form>
</body>
</html>
