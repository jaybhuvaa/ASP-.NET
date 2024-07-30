using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WT_LAB_4
{
    public partial class registrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initial dropdown population if needed
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = DropDownList1.SelectedValue;
            DropDownList2.Items.Clear();
            DropDownList3.Items.Clear();

            if (country == "India")
            {
                DropDownList2.Items.Add("Select State");
                DropDownList2.Items.Add("Rajasthan");
                DropDownList2.Items.Add("Maharashtra");
            }
            else if (country == "USA")
            {
                DropDownList2.Items.Add("Select State");
                DropDownList2.Items.Add("California");
                DropDownList2.Items.Add("Texas");
                DropDownList2.Items.Add("Georgia");
            }

            DropDownList2_SelectedIndexChanged(sender, e);
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string state = DropDownList2.SelectedValue;
            DropDownList3.Items.Clear();

            if (state == "Rajasthan")
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("Select City");
                DropDownList3.Items.Add("Jaipur");
                DropDownList3.Items.Add("Jodhpur");
                DropDownList3.Items.Add("Udaipur");
            }
            else if (state == "Maharashtra")
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("Select City");
                DropDownList3.Items.Add("Mumbai");
                DropDownList3.Items.Add("Pune");
                DropDownList3.Items.Add("Nagpur");
            }
            else if (state == "California")
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("Select City");
                DropDownList3.Items.Add("Los Angeles");
                DropDownList3.Items.Add("San Francisco");
                DropDownList3.Items.Add("San Diego");
            }
            else if (state == "Texas")
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("Select City");
                DropDownList3.Items.Add("Austin");
                DropDownList3.Items.Add("Dallas");
                DropDownList3.Items.Add("Houston");
            }
            else if (state == "Georgia")
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("Select City");
                DropDownList3.Items.Add("Atlanta");
                DropDownList3.Items.Add("Savannah");
                DropDownList3.Items.Add("Augusta");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                bool isCertificateSelected = CheckBoxList1.Items.Cast<ListItem>().Any(item => item.Selected);
                if (!isCertificateSelected)
                {
                    CheckBoxListValidator.Text = "Please select at least one certificate";
                }
                else
                {
                    CheckBoxListValidator.Text = string.Empty;
                    Label1.Text = "You have been registered successfully!";
                }
            }
        }
    }
}
