<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Book_Store.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:700,600' rel='stylesheet' type='text/css'/>
    <style>
        body{
            font-family: 'Open Sans', sans-serif;
            background:#3498db;
            margin: 0 auto 0 auto;  
            width:100%; 
            text-align:center;
            margin: 20px 0px 20px 0px;   
        }

        p{
            font-size:12px;
            text-decoration: none;
            color:#ffffff;
        }

        .box{
            background:white;
            width:300px;
            border-radius:6px;
            margin: 0 auto 0 auto;
            padding:0px 0px 70px 0px;
            border: #2980b9 4px solid; 
            }

        .textboxx{
            background:#ecf0f1;
            border: #ccc 1px solid;
            border-bottom: #ccc 2px solid;
            padding: 8px;
            width:250px;
            color:#AAAAAA;
            margin-top:10px;
            font-size:1em;
            border-radius:4px;
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
            float:left;
            margin-left:16px;
            font-weight:800;
            font-size:0.8em;
        }

        .btn:hover{
            background:#2CC06B; 
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="box">
            <h1>Welcome!</h1>

            &nbsp; <!-- End Btn -->
  
            <asp:Label ID="lbl_firstname" runat="server" Text="First Name :"></asp:Label>
            <asp:TextBox ID="txt_firstname" runat="server" CssClass="textboxx"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lbl_lastname" runat="server" Text="Last Name :"></asp:Label>
            <asp:TextBox ID="txt_lastname" runat="server" CssClass="textboxx"></asp:TextBox>
  
            <asp:Button ID="btn_Login" runat="server" Text="Login" CssClass="btn" OnClick="btn_Login_Click" />
  
        </div> <!-- End Box -->
  
    </form>

<p>Forgot your password? <u style="color:#f1c40f;">Click Here!</u></p>
 
</body>
</html>
