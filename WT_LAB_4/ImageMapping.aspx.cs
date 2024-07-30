using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WT_LAB_4
{
    public partial class ImageMapping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
        {
            string s= e.PostBackValue.ToString();
            TextBox1.Text = s;

            if(s == "clouds")
            {
                TextBox1.Text = "clouds";
            }
            else if(s == "mountains")
            {
                TextBox1.Text = "mountains";
            }
            else if (s == "grass")
            {
                TextBox1.Text= "grass";
            }
            
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            TextBox1.Text= "X:" + e.X.ToString() + " Y:" + e.Y.ToString();
        }
    }
}