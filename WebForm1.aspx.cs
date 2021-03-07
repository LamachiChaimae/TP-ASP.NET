using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
               int i = Convert.ToInt32(TextBox2.Text);//indice de depart
               int L = Convert.ToInt32(TextBox3.Text);//longueur de l'indice
               string nom = TextBox1.Text;
               string morceau = nom.Substring(i, L);
            
               Label2.Text = "bonjour la partie de nomest :" + morceau;
            }catch(Exception ex)
            {
                Response.Write("erreure" + ex.Message);
            }
            

                
        }
    }
}