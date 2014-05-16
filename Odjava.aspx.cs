using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Odjava : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ass
        string sID = Request.QueryString["SessionID"];
        lblIme.Text =(string) Session["korisnik"];
        lblSID.Text = sID;
    }
}