using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WT_LAB_2
{
    public partial class calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(TextBox1.Text);
            int b = Convert.ToInt16(TextBox4.Text);
            TextBox3.Text = Convert.ToString(a / b);
        }

        

        protected void Button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(TextBox1.Text);
            int b = Convert.ToInt16(TextBox4.Text);
            TextBox3.Text = Convert.ToString(a * b);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(TextBox1.Text);
            int b = Convert.ToInt16(TextBox4.Text);
            TextBox3.Text = Convert.ToString(a - b);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(TextBox1.Text);
            int b = Convert.ToInt16(TextBox4.Text);
            TextBox3.Text = Convert.ToString(a + b);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            
            if (Convert.ToInt16(TextBox4.Text) == 0)
            {
                TextBox4.BackColor = System.Drawing.Color.Red;
                Button4.Enabled = false;
            }
            else
            {
                TextBox4.BackColor = System.Drawing.Color.White;
                Button4.Enabled = true;
            }
        }
    }
}