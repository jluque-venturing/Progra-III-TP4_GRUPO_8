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

                CargarProvincias(ddlProvinciaInicio, dt);
                CargarProvincias(ddlProvinciaFinal, dt);

                PonerSeleccionar(ddlLocalidadInicio);
                PonerSeleccionar(ddlLocalidadFinal);
            }
        }

        void PonerSeleccionar(DropDownList ddl)
        {
            ddl.Items.Clear();
            ddl.Items.Add(new ListItem("--Seleccionar--", ""));
        }

        void CargarProvincias(DropDownList ddl, DataTable dt)
        {
            ddl.Items.Clear();
            ddl.DataSource = dt;
            ddl.DataTextField = "NombreProvincia";
            ddl.DataValueField = "IdProvincia";
            ddl.DataBind();

            ddl.Items.Insert(0, new ListItem("--Seleccionar--", ""));
            ddl.SelectedIndex = 0;
        }

        bool CargarProvinciasPreservando(DropDownList ddl, DataTable dt, string valorAPreservar)
        {
            CargarProvincias(ddl, dt);

            ListItem item = ddl.Items.FindByValue(valorAPreservar);
            if (item == null) return false;

            ddl.SelectedValue = valorAPreservar;
            return true;
        }


        protected void ddlProvinciaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosViajes datos = new DatosViajes();
            string provinciaFinalPrevia = ddlProvinciaFinal.SelectedValue;
            bool seMantuvoProvinciaFinal;

            if (ddlProvinciaInicio.SelectedValue != "")
            {
                int idProvinciaInicio = int.Parse(ddlProvinciaInicio.SelectedValue);

                DataTable dtLocalidades = datos.TraerLocalidades(idProvinciaInicio);
                ddlLocalidadInicio.Items.Clear();
                ddlLocalidadInicio.DataSource = dtLocalidades;
                ddlLocalidadInicio.DataTextField = "NombreLocalidad";
                ddlLocalidadInicio.DataValueField = "IdLocalidad";
                ddlLocalidadInicio.DataBind();

                DataTable dtProvincias = datos.TraerProvinciasExcepto(idProvinciaInicio);
                seMantuvoProvinciaFinal = CargarProvinciasPreservando(ddlProvinciaFinal, dtProvincias, provinciaFinalPrevia);
            }
            else
            {
                PonerSeleccionar(ddlLocalidadInicio);

                DataTable dtProvincias = datos.TraerProvincias();
                seMantuvoProvinciaFinal = CargarProvinciasPreservando(ddlProvinciaFinal, dtProvincias, provinciaFinalPrevia);
            }

            if (!seMantuvoProvinciaFinal) PonerSeleccionar(ddlLocalidadFinal);
        }
        protected void ddlProvinciaFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosViajes datos = new DatosViajes();
            string provinciaInicioPrevia = ddlProvinciaInicio.SelectedValue;
            bool seMantuvoProvinciaInicio;

            if (ddlProvinciaFinal.SelectedValue != "")
            {
                int idProvinciaFinal = int.Parse(ddlProvinciaFinal.SelectedValue);

                DataTable dtLocalidades = datos.TraerLocalidades(idProvinciaFinal);
                ddlLocalidadFinal.Items.Clear();
                ddlLocalidadFinal.DataSource = dtLocalidades;
                ddlLocalidadFinal.DataTextField = "NombreLocalidad";
                ddlLocalidadFinal.DataValueField = "IdLocalidad";
                ddlLocalidadFinal.DataBind();

                DataTable dtProvincias = datos.TraerProvinciasExcepto(idProvinciaFinal);
                seMantuvoProvinciaInicio = CargarProvinciasPreservando(ddlProvinciaInicio, dtProvincias, provinciaInicioPrevia);
            }
            else
            {
                PonerSeleccionar(ddlLocalidadFinal);

                DataTable dtProvincias = datos.TraerProvincias();
                seMantuvoProvinciaInicio = CargarProvinciasPreservando(ddlProvinciaInicio, dtProvincias, provinciaInicioPrevia);
            }

            if (!seMantuvoProvinciaInicio) PonerSeleccionar(ddlLocalidadInicio);
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