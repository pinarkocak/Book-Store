using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace Book_Store
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList cartList2 = new ArrayList();
            cartList2 = Session["cartList"] as ArrayList;
            Book Book1 = (Book)Session["book1"];
            Book Book2 = (Book)Session["book2"];
            Book Book3 = (Book)Session["book3"];
            Book Book4 = (Book)Session["book4"];
            Book Book5 = (Book)Session["book5"];
            Book Book6 = (Book)Session["book6"];
            if (!IsPostBack)
            {
                if (cartList2.Count == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Your Shopping Cart is Empty!')", true);
                }
                else
                {
                    int n = 3;
                    if (cartList2.Contains("1"))
                    {
                        Label[] labels = new Label[n];
                        Image image = new Image();
                        this.Controls.Add(image);
                        image.Height = 200;
                        image.Width = 150;
                        image.ImageUrl = Book1.ImageUrl;

                        for (int i = 0; i < n; i++)
                        {
                            labels[i] = new Label();
                            this.Controls.Add(labels[i]);
                        }
                        
                        labels[0].Text = "<br />Author : " + Book1.Author + "<br />";
                        labels[1].Text = "<br />Publisher : " +Book1.Publisher + "<br />";
                        labels[2].Text = "<br />Page Numbers : " + Book1.PageNumber + "<br />" + "<br />";
                    }
                    if (cartList2.Contains("2"))
                    {
                        Label[] labels = new Label[n];
                        Image image = new Image();
                        this.Controls.Add(image);
                        image.Height = 200;
                        image.Width = 150;
                        image.ImageUrl = Book2.ImageUrl;

                        for (int i = 0; i < n; i++)
                        {
                            labels[i] = new Label();
                            this.Controls.Add(labels[i]);
                        }

                        labels[0].Text = "<br />Author : " + Book2.Author + "<br />";
                        labels[1].Text = "<br />Publisher : " + Book2.Publisher + "<br />";
                        labels[2].Text = "<br />Page Numbers : " + Book2.PageNumber + "<br />" + "<br />";
                    }
                    if (cartList2.Contains("3"))
                    {
                        Label[] labels = new Label[n];
                        Image image = new Image();
                        this.Controls.Add(image);
                        image.Height = 200;
                        image.Width = 150;
                        image.ImageUrl = Book3.ImageUrl;

                        for (int i = 0; i < n; i++)
                        {
                            labels[i] = new Label();
                            this.Controls.Add(labels[i]);
                        }

                        labels[0].Text = "<br />Author : " + Book3.Author + "<br />";
                        labels[1].Text = "<br />Publisher : " + Book3.Publisher + "<br />";
                        labels[2].Text = "<br />Page Numbers : " + Book3.PageNumber + "<br />" + "<br />";
                    }
                    if (cartList2.Contains("4"))
                    {
                        Label[] labels = new Label[n];
                        Image image = new Image();
                        this.Controls.Add(image);
                        image.Height = 200;
                        image.Width = 150;
                        image.ImageUrl = Book4.ImageUrl;

                        for (int i = 0; i < n; i++)
                        {
                            labels[i] = new Label();
                            this.Controls.Add(labels[i]);
                        }

                        labels[0].Text = "<br />Author : " + Book4.Author + "<br />";
                        labels[1].Text = "<br />Publisher : " + Book4.Publisher + "<br />";
                        labels[2].Text = "<br />Page Numbers : " + Book4.PageNumber + "<br />" + "<br />";
                    }

                    if (cartList2.Contains("5"))
                    {
                        Label[] labels = new Label[n];
                        Image image = new Image();
                        this.Controls.Add(image);
                        image.Height = 200;
                        image.Width = 150;
                        image.ImageUrl = Book5.ImageUrl;

                        for (int i = 0; i < n; i++)
                        {
                            labels[i] = new Label();
                            this.Controls.Add(labels[i]);
                        }

                        labels[0].Text = "<br />Author : " + Book5.Author + "<br />";
                        labels[1].Text = "<br />Publisher : " + Book5.Publisher + "<br />";
                        labels[2].Text = "<br />Page Numbers : " + Book5.PageNumber + "<br />" + "<br />";
                    }

                    if (cartList2.Contains("6"))
                    {
                        Label[] labels = new Label[n];
                        Image image = new Image();
                        this.Controls.Add(image);
                        image.Height = 200;
                        image.Width = 150;
                        image.ImageUrl = Book6.ImageUrl;

                        for (int i = 0; i < n; i++)
                        {
                            labels[i] = new Label();
                            this.Controls.Add(labels[i]);
                        }

                        labels[0].Text = "<br />Author : " + Book6.Author + "<br />";
                        labels[1].Text = "<br />Publisher : " + Book6.Publisher + "<br />";
                        labels[2].Text = "<br />Page Numbers : " + Book6.PageNumber + "<br />" + "<br />";
                    }


                }
            }
        }

        protected void btn_Return_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}