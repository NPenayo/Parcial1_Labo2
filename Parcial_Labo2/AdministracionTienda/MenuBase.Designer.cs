
namespace AdministracionTienda
{
    partial class MenuBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuBase));
            this.Menu = new System.Windows.Forms.Panel();
            this.picFactu = new System.Windows.Forms.PictureBox();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.picUsuarios = new System.Windows.Forms.PictureBox();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.picCliente = new System.Windows.Forms.PictureBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.picProducto = new System.Windows.Forms.PictureBox();
            this.btnProductos = new System.Windows.Forms.Button();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.toolCerrar = new System.Windows.Forms.ToolTip(this.components);
            this.toolMinimizar = new System.Windows.Forms.ToolTip(this.components);
            this.tiempoSesion = new System.Windows.Forms.Timer(this.components);
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFactu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.Menu.Controls.Add(this.picFactu);
            this.Menu.Controls.Add(this.btnFacturacion);
            this.Menu.Controls.Add(this.picUsuarios);
            this.Menu.Controls.Add(this.btnEmpleados);
            this.Menu.Controls.Add(this.picCliente);
            this.Menu.Controls.Add(this.btnClientes);
            this.Menu.Controls.Add(this.picProducto);
            this.Menu.Controls.Add(this.btnProductos);
            this.Menu.Controls.Add(this.picHome);
            this.Menu.Controls.Add(this.btnInicio);
            this.Menu.Controls.Add(this.lblNombreUsuario);
            this.Menu.Controls.Add(this.lblNombreEmpresa);
            this.Menu.Controls.Add(this.picLogo);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(270, 900);
            this.Menu.TabIndex = 0;
            // 
            // picFactu
            // 
            this.picFactu.BackColor = System.Drawing.Color.Transparent;
            this.picFactu.Image = global::AdministracionTienda.Properties.Resources.invoice;
            this.picFactu.Location = new System.Drawing.Point(40, 628);
            this.picFactu.Name = "picFactu";
            this.picFactu.Size = new System.Drawing.Size(20, 20);
            this.picFactu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFactu.TabIndex = 12;
            this.picFactu.TabStop = false;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.btnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFacturacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFacturacion.Location = new System.Drawing.Point(28, 614);
            this.btnFacturacion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(215, 49);
            this.btnFacturacion.TabIndex = 11;
            this.btnFacturacion.Text = "FACTURACION";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            this.btnFacturacion.Leave += new System.EventHandler(this.btnFacturacion_Leave);
            this.btnFacturacion.MouseLeave += new System.EventHandler(this.btnFacturacion_MouseLeave);
            this.btnFacturacion.MouseHover += new System.EventHandler(this.btnFacturacion_MouseHover);
            // 
            // picUsuarios
            // 
            this.picUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.picUsuarios.Image = global::AdministracionTienda.Properties.Resources.gear;
            this.picUsuarios.Location = new System.Drawing.Point(40, 561);
            this.picUsuarios.Name = "picUsuarios";
            this.picUsuarios.Size = new System.Drawing.Size(20, 20);
            this.picUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsuarios.TabIndex = 10;
            this.picUsuarios.TabStop = false;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmpleados.Location = new System.Drawing.Point(28, 547);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(215, 49);
            this.btnEmpleados.TabIndex = 9;
            this.btnEmpleados.Text = "EMPLEADOS";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            this.btnEmpleados.Leave += new System.EventHandler(this.btnEmpleados_Leave);
            this.btnEmpleados.MouseLeave += new System.EventHandler(this.btnEmpleados_MouseLeave);
            this.btnEmpleados.MouseHover += new System.EventHandler(this.btnEmpleados_MouseHover);
            // 
            // picCliente
            // 
            this.picCliente.BackColor = System.Drawing.Color.Transparent;
            this.picCliente.Image = global::AdministracionTienda.Properties.Resources.customer;
            this.picCliente.Location = new System.Drawing.Point(40, 494);
            this.picCliente.Name = "picCliente";
            this.picCliente.Size = new System.Drawing.Size(20, 20);
            this.picCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCliente.TabIndex = 8;
            this.picCliente.TabStop = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientes.Location = new System.Drawing.Point(28, 480);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(215, 49);
            this.btnClientes.TabIndex = 7;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            this.btnClientes.Leave += new System.EventHandler(this.btnClientes_Leave);
            this.btnClientes.MouseLeave += new System.EventHandler(this.btnClientes_MouseLeave);
            this.btnClientes.MouseHover += new System.EventHandler(this.btnClientes_MouseHover);
            // 
            // picProducto
            // 
            this.picProducto.BackColor = System.Drawing.Color.Transparent;
            this.picProducto.Image = global::AdministracionTienda.Properties.Resources.product;
            this.picProducto.Location = new System.Drawing.Point(40, 427);
            this.picProducto.Name = "picProducto";
            this.picProducto.Size = new System.Drawing.Size(20, 20);
            this.picProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProducto.TabIndex = 6;
            this.picProducto.TabStop = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductos.Location = new System.Drawing.Point(28, 413);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(215, 49);
            this.btnProductos.TabIndex = 5;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            this.btnProductos.Leave += new System.EventHandler(this.btnProductos_Leave);
            this.btnProductos.MouseLeave += new System.EventHandler(this.btnProductos_MouseLeave);
            this.btnProductos.MouseHover += new System.EventHandler(this.btnProductos_MouseHover);
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.Transparent;
            this.picHome.Image = global::AdministracionTienda.Properties.Resources.home;
            this.picHome.Location = new System.Drawing.Point(40, 360);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(20, 20);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 4;
            this.picHome.TabStop = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInicio.Location = new System.Drawing.Point(28, 346);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(215, 49);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            this.btnInicio.Leave += new System.EventHandler(this.btnInicio_Leave);
            this.btnInicio.MouseLeave += new System.EventHandler(this.btnInicio_MouseLeave);
            this.btnInicio.MouseHover += new System.EventHandler(this.btnInicio_MouseHover);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 225);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(252, 22);
            this.lblNombreUsuario.TabIndex = 2;
            this.lblNombreUsuario.Text = "label1";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(96, 169);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(79, 22);
            this.lblNombreEmpresa.TabIndex = 1;
            this.lblNombreEmpresa.Text = "Multi-Pet";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::AdministracionTienda.Properties.Resources._3778546;
            this.picLogo.Location = new System.Drawing.Point(60, 41);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 150);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.Header.Controls.Add(this.btnMinimizar);
            this.Header.Controls.Add(this.btnCerrar);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(270, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1170, 41);
            this.Header.TabIndex = 1;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::AdministracionTienda.Properties.Resources.minimize;
            this.btnMinimizar.Location = new System.Drawing.Point(1092, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.toolMinimizar.SetToolTip(this.btnMinimizar, "Minimizar");
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::AdministracionTienda.Properties.Resources.close;
            this.btnCerrar.Location = new System.Drawing.Point(1128, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.toolCerrar.SetToolTip(this.btnCerrar, "Cerrar");
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(270, 41);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1170, 859);
            this.MainPanel.TabIndex = 2;
            // 
            // toolCerrar
            // 
            this.toolCerrar.AutomaticDelay = 200;
            this.toolCerrar.AutoPopDelay = 5000;
            this.toolCerrar.InitialDelay = 200;
            this.toolCerrar.ReshowDelay = 40;
            // 
            // tiempoSesion
            // 
            this.tiempoSesion.Interval = 60000;
            this.tiempoSesion.Tick += new System.EventHandler(this.tiempoSesion_Tick);
            // 
            // MenuBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet Shop";
            this.Load += new System.EventHandler(this.MenuBase_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFactu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNombreEmpresa;
        public System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.ToolTip toolCerrar;
        private System.Windows.Forms.ToolTip toolMinimizar;
        public System.Windows.Forms.Panel Menu;
        public System.Windows.Forms.Button btnInicio;
        public System.Windows.Forms.Button btnProductos;
        public System.Windows.Forms.Button btnFacturacion;
        public System.Windows.Forms.Button btnEmpleados;
        public System.Windows.Forms.Button btnClientes;
        public System.Windows.Forms.PictureBox picUsuarios;
        public System.Windows.Forms.PictureBox picFactu;
        public System.Windows.Forms.PictureBox picCliente;
        public System.Windows.Forms.PictureBox picProducto;
        public System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Timer tiempoSesion;
    }
}