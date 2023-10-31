using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase09
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                HttpCookie cookie = Request.Cookies["nombreCookie"];
                string valorLabel = cookie != null ? cookie.Value : "Sin valor";
                Label1.Text = valorLabel;
            if (this.Session["nombreVariable"] != null)
            {
                Label2.Text = Session["nombreVariable"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie1 = new HttpCookie("nombreCookie", "valorCookie");
            if(TextBox1.Text != string.Empty)
            {
                HttpCookie cookie2 = new HttpCookie("email", TextBox1.Text);
                DateTime exp = DateTime.Now.AddSeconds(2);
                cookie2.Expires = exp;
                Response.Cookies.Add(cookie2);
            }
            Response.Cookies.Add(cookie1);
            Response.Redirect(Request.RawUrl);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Session["nombreVariable"] = TextBox2.Text;
            Response.Redirect(Request.RawUrl);
        }
    }
}