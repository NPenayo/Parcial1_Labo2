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
    public partial class FormEmpleados : Form
    {
        static string criterioBusqueda;
        public FormEmpleados()
        {
            InitializeComponent();
            ListarEmpleados();
        }

        private void radioDNI_CheckedChanged(object sender, EventArgs e)
        {
            criterioBusqueda = "DNI";
            HabilitarBusqueda();
        }

        private void radioNombre_CheckedChanged(object sender, EventArgs e)
        {
            criterioBusqueda = "Nombre";
            HabilitarBusqueda();
        }

        private void radioApellido_CheckedChanged(object sender, EventArgs e)
        {
            criterioBusqueda = "Apellido";
            HabilitarBusqueda();
        }

        private void radioPrivilegios_CheckedChanged(object sender, EventArgs e)
        {
            criterioBusqueda = "Privilegios";
            cmbPrivilegios.BringToFront();
        }
        private void ListarEmpleados()
        {
            listEmpleados.Items.Clear();
            if (Program.usuarios is not null)
            {
                foreach (Usuario user in Program.usuarios)
                {
                    if (user is Empleado)
                    {
                        Empleado empleado = user as Empleado;
                        string[] fila = { empleado.NombreUsuario, empleado.Nombre, empleado.Apellido, empleado.FechaNacimiento, empleado.Cuil, empleado.Direccion, empleado.GetType().Name };
                        ListViewItem item = new ListViewItem(fila);
                        listEmpleados.Items.Add(item);
                    }
                }
            }
        }
        private void ListarEmpleados(Empleado buscar)
        {
            if (Program.usuarios is not null)
            {
                foreach (Usuario user in Program.usuarios)
                {
                    if (user is Empleado && user == buscar)
                    {
                        Empleado empleado = user as Empleado;
                        string[] fila = { empleado.NombreUsuario, empleado.Nombre, empleado.Apellido, empleado.FechaNacimiento, empleado.Cuil, empleado.Direccion, empleado.GetType().Name };
                        ListViewItem item = new ListViewItem(fila);
                        listEmpleados.Items.Add(item);
                    }
                }
            }
        }
        private void HabilitarBusqueda()
        {
            txtBusqueda.Enabled = true;
            txtBusqueda.BringToFront();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (criterioBusqueda is not null)
            {

                FiltrarLista(criterioBusqueda);
            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            ModalEmpleado modal = new ModalEmpleado();
            if (modal.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Se creo el usuario correctamente");
                ListarEmpleados();
            }
        }
        private void FiltrarLista(string parametro)
        {
            if (parametro is not null)
            {
                listEmpleados.Items.Clear();
                switch (parametro)
                {
                    case "DNI":
                        foreach (Usuario usuario in Program.usuarios)
                        {
                            if (usuario is Empleado)
                            {
                                Empleado empleado = usuario as Empleado;
                                if (empleado.DNI == txtBusqueda.Text)
                                {
                                    ListarEmpleados(empleado);

                                }

                            }
                        }
                        break;
                    case "Apellido":
                        foreach (Usuario usuario in Program.usuarios)
                        {
                            if (usuario is Empleado)
                            {
                                Empleado empleado = usuario as Empleado;
                                if (empleado.Apellido == txtBusqueda.Text)
                                {
                                    ListarEmpleados(empleado);

                                }

                            }
                        }
                        break;
                    case "Nombre":
                        foreach (Usuario usuario in Program.usuarios)
                        {
                            if (usuario is Empleado)
                            {
                                Empleado empleado = usuario as Empleado;
                                if (empleado.Nombre == txtBusqueda.Text)
                                {
                                    ListarEmpleados(empleado);

                                }

                            }
                        }
                        break;
                    case "Privilegios":
                        foreach (Usuario usuario in Program.usuarios)
                        {
                            if (usuario is Empleado)
                            {
                                Empleado empleado = usuario as Empleado;
                                if (empleado.GetType().Name == cmbPrivilegios.SelectedItem.ToString())
                                {
                                    ListarEmpleados(empleado);

                                }

                            }
                        }
                        break;
                }
            }
        }

        private void listEmpleados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection seleccionado = listEmpleados.SelectedItems;
            foreach (ListViewItem item in seleccionado)
            {

                Empleado empleado = ObtenerEmpleado(item.SubItems[0].Text);
                ModalEmpleado modalEmpleado = new ModalEmpleado(empleado);
                if (modalEmpleado.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Se actualizó correctamente el empleado");
                    ListarEmpleados();
                }
                break;
            }
        }
        private Empleado ObtenerEmpleado(string nombreUsuario)
        {
            foreach (Usuario usuario in Program.usuarios)
            {
                if (usuario is Empleado)
                {
                    Empleado empleado = usuario as Empleado;
                    if (empleado.NombreUsuario == nombreUsuario)
                    {
                        return empleado;

                    }

                }
            }
            return null;
        }
    }
}
