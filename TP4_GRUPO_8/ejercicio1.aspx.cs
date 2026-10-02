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
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {

                DatosViajes datos = new DatosViajes();

                DataTable dt = datos.TraerProvincias();

                ddlProvinciaInicio.DataSource = dt;
                ddlProvinciaInicio.DataTextField = "NombreProvincia";
                ddlProvinciaInicio.DataValueField = "IdProvincia";
                ddlProvinciaInicio.DataBind();

                PonerSeleccionar(ddlProvinciaInicio);
                PonerSeleccionar(ddlLocalidadInicio);
                PonerSeleccionar(ddlProvinciaFinal);
                PonerSeleccionar(ddlLocalidadFinal);
            }
        }

        void PonerSeleccionar(DropDownList ddl)
        {
            ddl.Items.Add(new ListItem("--Seleccionar--", ""));
        }


        protected void ddlProvinciaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlLocalidadInicio.Items.Clear();
            ddlProvinciaFinal.Items.Clear();
            ddlLocalidadFinal.Items.Clear();


            if (ddlProvinciaInicio.SelectedValue != "")
            {
                DatosViajes datos = new DatosViajes();
                int idProvinciaInicio = int.Parse(ddlProvinciaInicio.SelectedValue);

                DataTable dtInicio = datos.TraerLocalidades(idProvinciaInicio);
                ddlLocalidadInicio.DataSource = dtInicio;
                ddlLocalidadInicio.DataTextField = "NombreLocalidad";
                ddlLocalidadInicio.DataValueField = "IdLocalidad";
                ddlLocalidadInicio.DataBind();

                DataTable dtProvincias = datos.TraerProvinciasExcepto(idProvinciaInicio);
                ddlProvinciaFinal.DataSource = dtProvincias;
                ddlProvinciaFinal.DataTextField = "NombreProvincia";
                ddlProvinciaFinal.DataValueField = "IdProvincia";
                ddlProvinciaFinal.DataBind();

                PonerSeleccionar(ddlProvinciaFinal);
                PonerSeleccionar(ddlLocalidadFinal);
            }
            else
            {

                PonerSeleccionar(ddlLocalidadInicio);
                PonerSeleccionar(ddlProvinciaFinal);
                PonerSeleccionar(ddlLocalidadFinal);
            }
        }
        protected void ddlProvinciaFinal_SelectedIndexChanged(object sender, EventArgs e)
        {

            ddlLocalidadFinal.Items.Clear();

            if (ddlProvinciaFinal.SelectedValue != "")
            {
                DatosViajes datos = new DatosViajes();


                int idProvinciaFinal = int.Parse(ddlProvinciaFinal.SelectedValue);

                DataTable dtFinal = datos.TraerLocalidades(idProvinciaFinal);

                ddlLocalidadFinal.DataSource = dtFinal;
                ddlLocalidadFinal.DataTextField = "NombreLocalidad";
                ddlLocalidadFinal.DataValueField = "IdLocalidad";
                ddlLocalidadFinal.DataBind();

            }
            else
            {
                PonerSeleccionar(ddlLocalidadFinal);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
 
                if (!Page.IsValid) return;

        
                string locInicio = ddlLocalidadInicio.SelectedItem.Text;
                string provInicio = ddlProvinciaInicio.SelectedItem.Text;
                string locFinal = ddlLocalidadFinal.SelectedItem.Text;
                string provFinal = ddlProvinciaFinal.SelectedItem.Text;


            lblviaje.Text = "Viaje de " + locInicio + " (" + provInicio + ") a " + locFinal + " (" + provFinal + ")";
            
        }
    }
}