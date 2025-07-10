namespace Sistema_Vuelos
{
    partial class frmSeleccionVuelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVuelos = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarVuelo = new FontAwesome.Sharp.IconButton(); // Cambiado a IconButton
            this.toolTipVuelos = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).BeginInit();
            this.SuspendLayout();
            //
            // dgvVuelos
            //
            this.dgvVuelos.AllowUserToAddRows = false;
            this.dgvVuelos.AllowUserToDeleteRows = false;
            this.dgvVuelos.AllowUserToResizeRows = false;
            this.dgvVuelos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; // Fill para mejor aprovechamiento
            this.dgvVuelos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80))))); // Midnight Blue
            this.dgvVuelos.BorderStyle = System.Windows.Forms.BorderStyle.None; // Quitar borde para un look más moderno
            this.dgvVuelos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal; // Líneas horizontales solamente
            this.dgvVuelos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None; // Sin borde en los encabezados
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94))))); // Darker blue-gray for headers (Wet Asphalt)
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold); // Fuente semibold
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White; // Texto blanco
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94))))); // Mismo color de fondo para que no cambie al seleccionar
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVuelos.ColumnHeadersHeight = 35; // Altura ligeramente mayor
            this.dgvVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing; // Deshabilitar resize de encabezado
            this.dgvVuelos.EnableHeadersVisualStyles = false; // Importante para aplicar los estilos personalizados
            this.dgvVuelos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100))))); // Color de línea sutil
            this.dgvVuelos.Location = new System.Drawing.Point(30, 30); // Márgenes
            this.dgvVuelos.MultiSelect = false;
            this.dgvVuelos.Name = "dgvVuelos";
            this.dgvVuelos.ReadOnly = true;
            this.dgvVuelos.RowHeadersVisible = false;
            this.dgvVuelos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80))))); // Midnight Blue para filas
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241))))); // Clouds para texto de filas
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96))))); // Emerald Green para selección
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVuelos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVuelos.RowTemplate.Height = 30; // Altura de fila
            this.dgvVuelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVuelos.Size = new System.Drawing.Size(690, 310); // Ajustar tamaño dinámico
            this.dgvVuelos.TabIndex = 0;
            this.dgvVuelos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVuelos_CellClick);
            this.dgvVuelos.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVuelos_CellMouseEnter);
            this.dgvVuelos.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVuelos_CellMouseLeave);
            this.dgvVuelos.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVuelos_CellMouseMove);
            //
            // btnSeleccionarVuelo
            //
            this.btnSeleccionarVuelo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right; // Anclado a la derecha
            this.btnSeleccionarVuelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96))))); // Emerald Green
            this.btnSeleccionarVuelo.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarVuelo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarVuelo.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarVuelo.IconChar = FontAwesome.Sharp.IconChar.CheckCircle; // Icono de verificación
            this.btnSeleccionarVuelo.IconColor = System.Drawing.Color.White;
            this.btnSeleccionarVuelo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeleccionarVuelo.IconSize = 25;
            this.btnSeleccionarVuelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarVuelo.Location = new System.Drawing.Point(520, 375); // Posición para anclaje a la derecha
            this.btnSeleccionarVuelo.Name = "btnSeleccionarVuelo";
            this.btnSeleccionarVuelo.Size = new System.Drawing.Size(200, 45);
            this.btnSeleccionarVuelo.TabIndex = 1;
            this.btnSeleccionarVuelo.Text = "  Seleccionar Vuelo"; // Texto con espacio
            this.btnSeleccionarVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionarVuelo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionarVuelo.UseVisualStyleBackColor = false;
            this.btnSeleccionarVuelo.Click += new System.EventHandler(this.btnSeleccionarVuelo_Click);
            //this.btnSeleccionarVuelo.MouseEnter += new System.EventHandler(this.btnSeleccionarVuelo_MouseEnter);
            //this.btnSeleccionarVuelo.MouseLeave += new System.EventHandler(this.btnSeleccionarVuelo_MouseLeave);
            //
            // frmSeleccionVuelo
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80))))); // Midnight Blue
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.btnSeleccionarVuelo);
            this.Controls.Add(this.dgvVuelos);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // Cambiado a FixedSingle
            this.MaximizeBox = false;
            this.Name = "frmSeleccionVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "✨ Vuelos Disponibles"; // Título con icono Unicode
            //this.Load += new System.EventHandler(this.frmSeleccionVuelo_Load); // Agregar evento Load
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Declaración de los componentes con el tipo actualizado
        private System.Windows.Forms.DataGridView dgvVuelos;
        private FontAwesome.Sharp.IconButton btnSeleccionarVuelo;
        private System.Windows.Forms.ToolTip toolTipVuelos;
    }
}