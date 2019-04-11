<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Book_Store.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #panel {
            width:400px;
            margin-top:5%;
            margin-left:auto;
            margin-right:auto;
        }
        .left { 
            background-color:#e5e5e5;
            float:left;
        }
        .right {
            width:250px;
            background-color:#e6ffe6;
            height:200px;
            float:right;
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
        .image {
            width:150px;
            height:200px;
        }
        .btn{
            background:#2ecc71;
            width:170px;
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
        <h1>Shopping Cart</h1>
        <asp:Button ID="btn_Return" runat="server" Text="Return to Main Page" CssClass="btn" OnClick="btn_Return_Click" />
    </form>
</body>
</html>
