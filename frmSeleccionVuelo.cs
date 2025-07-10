using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Vuelos.Clases;

namespace Sistema_Vuelos
{
    public partial class frmSeleccionVuelo : Form
    {
        private DataTable vuelosDisponibles;
        private ConexionDB db;

        /// <summary>
        /// Constructor del formulario de selección de vuelos
        /// </summary>
        /// <param name="vuelos">DataTable con los vuelos disponibles para mostrar</param>
        public frmSeleccionVuelo(DataTable vuelos)
        {
            InitializeComponent();
            vuelosDisponibles = vuelos;
            db = new ConexionDB();
            CargarVuelosEnGrid();
        }

        /// <summary>
        /// Carga los vuelos disponibles en el DataGridView y configura las columnas
        /// </summary>
        private void CargarVuelosEnGrid()
        {
            dgvVuelos.DataSource = vuelosDisponibles;
            // Opcional: ajustar columnas, hacerlas de solo lectura, etc.
            dgvVuelos.Columns["IdVuelo"].Visible = false; // No mostrar el ID al usuario
        }

        /// <summary>
        /// Maneja el evento de clic en el botón para seleccionar un vuelo
        /// Abre el formulario de selección de asientos para el vuelo elegido
        /// </summary>
        private void btnSeleccionarVuelo_Click(object sender, EventArgs e)
        {
            if (dgvVuelos.SelectedRows.Count > 0)
            {
                // Obtener el IdVuelo de la fila seleccionada
                int idVueloSeleccionado = Convert.ToInt32(dgvVuelos.SelectedRows[0].Cells["IdVuelo"].Value);
                decimal precioVuelo = Convert.ToDecimal(dgvVuelos.SelectedRows[0].Cells["Precio"].Value); // Obtener el precio del vuelo

                frmSeleccionAsientos frmAsientos = new frmSeleccionAsientos(idVueloSeleccionado, precioVuelo);
                frmAsientos.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un vuelo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Maneja el evento de clic en una celda del DataGridView para seleccionar la fila completa
        /// </summary>
        private void dgvVuelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvVuelos.Rows[e.RowIndex].Selected = true;
            }
        }

        /// <summary>
        /// Maneja el evento de entrada del mouse a una celda, cambiando el cursor a mano
        /// </summary>
        private void dgvVuelos_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvVuelos.Cursor = Cursors.Hand;
            }
        }

        /// <summary>
        /// Maneja el evento de salida del mouse de una celda, restaurando el cursor predeterminado
        /// </summary>
        private void dgvVuelos_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvVuelos.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Maneja el movimiento del mouse sobre las celdas, mostrando un tooltip con información del vuelo
        /// </summary>
        private void dgvVuelos_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            var hit = dgvVuelos.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.Cell && hit.RowIndex >= 0)
            {
                var row = dgvVuelos.Rows[hit.RowIndex];
                var idVuelo = row.Cells["IdVuelo"].Value.ToString();
                var precio = row.Cells["Precio"].Value.ToString();
                toolTipVuelos.SetToolTip(dgvVuelos, $"Vuelo ID: {idVuelo} - Precio: ${precio}");
            }
        }
    }
}