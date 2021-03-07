using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string couleur = "";

            if (RadioButton1.Checked == true)
            {
                couleur = "rouge";
                Panel1.BackColor = Color.Red;
            }
            if (RadioButton2.Checked == true)
            {
                couleur = "blue";
                Panel1.BackColor = Color.Blue;
            }
            if (RadioButton3.Checked == true)
            {
                couleur = "vert";
                Panel1.BackColor = Color.Green;
            }
            if (RadioButton1.Checked == false && RadioButton2.Checked == false && RadioButton3.Checked == false)
            {
                Response.Write("Veuillez cocher une couleur");
            }
            else
            {
                Response.Write("couleur=" + couleur);
            }

            
        }
    }
}