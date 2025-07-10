namespace Sistema_Vuelos
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        // Utilizamos FontAwesome.Sharp.IconButton para los botones con íconos
        private FontAwesome.Sharp.IconButton btnBuscarVuelos;

        // Panel para organizar los controles de entrada
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInput;

        // Controles de entrada existentes
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnBuscarVuelos = new FontAwesome.Sharp.IconButton();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanelInput = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarVuelos
            // 
            this.btnBuscarVuelos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarVuelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBuscarVuelos.FlatAppearance.BorderSize = 0;
            this.btnBuscarVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVuelos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBuscarVuelos.ForeColor = System.Drawing.Color.White;
            this.btnBuscarVuelos.IconChar = FontAwesome.Sharp.IconChar.PlaneDeparture;
            this.btnBuscarVuelos.IconColor = System.Drawing.Color.White;
            this.btnBuscarVuelos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarVuelos.IconSize = 25;
            this.btnBuscarVuelos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarVuelos.Location = new System.Drawing.Point(175, 239);
            this.btnBuscarVuelos.Name = "btnBuscarVuelos";
            this.btnBuscarVuelos.Size = new System.Drawing.Size(200, 50);
            this.btnBuscarVuelos.TabIndex = 6;
            this.btnBuscarVuelos.Text = "  Buscar Vuelos";
            this.btnBuscarVuelos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarVuelos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarVuelos.UseVisualStyleBackColor = false;
            this.btnBuscarVuelos.Click += new System.EventHandler(this.btnBuscarVuelos_Click);
            // 
            // lblOrigen
            // 
            this.lblOrigen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrigen.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblOrigen.Location = new System.Drawing.Point(3, 17);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(100, 25);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen:";
            this.lblOrigen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrigen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(179, 14);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(322, 31);
            this.cmbOrigen.TabIndex = 1;
            // 
            // lblDestino
            // 
            this.lblDestino.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblDestino.Location = new System.Drawing.Point(3, 77);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(100, 25);
            this.lblDestino.TabIndex = 2;
            this.lblDestino.Text = "Destino:";
            this.lblDestino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDestino
            // 
            this.cmbDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDestino.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(179, 74);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(322, 31);
            this.cmbDestino.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblFecha.Location = new System.Drawing.Point(3, 137);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(154, 25);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha de salida:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaSalida.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaSalida.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dtpFechaSalida.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(179, 135);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(322, 30);
            this.dtpFechaSalida.TabIndex = 5;
            // 
            // tableLayoutPanelInput
            // 
            this.tableLayoutPanelInput.ColumnCount = 2;
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelInput.Controls.Add(this.lblOrigen, 0, 0);
            this.tableLayoutPanelInput.Controls.Add(this.cmbOrigen, 1, 0);
            this.tableLayoutPanelInput.Controls.Add(this.lblDestino, 0, 1);
            this.tableLayoutPanelInput.Controls.Add(this.cmbDestino, 1, 1);
            this.tableLayoutPanelInput.Controls.Add(this.lblFecha, 0, 2);
            this.tableLayoutPanelInput.Controls.Add(this.dtpFechaSalida, 1, 2);
            this.tableLayoutPanelInput.Location = new System.Drawing.Point(30, 30);
            this.tableLayoutPanelInput.Name = "tableLayoutPanelInput";
            this.tableLayoutPanelInput.RowCount = 3;
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelInput.Size = new System.Drawing.Size(504, 180);
            this.tableLayoutPanelInput.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(556, 320);
            this.Controls.Add(this.tableLayoutPanelInput);
            this.Controls.Add(this.btnBuscarVuelos);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "✈️ Buscador de Vuelos";
            this.tableLayoutPanelInput.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}