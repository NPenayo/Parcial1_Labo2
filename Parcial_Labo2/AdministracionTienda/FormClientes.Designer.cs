
namespace AdministracionTienda
{
    partial class FormClientes
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.radioDNI = new System.Windows.Forms.RadioButton();
            this.radioNombre = new System.Windows.Forms.RadioButton();
            this.radioApellido = new System.Windows.Forms.RadioButton();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.listClientes = new System.Windows.Forms.ListView();
            this.clDNI = new System.Windows.Forms.ColumnHeader();
            this.clNombre = new System.Windows.Forms.ColumnHeader();
            this.clApellido = new System.Windows.Forms.ColumnHeader();
            this.clSaldo = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(374, 158);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 40);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Enabled = false;
            this.txtBusqueda.Location = new System.Drawing.Point(78, 175);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(267, 24);
            this.txtBusqueda.TabIndex = 2;
            // 
            // radioDNI
            // 
            this.radioDNI.AutoSize = true;
            this.radioDNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioDNI.Location = new System.Drawing.Point(79, 94);
            this.radioDNI.Name = "radioDNI";
            this.radioDNI.Size = new System.Drawing.Size(46, 21);
            this.radioDNI.TabIndex = 3;
            this.radioDNI.TabStop = true;
            this.radioDNI.Text = "DNI";
            this.radioDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioDNI.UseVisualStyleBackColor = false;
            this.radioDNI.CheckedChanged += new System.EventHandler(this.radioDNI_CheckedChanged);
            // 
            // radioNombre
            // 
            this.radioNombre.AutoSize = true;
            this.radioNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioNombre.Location = new System.Drawing.Point(78, 121);
            this.radioNombre.Name = "radioNombre";
            this.radioNombre.Size = new System.Drawing.Size(71, 21);
            this.radioNombre.TabIndex = 4;
            this.radioNombre.TabStop = true;
            this.radioNombre.Text = "Nombre";
            this.radioNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioNombre.UseVisualStyleBackColor = false;
            this.radioNombre.CheckedChanged += new System.EventHandler(this.radioNombre_CheckedChanged);
            // 
            // radioApellido
            // 
            this.radioApellido.AutoSize = true;
            this.radioApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioApellido.Location = new System.Drawing.Point(78, 148);
            this.radioApellido.Name = "radioApellido";
            this.radioApellido.Size = new System.Drawing.Size(70, 21);
            this.radioApellido.TabIndex = 5;
            this.radioApellido.TabStop = true;
            this.radioApellido.Text = "Apellido";
            this.radioApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioApellido.UseVisualStyleBackColor = false;
            this.radioApellido.CheckedChanged += new System.EventHandler(this.radioApellido_CheckedChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBusqueda.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBusqueda.Location = new System.Drawing.Point(545, 89);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(163, 26);
            this.lblBusqueda.TabIndex = 6;
            this.lblBusqueda.Text = "BUSCAR CLIENTE";
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(222)))), ((int)(((byte)(100)))));
            this.btnCrearCliente.FlatAppearance.BorderSize = 0;
            this.btnCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCliente.ForeColor = System.Drawing.Color.White;
            this.btnCrearCliente.Location = new System.Drawing.Point(568, 159);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(140, 40);
            this.btnCrearCliente.TabIndex = 7;
            this.btnCrearCliente.Text = "NUEVO CLIENTE";
            this.btnCrearCliente.UseVisualStyleBackColor = false;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
            // 
            // listClientes
            // 
            this.listClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clDNI,
            this.clNombre,
            this.clApellido,
            this.clSaldo});
            this.listClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listClientes.HideSelection = false;
            this.listClientes.Location = new System.Drawing.Point(78, 221);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(630, 526);
            this.listClientes.TabIndex = 8;
            this.listClientes.UseCompatibleStateImageBehavior = false;
            this.listClientes.View = System.Windows.Forms.View.Details;
            this.listClientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listClientes_MouseDoubleClick);
            // 
            // clDNI
            // 
            this.clDNI.Text = "DNI";
            this.clDNI.Width = 150;
            // 
            // clNombre
            // 
            this.clNombre.Text = "Nombre";
            this.clNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clNombre.Width = 180;
            // 
            // clApellido
            // 
            this.clApellido.Text = "Apellido";
            this.clApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clApellido.Width = 180;
            // 
            // clSaldo
            // 
            this.clSaldo.Text = "Saldo";
            this.clSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clSaldo.Width = 120;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 859);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.btnCrearCliente);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.radioApellido);
            this.Controls.Add(this.radioNombre);
            this.Controls.Add(this.radioDNI);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.RadioButton radioDNI;
        private System.Windows.Forms.RadioButton radioNombre;
        private System.Windows.Forms.RadioButton radioApellido;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.ListView listClientes;
        private System.Windows.Forms.ColumnHeader clDNI;
        private System.Windows.Forms.ColumnHeader clNombre;
        private System.Windows.Forms.ColumnHeader clApellido;
        private System.Windows.Forms.ColumnHeader clSaldo;
    }
}