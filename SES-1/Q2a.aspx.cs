using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SES_1
{
    public partial class Q2a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            TextBox1.Text= "X: " + e.X + " Y: " + e.Y;
        }

        protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
        {
            String pbc = e.PostBackValue.ToString();

            if (pbc == "0")
            {
                TextBox1.Text = "You clicked on the sun";
            }
            else if (pbc == "1") {
                TextBox1.Text = "You clicked on the mountain";
            }
            else if (pbc == "2")
            {
                TextBox1.Text = "You clicked on the sky";
            }
        }
    }
}