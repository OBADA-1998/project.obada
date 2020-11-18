using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.obada
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

          
        }

        protected void btn_l_Click(object sender, EventArgs e)
        {

            Session["E-mail"] = txt_e.Text;
            Session["Password"] = txt_p.Text;
            Response.Redirect("Session3.aspx");
        }

        protected void txt_u_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void txt_p_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void btn_c_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("userinfo");
            cookie["E-mail"] = txt_e.Text;
            cookie["Password"] = txt_p.Text;
            cookie.Expires = DateTime.Now.AddDays(15);
            Response.Cookies.Add(cookie);
            Response.Redirect("~/Session3.aspx");
        }

        protected void txt_e_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("userinfo");
            cookie["E-mail"] = txt_e.Text;
            cookie["Password"] = txt_p.Text;
            cookie.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(cookie);
            Response.Redirect("~/Session3.aspx");
        }

        protected void txt_p_TextChanged1(object sender, EventArgs e)
        {

        }
    }
}