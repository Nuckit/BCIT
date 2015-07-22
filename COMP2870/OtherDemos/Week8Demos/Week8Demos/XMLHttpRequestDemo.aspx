<%@ Page Language="C#" AutoEventWireup="true" CodeFile="XMLHttpRequestDemo.aspx.cs" Inherits="XMLHttpRequestDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">

        function getDataFromServer() {
            var oReq = new XMLHttpRequest();
            oReq.onload = reqListener;
            oReq.open("get", "sampledata.csv", true);
            oReq.send();            
        }
        
        function reqListener() {
            //alert(this.responseText);
            var span = document.getElementById("response");
            span.innerText = this.responseText;
        }
       

    </script>
</head>
<body>
    <form id="form1" runat="server">
    
        <asp:Button ID="Button1" runat="server" 
            OnClientClick="getDataFromServer(); return false;" Text="Button" />
        <span id="response"></span>
    </form>
</body>
</html>
