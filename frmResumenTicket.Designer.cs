namespace Sistema_Vuelos
{
    partial class frmResumenTicket
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtituloPasajero = new System.Windows.Forms.Label();
            this.lblSubtituloVuelo = new System.Windows.Forms.Label();
            this.panelDatosVuelo = new System.Windows.Forms.Panel();
            this.lblOrigenDestino = new System.Windows.Forms.Label();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.btnFinalizar = new FontAwesome.Sharp.IconButton();
            this.btnNuevoBoleto = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanelBoletos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnImprimirTicket = new FontAwesome.Sharp.IconButton();
            this.panelDatosVuelo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(268, -2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(700, 62);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "🎉 ¡Tu Reserva ha sido Confirmada!";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtituloPasajero
            // 
            this.lblSubtituloPasajero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubtituloPasajero.ForeColor = System.Drawing.Color.Gold;
            this.lblSubtituloPasajero.Location = new System.Drawing.Point(12, 249);
            this.lblSubtituloPasajero.Name = "lblSubtituloPasajero";
            this.lblSubtituloPasajero.Size = new System.Drawing.Size(458, 54);
            this.lblSubtituloPasajero.TabIndex = 0;
            this.lblSubtituloPasajero.Text = "Datos de los Pasajeros";
            // 
            // lblSubtituloVuelo
            // 
            this.lblSubtituloVuelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubtituloVuelo.ForeColor = System.Drawing.Color.Gold;
            this.lblSubtituloVuelo.Location = new System.Drawing.Point(10, 0);
            this.lblSubtituloVuelo.Name = "lblSubtituloVuelo";
            this.lblSubtituloVuelo.Size = new System.Drawing.Size(443, 53);
            this.lblSubtituloVuelo.TabIndex = 0;
            this.lblSubtituloVuelo.Text = "✈️ Detalles del Vuelo";
            // 
            // panelDatosVuelo
            // 
            this.panelDatosVuelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelDatosVuelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatosVuelo.Controls.Add(this.lblSubtituloVuelo);
            this.panelDatosVuelo.Controls.Add(this.lblOrigenDestino);
            this.panelDatosVuelo.Controls.Add(this.lblFechaHora);
            this.panelDatosVuelo.Location = new System.Drawing.Point(12, 55);
            this.panelDatosVuelo.Name = "panelDatosVuelo";
            this.panelDatosVuelo.Size = new System.Drawing.Size(824, 191);
            this.panelDatosVuelo.TabIndex = 2;
            // 
            // lblOrigenDestino
            // 
            this.lblOrigenDestino.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblOrigenDestino.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOrigenDestino.Location = new System.Drawing.Point(14, 53);
            this.lblOrigenDestino.Name = "lblOrigenDestino";
            this.lblOrigenDestino.Size = new System.Drawing.Size(432, 50);
            this.lblOrigenDestino.TabIndex = 1;
            this.lblOrigenDestino.Text = "Vuelo:";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblFechaHora.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaHora.Location = new System.Drawing.Point(14, 118);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(423, 39);
            this.lblFechaHora.TabIndex = 2;
            this.lblFechaHora.Text = "Fecha/Hora:";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblPrecioFinal.ForeColor = System.Drawing.Color.Gold;
            this.lblPrecioFinal.Location = new System.Drawing.Point(842, 84);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(387, 35);
            this.lblPrecioFinal.TabIndex = 4;
            this.lblPrecioFinal.Text = "💰 Precio Total: $0.00";
            this.lblPrecioFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnFinalizar.IconColor = System.Drawing.Color.White;
            this.btnFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinalizar.IconSize = 25;
            this.btnFinalizar.Location = new System.Drawing.Point(848, 174);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(377, 39);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "  Finalizar Compra";
            this.btnFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnNuevoBoleto
            // 
            this.btnNuevoBoleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnNuevoBoleto.FlatAppearance.BorderSize = 0;
            this.btnNuevoBoleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoBoleto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNuevoBoleto.ForeColor = System.Drawing.Color.White;
            this.btnNuevoBoleto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNuevoBoleto.IconColor = System.Drawing.Color.White;
            this.btnNuevoBoleto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoBoleto.IconSize = 25;
            this.btnNuevoBoleto.Location = new System.Drawing.Point(848, 124);
            this.btnNuevoBoleto.Name = "btnNuevoBoleto";
            this.btnNuevoBoleto.Size = new System.Drawing.Size(377, 35);
            this.btnNuevoBoleto.TabIndex = 6;
            this.btnNuevoBoleto.Text = "  Nuevo Boleto";
            this.btnNuevoBoleto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoBoleto.UseVisualStyleBackColor = false;
            this.btnNuevoBoleto.Click += new System.EventHandler(this.btnNuevoBoleto_Click);
            // 
            // flowLayoutPanelBoletos
            // 
            this.flowLayoutPanelBoletos.AutoScroll = true;
            this.flowLayoutPanelBoletos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.flowLayoutPanelBoletos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelBoletos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelBoletos.Location = new System.Drawing.Point(12, 306);
            this.flowLayoutPanelBoletos.Name = "flowLayoutPanelBoletos";
            this.flowLayoutPanelBoletos.Size = new System.Drawing.Size(824, 281);
            this.flowLayoutPanelBoletos.TabIndex = 1;
            this.flowLayoutPanelBoletos.WrapContents = false;
            // 
            // btnImprimirTicket
            // 
            this.btnImprimirTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnImprimirTicket.FlatAppearance.BorderSize = 0;
            this.btnImprimirTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirTicket.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnImprimirTicket.ForeColor = System.Drawing.Color.White;
            this.btnImprimirTicket.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimirTicket.IconColor = System.Drawing.Color.White;
            this.btnImprimirTicket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimirTicket.IconSize = 25;
            this.btnImprimirTicket.Location = new System.Drawing.Point(848, 445);
            this.btnImprimirTicket.Name = "btnImprimirTicket";
            this.btnImprimirTicket.Size = new System.Drawing.Size(377, 40);
            this.btnImprimirTicket.TabIndex = 5;
            this.btnImprimirTicket.Text = "  Ver Tickets";
            this.btnImprimirTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirTicket.UseVisualStyleBackColor = false;
            this.btnImprimirTicket.Click += new System.EventHandler(this.btnImprimirTicket_Click);
            // 
            // frmResumenTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1237, 599);
            this.Controls.Add(this.lblSubtituloPasajero);
            this.Controls.Add(this.flowLayoutPanelBoletos);
            this.Controls.Add(this.panelDatosVuelo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.btnImprimirTicket);
            this.Controls.Add(this.btnNuevoBoleto);
            this.Controls.Add(this.btnFinalizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResumenTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "✅ Confirmación de Reserva";
            this.panelDatosVuelo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtituloPasajero;
        private System.Windows.Forms.Panel panelDatosVuelo;
        private System.Windows.Forms.Label lblSubtituloVuelo;
        private System.Windows.Forms.Label lblOrigenDestino;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblPrecioFinal;
        private FontAwesome.Sharp.IconButton btnFinalizar;
        private FontAwesome.Sharp.IconButton btnNuevoBoleto;
        // CHANGE START: Declare the new FlowLayoutPanel
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBoletos; // Changed type and name
        // CHANGE END
        private FontAwesome.Sharp.IconButton btnImprimirTicket;
    }
}