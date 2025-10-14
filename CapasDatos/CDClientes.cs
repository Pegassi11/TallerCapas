using CapasEntidad;
using MySql.Data.MySqlClient;

namespace CapasDatos
{
    public class CDCliente
    {
        // Esta es la variable global
        String CadenaConexion = "Server=localhost;Database=DB_Clientes;User=root;Password=;";

        public void Crear(CEClientes cE)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "INSERT INTO Clientes (idClientes, nombreApellido, cedCliente, cgtCliente, fechaCrea, montoTotal, fotoCliente, numLote) value ('" + cE.IdClientes + "', '" + cE.nombreComp + "', '" + cE.cedCliente + "','" + cE.ctgCliente + "', '" + cE.fechaCrea + "', '" + cE.montoTotal + "','" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(cE.fotoCliente) + "','" + cE.numLote + "')";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            MessageBox.Show("El registro a sido creado");
        }

    }
}
