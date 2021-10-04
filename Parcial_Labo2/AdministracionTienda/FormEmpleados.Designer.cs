
namespace AdministracionTienda
{
    partial class FormEmpleados
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
            this.listEmpleados = new System.Windows.Forms.ListView();
            this.cUserName = new System.Windows.Forms.ColumnHeader();
            this.clNombre = new System.Windows.Forms.ColumnHeader();
            this.clApellido = new System.Windows.Forms.ColumnHeader();
            this.clFechaNac = new System.Windows.Forms.ColumnHeader();
            this.clCuil = new System.Windows.Forms.ColumnHeader();
            this.clDireccion = new System.Windows.Forms.ColumnHeader();
            this.clPrivilegios = new System.Windows.Forms.ColumnHeader();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.radioApellido = new System.Windows.Forms.RadioButton();
            this.radioNombre = new System.Windows.Forms.RadioButton();
            this.radioDNI = new System.Windows.Forms.RadioButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.radioPrivilegios = new System.Windows.Forms.RadioButton();
            this.cmbPrivilegios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listEmpleados
            // 
            this.listEmpleados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cUserName,
            this.clNombre,
            this.clApellido,
            this.clFechaNac,
            this.clCuil,
            this.clDireccion,
            this.clPrivilegios});
            this.listEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listEmpleados.HideSelection = false;
            this.listEmpleados.Location = new System.Drawing.Point(69, 224);
            this.listEmpleados.Name = "listEmpleados";
            this.listEmpleados.Size = new System.Drawing.Size(1030, 570);
            this.listEmpleados.TabIndex = 16;
            this.listEmpleados.UseCompatibleStateImageBehavior = false;
            this.listEmpleados.View = System.Windows.Forms.View.Details;
            this.listEmpleados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listEmpleados_MouseDoubleClick);
            // 
            // cUserName
            // 
            this.cUserName.Text = "Nombre de Usuario";
            this.cUserName.Width = 130;
            // 
            // clNombre
            // 
            this.clNombre.Text = "Nombre";
            this.clNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clNombre.Width = 150;
            // 
            // clApellido
            // 
            this.clApellido.Text = "Apellido";
            this.clApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clApellido.Width = 150;
            // 
            // clFechaNac
            // 
            this.clFechaNac.Text = "Fecha de Nacimiento";
            this.clFechaNac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clFechaNac.Width = 150;
            // 
            // clCuil
            // 
            this.clCuil.Text = "CUIL";
            this.clCuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clCuil.Width = 150;
            // 
            // clDireccion
            // 
            this.clDireccion.Text = "Direccion";
            this.clDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clDireccion.Width = 200;
            // 
            // clPrivilegios
            // 
            this.clPrivilegios.Text = "Pivilegios";
            this.clPrivilegios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clPrivilegios.Width = 120;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(222)))), ((int)(((byte)(100)))));
            this.btnCrearUsuario.FlatAppearance.BorderSize = 0;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCrearUsuario.Location = new System.Drawing.Point(959, 165);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(140, 40);
            this.btnCrearUsuario.TabIndex = 15;
            this.btnCrearUsuario.Text = "NUEVO EMPLEADO";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBusqueda.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBusqueda.Location = new System.Drawing.Point(909, 59);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(190, 26);
            this.lblBusqueda.TabIndex = 14;
            this.lblBusqueda.Text = "BUSCAR EMPLEADO";
            // 
            // radioApellido
            // 
            this.radioApellido.AutoSize = true;
            this.radioApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioApellido.Location = new System.Drawing.Point(70, 113);
            this.radioApellido.Name = "radioApellido";
            this.radioApellido.Size = new System.Drawing.Size(70, 21);
            this.radioApellido.TabIndex = 13;
            this.radioApellido.TabStop = true;
            this.radioApellido.Text = "Apellido";
            this.radioApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioApellido.UseVisualStyleBackColor = false;
            this.radioApellido.CheckedChanged += new System.EventHandler(this.radioApellido_CheckedChanged);
            // 
            // radioNombre
            // 
            this.radioNombre.AutoSize = true;
            this.radioNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioNombre.Location = new System.Drawing.Point(70, 86);
            this.radioNombre.Name = "radioNombre";
            this.radioNombre.Size = new System.Drawing.Size(71, 21);
            this.radioNombre.TabIndex = 12;
            this.radioNombre.TabStop = true;
            this.radioNombre.Text = "Nombre";
            this.radioNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioNombre.UseVisualStyleBackColor = false;
            this.radioNombre.CheckedChanged += new System.EventHandler(this.radioNombre_CheckedChanged);
            // 
            // radioDNI
            // 
            this.radioDNI.AutoSize = true;
            this.radioDNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioDNI.Location = new System.Drawing.Point(70, 59);
            this.radioDNI.Name = "radioDNI";
            this.radioDNI.Size = new System.Drawing.Size(46, 21);
            this.radioDNI.TabIndex = 11;
            this.radioDNI.TabStop = true;
            this.radioDNI.Text = "DNI";
            this.radioDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioDNI.UseVisualStyleBackColor = false;
            this.radioDNI.CheckedChanged += new System.EventHandler(this.radioDNI_CheckedChanged);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Enabled = false;
            this.txtBusqueda.Location = new System.Drawing.Point(70, 175);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(267, 24);
            this.txtBusqueda.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(360, 165);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 40);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // radioPrivilegios
            // 
            this.radioPrivilegios.AutoSize = true;
            this.radioPrivilegios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioPrivilegios.Location = new System.Drawing.Point(70, 140);
            this.radioPrivilegios.Name = "radioPrivilegios";
            this.radioPrivilegios.Size = new System.Drawing.Size(82, 21);
            this.radioPrivilegios.TabIndex = 17;
            this.radioPrivilegios.TabStop = true;
            this.radioPrivilegios.Text = "Privilegios";
            this.radioPrivilegios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioPrivilegios.UseVisualStyleBackColor = false;
            this.radioPrivilegios.CheckedChanged += new System.EventHandler(this.radioPrivilegios_CheckedChanged);
            // 
            // cmbPrivilegios
            // 
            this.cmbPrivilegios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPrivilegios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrivilegios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPrivilegios.FormattingEnabled = true;
            this.cmbPrivilegios.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cmbPrivilegios.Location = new System.Drawing.Point(70, 173);
            this.cmbPrivilegios.Name = "cmbPrivilegios";
            this.cmbPrivilegios.Size = new System.Drawing.Size(267, 25);
            this.cmbPrivilegios.TabIndex = 18;
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 929);
            this.Controls.Add(this.radioPrivilegios);
            this.Controls.Add(this.listEmpleados);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.radioApellido);
            this.Controls.Add(this.radioNombre);
            this.Controls.Add(this.radioDNI);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbPrivilegios);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmpleados";
            this.Text = "FormUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listEmpleados;
        private System.Windows.Forms.ColumnHeader cUserName;
        private System.Windows.Forms.ColumnHeader clNombre;
        private System.Windows.Forms.ColumnHeader clApellido;
        private System.Windows.Forms.ColumnHeader clPrivilegios;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.RadioButton radioApellido;
        private System.Windows.Forms.RadioButton radioNombre;
        private System.Windows.Forms.RadioButton radioDNI;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton radioPrivilegios;
        private System.Windows.Forms.ComboBox cmbPrivilegios;
        private System.Windows.Forms.ColumnHeader clFechaNac;
        private System.Windows.Forms.ColumnHeader clCuil;
        private System.Windows.Forms.ColumnHeader clDireccion;
    }
}