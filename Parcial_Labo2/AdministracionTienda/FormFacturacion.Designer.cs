
namespace AdministracionTienda
{
    partial class FormFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturacion));
            this.listTransacciones = new System.Windows.Forms.ListView();
            this.clID = new System.Windows.Forms.ColumnHeader();
            this.clFecha = new System.Windows.Forms.ColumnHeader();
            this.clUsuario = new System.Windows.Forms.ColumnHeader();
            this.clCliente = new System.Windows.Forms.ColumnHeader();
            this.clImporte = new System.Windows.Forms.ColumnHeader();
            this.lblFacturacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listTransacciones
            // 
            this.listTransacciones.BackColor = System.Drawing.Color.White;
            this.listTransacciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clID,
            this.clFecha,
            this.clUsuario,
            this.clCliente,
            this.clImporte});
            this.listTransacciones.HideSelection = false;
            this.listTransacciones.Location = new System.Drawing.Point(313, 253);
            this.listTransacciones.Name = "listTransacciones";
            this.listTransacciones.Size = new System.Drawing.Size(769, 529);
            this.listTransacciones.TabIndex = 0;
            this.listTransacciones.UseCompatibleStateImageBehavior = false;
            this.listTransacciones.View = System.Windows.Forms.View.Details;
            // 
            // clID
            // 
            this.clID.Text = "IDTransaccion";
            this.clID.Width = 120;
            // 
            // clFecha
            // 
            this.clFecha.Text = "Fecha";
            this.clFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clFecha.Width = 100;
            // 
            // clUsuario
            // 
            this.clUsuario.Text = "Empleado";
            this.clUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clUsuario.Width = 120;
            // 
            // clCliente
            // 
            this.clCliente.Text = "Cliente";
            this.clCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clCliente.Width = 120;
            // 
            // clImporte
            // 
            this.clImporte.Text = "Importe";
            this.clImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clImporte.Width = 120;
            // 
            // lblFacturacion
            // 
            this.lblFacturacion.AutoSize = true;
            this.lblFacturacion.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFacturacion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblFacturacion.Location = new System.Drawing.Point(965, 109);
            this.lblFacturacion.Name = "lblFacturacion";
            this.lblFacturacion.Size = new System.Drawing.Size(117, 22);
            this.lblFacturacion.TabIndex = 1;
            this.lblFacturacion.Text = "FACTURACION";
            // 
            // FormFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 929);
            this.Controls.Add(this.lblFacturacion);
            this.Controls.Add(this.listTransacciones);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFacturacion";
            this.Text = "FormFacturacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listTransacciones;
        private System.Windows.Forms.ColumnHeader clID;
        private System.Windows.Forms.ColumnHeader clFecha;
        private System.Windows.Forms.ColumnHeader clUsuario;
        private System.Windows.Forms.ColumnHeader clCliente;
        private System.Windows.Forms.ColumnHeader clImporte;
        private System.Windows.Forms.Label lblFacturacion;
    }
}