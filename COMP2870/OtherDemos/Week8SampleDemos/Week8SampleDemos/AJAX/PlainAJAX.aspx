<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PlainAJAX.aspx.cs" Inherits="AJAX_PlainAJAX" %>
<%@ OutputCache Location="None" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Plain AJAX</title>
    <script type="text/javascript">
       
       
        
        //Gets the server time via an AJAX call.
        function getServerTime() {
            var url = "TimeHandler.ashx";
            var req = new XMLHttpRequest();

            req.open("GET", url, true);

            req.onload = function () {
                if (this.status === 200) { alert(this.responseText); return false; }
             
                return false;
            }
            req.send();
        }
        

        
    </script>
</head>
<body>
    <form id="form1" runat="server">
     <p style="background-color:InfoBackground">This page demonstrates the use of XMLHttpRequest object available in JavaScript to generate asynchronous requests to the server 
     to obtain data and update the page in the browser" </p>
   <div>
    
        <asp:Button ID="btnSubmitPostback" runat="server" Text="Get Server Time (Postback)" 
            onclick="btnSubmitPostback_Click" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    <div style="margin-top:50px">
     <asp:Button ID="btnSubmit" runat="server" Text="Get Server Time (AJAX)" 
            OnClientClick="return getServerTime();"/>
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
