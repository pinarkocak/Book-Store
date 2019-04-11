using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace Book_Store
{
    public partial class Default : System.Web.UI.Page
    {
        public ArrayList my_cartList = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookieReader = Request.Cookies["cookieFolder"];
            lbl_welcome.Text = "Welcome " + cookieReader["firstname"] + " " + cookieReader["lastname"];
          
            if(!IsPostBack)
            {
                var book1 = new Book(1, "Hobbit", "J.R.R. Tolkien", "ithaki", 384, "./images/Hobbit.jpg");
                Session.Add("book1", book1);               
                var book2 = new Book(2, "Hayvan Çiftliği", "George Orwell", "Can Yayınları", 160, "./images/hayvan-cifligi.jpg");
                Session.Add("book2", book2);
                var book3 = new Book(3, "Harry Potter ve Ölüm Yadigarları", "J.K. Rowling", "Yapı Kredi Yayınları", 696, "./images/HP_7.jpg");
                Session.Add("book3", book3);
                var book4 = new Book(4, "Kitap Hırsızı", "Markus Zusak ", "Martı Yayınları", 574, "./images/kitap-hirsizi.jpg");
                Session.Add("book4", book4);
                var book5 = new Book(1, "Mary Queen of Scots", "Stefan Zweig", "Pushkin Press", 448, "./images/mary-stuart.jpg");
                Session.Add("book5", book5);
                var book6 = new Book(1, "Sherlock Holmes: Korku Vadisi", "Sir Arthur Conan Doyle", "Avrupa Yakası Yayınları", 240, "./images/sherlock.jpg");
                Session.Add("book6", book6);
            }
            

        }

        protected void btn_Logout_Click(object sender, EventArgs e)
        {
            HttpCookie deletecookie = Request.Cookies["cookieFolder"];
            deletecookie.Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("Login.aspx");
        }

        protected void img_shopcart_Click(object sender, ImageClickEventArgs e)
        {            
            Response.Redirect("Cart.aspx");
        }

        protected void img_book1_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["book1"] != null)
                Response.Redirect("BookInfo.aspx?id="+1);
        }

        protected void img_book2_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["book2"] != null)
                Response.Redirect("BookInfo.aspx?id="+2);
        }

        protected void img_book3_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["book3"] != null)
                Response.Redirect("BookInfo.aspx?id="+3);
        }

        protected void img_book4_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["book4"] != null)
                Response.Redirect("BookInfo.aspx?id="+4);
        }

        protected void img_book5_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["book5"] != null)
                Response.Redirect("BookInfo.aspx?id="+5);
        }

        protected void img_book6_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["book6"] != null)
                Response.Redirect("BookInfo.aspx?id="+6);
        }
    }
}