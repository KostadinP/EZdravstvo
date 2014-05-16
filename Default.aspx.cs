using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GlavnaStranica : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string[] listaNaBoi = Enum.GetNames(typeof(System.Drawing.KnownColor));
            ddlPozadina.DataSource = listaNaBoi;
            ddlPozadina.DataBind();
            ddlFont.DataSource = listaNaBoi;
            ddlFont.DataBind();
            lblKorisnik.Text =(string) Session["korisnik"];
            if (Request.Cookies[lblKorisnik.Text] != null)
            {
                HttpCookie cookie = Request.Cookies[lblKorisnik.Text];
                ddlPozadina.SelectedIndex = Convert.ToInt32(cookie["Pozadina"]);
                ddlFont.SelectedIndex = Convert.ToInt32(cookie["Font"]);
                pnlPanela.BackColor = Color.FromName(ddlPozadina.SelectedItem.Text);
                lblPoraka.ForeColor = Color.FromName(ddlFont.SelectedItem.Text);
                lblPoraka.Text = "Креирано е колаче";
            }
            else
            {
                lblPoraka.Text = lblKorisnik.Text + ", ова е твоја прва посета на страницата. Избери боја на позадина и фонт," +
                  "a потоа кликни зачувај за да се зачува твојот избор на бои.";
            }
        }

        lblKorisnici.Text = Application.Count.ToString();
        foreach (string s in Application.Keys)
            lblKorisnici.Text +=", "+s;  
    }
    protected void ddlPozadina_SelectedIndexChanged(object sender, EventArgs e)
    {
        pnlPanela.BackColor = Color.FromName(ddlPozadina.SelectedItem.Text);
    }
    protected void ddlFont_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblPoraka.ForeColor = Color.FromName(ddlFont.SelectedItem.Text);
    }
    protected void btnOdjava_Click(object sender, EventArgs e)
    {
        Application.Contents.Remove(lblKorisnik.Text);
        Response.Redirect("Odjava.aspx?SessionID=" + Session.SessionID);
    }
    protected void btnZacuvaj_Click(object sender, EventArgs e)
    {
        HttpCookie cookie = new HttpCookie(lblKorisnik.Text); ;
        cookie["Pozadina"] = ddlPozadina.SelectedIndex.ToString();
        cookie["Font"] = ddlFont.SelectedIndex.ToString();
        cookie["log"] = DateTime.Now.ToString();
        cookie.Expires = DateTime.Now.AddMinutes(5);
        Response.Cookies.Add(cookie);
        lblPoraka.Text = "Креирано е колаче";
    }
}