namespace Sistema_Vuelos
{
    partial class frmDatosPasajero
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnRegistrarSiguiente = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanelDatos = new System.Windows.Forms.TableLayoutPanel();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.errorProviderDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.lstBoletosPendientes = new System.Windows.Forms.ListBox();
            this.lblBoletoActual = new System.Windows.Forms.Label();
            this.tableLayoutPanelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(47, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(471, 40);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "📝 Ingresa los datos del pasajero";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(3, 11);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre(s):";
            // 
            // btnRegistrarSiguiente
            // 
            this.btnRegistrarSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistrarSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnRegistrarSiguiente.FlatAppearance.BorderSize = 0;
            this.btnRegistrarSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarSiguiente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarSiguiente.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnRegistrarSiguiente.IconColor = System.Drawing.Color.White;
            this.btnRegistrarSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarSiguiente.IconSize = 25;
            this.btnRegistrarSiguiente.Location = new System.Drawing.Point(318, 370);
            this.btnRegistrarSiguiente.Name = "btnRegistrarSiguiente";
            this.btnRegistrarSiguiente.Size = new System.Drawing.Size(180, 45);
            this.btnRegistrarSiguiente.TabIndex = 3;
            this.btnRegistrarSiguiente.Text = "  Confirmar";
            this.btnRegistrarSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarSiguiente.UseVisualStyleBackColor = false;
            this.btnRegistrarSiguiente.Click += new System.EventHandler(this.btnRegistrarSiguiente_Click);
            // 
            // tableLayoutPanelDatos
            // 
            this.tableLayoutPanelDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanelDatos.ColumnCount = 2;
            this.tableLayoutPanelDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelDatos.Controls.Add(this.lblApellido, 0, 1);
            this.tableLayoutPanelDatos.Controls.Add(this.lblNombre, 0, 0);
            this.tableLayoutPanelDatos.Controls.Add(this.txtNombre, 1, 0);
            this.tableLayoutPanelDatos.Controls.Add(this.txtApellido, 1, 1);
            this.tableLayoutPanelDatos.Location = new System.Drawing.Point(58, 63);
            this.tableLayoutPanelDatos.Name = "tableLayoutPanelDatos";
            this.tableLayoutPanelDatos.RowCount = 2;
            this.tableLayoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDatos.Size = new System.Drawing.Size(440, 95);
            this.tableLayoutPanelDatos.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblApellido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblApellido.Location = new System.Drawing.Point(3, 58);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(120, 25);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido(s):";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(135, 8);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(302, 30);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtApellido.Location = new System.Drawing.Point(135, 56);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(302, 30);
            this.txtApellido.TabIndex = 3;
            // 
            // errorProviderDatos
            // 
            this.errorProviderDatos.ContainerControl = this;
            // 
            // lstBoletosPendientes
            // 
            this.lstBoletosPendientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lstBoletosPendientes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstBoletosPendientes.FormattingEnabled = true;
            this.lstBoletosPendientes.ItemHeight = 23;
            this.lstBoletosPendientes.Location = new System.Drawing.Point(58, 175);
            this.lstBoletosPendientes.Name = "lstBoletosPendientes";
            this.lstBoletosPendientes.Size = new System.Drawing.Size(440, 165);
            this.lstBoletosPendientes.TabIndex = 1;
            this.lstBoletosPendientes.SelectedIndexChanged += new System.EventHandler(this.lstBoletosPendientes_SelectedIndexChanged);
            // 
            // lblBoletoActual
            // 
            this.lblBoletoActual.AutoSize = true;
            this.lblBoletoActual.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblBoletoActual.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBoletoActual.Location = new System.Drawing.Point(54, 370);
            this.lblBoletoActual.Name = "lblBoletoActual";
            this.lblBoletoActual.Size = new System.Drawing.Size(55, 23);
            this.lblBoletoActual.TabIndex = 0;
            this.lblBoletoActual.Text = "label1";
            // 
            // frmDatosPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(557, 452);
            this.Controls.Add(this.lblBoletoActual);
            this.Controls.Add(this.lstBoletosPendientes);
            this.Controls.Add(this.tableLayoutPanelDatos);
            this.Controls.Add(this.btnRegistrarSiguiente);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDatosPasajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "👤 Datos del Pasajero";
            this.tableLayoutPanelDatos.ResumeLayout(false);
            this.tableLayoutPanelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDatos;
        private System.Windows.Forms.Label lblNombre;
        private FontAwesome.Sharp.IconButton btnRegistrarSiguiente;
        private System.Windows.Forms.ErrorProvider errorProviderDatos;
        private System.Windows.Forms.ListBox lstBoletosPendientes;
        private System.Windows.Forms.Label lblBoletoActual;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
    }
}