using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase09
{
    public partial class EjemploSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarGrilla();
        }
        private void llenarGrilla()
        {
            List<string> carrito = (List<string>)Session["carrito"];
            GridView1.DataSource = carrito;
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> carrito = new List<string>();
            if (Session["carrito"] != null)
                carrito = (List<string>)Session["carrito"];

            carrito.Add(TextBox1.Text);
            Session["carrito"] = carrito;
            llenarGrilla();
        }
    }
}