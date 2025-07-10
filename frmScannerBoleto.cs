using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPasajeros
{
    public partial class frmScannerBoleto : Form
    {
        private clsDaoVuelos dao = new clsDaoVuelos();

        public frmScannerBoleto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los datos de los vuelos y pasajeros en el DataGridView
        /// </summary>
        private void CargarDatos()
        {
            dgvLista.DataSource = dao.ObtenerResumenVuelos();
        }

        /// <summary>
        /// Maneja el evento cuando se presiona una tecla en el campo de escaneo.
        /// Si es Enter, busca y marca el boleto correspondiente al código escaneado.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento</param>
        /// <param name="e">Argumentos del evento de tecla</param>
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string codigo = txtScanear.Text.Trim();
                var dao = new clsDaoVuelos();

                var boleto = dao.ObtenerBoletoPorCodigo(codigo);
                if (boleto != null)
                {
                    dao.MarcarLlegadaPorCodigo(codigo); // Marca como llegado

                    txtNombre.Text = boleto.Nombre;
                    txtAsiento.Text = boleto.NumeroAsiento;
                    txtVuelo.Text = $"{boleto.Origen} → {boleto.Destino}";
                    txtFechaVuelo.Text = boleto.FechaSalida.ToShortDateString();

                    CargarDatos(); // Método para refrescar el DataGridView
                }
                else
                {
                    MessageBox.Show("Boleto no encontrado.");
                }

                txtScanear.Clear();
            }
        }

        /// <summary>
        /// Busca un boleto por su código de barras y marca la llegada del pasajero.
        /// Actualiza la interfaz con la información del boleto encontrado.
        /// </summary>
        private void BuscarYMarcarBoleto()
        {
            string codigoBarra = txtScanear.Text.Trim();

            if (!string.IsNullOrEmpty(codigoBarra))
            {
                // Marca la llegada del pasajero en base al código de barras
                dao.MarcarLlegadaPorCodigo(codigoBarra);

                // Busca la información del boleto
                Vuelos v = dao.ObtenerBoletoPorCodigo(codigoBarra);
                if (v != null)
                {
                    txtNombre.Text = v.Nombre;
                    txtAsiento.Text = v.NumeroAsiento;
                    txtVuelo.Text = v.Ruta;
                    txtFechaVuelo.Text = v.FechaSalida.ToShortDateString();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún vuelo con ese código de barras.");
                }

                // Refresca el DataGridView
                CargarDatos();

                // Limpia y enfoca el lector
                txtScanear.Clear();
                txtScanear.Focus();
            }
            else
            {
                MessageBox.Show("Ingresa un código de barras válido.");
            }
        }

        /// <summary>
        /// Maneja el evento click del botón Buscar, ejecutando la búsqueda y marcado del boleto
        /// </summary>
        /// <param name="sender">Objeto que generó el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarYMarcarBoleto(); // manual, presionando el botón buscar
        }

        private void frmScannerBoleto_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Maneja el evento click del botón Actualizar, refrescando los datos mostrados
        /// </summary>
        /// <param name="sender">Objeto que generó el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtScanear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}