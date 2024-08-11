using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_4_MP
{
    public partial class cp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.mstrbtn.Click += cp_click;
        }

        protected void cp_click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)Master.FindControl("TextBox1");
            Label1.Text = textBox.Text;
        }
    }
}