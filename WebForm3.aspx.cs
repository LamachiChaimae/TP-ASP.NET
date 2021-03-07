using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            testChangeCouleur();
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            testChangeCouleur();
        }
        public void testChangeCouleur()
        {
            if (RadioButtonList1.SelectedIndex == 0)
            {
                Panel1.BackColor = Color.Red;
            }
            if (RadioButtonList1.SelectedIndex == 1)
            {
                Panel1.BackColor = Color.Blue;
            }
            if (RadioButtonList1.SelectedIndex == 2)
            {
                Panel1.BackColor = Color.Green;
            }
        }
    }
}