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
    public partial class ModalCantidad : Form
    {
        private static int stockProducto;
        public ModalCantidad()
        {
            InitializeComponent();
        }
        public ModalCantidad(int stock) : this()
        {
            stockProducto = stock;
            this.ShowDialog();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validacion.NumeroEntero(txtCantidad.Text) && int.Parse(txtCantidad.Text) <= stockProducto)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Cantidad invalida");
            }

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
