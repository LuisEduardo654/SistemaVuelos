using BarcodeStandard;
using DAO;
using Sistema_Vuelos.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sistema_Vuelos
{
    /// <summary>
    /// Formulario para registrar los datos de los pasajeros asociados a boletos seleccionados.
    /// </summary>
    public partial class frmDatosPasajero : Form
    {
        private int idVueloSeleccionado;
        private List<int> asientosSeleccionadosIds;
        private decimal precioFinalTotal;
        private ConexionDB db;

        private List<string> nombresPasajeros;
        private List<string> apellidosPasajeros;
        private int indiceBoletoActual;

        /// <summary>
        /// Constructor del formulario frmDatosPasajero.
        /// </summary>
        /// <param name="idVuelo">ID del vuelo seleccionado.</param>
        /// <param name="asientosIds">Lista de IDs de asientos seleccionados.</param>
        /// <param name="precioTotal">Precio total acumulado por los boletos.</param>
        public frmDatosPasajero(int idVuelo, List<int> asientosIds, decimal precioTotal)
        {
            InitializeComponent();
            idVueloSeleccionado = idVuelo;
            asientosSeleccionadosIds = asientosIds;
            precioFinalTotal = precioTotal;
            db = new ConexionDB();

            nombresPasajeros = new List<string>(new string[asientosSeleccionadosIds.Count]);
            apellidosPasajeros = new List<string>(new string[asientosSeleccionadosIds.Count]);
            indiceBoletoActual = 0;

            CargarBoletosPendientes();
            ActualizarEstadoUI();
        }

        /// <summary>
        /// Carga los boletos en el ListBox con etiquetas "Boleto 1", "Boleto 2", etc.
        /// </summary>
        private void CargarBoletosPendientes()
        {
            for (int i = 0; i < asientosSeleccionadosIds.Count; i++)
                lstBoletosPendientes.Items.Add($"Boleto {i + 1}");

            if (lstBoletosPendientes.Items.Count > 0)
                lstBoletosPendientes.SelectedIndex = 0;
        }

        /// <summary>
        /// Actualiza los campos del formulario según el boleto que se esté registrando.
        /// </summary>
        private void ActualizarEstadoUI()
        {
            if (indiceBoletoActual < asientosSeleccionadosIds.Count)
            {
                lblBoletoActual.Text = $"Registrando: Boleto {indiceBoletoActual + 1}";
                txtNombre.Text = nombresPasajeros[indiceBoletoActual];
                txtApellido.Text = apellidosPasajeros[indiceBoletoActual];
                btnRegistrarSiguiente.Text = "Siguiente Pasajero";
                txtNombre.Enabled = txtApellido.Enabled = true;
                txtNombre.Focus();
            }
            else
            {
                lblBoletoActual.Text = "Todos los pasajeros registrados.";
                txtNombre.Text = txtApellido.Text = "";
                txtNombre.Enabled = txtApellido.Enabled = false;
                btnRegistrarSiguiente.Text = "Finalizar Compra";
                btnRegistrarSiguiente.Focus();
            }
        }

        /// <summary>
        /// Finaliza la compra de múltiples boletos registrando cada pasajero y su boleto.
        /// </summary>
        private void FinalizarCompraMultiplesPasajeros()
        {
            try
            {
                for (int i = 0; i < asientosSeleccionadosIds.Count; i++)
                {
                    int idAsiento = asientosSeleccionadosIds[i];
                    string nombrePasajero = nombresPasajeros[i];
                    string apellidoPasajero = apellidosPasajeros[i];
                    string emailTemp = $"{nombrePasajero.Replace(" ", "").ToLower().Substring(0, Math.Min(nombrePasajero.Length, 15))}_{Guid.NewGuid().ToString().Substring(0, 4)}@email.com";
                    string telefonoTemp = "0000000000";

                    int idPasajero = db.InsertarPasajero(nombrePasajero, apellidoPasajero, emailTemp, telefonoTemp);

                    if (idPasajero > 0)
                    {
                        string codigoBarrasGenerado = GenerarCodigoBarrasUnico(idVueloSeleccionado, idAsiento, idPasajero);
                        db.ActualizarEstadoAsiento(idAsiento, true);
                        decimal precioUnitario = precioFinalTotal / asientosSeleccionadosIds.Count;
                        db.InsertarBoleto(idPasajero, idVueloSeleccionado, idAsiento, precioUnitario, codigoBarrasGenerado);
                    }
                    else
                    {
                        MessageBox.Show($"Error al registrar al pasajero: {nombrePasajero} {apellidoPasajero}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessageBox.Show("Compra de boletos finalizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmResumenTicket frmTicket = new frmResumenTicket(idVueloSeleccionado, asientosSeleccionadosIds, precioFinalTotal);
                frmTicket.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error durante la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Genera un código de barras único en formato de texto combinando varios datos.
        /// </summary>
        /// <param name="idVuelo">ID del vuelo.</param>
        /// <param name="idAsiento">ID del asiento.</param>
        /// <param name="idPasajero">ID del pasajero.</param>
        /// <returns>Código de barras generado como cadena.</returns>
        private string GenerarCodigoBarrasUnico(int idVuelo, int idAsiento, int idPasajero)
        {
            string timestamp = DateTime.Now.Ticks.ToString();
            return $"V{idVuelo}A{idAsiento}P{idPasajero}T{timestamp}";
        }

        /// <summary>
        /// Valida los campos de nombre y apellido antes de avanzar.
        /// </summary>
        /// <returns>True si todos los campos son válidos, de lo contrario False.</returns>
        private bool ValidarCampos()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProviderDatos.SetError(txtNombre, "El nombre es obligatorio.");
                isValid = false;
            }
            else
                errorProviderDatos.SetError(txtNombre, "");

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                errorProviderDatos.SetError(txtApellido, "El apellido es obligatorio.");
                isValid = false;
            }
            else
                errorProviderDatos.SetError(txtApellido, "");

            return isValid;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$");
        }

        private void ValidarCampoIndividual(TextBox textBox, string errorMessage, bool condition)
        {
            errorProviderDatos.SetError(textBox, condition ? errorMessage : "");
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            ValidarCampoIndividual(txtNombre, "El nombre es obligatorio.", string.IsNullOrWhiteSpace(txtNombre.Text));
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            ValidarCampoIndividual(txtApellido, "El apellido es obligatorio.", string.IsNullOrWhiteSpace(txtApellido.Text));
        }

        /// <summary>
        /// Evento al cambiar la selección de boletos en el ListBox. Guarda datos actuales y carga nuevos.
        /// </summary>
        private void lstBoletosPendientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int previousIndex = indiceBoletoActual;

            if (lstBoletosPendientes.SelectedIndex != -1 && lstBoletosPendientes.SelectedIndex != previousIndex)
            {
                if (previousIndex >= 0 && previousIndex < nombresPasajeros.Count)
                {
                    nombresPasajeros[previousIndex] = txtNombre.Text.Trim();
                    apellidosPasajeros[previousIndex] = txtApellido.Text.Trim();
                }

                indiceBoletoActual = lstBoletosPendientes.SelectedIndex;
                ActualizarEstadoUI();
            }
        }

        /// <summary>
        /// Evento click del botón "Registrar Siguiente". Valida y guarda datos del pasajero actual.
        /// </summary>
        private void btnRegistrarSiguiente_Click(object sender, EventArgs e)
        {
            bool camposValidos = ValidarCampos();

            if (!camposValidos)
            {
                MessageBox.Show("Por favor, ingresa todos los campos requeridos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            nombresPasajeros[indiceBoletoActual] = txtNombre.Text.Trim();
            apellidosPasajeros[indiceBoletoActual] = txtApellido.Text.Trim();

            indiceBoletoActual++;
            lstBoletosPendientes.SelectedIndex = (indiceBoletoActual < lstBoletosPendientes.Items.Count) ? indiceBoletoActual : -1;
            ActualizarEstadoUI();

            if (indiceBoletoActual >= asientosSeleccionadosIds.Count)
                FinalizarCompraMultiplesPasajeros();
            else
            {
                txtNombre.Clear();
                txtApellido.Clear();
            }
        }
    }
}
