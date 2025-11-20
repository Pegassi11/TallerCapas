using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapasNegocio;
using System.IO;
using Microsoft.Reporting.NETCore;
using Microsoft.Web.WebView2.WinForms;

namespace CapaPresentacion
{
    public partial class frmEstadoCuenta : Form
    {
        public frmEstadoCuenta()
        {
            InitializeComponent();
        }

        private CNCliente cNCliente = new CNCliente();
        private CNEstadoCuenta cNEstadoCuenta = new CNEstadoCuenta();

        private void frmEstadoCuenta_Load(object sender, EventArgs e)
        {
            try
            {                DataSet? dsClientes = cNCliente.obtenerDatos();
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
                DateTime fechaDesde = dtFecha.Value;
                DateTime fechaHasta = dtFechaFin.Value;

                DataTable dt = cNEstadoCuenta.obtenerDatos(idCliente, fechaDesde, fechaHasta);

                dgvReporte.DataSource = dt;

                // Calcular saldo y colorear filas para que ambos formularios hagan lo mismo
                decimal saldo =0m;

                // Si el DataTable incluye una columna 'Saldo' asumimos que el procedimiento ya calculó el saldo
                if (dt.Columns.Contains("Saldo"))
                {
                    if (dt.Rows.Count >0)
                    {
                        var lastVal = dt.Rows[dt.Rows.Count -1]["Saldo"];
                        if (lastVal != DBNull.Value)
                        {
                            Decimal.TryParse(lastVal.ToString(), out saldo);
                        }
                    }
                }
                else if (dt.Columns.Contains("Debe") || dt.Columns.Contains("Haber"))
                {
                    // Si existen columnas Debe/Haber, calcular saldo = SUM(Debe) - SUM(Haber)
                    decimal sumDebe =0m;
                    decimal sumHaber =0m;
                    foreach (DataRow r in dt.Rows)
                    {
                        if (dt.Columns.Contains("Debe") && r["Debe"] != DBNull.Value)
                        {
                            if (Decimal.TryParse(r["Debe"].ToString(), out var d))
                            {
                                sumDebe += d;
                            }
                            }
                        if (dt.Columns.Contains("Haber") && r["Haber"] != DBNull.Value)
                        {
                            if (Decimal.TryParse(r["Haber"].ToString(), out var h))
                            {
                                sumHaber += h;
                            }
                        }
                    }
                    saldo = sumDebe - sumHaber;
                }
                else if (dt.Columns.Contains("Monto"))
                {
                    // Sumar la columna Monto (fuerza bruta)
                    for (int i =0; i < dt.Rows.Count; i++)
                    {
                        var cell = dt.Rows[i]["Monto"];
                        if (cell == null || cell == DBNull.Value) continue;

                        decimal monto =0m;
                        Decimal.TryParse(cell.ToString(), out monto);
                        saldo += monto;
                    }
                }
                else
                {
                    // Intento genérico: sumar la primera columna númerica que encuentre
                    foreach (DataColumn col in dt.Columns)
                    {
                        if (col.DataType == typeof(decimal) || col.DataType == typeof(double) || col.DataType == typeof(float) || col.DataType == typeof(int))
                        {
                            decimal temp =0m;
                            for (int i =0; i < dt.Rows.Count; i++)
                            {
                                var cell = dt.Rows[i][col.ColumnName];
                                if (cell == null || cell == DBNull.Value) continue;
                                Decimal.TryParse(cell.ToString(), out var v);
                                temp += v;
                            }
                            saldo = temp;
                            break;
                        }
                    }
                }

                // Colorear filas en el DataGridView según la columna disponible (preferir Monto, luego Debe/Haber)
                for (int i =0; i < dgvReporte.Rows.Count; i++)
                {
                    decimal monto =0m;
                    DataGridViewRow row = dgvReporte.Rows[i];

                    if (dgvReporte.Columns.Contains("Monto") && row.Cells["Monto"].Value != null && row.Cells["Monto"].Value != DBNull.Value)
                    {
                        Decimal.TryParse(row.Cells["Monto"].Value.ToString(), out monto);
                    }
                    else if (dgvReporte.Columns.Contains("Debe") || dgvReporte.Columns.Contains("Haber"))
                    {
                        decimal d =0m, h =0m;
                        if (dgvReporte.Columns.Contains("Debe") && row.Cells["Debe"].Value != null && row.Cells["Debe"].Value != DBNull.Value)
                            Decimal.TryParse(row.Cells["Debe"].Value.ToString(), out d);
                        if (dgvReporte.Columns.Contains("Haber") && row.Cells["Haber"].Value != null && row.Cells["Haber"].Value != DBNull.Value)
                            Decimal.TryParse(row.Cells["Haber"].Value.ToString(), out h);
                        monto = d - h; // para determinar color
                    }

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

                // Mostrar saldo
                label4.Text = "Saldo Final:"; // asegurar etiqueta descriptiva
                lblSaldo.Text = saldo.ToString("N2");
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

                    // Llamada al método modificado
                    MostrarPdf(rutaDestino);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al renderizar o guardar el PDF: " + ex.Message);
                }
            }
        }

        // --- MÉTODO MODIFICADO: Abre el PDF en una ventana nueva ---
        private void MostrarPdf(string rutaPdf)
        {
            try
            {
                // 1. Crear un formulario temporal para alojar el visor
                Form formularioVisor = new Form();
                formularioVisor.Text = "Vista Previa del Reporte";
                formularioVisor.Size = new Size(1000, 800);
                formularioVisor.StartPosition = FormStartPosition.CenterScreen;

                // 2. Configurar el control WebView2
                var webView = new WebView2();
                webView.Dock = DockStyle.Fill;

                // 3. Agregar el visor al nuevo formulario
                formularioVisor.Controls.Add(webView);

                // 4. Mostrar el formulario inmediatamente (sin bloquear el anterior)
                formularioVisor.Show();

                // 5. Cargar el PDF
                webView.EnsureCoreWebView2Async().ContinueWith(task =>
                {
                    if (task.Exception == null)
                    {
                        // Usar Invoke porque estamos interactuando con la UI desde otro hilo
                        formularioVisor.Invoke((MethodInvoker)delegate
                        {
                            webView.Source = new Uri(rutaPdf);
                        });
                    }
                    else
                    {
                        MessageBox.Show("Error al inicializar el visor PDF: " + task.Exception.Message);
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