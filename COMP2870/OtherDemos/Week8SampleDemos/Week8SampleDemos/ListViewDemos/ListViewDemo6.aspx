<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListViewDemo6.aspx.cs" Inherits="ListViewDemos_ListViewDemo6" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script> <!-- 33 KB -->

<!-- fotorama.css & fotorama.js. -->

    <link  href="http://cdnjs.cloudflare.com/ajax/libs/fotorama/4.6.3/fotorama.css" rel="stylesheet"> <!-- 3 KB -->
<script src="http://cdnjs.cloudflare.com/ajax/libs/fotorama/4.6.3/fotorama.js"></script> <!-- 16 KB -->

</head>
<body>
    <form id="form1" runat="server">
   <div class="fotorama">
       <asp:ListView ID="lvPhotos" runat="server">        
            <ItemTemplate>                
                  <asp:Image  runat="server"  id="imPhoto" ImageUrl='<%# Container.DataItem %>'
                 />                     
            </ItemTemplate>
        </asp:ListView>    
    </div>
    </form>
</body>
</html>

