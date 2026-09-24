using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_GRUPO_8
{
    public partial class ejersicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PonerSeleccionar(ddlProvinciaInicio);
                PonerSeleccionar(ddlLocalidadInicio);
                PonerSeleccionar(ddlProvinciaFinal);
                PonerSeleccionar(ddlLocalidadFinal);

                DatosViajes datos = new DatosViajes();

                DataTable dt = datos.TraerProvincias();

                ddlProvinciaInicio.DataSource = dt;
                ddlProvinciaInicio.DataTextField = "NombreProvincia";
                ddlProvinciaInicio.DataValueField = "IdProvincia";
                ddlProvinciaInicio.DataBind();

            }
        }

        void PonerSeleccionar(DropDownList ddl)
        {
            ddl.Items.Add(new ListItem("--Seleccionar--", ""));
        }
    }
}