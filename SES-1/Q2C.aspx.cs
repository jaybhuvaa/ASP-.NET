using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SES_1
{
    public partial class Q2C : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int r= Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            int c =Convert.ToInt32(DropDownList2.SelectedValue.ToString());

            Table t=new Table();

            for (int i = 0; i < r; i++) { 
                TableRow tr = new TableRow();
                for (int j = 0; j < c; j++)
                {
                    TableCell tc = new TableCell();
                    
                    String choice=RadioButtonList1.SelectedValue.ToString();

                    if (choice == "TextBox") {
                        TextBox textBox = new TextBox();
                        textBox.Text="Row"+i+"Col"+j;
                        tc.Controls.Add(textBox);
                    }
                    else if (choice == "HyperLink")
                    {
                        HyperLink hp = new HyperLink();
                        hp.Text = "Row" + i + "Col" + j;
                        tc.Controls.Add(hp);
                    }
                    else if (choice == "LinkButton") {
                        LinkButton linkButton = new LinkButton();
                        linkButton.Text = "Row" + i + "Col" + j;
                        tc.Controls.Add(linkButton);
                    }
                    tr.Controls.Add(tc);
                }t.Controls.Add(tr);
            }
            PlaceHolder1.Controls.Add(t);

        }
    }
}