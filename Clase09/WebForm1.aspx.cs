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
            //lectura de cookie
                HttpCookie cookie = Request.Cookies["email"];
                string valorLabel = cookie != null ? $"{cookie.Value}" : "Sin valor";
                Label1.Text = valorLabel;
            //lectura de Session
            if (this.Session["nombreVariable"] != null)
            {
                Label2.Text = Session["nombreVariable"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Cookie Sesion
            HttpCookie cookie1 = new HttpCookie("nombreCookie", "valorCookie");
            Response.Cookies.Add(cookie1);

            if (TextBox1.Text != string.Empty)
            {
                //Cookie con fecha expiracion
                HttpCookie cookie2 = new HttpCookie("email", TextBox1.Text);
                int segundos = int.Parse(TextBox3.Text != "" ? TextBox3.Text: "0")   ;
                DateTime exp = DateTime.Now.AddSeconds(segundos);
                cookie2.Expires = exp;
                Response.Cookies.Add(cookie2);
            }
            Response.Redirect(Request.RawUrl);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Session - por defecto 20 minutos de inactividad
            this.Session["nombreVariable"] = TextBox2.Text;
            Response.Redirect(Request.RawUrl);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session.Remove("nombreVariable");
        }
    }
}