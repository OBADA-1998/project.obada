using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.obada
{
    public partial class Session3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["E-mail"].ToString();
            Label2.Text = Session["Password"].ToString();


        }
        }
    }
