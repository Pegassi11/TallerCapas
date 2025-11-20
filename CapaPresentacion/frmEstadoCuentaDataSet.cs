using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapasNegocio;
using System.IO;
using Microsoft.Reporting.NETCore;
using Microsoft.Web.WebView2.WinForms;

namespace CapaPresentacion
{
 public partial class frmEstadoCuentaDataSet : Form
 {
 private CNEstadoCuenta cNEstadoCuenta = new CNEstadoCuenta();
 private CNCliente cNCliente = new CNCliente();

 public frmEstadoCuentaDataSet()
 {
 InitializeComponent();
 }

 private static T GetValueOrDefault<T>(DataRow r, string[] candidates, T defaultValue)
 {
 foreach (var name in candidates)
 {
 if (r.Table.Columns.Contains(name) && r[name] != DBNull.Value)
 {
 try
 {
 return (T)Convert.ChangeType(r[name], typeof(T));
 }
 catch { }
 }
 }
 return defaultValue;
 }

 private void frmEstadoCuentaDataSet_Load(object sender, EventArgs e)
 {
 try
 {
 // Cargar clientes en combo, igual que el formulario original
 DataSet? dsClientes = cNCliente.obtenerDatos();
 DataTable? dtClientes = dsClientes != null ? dsClientes.Tables["clientes"] : null;

 if (dtClientes != null)
 {
 cbxCliente.DataSource = dtClientes;
 cbxCliente.DisplayMember = "NombreComp";
 cbxCliente.ValueMember = "IdClientes";
 cbxCliente.SelectedIndex = -1;
 }
 }
 catch (Exception ex)
 {
 MessageBox.Show("Error al cargar clientes: " + ex.Message);
 }
 }

 private void btnAceptar_Click(object sender, EventArgs e)
 {
 try
 {
 if (cbxCliente.SelectedValue == null)
 {
 MessageBox.Show("Por favor seleccione un cliente.");
 return;
 }

 int idCliente = Convert.ToInt32(cbxCliente.SelectedValue);
 DateTime fechaDesde = dtFecha.Value.Date;
 DateTime fechaHasta = dtFechaFin.Value.Date;

 // Obtener el DataSet maestro-detalle
 DataSet ds = cNEstadoCuenta.obtenerDatosDataSet();
 if (ds == null || !ds.Tables.Contains("Transacciones"))
 {
 MessageBox.Show("No hay transacciones disponibles.");
 return;
 }

 DataTable dtTrans = ds.Tables["Transacciones"];

 // Construir lista robusta de transacciones leyendo columnas por nombres posibles
 var todas = new System.Collections.Generic.List<(int Id, DateTime Fecha, decimal Monto, string Tipo, int IdCliente)>();
 foreach (DataRow r in dtTrans.Rows)
 {
 int rowCliente = GetValueOrDefault<int>(r, new[] { "IdCliente", "idCliente", "IdClientes", "idclientes" },0);
 int idTrans = GetValueOrDefault<int>(r, new[] { "idtrans", "idtransacciones", "IdTrans" },0);
 DateTime fecha = GetValueOrDefault<DateTime>(r, new[] { "Fecha", "fecha" }, DateTime.MinValue);
 decimal monto = GetValueOrDefault<decimal>(r, new[] { "Monto", "monto", "montoTotal" },0m);
 string tipo = GetValueOrDefault<string>(r, new[] { "tipoTrans", "tipoTransaccion", "Tipo" }, string.Empty);

 // Añadir solo filas del cliente
 if (rowCliente == idCliente)
 {
 todas.Add((idTrans, fecha, monto, tipo ?? string.Empty, rowCliente));
 }
 }

 // calcular saldo inicial (antes de fechaDesde): creditos - debitos
 decimal totalCreditosAntes = todas.Where(t => t.Fecha < fechaDesde && string.Equals(t.Tipo, "CR", StringComparison.OrdinalIgnoreCase)).Sum(t => t.Monto);
 decimal totalDebitosAntes = todas.Where(t => t.Fecha < fechaDesde && string.Equals(t.Tipo, "DB", StringComparison.OrdinalIgnoreCase)).Sum(t => t.Monto);
 decimal saldoInicial = totalCreditosAntes - totalDebitosAntes;

 // transacciones en rango ordenadas
 var enRango = todas
 .Where(t => t.Fecha >= fechaDesde && t.Fecha <= fechaHasta)
 .OrderBy(t => t.Fecha)
 .ThenBy(t => t.Id)
 .ToList();

 // Preparar DataTable resultado con la misma estructura que el SP
 DataTable dtResultado = new DataTable();
 dtResultado.Columns.Add("idtrans", typeof(int));
 dtResultado.Columns.Add("Fecha", typeof(DateTime));
 dtResultado.Columns.Add("Debe", typeof(decimal));
 dtResultado.Columns.Add("Haber", typeof(decimal));
 dtResultado.Columns.Add("Saldo", typeof(decimal));

 // Fila inicial con saldo inicial
 DataRow filaInicial = dtResultado.NewRow();
 filaInicial["idtrans"] =0;
 filaInicial["Fecha"] = fechaDesde;
 filaInicial["Debe"] =0m;
 filaInicial["Haber"] =0m;
 filaInicial["Saldo"] = saldoInicial;
 dtResultado.Rows.Add(filaInicial);

 // Calcular saldo corrido
 decimal saldoCorriente = saldoInicial;
 foreach (var t in enRango)
 {
 decimal debe = string.Equals(t.Tipo, "DB", StringComparison.OrdinalIgnoreCase) ? t.Monto :0m;
 decimal haber = string.Equals(t.Tipo, "CR", StringComparison.OrdinalIgnoreCase) ? t.Monto :0m;
 saldoCorriente += (haber - debe);

 DataRow r = dtResultado.NewRow();
 r["idtrans"] = t.Id;
 r["Fecha"] = t.Fecha;
 r["Debe"] = debe;
 r["Haber"] = haber;
 r["Saldo"] = saldoCorriente;
 dtResultado.Rows.Add(r);
 }

 // Mostrar en el grid
 dgvReporte.DataSource = dtResultado;
 dgvReporte.Refresh();

 // Colorear filas según monto (usar abs(haber-debe) como referencia)
 for (int i =0; i < dgvReporte.Rows.Count; i++)
 {
 var row = dgvReporte.Rows[i];
 decimal monto =0m;
 if (row.Cells["Debe"].Value != DBNull.Value && Convert.ToDecimal(row.Cells["Debe"].Value) !=0m)
 monto = Convert.ToDecimal(row.Cells["Debe"].Value);
 else if (row.Cells["Haber"].Value != DBNull.Value && Convert.ToDecimal(row.Cells["Haber"].Value) !=0m)
 monto = Convert.ToDecimal(row.Cells["Haber"].Value);

 if (monto >25000m && monto <40000m)
 {
 row.DefaultCellStyle.BackColor = Color.GreenYellow;
 row.DefaultCellStyle.ForeColor = Color.DarkBlue;
 }
 else if (monto >40000m && monto <70000m)
 {
 row.DefaultCellStyle.BackColor = Color.Yellow;
 row.DefaultCellStyle.ForeColor = Color.DarkBlue;
 }
 else
 {
 row.DefaultCellStyle.BackColor = Color.White;
 row.DefaultCellStyle.ForeColor = Color.Black;
 }
 }

 // Mostrar saldo final
 lblSaldo.Text = saldoCorriente.ToString("N2");
 }
 catch (Exception ex)
 {
 MessageBox.Show("Error al consultar: " + ex.Message);
 }
 }

 private void btnImprimir_Click(object sender, EventArgs e)
 {
 try
 {
 if (cbxCliente.SelectedValue == null)
 {
 MessageBox.Show("Seleccione un cliente antes de imprimir.");
 return;
 }

 int idCliente = Convert.ToInt32(cbxCliente.SelectedValue);
 DateTime fechaDesde = dtFecha.Value;
 DateTime fechaHasta = dtFechaFin.Value;

 // Aquí reutilizamos el procedimiento original para el informe PDF
 DataTable dtDatos = cNEstadoCuenta.obtenerDatos(idCliente, fechaDesde, fechaHasta);

 if (dtDatos != null && dtDatos.Rows.Count >0)
 {
 GenerarReportePDF(dtDatos);
 }
 else
 {
 MessageBox.Show("No hay datos para generar el reporte en ese rango de fechas.");
 }
 }
 catch (Exception ex)
 {
 MessageBox.Show("Error al intentar imprimir: " + ex.Message);
 }
 }

 private void GenerarReportePDF(DataTable dtOrigen)
 {
 string rutaReporte = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", "ReporteSaldoClientes.rdlc");

 if (!File.Exists(rutaReporte))
 {
 MessageBox.Show("No se encuentra el archivo de diseño del reporte en:\n" + rutaReporte);
 return;
 }

 using (var report = new LocalReport())
 {
 report.ReportPath = rutaReporte;
 report.DataSources.Clear();
 report.DataSources.Add(new ReportDataSource("DataSet1", dtOrigen));

 try
 {
 byte[] pdfBytes = report.Render("PDF");

 string nombreArchivo = $"EstadoCuenta_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf";
 string rutaDestino = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nombreArchivo);

 File.WriteAllBytes(rutaDestino, pdfBytes);

 MostrarPdf(rutaDestino);
 }
 catch (Exception ex)
 {
 MessageBox.Show("Error al renderizar o guardar el PDF: " + ex.Message);
 }
 }
 }

 private void MostrarPdf(string rutaPdf)
 {
 try
 {
 Form formularioVisor = new Form();
 formularioVisor.Text = "Vista Previa del Reporte";
 formularioVisor.Size = new Size(1000,800);
 formularioVisor.StartPosition = FormStartPosition.CenterScreen;

 var webView = new WebView2();
 webView.Dock = DockStyle.Fill;

 formularioVisor.Controls.Add(webView);

 formularioVisor.Show();

 webView.EnsureCoreWebView2Async().ContinueWith(task =>
 {
 if (task.Exception == null)
 {
 formularioVisor.Invoke((MethodInvoker)delegate
 {
 webView.Source = new Uri(rutaPdf);
 });
 }
 else
 {
 MessageBox.Show("Errores al inicializar el visor PDF: " + task.Exception.Message);
 }
 });
 }
 catch (Exception ex)
 {
 MessageBox.Show("Error al intentar visualizar el PDF internamente: " + ex.Message);
 }
 }
 }
}
