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

        public DataTable TraerProductosFiltrados(string operadorProducto, int idProducto,
                                                 string operadorCategoria, int idCategoria)
        {
            DataTable dt = new DataTable();

            string consulta = "SELECT * FROM Productos WHERE 1=1 ";

            if (idProducto > 0)
            {
                consulta += "AND IdProducto " + operadorProducto + " @idProducto ";
            }

            if (idCategoria > 0)
            {
                consulta += "AND IdCategoría " + operadorCategoria + " @idCategoria ";
            }

            using (SqlConnection conexion = new SqlConnection(rutaNeptunoSQL))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);

                if (idProducto > 0)
                {
                    comando.Parameters.AddWithValue("@idProducto", idProducto);
                }

                if (idCategoria > 0)
                {
                    comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                }

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                adaptador.Fill(dt);
            }

            return dt;
        }
    }
}