using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SES_1
{
    public partial class Q2b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar1.FirstDayOfWeek = FirstDayOfWeek.Tuesday;
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            DateTime eventd = new DateTime(2024, 8, 21);
            DateTime eventend=eventd.AddDays(5);

            if (e.Day.Date > eventd && e.Day.Date< eventend)
            {
                e.Cell.BackColor = System.Drawing.Color.Brown;
                e.Day.IsSelectable = false;
                
            }

            DateTime dateTime = new DateTime(2024, 8, 15);
            DateTime dateTime1 = new DateTime(2024, 8, 19);

            if (e.Day.Date == dateTime || e.Day.Date==dateTime1) { 
                e.Cell.BackColor = System.Drawing.Color.Chartreuse;
                e.Cell.Text= "Holiday";
            }

            if (e.Day.Date.ToString("dddd") == "Monday") { 
                e.Cell.BackColor = System.Drawing.Color.BlueViolet;
               
            }
        }
    }
}