using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase09
{
    public partial class EjemploCookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["colorFondo"];
                if (cookie != null)
                {
                    string color = cookie.Value;
                    form1.Style["background-color"] = color;
                    cuerpo.Style["background-color"] = color;
                    DropDownList1.SelectedValue = color;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string colorSeleccionado = DropDownList1.SelectedValue;

            // Crear cookie desde C#
            HttpCookie cookie = new HttpCookie("colorFondo", colorSeleccionado);
            cookie.Expires = DateTime.Now.AddDays(7); // dura 7 días
            Response.Cookies.Add(cookie);

            cuerpo.Style["background-color"] = colorSeleccionado;
            form1.Style["background-color"] = colorSeleccionado;
        }
    }
}