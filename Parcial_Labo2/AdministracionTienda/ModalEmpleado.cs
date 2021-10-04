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
    public partial class ModalEmpleado : Form
    {
        static Empleado empleado;
        public ModalEmpleado()
        {
            InitializeComponent();
            lblNuevaPass.Text = "Password";
            btnAceptar.Visible = true;
            btnAceptar.BringToFront();
            btnGuardar.Visible = false;
            this.ShowDialog();
        }
        public ModalEmpleado(Empleado emp)
        {
            InitializeComponent();
            lblNuevaPass.Text = "Nueva Password";
            panelNuevaPass.Visible = false;
            txtNuevaPass.Visible = false;
            txtVerificar.Visible = false;
            lblNuevaPass.Visible = false;
            lblVerificar.Visible = false;
            empleado = emp;
            txtNombre.Text = empleado.Nombre;
            txtApellido.Text = empleado.Apellido;
            txtDni.Text = empleado.DNI;
            txtFecha.Text = empleado.FechaNacimiento;
            txtDireccion.Text = emp.Direccion;
            txtLocalidad.Text = emp.Localidad;
            txtCuil.Text = emp.Cuil;
            cmbPrivilegios.Text = emp.GetType().Name;
            btnCambiarClave.Visible = true;
            btnEliminar.Visible = true;
            btnAceptar.Visible = false;
            btnGuardar.BringToFront();
            btnGuardar.Visible = true;
            this.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtApellido.Text) &&
                !String.IsNullOrEmpty(txtNombre.Text) &&
                !String.IsNullOrEmpty(txtDni.Text) &&
                !String.IsNullOrEmpty(txtFecha.Text) &&
                !String.IsNullOrEmpty(txtDireccion.Text) &&
                !String.IsNullOrEmpty(txtLocalidad.Text) &&
                !String.IsNullOrEmpty(txtCuil.Text) &&
                !String.IsNullOrEmpty(cmbPrivilegios.Text))
            {
                if (Validacion.Cuil(txtCuil.Text) && Validacion.Dni(txtDni.Text) && Validacion.Fecha(txtFecha.Text) && VerificarClaves())
                {
                    if (cmbPrivilegios.SelectedItem.ToString() == "Empleado")
                    {
                        Empleado nuevoEmpleado = new Empleado(txtDni.Text, txtNombre.Text, txtApellido.Text, txtFecha.Text, txtDireccion.Text, txtLocalidad.Text, txtCuil.Text, txtNuevaPass.Text);
                        Program.usuarios.Add(nuevoEmpleado);
                        DialogResult = DialogResult.OK;

                    }
                    if (cmbPrivilegios.SelectedItem.ToString() == "Administrador")
                    {
                        Administrador nuevoAdmin = new Administrador(txtDni.Text, txtNombre.Text, txtApellido.Text, txtFecha.Text, txtDireccion.Text, txtLocalidad.Text, txtCuil.Text, txtNuevaPass.Text);
                        Program.usuarios.Add(nuevoAdmin);
                        DialogResult = DialogResult.OK;

                    }
                }
                else
                {
                    MessageBox.Show("Los datos ingresados son ivalidos");
                }
            }
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            panelNuevaPass.Visible = true;
            txtNuevaPass.Visible = true;
            txtVerificar.Visible = true;
            lblNuevaPass.Visible = true;
            lblVerificar.Visible = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar el usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Program.usuarios.Remove(empleado);
                DialogResult = DialogResult.OK;
            }
        }
        private bool VerificarClaves()
        {
            if (!String.IsNullOrEmpty(txtNuevaPass.Text) && Validacion.FormatoPassword(txtNuevaPass.Text) && txtNuevaPass.Text == txtVerificar.Text)
            {
                return true;
            }
            return false;
        }

        private void ModalEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
