using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.obada
{
    public partial class Viewstate : System.Web.UI.Page
    {
        int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                txt_1.Text = "0";
            txt_1.Text = Session["user"].ToString();
            Response.Write(Session["password"].ToString());
        }

        protected void btn_1_Click(object sender, EventArgs e)
        {
            if (ViewState["click"] != null)
                count = (int)ViewState["click"] + 1;
            txt_1.Text = count.ToString();
            ViewState["click"] = count; 
        }

        protected void txt_1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_s_Click(object sender, EventArgs e)
        {
            Session["user"] = "obada";
            Session["password"] = "00000";
            Response.Redirect("Session.aspx");
        }
    }
}