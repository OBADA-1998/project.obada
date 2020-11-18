using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.obada
{
    public partial class App : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_g_Click(object sender, EventArgs e)
        {
            Application["Name"] = txt_n.Text;
            Application["E-mail"] = txt_n.Text;
            Response.Redirect("~/App2.aspx");
        }
    }
}