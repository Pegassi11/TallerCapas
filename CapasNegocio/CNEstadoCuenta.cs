using System;
using System.Data;
using CapasDatos;

namespace CapasNegocio
{
 public class CNEstadoCuenta
 {
 private CDEstadoCuenta cdEstadoCuenta = new CDEstadoCuenta();

 public DataTable obtenerDatos(int idCliente, DateTime desde, DateTime hasta)
 {
 return cdEstadoCuenta.ObtenerEstadoCuentaTable(idCliente, desde, hasta);
 }

 // Nuevo método para devolver todo el DataSet maestro-detalle
 public DataSet obtenerDatosDataSet()
 {
 return cdEstadoCuenta.ObtenerEstadoCuentaDataSet();
 }
 }
}