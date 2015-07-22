<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JQueryCalendar.aspx.cs" Inherits="JQueryCalendar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>JQuery Calendar</title>

     <link rel="stylesheet" href="//ajax.googleapis.com/ajax/libs/jqueryui/1.10.4/themes/smoothness/jquery-ui.css" />
     <script src="//ajax.googleapis.com/ajax/libs/jquery/2.1.0/jquery.min.js"></script>
     <script src="//ajax.googleapis.com/ajax/libs/jqueryui/1.10.4/jquery-ui.min.js"></script>
   
  
   <script type="text/javascript">
       $(document).ready(function() {
            $("#tbCalendar").datepicker();
       });
  </script>
  <style type="text/css">
  div.ui-datepicker
  {
  	font-size:62.5%
  }
  </style>
</head>
<body>
    <form id="form1" runat="server">
     <p style="background-color:InfoBackground">This page demonstrates how you can make use of Calendar control that is client based. This calendar control is 
     rendered on the client unlike the ASP.NET Calendar control and provides a much better experience. You can make use of this in your assignment. Make sure you copy 
     the script and style tags specified in the HEAD of the document in order for this to work. </p>
    <div>
    <asp:TextBox runat="server" ID="tbCalendar" ClientIDMode="Static"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="tbCalendar" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
    </div>
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" /><asp:Label ID="Label1" runat="server"
        Text=""></asp:Label>
    </form>
</body>
</html>
