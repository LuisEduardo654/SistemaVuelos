using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace Sistema_Vuelos
{
    /// <summary>
    /// Formulario principal para la selección de origen, destino y fecha de vuelo.
    /// </summary>
    public partial class frmPrincipal : Form
    {
        private ConexionDB db;

        /// <summary>
        /// Constructor del formulario frmPrincipal.
        /// Inicializa componentes, aplica estilos y carga los datos iniciales.
        /// </summary>
        public frmPrincipal()
        {
            InitializeComponent();
            EstilizarFormulario();
            CargarDatosIniciales();
            db = new ConexionDB();
        }

        /// <summary>
        /// Llena los ComboBox de origen y destino con opciones predefinidas.
        /// </summary>
        private void CargarDatosIniciales()
        {
            cmbOrigen.Items.AddRange(new string[]
            {
                "Ciudad de México", "Guadalajara", "Monterrey", "León", "Puebla", "Toluca",
                "São Paulo", "Brasilia", "Río de Janeiro"
            });

            cmbDestino.Items.AddRange(new string[]
            {
                "Cancún", "Tijuana", "Ciudad de México", "Querétaro", "Ciudad Juárez", "Mérida",
                "São Paulo", "Río de Janeiro", "Buenos Aires", "Lima", "Bogotá"
            });
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en "Buscar Vuelos".
        /// Valida los campos, consulta los vuelos disponibles y navega al formulario de selección.
        /// </summary>
        private void btnBuscarVuelos_Click(object sender, EventArgs e)
        {
            string origen = cmbOrigen.SelectedItem?.ToString();
            string destino = cmbDestino.SelectedItem?.ToString();
            DateTime fecha = dtpFechaSalida.Value;

            if (string.IsNullOrEmpty(origen) || string.IsNullOrEmpty(destino))
            {
                MessageBox.Show("Por favor, selecciona un origen y un destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Consultar vuelos disponibles
            DataTable vuelosDisponibles = db.ObtenerVuelos(origen, destino, fecha);

            if (vuelosDisponibles.Rows.Count > 0)
            {
                frmSeleccionVuelo frmSeleccion = new frmSeleccionVuelo(vuelosDisponibles);
                frmSeleccion.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se encontraron vuelos para la fecha y destinos seleccionados.", "Sin Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Aplica estilos personalizados al formulario y a los controles incluidos.
        /// </summary>
        private void EstilizarFormulario()
        {
            this.BackColor = Color.FromArgb(30, 30, 60);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ComboBox cb)
                {
                    cb.BackColor = Color.White;
                    cb.ForeColor = Color.Black;
                    cb.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    cb.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else if (ctrl is Button btn)
                {
                    btn.BackColor = Color.MediumSlateBlue;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                }
                else if (ctrl is DateTimePicker dtp)
                {
                    dtp.CalendarMonthBackground = Color.White;
                    dtp.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                }
                else if (ctrl is Label lbl)
                {
                    lbl.ForeColor = Color.White;
                    lbl.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                }
            }
        }
    }
}
