using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace Book_Store
{
    public partial class BookInfo : System.Web.UI.Page
    {
        ArrayList cartList2 = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {
            Book Book1 = (Book)Session["book1"];
            Book Book2 = (Book)Session["book2"];
            Book Book3 = (Book)Session["book3"];
            Book Book4 = (Book)Session["book4"];
            Book Book5 = (Book)Session["book5"];
            Book Book6 = (Book)Session["book6"];

            if (!IsPostBack)
            {
                if (Request.QueryString["id"] == "1")
                {
                    lbl_bookTitle.Text = Book1.Title;
                    lbl_bookAuthor.Text = "Author : " + Book1.Author;
                    lbl_bookPublisher.Text = "Publisher : " + Book1.Publisher;
                    lbl_bookPages.Text = "Pages : " + Book1.PageNumber;
                    book_image.ImageUrl = Book1.ImageUrl;
                }
                if (Request.QueryString["id"] == "2")
                {
                    lbl_bookTitle.Text = Book2.Title;
                    lbl_bookAuthor.Text = "Author : " + Book2.Author;
                    lbl_bookPublisher.Text = "Publisher : " + Book2.Publisher;
                    lbl_bookPages.Text = "Pages : " + Book2.PageNumber;
                    book_image.ImageUrl = Book2.ImageUrl;
                }
                if (Request.QueryString["id"] == "3")
                {
                    lbl_bookTitle.Text = Book3.Title;
                    lbl_bookAuthor.Text = "Author : " + Book3.Author;
                    lbl_bookPublisher.Text = "Publisher : " + Book3.Publisher;
                    lbl_bookPages.Text = "Pages : " + Book3.PageNumber;
                    book_image.ImageUrl = Book3.ImageUrl;
                }
                if (Request.QueryString["id"] == "4")
                {
                    lbl_bookTitle.Text = Book4.Title;
                    lbl_bookAuthor.Text = "Author : " + Book4.Author;
                    lbl_bookPublisher.Text = "Publisher : " + Book4.Publisher;
                    lbl_bookPages.Text = "Pages : " + Book4.PageNumber;
                    book_image.ImageUrl = Book4.ImageUrl;
                }
                if (Request.QueryString["id"] == "5")
                {
                    lbl_bookTitle.Text = Book5.Title;
                    lbl_bookAuthor.Text = "Author : " + Book5.Author;
                    lbl_bookPublisher.Text = "Publisher : " + Book5.Publisher;
                    lbl_bookPages.Text = "Pages : " + Book5.PageNumber;
                    book_image.ImageUrl = Book5.ImageUrl;
                }
                if (Request.QueryString["id"] == "6")
                {
                    lbl_bookTitle.Text = Book6.Title;
                    lbl_bookAuthor.Text = "Author : " + Book6.Author;
                    lbl_bookPublisher.Text = "Publisher : " + Book6.Publisher;
                    lbl_bookPages.Text = "Pages : " + Book6.PageNumber;
                    book_image.ImageUrl = Book6.ImageUrl;
                }
                else if (Request.QueryString["id"] == "")
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Specify a Book ID!')", true);
                }
            }
        }

        protected void btn_returnMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btn_addtoCart_Click(object sender, EventArgs e)
        {
            cartList2 = (ArrayList)Session["cartList"];

            if(Request.QueryString["id"] != "")
            {
                if (!cartList2.Contains("1") || !cartList2.Contains("2") || !cartList2.Contains("3") || !cartList2.Contains("4") || !cartList2.Contains("5") || !cartList2.Contains("6"))
                {
                    cartList2.Add(Request.QueryString["id"].ToString());
                    lbl_warning.Text = "Book is added to the shopping cart";
                    Session["cartList"] = cartList2;
                }
                else
                {
                    lbl_warning.Text = "Book is already in the shopping cart";
                }

            }                      

        }

        protected void btn_gotoCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }
    }
}