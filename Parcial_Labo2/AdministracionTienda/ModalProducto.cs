using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
namespace AdministracionTienda
{
    public partial class ModalProducto : Form
    {
        static Producto product;
        public ModalProducto()
        {
            InitializeComponent();
            this.ShowDialog();
            btnGuardar.Visible = false;
            btnAceptar.Visible = true;
            btnAceptar.BringToFront();
        }
        public ModalProducto(Producto producto)
        {
            InitializeComponent();
            product = producto;
            txtMarca.Text = product.Marca;
            txtDescripcion.Text = product.Descripcion;
            txtPrecio.Text = product.Precio.ToString();
            txtStock.Text = product.Stock.ToString();
            cmbTipo.Text = product.Tipo.ToString();
            btnGuardar.Visible = true;
            btnEliminar.Visible = true;
            btnGuardar.BringToFront();
            btnAceptar.Visible = false;
            this.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion is not null && txtMarca is not null && txtPrecio is not null && txtStock is not null)
            {
                if (double.TryParse(txtPrecio.Text, out double precio) && int.TryParse(txtStock.Text, out int stock))
                {
                    ETipoProducto tipo = (ETipoProducto)Enum.Parse(typeof(ETipoProducto), cmbTipo.SelectedItem.ToString());
                    Producto nuevoProd = new Producto(tipo, precio, txtMarca.Text, txtDescripcion.Text, stock);
                    if (!Program.productos.Contains(nuevoProd))
                    {
                        Program.productos.Add(nuevoProd);
                        DialogResult = DialogResult.OK;
                    }
                    DialogResult = DialogResult.Cancel;

                }
                else
                {
                    MessageBox.Show("Los valores ingresados son incorrectos");
                }

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrecio.Text, out double precio) && int.TryParse(txtStock.Text, out int stock))
            {
                int indice = Program.productos.IndexOf(product);
                ETipoProducto tipo = (ETipoProducto)Enum.Parse(typeof(ETipoProducto), cmbTipo.SelectedItem.ToString());
                Program.productos[indice].Marca = txtMarca.Text;
                Program.productos[indice].Descripcion = txtDescripcion.Text;
                Program.productos[indice].Stock = stock;
                Program.productos[indice].Precio = precio;
                Program.productos[indice].Tipo = tipo;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea eliminar el producto", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes){
                Program.productos.Remove(product);
                DialogResult = DialogResult.OK;
            }
           
        }
    }
}
