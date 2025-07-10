using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Vuelos
{
    /// <summary>
    /// Formulario de inicio del sistema de vuelos.
    /// Actúa como pantalla de bienvenida o presentación inicial.
    /// </summary>
    public partial class frmInicio : Form
    {
        /// <summary>
        /// Constructor del formulario frmInicio.
        /// Inicializa los componentes visuales del formulario.
        /// </summary>
        public frmInicio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Continuar".
        /// Navega al formulario principal y oculta el formulario actual.
        /// </summary>
        /// <param name="sender">El control que disparó el evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // Crear y mostrar el formulario principal del sistema
            frmPrincipal frmSeleccion = new frmPrincipal();
            frmSeleccion.Show();

            // Ocultar la pantalla de inicio
            this.Hide();
        }
    }
}

