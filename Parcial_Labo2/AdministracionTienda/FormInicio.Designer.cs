
namespace AdministracionTienda
{
    partial class FormInicio
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
            this.lblHora = new System.Windows.Forms.Label();
            this.btnNuevaOpe = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panelCompra = new System.Windows.Forms.Panel();
            this.btnCerrarLista = new System.Windows.Forms.PictureBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalTitulo = new System.Windows.Forms.Label();
            this.listProductos = new System.Windows.Forms.ListView();
            this.clCodigo = new System.Windows.Forms.ColumnHeader();
            this.clMarca = new System.Windows.Forms.ColumnHeader();
            this.clDescripcion = new System.Windows.Forms.ColumnHeader();
            this.clPrecio = new System.Windows.Forms.ColumnHeader();
            this.clStock = new System.Windows.Forms.ColumnHeader();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.panelCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarLista)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHora.Font = new System.Drawing.Font("Open Sans", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblHora.Location = new System.Drawing.Point(873, 8);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(283, 97);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "00:06";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNuevaOpe
            // 
            this.btnNuevaOpe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(222)))), ((int)(((byte)(100)))));
            this.btnNuevaOpe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaOpe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaOpe.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevaOpe.ForeColor = System.Drawing.Color.White;
            this.btnNuevaOpe.Location = new System.Drawing.Point(84, 12);
            this.btnNuevaOpe.Name = "btnNuevaOpe";
            this.btnNuevaOpe.Size = new System.Drawing.Size(175, 40);
            this.btnNuevaOpe.TabIndex = 1;
            this.btnNuevaOpe.Text = "NUEVA OPERACION";
            this.btnNuevaOpe.UseVisualStyleBackColor = false;
            this.btnNuevaOpe.Click += new System.EventHandler(this.btnNuevaOpe_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnNuevaOpe);
            this.panelTop.Controls.Add(this.lblHora);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1170, 149);
            this.panelTop.TabIndex = 3;
            // 
            // panelCliente
            // 
            this.panelCliente.Controls.Add(this.btnLimpiar);
            this.panelCliente.Controls.Add(this.panelCompra);
            this.panelCliente.Controls.Add(this.btnBuscar);
            this.panelCliente.Controls.Add(this.lblSaldo);
            this.panelCliente.Controls.Add(this.lblApellido);
            this.panelCliente.Controls.Add(this.txtApellido);
            this.panelCliente.Controls.Add(this.lblNombre);
            this.panelCliente.Controls.Add(this.txtNombre);
            this.panelCliente.Controls.Add(this.lblDni);
            this.panelCliente.Controls.Add(this.txtDni);
            this.panelCliente.Controls.Add(this.lblCliente);
            this.panelCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCliente.Location = new System.Drawing.Point(0, 149);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(1170, 710);
            this.panelCliente.TabIndex = 4;
            this.panelCliente.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Orange;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(720, 157);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 40);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panelCompra
            // 
            this.panelCompra.Controls.Add(this.btnCerrarLista);
            this.panelCompra.Controls.Add(this.btnFinalizar);
            this.panelCompra.Controls.Add(this.lblTotal);
            this.panelCompra.Controls.Add(this.lblTotalTitulo);
            this.panelCompra.Controls.Add(this.listProductos);
            this.panelCompra.Controls.Add(this.btnCancelar);
            this.panelCompra.Location = new System.Drawing.Point(0, 217);
            this.panelCompra.Name = "panelCompra";
            this.panelCompra.Size = new System.Drawing.Size(1169, 492);
            this.panelCompra.TabIndex = 11;
            this.panelCompra.Visible = false;
            // 
            // btnCerrarLista
            // 
            this.btnCerrarLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarLista.Image = global::AdministracionTienda.Properties.Resources.close;
            this.btnCerrarLista.Location = new System.Drawing.Point(1123, 3);
            this.btnCerrarLista.Name = "btnCerrarLista";
            this.btnCerrarLista.Size = new System.Drawing.Size(35, 35);
            this.btnCerrarLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarLista.TabIndex = 12;
            this.btnCerrarLista.TabStop = false;
            this.btnCerrarLista.Click += new System.EventHandler(this.btnCerrarLista_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(222)))), ((int)(((byte)(100)))));
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(1016, 350);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(140, 40);
            this.btnFinalizar.TabIndex = 11;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotal.Location = new System.Drawing.Point(716, 99);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 22);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "0";
            // 
            // lblTotalTitulo
            // 
            this.lblTotalTitulo.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalTitulo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalTitulo.Location = new System.Drawing.Point(695, 52);
            this.lblTotalTitulo.Name = "lblTotalTitulo";
            this.lblTotalTitulo.Size = new System.Drawing.Size(100, 23);
            this.lblTotalTitulo.TabIndex = 9;
            this.lblTotalTitulo.Text = "TOTAL";
            this.lblTotalTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listProductos
            // 
            this.listProductos.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listProductos.AutoArrange = false;
            this.listProductos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clCodigo,
            this.clMarca,
            this.clDescripcion,
            this.clPrecio,
            this.clStock});
            this.listProductos.FullRowSelect = true;
            this.listProductos.GridLines = true;
            this.listProductos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listProductos.HideSelection = false;
            this.listProductos.Location = new System.Drawing.Point(84, 52);
            this.listProductos.Name = "listProductos";
            this.listProductos.Size = new System.Drawing.Size(584, 400);
            this.listProductos.TabIndex = 8;
            this.listProductos.UseCompatibleStateImageBehavior = false;
            this.listProductos.View = System.Windows.Forms.View.Details;
            this.listProductos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listProductos_MouseDoubleClick);
            // 
            // clCodigo
            // 
            this.clCodigo.Text = "Codigo";
            this.clCodigo.Width = 80;
            // 
            // clMarca
            // 
            this.clMarca.Text = "Marca";
            this.clMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clMarca.Width = 120;
            // 
            // clDescripcion
            // 
            this.clDescripcion.Text = "Descripcion";
            this.clDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clDescripcion.Width = 250;
            // 
            // clPrecio
            // 
            this.clPrecio.Text = "Precio";
            this.clPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clPrecio.Width = 70;
            // 
            // clStock
            // 
            this.clStock.Text = "Stock";
            this.clStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(1016, 412);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 40);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(602, 157);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 40);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSaldo.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.Location = new System.Drawing.Point(881, 96);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(62, 17);
            this.lblSaldo.TabIndex = 7;
            this.lblSaldo.Text = "Saldo: $ 0";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblApellido.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(577, 96);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(53, 17);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(649, 92);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(146, 24);
            this.txtApellido.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(326, 96);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 17);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(386, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 24);
            this.txtNombre.TabIndex = 2;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDni.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(82, 96);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 17);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDni.Location = new System.Drawing.Point(131, 92);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(146, 24);
            this.txtDni.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.Location = new System.Drawing.Point(84, 24);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(62, 22);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // timerHora
            // 
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 859);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.panelTop.ResumeLayout(false);
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.panelCompra.ResumeLayout(false);
            this.panelCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnNuevaOpe;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelCompra;
        private System.Windows.Forms.Label lblTotalTitulo;
        private System.Windows.Forms.ListView listProductos;
        private System.Windows.Forms.ColumnHeader clCodigo;
        private System.Windows.Forms.ColumnHeader clMarca;
        private System.Windows.Forms.ColumnHeader clDescripcion;
        private System.Windows.Forms.ColumnHeader clPrecio;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.ColumnHeader clStock;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.PictureBox btnCerrarLista;
        private System.Windows.Forms.Button btnLimpiar;
    }
}