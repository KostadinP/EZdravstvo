using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Najava : System.Web.UI.Page
{
    private int counter;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            counter = (int)ViewState["Counter"];
        }
    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        ViewState["Counter"] = counter;
    }
    protected void ptnPodnesi_Click(object sender, EventArgs e)
    {
        if (tbLozinka.Text == "mp")
        {
            Session["korisnik"] = tbKorisnik.Text;
            Application[tbKorisnik.Text] = "";
            Response.Redirect("GlavnaStranica.aspx");   
        }
        else
        {
            if (counter < 3)
            {
                counter++;
                lblObidi.Text = counter.ToString();
            }
            else
            {
                btnPodnesi.Enabled = false;
                lblObidi.Text = "Го надминавте бројот на обиди за најава!\nНе ви е дозволено да се најавите.";
            }
        }
    }
}