using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP4_GRUPO_8
{
    public class DatosLibreria
    {
        private string rutaLibreriaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security = True";
        public DataTable TraerTemas()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = new SqlConnection(rutaLibreriaSQL))
            {
                string consulta = "SELECT * FROM Temas";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }
    }
}