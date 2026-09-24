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
                LimpiarFiltros();
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

        void LimpiarFiltros()
        {
            txtIdProducto.Text = string.Empty;
            ddlOpProducto.SelectedIndex = 0;
            ddlOpCategoria.SelectedIndex = 0;
        }
    }
}
