using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.obada
{
    public partial class App2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["Name"] != null)
            {
                Label1.Text = Application["Name"].ToString();
            }
            if (Application["E-mail"] != null)
            {
                Label2.Text = Application["E-mail"].ToString();
            }
        }
    }
}