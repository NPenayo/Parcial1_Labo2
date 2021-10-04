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

    public partial class FormInicio : Form
    {
        static int horas;
        static int minutos;
        static List<Cliente> clientes;
        static Transaccion transaccion;
        static Cliente clienteTrx;
        public FormInicio()
        {
            InitializeComponent();
            MostrarHora();
            timerHora.Enabled = true;
        }

        private void btnNuevaOpe_Click(object sender, EventArgs e)
        {
            this.panelCliente.Visible = true;
            clientes = new List<Cliente>();
            foreach (Usuario item in Program.usuarios)
            {
                if (item is Cliente)
                {

                    clientes.Add((Cliente)item);
                }
            }


        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            MostrarHora();

        }
        private void MostrarHora()
        {
            horas = DateTime.Now.Hour;
            minutos = DateTime.Now.Minute;
            if (minutos < 10)
            {
                this.lblHora.Text = $"{horas}:0{minutos}";

            }
            else
            {
                this.lblHora.Text = $"{horas}:{minutos}";
            }
        }
        private Cliente BuscarCliente(string valor)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.DNI == valor)
                {
                    clienteTrx = cliente;
                    return cliente;
                }
            }
            return null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            if (dni is null)
            {
                txtDni.Text = "Debe escribir un DNI";
            }
            else
            {
                clienteTrx = BuscarCliente(dni);
                if (clienteTrx is null)
                {
                    MessageBox.Show("No se encontró el cliente");
                }
                else
                {
                    txtApellido.Text = clienteTrx.Apellido;
                    txtNombre.Text = clienteTrx.Nombre;
                    ImprimirSaldo();
                    panelCompra.Visible = true;
                    MostrarProductos();
                    transaccion = null;
                }

            }
        }
        private void MostrarProductos()
        {
            listProductos.Items.Clear();
            foreach (Producto producto in Program.productos)
            {
                if (producto.Stock > 0)
                {
                    string[] fila = { producto.IdProducto.Trim(), producto.Marca, producto.Descripcion, producto.Precio.ToString(), producto.Stock.ToString() };
                    ListViewItem item = new ListViewItem(fila);
                    listProductos.Items.Add(item);
                }

            }
        }

        private void listProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int stockItem = 0;
            double precioItem;
            Producto prod = null;
            ListView.SelectedListViewItemCollection seleccionado = listProductos.SelectedItems;
            foreach (ListViewItem item in seleccionado)
            {
                stockItem = int.Parse(item.SubItems[4].Text);
                precioItem = double.Parse(item.SubItems[3].Text);
                prod = ObtenerProducto(item.SubItems[0].Text);
                break;
            }
            ModalCantidad modalCantidad = new ModalCantidad(stockItem);
            if (transaccion is null)
            {
                transaccion = new Transaccion(clienteTrx, Program.sesion.Usuario as Empleado);
            }
            if (modalCantidad.DialogResult == DialogResult.OK && prod is not null)
            {

                int cantidad = int.Parse(modalCantidad.txtCantidad.Text);
                if (transaccion.AgregarProducto(prod, cantidad))
                {
                    ImprimirSaldo();
                    MostrarProductos();
                    ImprimirTotal();
                }
                else
                {
                    MessageBox.Show("Saldo del cliente insuficiente");
                }

            }
        }
        private Producto ObtenerProducto(string productId)
        {
            foreach (Producto producto in Program.productos)
            {
                if (producto.IdProducto == productId)
                {
                    return producto;
                }
            }
            return null;
        }
        private void ImprimirSaldo()
        {
            if(clienteTrx is not null)
            {

            string saldo = clienteTrx.Saldo.ToString("N2");
            lblSaldo.Text = $"Saldo: $ {saldo}";
            }
            else
            {
                lblSaldo.Text = "Saldo: $ 0";

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (transaccion is not null)
            {

                foreach (KeyValuePair<Producto, int> item in transaccion.Productos)
                {
                    transaccion.QuitarProducto(item.Key);
                }
                MostrarProductos();
                ImprimirSaldo();
                ImprimirTotal();

            }
        }
        private void ImprimirTotal()
        {
            lblTotal.Text = $"${transaccion.Total.ToString("N2")}";

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (transaccion is not null)
            {
                Factura factura = new Factura(ETipoFactura.B, transaccion);
                factura.Guardar();
                MessageBox.Show($"Compra realizada con exito, se generó la factura\n {factura.NumeroFactura}");
                panelCompra.Visible = false;
                LimpiarTodo();
            }

        }

        private void btnCerrarLista_Click(object sender, EventArgs e)
        {
            panelCompra.Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void LimpiarTodo()
        {
            txtDni.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            ImprimirSaldo();
            lblTotal.Text = "0";
        }
    }
}
