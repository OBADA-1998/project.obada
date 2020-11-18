using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.obada
{
    public partial class Hidden_F : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_1_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = txt_1.Text;
        }

        protected void btn_2_Click(object sender, EventArgs e)
        {
            Label1.Text = HiddenField1.Value;
        }
    }
}