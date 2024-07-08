using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WT_LAB_2
{
    public partial class comcal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(TextBox2.Text) == 0)
            {
                TextBox2.BackColor = System.Drawing.Color.Red;
                Button4.Enabled = false;
            }
            else
            {
                TextBox2.BackColor = System.Drawing.Color.White;
                Button4.Enabled = true;
            }
        }

        protected void Button2_Command(object sender, CommandEventArgs e)
        {
            int a = Convert.ToInt16(TextBox1.Text);
            int b = Convert.ToInt16(TextBox2.Text);

            switch (e.CommandArgument)
            {
                case "+":
                    TextBox3.Text = Convert.ToString(a + b);
                    break;
                case "-":
                    TextBox3.Text = Convert.ToString(a - b);
                    break;
                case "*":
                    TextBox3.Text = Convert.ToString(a * b);
                    break;
                case "/":
                    TextBox3.Text = Convert.ToString(a / b);
                    break;
            }
        }
    }
}