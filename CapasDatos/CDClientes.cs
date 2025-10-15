using System.Data;
using CapasEntidad;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace CapasDatos
{
    public class CDCliente
    {
        String CadenaConexion = "Server=localhost\\SQLEXPRESS;Database=DB_Clientes;Integrated Security=True;Encrypt=False;";

        public void Crear(CEClientes cE)
        {
            SqlConnection sqlConnection = new SqlConnection(CadenaConexion);
            sqlConnection.Open();

            // --- CORRECCIÓN FINAL ---
            string Query = "INSERT INTO Clientes (IdClientes, NombreComp, CedCliente, CtgCliente, FotoCliente, MontoTotal) " +
                           "VALUES ('" + cE.IdClientes + "', '" + cE.nombreComp + "', '" + cE.cedCliente + "','" + cE.ctgCliente + "','" + cE.fotoCliente + "', '" + cE.montoTotal + "')";

            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("El registro ha sido creado");
        }

        public DataSet lista()
        {
            SqlConnection sqlConnection = new SqlConnection(CadenaConexion);
            sqlConnection.Open();
            // Para mayor precisión, se usan los nombres exactos de las columnas de la BD
            string Query = "SELECT IdClientes, NombreComp, CedCliente, CtgCliente, FotoCliente, MontoTotal FROM Clientes";
            SqlDataAdapter Adaptador;
            DataSet dataSet = new DataSet();
            Adaptador = new SqlDataAdapter(Query, sqlConnection);
            Adaptador.Fill(dataSet, "clientes");
            return dataSet;
        }
    }
}