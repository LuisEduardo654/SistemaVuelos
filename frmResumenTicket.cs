using BarcodeLib;
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace Sistema_Vuelos
{
    public partial class frmResumenTicket : Form
    {
        private int idVuelo;
        private List<int> asientosIds;
        private decimal precioFinal;
        private ConexionDB db;

        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private List<BoletoInfo> boletosParaImprimir;

        private PrintDocument printDocumentCodigos;
        private PrintPreviewDialog printPreviewCodigos;

        /// <summary>
        /// Constructor del formulario de resumen de tickets
        /// </summary>
        /// <param name="vueloId">ID del vuelo seleccionado</param>
        /// <param name="asientosSeleccionados">Lista de IDs de asientos seleccionados</param>
        /// <param name="totalPrecio">Precio total de los boletos</param>
        public frmResumenTicket(int vueloId, List<int> asientosSeleccionados, decimal totalPrecio)
        {
            InitializeComponent();
            this.idVuelo = vueloId;
            this.asientosIds = asientosSeleccionados;
            this.precioFinal = totalPrecio;
            this.db = new ConexionDB();

            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocumentCodigos_PrintPage);
            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            printDocumentCodigos = new PrintDocument();
            printDocumentCodigos.PrintPage += printDocumentCodigos_PrintPage;
            printPreviewCodigos = new PrintPreviewDialog();
            printPreviewCodigos.Document = printDocumentCodigos;

            CargarResumen();
        }

        /// <summary>
        /// Carga el resumen de los boletos con información de vuelo, pasajeros y asientos
        /// </summary>
        private void CargarResumen()
        {
            DataTable dtVuelo = db.Consultar($"SELECT Origen, Destino, FechaSalida, HoraSalida, Precio FROM Vuelos WHERE IdVuelo = {idVuelo}");
            if (dtVuelo.Rows.Count > 0)
            {
                DataRow rowVuelo = dtVuelo.Rows[0];
                lblOrigenDestino.Text = $"Vuelo: {rowVuelo["Origen"]} a {rowVuelo["Destino"]}";
                lblFechaHora.Text = $"Fecha y Hora: {Convert.ToDateTime(rowVuelo["FechaSalida"]).ToShortDateString()} {rowVuelo["HoraSalida"]}";
            }

            flowLayoutPanelBoletos.Controls.Clear();
            boletosParaImprimir = new List<BoletoInfo>();

            foreach (int asientoId in asientosIds)
            {
                DataTable dtBoleto = db.Consultar($"SELECT IdBoleto, IdPasajero, CodigoBarras FROM Boletos WHERE IdVuelo = {idVuelo} AND IdAsiento = {asientoId}");
                if (dtBoleto.Rows.Count > 0)
                {
                    int idBoleto = Convert.ToInt32(dtBoleto.Rows[0]["IdBoleto"]);
                    int idPasajeroBoleto = Convert.ToInt32(dtBoleto.Rows[0]["IdPasajero"]);
                    string codigoBarrasNumero = dtBoleto.Rows[0]["CodigoBarras"].ToString();

                    DataTable dtAsiento = db.Consultar($"SELECT NumeroAsiento FROM Asientos WHERE IdAsiento = {asientoId}");
                    string numeroAsiento = dtAsiento.Rows.Count > 0 ? dtAsiento.Rows[0]["NumeroAsiento"].ToString() : "N/A";

                    DataTable dtPasajero = db.Consultar($"SELECT Nombre, Apellido FROM Pasajeros WHERE IdPasajero = {idPasajeroBoleto}");
                    string nombrePasajero = dtPasajero.Rows.Count > 0 ? dtPasajero.Rows[0]["Nombre"].ToString() : "Desconocido";
                    string apellidoPasajero = dtPasajero.Rows.Count > 0 ? dtPasajero.Rows[0]["Apellido"].ToString() : "";

                    boletosParaImprimir.Add(new BoletoInfo
                    {
                        IdBoleto = idBoleto,
                        NumeroAsiento = numeroAsiento,
                        NombrePasajero = nombrePasajero,
                        ApellidoPasajero = apellidoPasajero,
                        CodigoBarras = codigoBarrasNumero
                    });

                    // Creación de panel visual para cada boleto
                    Panel ticketPanel = new Panel();
                    ticketPanel.Width = flowLayoutPanelBoletos.ClientSize.Width - 25;
                    ticketPanel.AutoSize = true;
                    ticketPanel.Padding = new Padding(10);
                    ticketPanel.Margin = new Padding(0, 5, 0, 15);
                    ticketPanel.BorderStyle = BorderStyle.FixedSingle;
                    ticketPanel.BackColor = Color.FromArgb(40, 40, 40);

                    int currentY = 0;

                    Label lblBoletoInfo = new Label();
                    lblBoletoInfo.Text = $"Boleto para Asiento: {numeroAsiento}";
                    lblBoletoInfo.Location = new Point(0, currentY);
                    lblBoletoInfo.AutoSize = true;
                    lblBoletoInfo.Font = new Font(lblBoletoInfo.Font, FontStyle.Bold);
                    lblBoletoInfo.ForeColor = Color.Yellow;
                    ticketPanel.Controls.Add(lblBoletoInfo);
                    currentY += lblBoletoInfo.Height + 5;

                    Label lblPasajeroInfo = new Label();
                    lblPasajeroInfo.Text = $"Pasajero: {nombrePasajero} {apellidoPasajero}";
                    lblPasajeroInfo.Location = new Point(10, currentY);
                    lblPasajeroInfo.AutoSize = true;
                    lblPasajeroInfo.ForeColor = Color.White;
                    ticketPanel.Controls.Add(lblPasajeroInfo);
                    currentY += lblPasajeroInfo.Height + 2;

                    Label lblCodigoBarrasNum = new Label();
                    lblCodigoBarrasNum.Text = $"Código de Barras: {codigoBarrasNumero}";
                    lblCodigoBarrasNum.Location = new Point(10, currentY);
                    lblCodigoBarrasNum.AutoSize = true;
                    lblCodigoBarrasNum.Font = new Font(lblCodigoBarrasNum.Font, FontStyle.Italic);
                    lblCodigoBarrasNum.ForeColor = Color.LightGray;
                    ticketPanel.Controls.Add(lblCodigoBarrasNum);
                    currentY += lblCodigoBarrasNum.Height + 5;
                    ticketPanel.Height = currentY + ticketPanel.Padding.Bottom;

                    flowLayoutPanelBoletos.Controls.Add(ticketPanel);
                }
            }

            lblPrecioFinal.Text = $"Precio Total: ${precioFinal:N2}";
        }

        /// <summary>
        /// Maneja el evento de impresión de los boletos, generando la representación visual para imprimir
        /// </summary>
        private void printDocumentCodigos_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fuente = new Font("Arial", 10);
            Font fuenteBold = new Font("Arial", 10, FontStyle.Bold);
            Brush pincel = Brushes.Black;

            float y = 50;
            float padding = 10;
            float mitad = e.PageBounds.Width / 2;
            float anchoBoleto = mitad - 2 * padding;

            foreach (var boleto in boletosParaImprimir)
            {
                g.DrawLine(Pens.Black, mitad, y - 10, mitad, y + 300);

                float yLeft = y;
                float yRight = y;

                string rutaTexto = lblOrigenDestino.Text.Split(':')[1].Trim();
                string[] partes = rutaTexto.Split(new string[] { " a " }, StringSplitOptions.None);
                string origen = partes[0].Trim();
                string destino = partes[1].Trim();

                string fechaHoraTexto = lblFechaHora.Text;
                int indiceDosPuntos = fechaHoraTexto.IndexOf(':');
                string fechaHora = fechaHoraTexto.Substring(indiceDosPuntos + 1).Trim();

                // Lado izquierdo
                g.DrawString("RUTA", fuenteBold, pincel, padding, yLeft);
                yLeft += 15;
                g.DrawString($"{origen}/{destino}", fuente, pincel, padding, yLeft);
                yLeft += 25;

                g.DrawString("FECHA Y HORA", fuenteBold, pincel, padding, yLeft);
                yLeft += 15;
                g.DrawString(fechaHora, fuente, pincel, padding, yLeft);
                yLeft += 25;

                g.DrawString("ASIENTO", fuenteBold, pincel, padding, yLeft);
                yLeft += 15;
                g.DrawString(boleto.NumeroAsiento, fuente, pincel, padding, yLeft);
                yLeft += 25;

                // Lado derecho
                float xRight = mitad + padding;
                g.DrawString("PASAJERO", fuenteBold, pincel, xRight, yRight);
                yRight += 15;
                g.DrawString($"{boleto.NombrePasajero} {boleto.ApellidoPasajero}", fuente, pincel, xRight, yRight);
                yRight += 25;

                g.DrawString("RUTA", fuenteBold, pincel, xRight, yRight);
                yRight += 15;
                g.DrawString($"{origen}/{destino}", fuente, pincel, xRight, yRight);
                yRight += 25;

                g.DrawString("FECHA Y HORA", fuenteBold, pincel, xRight, yRight);
                yRight += 15;
                g.DrawString(fechaHora, fuente, pincel, xRight, yRight);
                yRight += 25;

                g.DrawString("ASIENTO", fuenteBold, pincel, xRight, yRight);
                yRight += 15;
                g.DrawString(boleto.NumeroAsiento, fuente, pincel, xRight, yRight);
                yRight += 25;

                // Código de barras
                float yCodigoBarras = Math.Max(yLeft, yRight) + 10;

                if (!string.IsNullOrWhiteSpace(boleto.CodigoBarras) && boleto.CodigoBarras.Length >= 4)
                {
                    try
                    {
                        Barcode codigoBarras = new Barcode
                        {
                            IncludeLabel = true,
                            Alignment = AlignmentPositions.LEFT
                        };

                        Image img = codigoBarras.Encode(TYPE.CODE128, boleto.CodigoBarras, Color.Black, Color.White, 300, 100);
                        float xCodigo = mitad + padding;
                        g.DrawImage(img, xCodigo, yCodigoBarras);

                        y = yCodigoBarras + img.Height + 40;
                    }
                    catch
                    {
                        g.DrawString("(Error en código de barras)", fuente, Brushes.Red, mitad + padding, yCodigoBarras + 20);
                        y = yCodigoBarras + 80;
                    }
                }
                else
                {
                    g.DrawString("(Código de barras no válido)", fuente, Brushes.Red, mitad + padding, yCodigoBarras + 20);
                    y = yCodigoBarras + 80;
                }

                y += 50;
            }

            e.HasMorePages = false;
        }

        /// <summary>
        /// Maneja el evento de clic para imprimir los tickets de los boletos
        /// </summary>
        private void btnImprimirTicket_Click(object sender, EventArgs e)
        {
            if (boletosParaImprimir == null || boletosParaImprimir.Count == 0)
            {
                MessageBox.Show("No hay códigos de barras disponibles para imprimir.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            printPreviewDialog.ShowDialog();
        }

        /// <summary>
        /// Maneja el evento de clic para finalizar y cerrar la aplicación
        /// </summary>
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Maneja el evento de clic para crear un nuevo boleto, volviendo al formulario principal
        /// </summary>
        private void btnNuevoBoleto_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }

        /// <summary>
        /// Clase interna para almacenar información de los boletos
        /// </summary>
        private class BoletoInfo
        {
            public int IdBoleto { get; set; }
            public string NumeroAsiento { get; set; }
            public string NombrePasajero { get; set; }
            public string ApellidoPasajero { get; set; }
            public string CodigoBarras { get; set; }
        }

        /// <summary>
        /// Maneja el evento de clic para imprimir solo los códigos de barras
        /// </summary>
        private void btnImprimirCodigos_Click(object sender, EventArgs e)
        {
            if (boletosParaImprimir == null || boletosParaImprimir.Count == 0)
            {
                MessageBox.Show("No hay códigos de barras disponibles para imprimir.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            printPreviewCodigos.ShowDialog();
        }

        private void panelBoletos_Paint(object sender, PaintEventArgs e)
        {
            // Método vacío para manejar eventos de pintura del panel
        }
    }
}