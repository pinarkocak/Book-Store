<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookInfo.aspx.cs" Inherits="Book_Store.BookInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
         #panel {
            width:700px;
            margin-top:5%;
            margin-left:auto;
            margin-right:auto;
        }
        .left { 
            background-color:#e5e5e5;
            float:left;
        }
        .right {
            width:300px;
            background-color:#e6ffe6;
            height:500px;
            float:right;
        }
        .image {
            width:360px;
            height:500px;
        }
        .logo {
            float:left;
            width:300px;
            height:70px;
            margin-top:5px;
            margin-left:10px;
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
        .label {
            margin-top:20px;
            margin-left:20px;
        }
        .btn{
            background:#2ecc71;
            width:265px;
            padding-top:5px;
            padding-bottom:5px;
            color:white;
            border-radius:4px;
            border: #27ae60 1px solid;
  
            margin-top:20px;
            margin-bottom:20px;
            margin-left:16px;
            font-weight:800;
            font-size:0.8em;
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
                <asp:Image ID="book_image" runat="server" CssClass="image"/>
            </div>
            <div class="right">  
                <br />
                <br />
               <asp:Label ID="lbl_bookTitle" runat="server" CssClass="label" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lbl_bookAuthor" runat="server" CssClass="label" Font-Italic="True" ></asp:Label>
                <br />
                <br />
                <asp:Label ID="lbl_bookPublisher" runat="server" CssClass="label" Font-Italic="True"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lbl_bookPages" runat="server" CssClass="label" Font-Italic="True"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btn_addtoCart" runat="server" Text="Add To Cart" OnClick="btn_addtoCart_Click" CssClass="btn" />
                <br />
                <br 
                <asp:Label ID="lbl_warning" runat="server" CssClass="label" ></asp:Label>
                <br />
                <br />
                <asp:Button ID="btn_gotoCart" runat="server" Text="Go To Cart" OnClick="btn_gotoCart_Click" CssClass="btn" />
                <br />
                <br />
                <asp:Button ID="btn_returnMain" runat="server" Text="Return to Main Page" OnClick="btn_returnMain_Click" CssClass="btn" />
            </div>
           
        </div>
    </form>
</body>
</html>
