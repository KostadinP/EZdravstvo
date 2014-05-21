using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Imaging;

public partial class Najava : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void Submit_Click(object sender, EventArgs e)
    {
        if (this.CodeTxt.Text == this.Session["CaptchaImageText"].ToString())
        {

        }
        else
        {
            
            Response.Redirect("~/Najava.aspx");
        }
        this.CodeTxt.Text = "";
    }
}