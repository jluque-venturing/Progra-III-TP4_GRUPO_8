using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP4_GRUPO_8
{
    public class DatosNeptuno
    {
        private const string rutaNeptunoSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security = True";

        public DataTable TraerProductos()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = new SqlConnection(rutaNeptunoSQL))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Productos", conexion);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                adaptador.Fill(dt);
            }

            return dt;
        }
    }
}