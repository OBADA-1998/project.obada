using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.obada
{
    public partial class application2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( Application["name"]!=null)
            {
                Label1.Text = Application["name"].ToString();
            }
            if(Application["email"]!=null)
            {
                Label2.Text = Application["email"].ToString();
            }
        }
    }
}