using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapasDatos
{
    public class CDCategorias
    {
        // Reutiliza la misma cadena de conexión
        String CadenaConexion = "Server=localhost\\SQLEXPRESS;Database=DB_Clientes;Integrated Security=True;Encrypt=False;";

        public DataSet lista()
        {
            SqlConnection sqlConnection = new SqlConnection(CadenaConexion);
            sqlConnection.Open();
            string Query = "SELECT idCategoria, descCat FROM Categorias WHERE activo = 1";
            SqlDataAdapter Adaptador = new SqlDataAdapter(Query, sqlConnection);
            DataSet dataSet = new DataSet();
            Adaptador.Fill(dataSet, "categorias");
            return dataSet;
        }
    }
}
