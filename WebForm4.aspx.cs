using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (this.IsPostBack == false)
            {       //c est la1eme fois donc en remplis

                 //au demarage remplis dropdowlist
                    ListItem s = new ListItem("selectionnez", "0");
                    ListItem x = new ListItem("benimellel", "1");
                    ListItem y = new ListItem("casablanca", "2");
                    DropDownList1.Items.Add(s);
                    DropDownList1.Items.Add(x);
                    DropDownList1.Items.Add(y);
                    DropDownList1.Items.Add(new ListItem("agadir", "3"));
            }
            else
            {
                //entree 2eme fois 3eme fois a cause d un click sur button submit
                //a cause d un postback
                //radiobutton autopostback=true
                 //this.IsPostBack == true;
            }
            


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //verifier est ce que vous avez changer selectionnez
            if (DropDownList1.SelectedIndex == 0)
            {
                Response.Write("<h1>Veuillez choisir une vrai ville");
            }
            else
            {

                  // string ville = DropDownList1.Items[DropDownList1.SelectedIndex].Text;
                   string ville = DropDownList1.SelectedItem.Text;
                   string valueVille = DropDownList1.SelectedValue;
                   // string valueVille = DropDownList1.SelectedItem.Value;
                   Response.Write(ville + valueVille);
                   lblvilleSellectionez.Text = "nom de ville=" + ville + " , value option :" + valueVille;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            string globalchaine = "";
            for(i=0;i<=DropDownList1.Items.Count-1;i++)
            {
                string  vi=DropDownList1.Items[i].Text;
                string  va=DropDownList1.Items[i].Value;
                globalchaine += " <br/>ville" + vi + ",value=" + va;

            }
            Response.Write(globalchaine);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if(TextBox3.Text==""|| TextBox2.Text == "")
            {
                Response.Write("on peut pas ajouter ville on value vide");
            }
            else
            {
                ListItem nouvelleVille = new ListItem(TextBox3.Text, TextBox2.Text);
                DropDownList1.Items.Add(nouvelleVille);
            }
        }
    }
}