<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SimpleDataBinding.aspx.cs" Inherits="SimpleDataBinding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
    <h3>Current time is <%# currentTime %> </h3>

        <asp:Label runat="server" ID="lblDate"
             Text='<%# "today is " +  DateTime.Now.ToShortDateString()  %>'></asp:Label>
    </div>
    </form>
</body>
</html>
