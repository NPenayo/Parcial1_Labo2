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
    public partial class FormClientes : Form
    {
        static string parametroBusqueda;
        public FormClientes()
        {
            InitializeComponent();
            ListarClientes();
        }

        private void radioDNI_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarBusqueda();
            parametroBusqueda = "DNI";
        }

        private void radioNombre_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarBusqueda();
            parametroBusqueda = "Nombre";
        }

        private void radioApellido_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarBusqueda();
            parametroBusqueda = "Apellido";
        }
        /// <summary>
        /// Habilita el textBox para buscar
        /// </summary>
        private void HabilitarBusqueda()
        {
            this.txtBusqueda.Enabled = true;
        }
        /// <summary>
        /// Muestra la lista de todos los clientes
        /// </summary>
        private void ListarClientes()
        {
            listClientes.Items.Clear();
            if (Program.usuarios is not null)
            {
                foreach (Usuario user in Program.usuarios)
                {
                    if (user is Cliente)
                    {
                        Cliente client = user as Cliente;
                        string[] fila = { client.DNI, client.Nombre, client.Apellido, client.Saldo.ToString() };
                        ListViewItem item = new ListViewItem(fila);
                        listClientes.Items.Add(item);
                    }
                }
            }
        }
        /// <summary>
        /// Muestra los detalles de un cliente 
        /// </summary>
        /// <param name="cliente"></param>
        private void ListarClientes(Cliente cliente)
        {
            listClientes.Items.Clear();
            if (Program.usuarios is not null)
            {
                foreach (Usuario user in Program.usuarios)
                {
                    if (user is Cliente && user == cliente)
                    {
                        Cliente client = user as Cliente;
                        string[] fila = { client.DNI, client.Nombre, client.Apellido, client.Saldo.ToString() };
                        ListViewItem item = new ListViewItem(fila);
                        listClientes.Items.Add(item);
                    }
                }
            }
        }
        /// <summary>
        /// Filtra la lista de clientes segun un criterio de busqueda
        /// </summary>
        /// <param name="parametro"></param>
        private void FiltrarLista(string parametro)
        {
            if (parametro is not null)
            {
                switch (parametro)
                {
                    case "DNI":
                        foreach (Usuario usuario in Program.usuarios)
                        {
                            if (usuario is Cliente)
                            {
                                Cliente cliente = usuario as Cliente;
                                if (cliente.DNI == txtBusqueda.Text)
                                {
                                    ListarClientes(cliente);

                                }

                            }
                        }
                        break;
                    case "Apellido":
                        foreach (Usuario usuario in Program.usuarios)
                        {
                            if (usuario is Cliente)
                            {
                                Cliente cliente = usuario as Cliente;
                                if (cliente.Apellido == txtBusqueda.Text)
                                {
                                    ListarClientes(cliente);

                                }

                            }
                        }
                        break;
                    case "Nombre":
                        foreach (Usuario usuario in Program.usuarios)
                        {
                            if (usuario is Cliente)
                            {
                                Cliente cliente = usuario as Cliente;
                                if (cliente.Nombre == txtBusqueda.Text)
                                {
                                    ListarClientes(cliente);

                                }

                            }
                        }
                        break;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (parametroBusqueda is not null)
            {

                FiltrarLista(parametroBusqueda);
            }
            if (String.IsNullOrEmpty(txtBusqueda.Text))
            {
                ListarClientes();
            }
        }

        private void listClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection seleccionado = listClientes.SelectedItems;
            foreach (ListViewItem item in seleccionado)
            {

                Cliente cliente = ObtenerCliente(item.SubItems[0].Text);
                ModalCliente modalCliente = new ModalCliente(cliente);
                if (modalCliente.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Se actualizó correctamente el cliente");
                    ListarClientes();
                }
                break;
            }
        }

        private Cliente ObtenerCliente(string dni)
        {
            foreach (Usuario usuario in Program.usuarios)
            {
                if (usuario is Cliente)
                {
                    Cliente cliente = usuario as Cliente;
                    if (cliente.DNI == dni)
                    {
                        return cliente;

                    }

                }
            }
            return null;
        }
    }
}
