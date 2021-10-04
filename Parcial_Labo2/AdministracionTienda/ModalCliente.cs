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
    public partial class ModalCliente : Form
    {
        static Cliente cliente;
        public ModalCliente()
        {
            InitializeComponent();
            this.btnGuardar.Visible = false;
            this.btnAceptar.Visible = true;
            this.btnAceptar.BringToFront();
            this.ShowDialog();
        }
        public ModalCliente(Cliente client)
        {
            InitializeComponent();
            cliente = client;
            this.btnGuardar.Visible = true;
            this.btnAceptar.Visible = false;
            this.btnGuardar.BringToFront();
            this.btnEliminar.Visible = true;
            txtDni.Text = client.DNI;
            txtApellido.Text = client.Apellido;
            txtNombre.Text = client.Nombre;
            txtSaldo.Text = client.Saldo.ToString();
            this.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDni.Text) && !String.IsNullOrEmpty(txtNombre.Text) && !String.IsNullOrEmpty(txtApellido.Text) && !String.IsNullOrEmpty(txtSaldo.Text) && Validacion.Dni(txtDni.Text) && double.TryParse(txtSaldo.Text, out double saldo))
            {
                Cliente nuevoCliente = new Cliente(txtDni.Text, txtNombre.Text, txtApellido.Text, saldo);
                Program.usuarios.Add(nuevoCliente);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Parametros invalidos");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDni.Text) && !String.IsNullOrEmpty(txtNombre.Text) && !String.IsNullOrEmpty(txtApellido.Text) && !String.IsNullOrEmpty(txtSaldo.Text) && Validacion.Dni(txtDni.Text) && double.TryParse(txtSaldo.Text, out double saldo))
            {
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.DNI = txtDni.Text;
                cliente.Saldo = saldo;
                DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Parametros invalidos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar el cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Program.usuarios.Remove(cliente);
                DialogResult = DialogResult.OK;

            }
        }
    }
}
