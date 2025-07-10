using DAO;
using Sistema_Vuelos.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Vuelos
{
    public partial class frmSeleccionAsientos : Form
    {
        private int idVueloActual;
        private decimal precioBaseVuelo;
        private ConexionDB db;
        private List<int> asientosSeleccionadosIds;
        private decimal precioTotalAcumulado;
        public frmSeleccionAsientos(int idVuelo, decimal precioVuelo)
        {
            InitializeComponent();
            idVueloActual = idVuelo;
            precioBaseVuelo = precioVuelo;
            db = new ConexionDB();
            asientosSeleccionadosIds = new List<int>();
            precioTotalAcumulado = 0;
            CargarAsientos();
        }

        /// <summary>
        /// Carga los asientos disponibles y ocupados del vuelo desde la base de datos y los muestra como botones.
        /// </summary>
        private void CargarAsientos()
        {
            DataTable asientos = db.ObtenerAsientosVuelo(idVueloActual);
            int x = 10, y = 10;
            int asientosPorFila = 5;

            foreach (DataRow row in asientos.Rows)
            {
                Button btnAsiento = new Button
                {
                    Width = 60,
                    Height = 40,
                    Text = row["NumeroAsiento"].ToString(),
                    Tag = Convert.ToInt32(row["IdAsiento"]),
                    Location = new Point(x, y),
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };

                btnAsiento.FlatAppearance.BorderSize = 0;

                bool ocupado = Convert.ToBoolean(row["Ocupado"]);
                if (ocupado)
                {
                    btnAsiento.BackColor = Color.Red;
                    btnAsiento.Enabled = false;
                }
                else
                {
                    btnAsiento.BackColor = Color.LightGreen;
                    btnAsiento.Click += btnAsiento_Click;
                }

                panelAsientos.Controls.Add(btnAsiento);

                x += 70;
                if (panelAsientos.Controls.Count % asientosPorFila == 0)
                {
                    x = 10;
                    y += 50;
                }
            }
        }

        /// <summary>
        /// Evento que se activa al hacer clic en un botón de asiento. Permite seleccionar o deseleccionar asientos.
        /// </summary>
        private void btnAsiento_Click(object sender, EventArgs e)
        {
            Button btnAsiento = sender as Button;
            int idAsiento = (int)btnAsiento.Tag;

            if (btnAsiento.BackColor == Color.LightGreen)
            {
                btnAsiento.BackColor = Color.LightBlue;
                asientosSeleccionadosIds.Add(idAsiento);
                precioTotalAcumulado += precioBaseVuelo;
            }
            else if (btnAsiento.BackColor == Color.LightBlue)
            {
                btnAsiento.BackColor = Color.LightGreen;
                asientosSeleccionadosIds.Remove(idAsiento);
                precioTotalAcumulado -= precioBaseVuelo;
            }

            lblPrecioTotal.Text = $"Precio Total: ${precioTotalAcumulado:N2}";
        }

        /// <summary>
        /// Evento del botón "Continuar" que valida la selección de asientos y muestra el formulario de datos del pasajero.
        /// </summary>
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (asientosSeleccionadosIds.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona al menos un asiento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmDatosPasajero frmPasajero = new frmDatosPasajero(idVueloActual, asientosSeleccionadosIds, precioTotalAcumulado);
            frmPasajero.Show();
            this.Hide();
        }
    }
}
