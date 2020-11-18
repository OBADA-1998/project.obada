using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.obada
{
    public partial class cookies2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        HttpCookie cookie= Request.Cookies["userinfo"];
            if (cookie != null)
            {
                Lab1.Text = cookie["Name"];
                lab2.Text = cookie["Email"];
            }
        }
    }
}