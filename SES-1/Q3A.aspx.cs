using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SES_1
{
    public partial class Q3A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.rbq.SelectedIndexChanged += Master_slchng;
          
        }
        protected void Master_slchng(object sender, EventArgs e)
        {
            
            RadioButtonList rb = (RadioButtonList)Master.FindControl("rb1");
            lb1.Text= "You have selected " + rb.SelectedValue.ToString();

            if(rb.SelectedValue.ToString() == "IT")
            {
                lb1.Text = "You have selected IT";
            }
            else if(rb.SelectedValue.ToString() == "CE")
            {
               lb1.Text = "You have selected CE";
            }
            else if(rb.SelectedValue.ToString() == "EC")
            {
                lb1.Text = "You have selected EC";
            }
           
            else
            {
                lb1.Text = "You have not selected any branch";
            }
        }
       
    }
}