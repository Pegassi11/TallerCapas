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

            string Query = "INSERT INTO Clientes (IdClientes, NombreComp, CedCliente, CtgCliente, FotoCliente, MontoTotal, Correo, Genero, Interes1, Interes2, Interes3) " +
                   "VALUES ('" + cE.IdClientes + "', '" + cE.nombreComp + "', '" + cE.cedCliente + "','" + cE.ctgCliente + "','" + cE.fotoCliente + "', '" + cE.montoTotal + "', '" + cE.Correo + "', '" + cE.Genero + "', '" + (cE.Interes1 ? 1 : 0) + "', '" + (cE.Interes2 ? 1 : 0) + "', '" + (cE.Interes3 ? 1 : 0) + "')";

            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("El registro ha sido creado");
        }

        public DataSet lista()
        {
            SqlConnection sqlConnection = new SqlConnection(CadenaConexion);
            sqlConnection.Open();
            string Query = "SELECT IdClientes, NombreComp, CedCliente, CtgCliente, FotoCliente, MontoTotal, Correo, Genero, Interes1, Interes2, Interes3 FROM Clientes";
            SqlDataAdapter Adaptador;
            DataSet dataSet = new DataSet();
            Adaptador = new SqlDataAdapter(Query, sqlConnection);
            Adaptador.Fill(dataSet, "clientes");
            return dataSet;
        }
        public void Actualizar(CEClientes cE)
        {
            SqlConnection sqlConnection = new SqlConnection(CadenaConexion);
            sqlConnection.Open();

            // La consulta UPDATE modifica un registro existente.
            // SET especifica qué columnas cambiar.
            // WHERE es crucial: especifica CUÁL registro cambiar.
            string Query = "UPDATE Clientes SET " +
                           "NombreComp = '" + cE.nombreComp + "', " +
                           "CedCliente = '" + cE.cedCliente + "', " +
                           "CtgCliente = '" + cE.ctgCliente + "', " +
                           "FotoCliente = '" + cE.fotoCliente + "', " +
                           "MontoTotal = '" + cE.montoTotal + "', " +
                           "Correo = '" + cE.Correo + "', " +
                           "Genero = '" + cE.Genero + "', " +               
                           "Interes1 = '" + (cE.Interes1 ? 1 : 0) + "', " + 
                           "Interes2 = '" + (cE.Interes2 ? 1 : 0) + "', " + 
                           "Interes3 = '" + (cE.Interes3 ? 1 : 0) + "' " +
                           "WHERE IdClientes = '" + cE.IdClientes + "'";

            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            // Es una buena práctica cerrar la conexión, aunque no se pida.
            sqlConnection.Close();
        }
    }
}