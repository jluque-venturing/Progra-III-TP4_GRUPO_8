using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP4_GRUPO_8
{
    public class DatosViajes
    {
        private const string rutaViajesSQL =
@"Data Source=.\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True";

        public DataTable Consultar(string sql, SqlParameter[] parametros)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = new SqlConnection(rutaViajesSQL))
            {
                SqlCommand comando = new SqlCommand(sql, conexion);

                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros);
                }

                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable TraerProvincias()
        {
            string consulta = "SELECT * FROM Provincias";

            return Consultar(consulta, null);
        }
    }
}