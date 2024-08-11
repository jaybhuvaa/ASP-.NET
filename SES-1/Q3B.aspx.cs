using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SES_1
{
    public partial class Q3B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String name = FileUpload1.PostedFile.FileName;
            if (FileUpload1.HasFile)
            {
                if (FileUpload1.PostedFile.ContentType == "application/pdf")
                {
                    if (FileUpload1.PostedFile.ContentLength < 10000)
                    {
                        FileUpload1.PostedFile.SaveAs(Server.MapPath("~/") + name);
                    }
                    else
                    {

                        Label1.Text = "File size should be less than 10KB";
                    }
                }
                else
                {
                    Label1.Text = "File type should be pdf";
                }
            }
            else
            {
                Label1.Text = "Please select a file";
            }

            Label2.Text= "Name: " + TextBox1.Text + "<br/>" + "Enrollment number: " + TextBox2.Text + "<br/>" + "Conatct Number: " + TextBox3.Text + "<br/>" + "Email: "+ TextBox4.Text + "<br/>" + " Resume File: " + name;
        }
        
    }
}