using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_GRUPO_8
{
    public partial class ejercicio3_page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idTema = Request.QueryString["idTema"];


            if (!string.IsNullOrEmpty(idTema))
            {

                lblIdTema.Text = "Tema seleccionado: " + idTema;

                DatosLibreria datos = new DatosLibreria();
                grdLibros.DataSource = datos.TraerLibrosPorTema(Convert.ToInt32(idTema));
                grdLibros.DataBind();

                HyperLink1.NavigateUrl = "ejercicio3-page1.aspx?IdTema=" + idTema;
            }
            else
            {

                lblIdTema.Text = "No se eligió ningún tema";
                lblIdTema.ForeColor = System.Drawing.Color.Red; 


            }
        }
    }

}

