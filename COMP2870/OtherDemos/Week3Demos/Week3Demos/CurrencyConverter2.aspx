<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CurrencyConverter2.aspx.cs" Inherits="CurrencyConverter2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <p style="background-color:ActiveBorder">This page displays HTML elements - input text, input submit (button) and a div. One thing to note is that the controls
do not retain their values across postbacks (button clicks)</p>
<div>
<h4>US Dollars to Canadian.</h4>
Convert:&nbsp;
<input type="text" name="amount" />
<br /><br />
<input type="submit" />
<br />
 <%
     if (IsPostBack)
     {
         string amount = Request.Form["amount"];
         decimal value = Convert.ToDecimal(amount) * 1.10m;
         Response.Write("Convereted value : " + value);
     }
  %>
<span style="font-weight: bold" id="spResult"></span>
</div>
    </form>
</body>
</html>
