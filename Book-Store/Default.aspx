<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Book_Store.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #panel {
            width:1100px;
            margin-top:5%;
            margin-left:auto;
            margin-right:auto;
        }
        .left { 
            width:300px;
            background-color:#e5e5e5;
            height:230px;
            float:left;
        }
        .right {
            width:730px;
            background-color:#e6ffe6;
            height:640px;
            float:right;
        }
        .image {
            margin-left:10px;
            width:50px;
            height:50px;
            margin-top: 10px;
        }
        .btn {
            background:#ff6600;
            width:280px;
            margin-left:10px;
            padding-top:5px;
            padding-bottom:5px;
            color:white;
            border-radius:4px;
            border: #27ae60 1px solid;
        }
        .image_books {
            width:200px;
            height:270px;
            margin-left:30px;
            margin-top:30px;
        }
        .panel_header {
            background-color:#e6ffe6;
            height:80px;
            width:100%;
            margin-top:auto;
            margin-bottom:auto;
            margin-left:auto;
            margin-right:auto;
        }  
        .logo {
            float:left;
            width:300px;
            height:70px;
            margin-top:5px;
            margin-left:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <!-- Header -->
            <asp:Panel ID="panel_header" runat="server" CssClass="panel_header">
                <asp:Image ID="img_icon" runat="server" src="images/Bookshop-Logo.png" CssClass="logo" />              
            </asp:Panel>
         <div id="panel">
            <div class="left">
               
                <asp:Image ID="Image1" runat="server" src="https://images.vexels.com/media/users/3/147101/isolated/preview/b4a49d4b864c74bb73de63f080ad7930-instagram-profile-button-by-vexels.png" CssClass="image"/>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbl_welcome" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Larger"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;               
                <asp:ImageButton ID="img_shopcart" runat="server" src="http://akademi.zentekyazilim.net/img/parekende.png" CssClass="image" OnClick="img_shopcart_Click" />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
                <asp:Button ID="btn_Logout" runat="server" Text="Log Out" CssClass="btn" OnClick="btn_Logout_Click" ForeColor="White"/>
               
            </div>
            <div class="right">
                 
                <asp:ImageButton ID="img_book1" runat="server" src="images/Hobbit.jpg" CssClass="image_books" OnClick="img_book1_Click"/>
                <asp:ImageButton ID="img_book2" runat="server" src="images/hayvan-cifligi.jpg" CssClass="image_books" OnClick="img_book2_Click"/>
                <asp:ImageButton ID="img_book3" runat="server" src="images/HP_7.jpg" CssClass="image_books" OnClick="img_book3_Click"/>
                <asp:ImageButton ID="img_book4" runat="server" src="images/kitap-hirsizi.jpg" CssClass="image_books" OnClick="img_book4_Click"/>
                <asp:ImageButton ID="img_book5" runat="server" src="images/mary-stuart.jpg" CssClass="image_books" OnClick="img_book5_Click"/>
                <asp:ImageButton ID="img_book6" runat="server" src="images/sherlock.jpg" CssClass="image_books" OnClick="img_book6_Click"/>

            </div>
           
        </div>
    </form>
</body>
</html>
