using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SES_1
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public RadioButtonList rbq
        {
            get
            {
                return rb1;
            }
        }

        protected void rb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}