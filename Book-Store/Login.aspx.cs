using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace Book_Store
{
    public partial class Login : System.Web.UI.Page
    {
        public ArrayList cartList;

        protected void Page_Load(object sender, EventArgs e)
        {
            cartList = new ArrayList();
            Session["cartList"] = cartList;
        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {           
            if (txt_firstname.Text != "" && txt_lastname.Text != "")
            {
                HttpCookie UserInfo = new HttpCookie("cookieFolder");
                UserInfo["firstname"] = txt_firstname.Text;
                UserInfo["lastname"] = txt_lastname.Text;
                UserInfo.Expires = DateTime.Now.AddMonths(1);
                Response.Cookies.Add(UserInfo);

                Response.Redirect("Default.aspx");                
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You are not logged in. Please login to continue')", true);
            }        
            
        }
    }
}