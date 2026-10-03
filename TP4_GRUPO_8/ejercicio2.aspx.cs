using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_GRUPO_8
{
    public partial class ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarOperadores();
                LimpiarTexto();
                CargarGrilla();
            }
        }

        void CargarOperadores()
        {
            // Para los operadores de comparación, se agregan los elementos al DropDownList correspondiente
            ddlOpProducto.Items.Add(new ListItem("Igual a:", "="));
            ddlOpProducto.Items.Add(new ListItem("Mayor a:", ">"));
            ddlOpProducto.Items.Add(new ListItem("Menor a:", "<"));

            ddlOpCategoria.Items.Add(new ListItem("Igual a:", "="));
            ddlOpCategoria.Items.Add(new ListItem("Mayor a:", ">"));
            ddlOpCategoria.Items.Add(new ListItem("Menor a:", "<"));
        }
        void LimpiarTexto ()
        {
           txtIdCategoria.Text = string.Empty;
           txtIdProducto.Text = string.Empty;

        }

        void LimpiarFiltros()
        {
            txtIdProducto.Text = string.Empty;
            ddlOpProducto.SelectedIndex = 0;
            ddlOpCategoria.SelectedIndex = 0;
        }
        void CargarGrilla()
        {
            DatosNeptuno datos = new DatosNeptuno();

            grdProductos.DataSource = datos.TraerProductos();
            grdProductos.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            int idProducto = 0;
            int idCategoria = 0;

            if (txtIdProducto.Text != "")
            {
                idProducto = int.Parse(txtIdProducto.Text);
            }

            if (txtIdCategoria.Text != "")
            {
                idCategoria = int.Parse(txtIdCategoria.Text);
            }

            string operadorProducto = ddlOpProducto.SelectedValue;
            string operadorCategoria = ddlOpCategoria.SelectedValue;

            DatosNeptuno datos = new DatosNeptuno();

            grdProductos.DataSource = datos.TraerProductosFiltrados(
                operadorProducto,
                idProducto,
                operadorCategoria,
                idCategoria);

            grdProductos.DataBind();
            LimpiarTexto();
        }

        protected void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
            CargarGrilla();
        }
    }
}
