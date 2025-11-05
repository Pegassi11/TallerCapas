using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapasDatos
{
 public class CDEstadoCuenta
 {
 private string CadenaConexion = "Server=localhost\\SQLEXPRESS;Database=DB_Clientes;Integrated Security=True;Encrypt=False;";

 public DataTable ObtenerEstadoCuentaTable(int idCliente, DateTime desde, DateTime hasta)
 {
 using var sqlConnection = new SqlConnection(CadenaConexion);
 using var cmd = new SqlCommand("dbo.sp_EstadoCuentaCliente", sqlConnection)
 {
 CommandType = CommandType.StoredProcedure
 };

 cmd.Parameters.Add(new SqlParameter("@pIdCliente", SqlDbType.Int) { Value = idCliente });
 cmd.Parameters.Add(new SqlParameter("@pDesde", SqlDbType.Date) { Value = desde.Date });
 cmd.Parameters.Add(new SqlParameter("@pHasta", SqlDbType.Date) { Value = hasta.Date });

 using var da = new SqlDataAdapter(cmd);
 var dt = new DataTable();

 da.Fill(dt);

 // Normalizar nombres de columnas esperados por la capa de presentación
 // Algunos nombres pueden variar según el SELECT del stored procedure
 if (dt.Columns.Contains("idtransacciones") && !dt.Columns.Contains("idtrans"))
 {
 var col = dt.Columns["idtransacciones"];
 if (col != null)
 col.ColumnName = "idtrans";
 }
 if (dt.Columns.Contains("idtrans") && !dt.Columns.Contains("IdTransacciones"))
 {
 // opcional: mantener minúscula "idtrans" para consistencia
 }

 if (dt.Columns.Contains("fecha") && !dt.Columns.Contains("Fecha"))
 {
 var col = dt.Columns["fecha"];
 if (col != null)
 col.ColumnName = "Fecha";
 }

 if (dt.Columns.Contains("debe") && !dt.Columns.Contains("Debe"))
 {
 var col = dt.Columns["debe"];
 if (col != null)
 col.ColumnName = "Debe";
 }

 if (dt.Columns.Contains("haber") && !dt.Columns.Contains("Haber"))
 {
 var col = dt.Columns["haber"];
 if (col != null)
 col.ColumnName = "Haber";
 }

 if (dt.Columns.Contains("saldo") && !dt.Columns.Contains("Saldo"))
 {
 var col = dt.Columns["saldo"];
 if (col != null)
 col.ColumnName = "Saldo";
 }

 return dt;
 }
 }
}