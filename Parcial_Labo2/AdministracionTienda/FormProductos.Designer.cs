
namespace AdministracionTienda
{
    partial class FormProductos
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listProductos = new System.Windows.Forms.ListView();
            this.listCodigo = new System.Windows.Forms.ColumnHeader();
            this.listMarca = new System.Windows.Forms.ColumnHeader();
            this.listDescripcion = new System.Windows.Forms.ColumnHeader();
            this.listPrecio = new System.Windows.Forms.ColumnHeader();
            this.listStock = new System.Windows.Forms.ColumnHeader();
            this.listCategorias = new System.Windows.Forms.ListView();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.btnAgregar);
            this.panelBody.Controls.Add(this.listProductos);
            this.panelBody.Controls.Add(this.listCategorias);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1154, 929);
            this.panelBody.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(222)))), ((int)(((byte)(100)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(862, 750);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(201, 48);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "CARGAR PRODUCTO";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listProductos
            // 
            this.listProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listCodigo,
            this.listMarca,
            this.listDescripcion,
            this.listPrecio,
            this.listStock});
            this.listProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listProductos.HideSelection = false;
            this.listProductos.Location = new System.Drawing.Point(382, 32);
            this.listProductos.Name = "listProductos";
            this.listProductos.Size = new System.Drawing.Size(681, 696);
            this.listProductos.TabIndex = 1;
            this.listProductos.UseCompatibleStateImageBehavior = false;
            this.listProductos.View = System.Windows.Forms.View.Details;
            this.listProductos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listProductos_MouseDoubleClick);
            // 
            // listCodigo
            // 
            this.listCodigo.Text = "Codigo";
            this.listCodigo.Width = 100;
            // 
            // listMarca
            // 
            this.listMarca.Text = "Marca";
            this.listMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listMarca.Width = 120;
            // 
            // listDescripcion
            // 
            this.listDescripcion.Text = "Descripcion";
            this.listDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listDescripcion.Width = 300;
            // 
            // listPrecio
            // 
            this.listPrecio.Text = "Precio";
            this.listPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listPrecio.Width = 80;
            // 
            // listStock
            // 
            this.listStock.Text = "Stock";
            this.listStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listStock.Width = 80;
            // 
            // listCategorias
            // 
            this.listCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listCategorias.HideSelection = false;
            this.listCategorias.Location = new System.Drawing.Point(91, 64);
            this.listCategorias.Name = "listCategorias";
            this.listCategorias.Scrollable = false;
            this.listCategorias.Size = new System.Drawing.Size(250, 835);
            this.listCategorias.TabIndex = 0;
            this.listCategorias.UseCompatibleStateImageBehavior = false;
            this.listCategorias.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listCategorias_MouseDoubleClick);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 929);
            this.Controls.Add(this.panelBody);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.ListView listCategorias;
        private System.Windows.Forms.ListView listProductos;
        private System.Windows.Forms.ColumnHeader listCodigo;
        private System.Windows.Forms.ColumnHeader listMarca;
        private System.Windows.Forms.ColumnHeader listDescripcion;
        private System.Windows.Forms.ColumnHeader listPrecio;
        private System.Windows.Forms.ColumnHeader listStock;
        private System.Windows.Forms.Button btnAgregar;
    }
}