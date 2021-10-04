using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AdministracionTienda
{

    public partial class MenuBase : Form
    {
        static int timeOut = 3;
        private Login login;
        private Form formActivo = null;
        public MenuBase()
        {
            InitializeComponent();
            AbrirFormEnCuerpo(new FormInicio());
        }

        public MenuBase(Login form, string nombreUsuario) : this()
        {
            this.lblNombreUsuario.Text = nombreUsuario;
            this.login = form;

        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.login.Show();
                this.Close();

            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Cambia el color de la fuente al hacer hover
        /// </summary>
        /// <param name="btn"></param>
        static void ColorHover(Button btn)
        {
            btn.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

        }
        /// <summary>
        /// Cambia el color de la fuente al hacer leave
        /// </summary>
        /// <param name="btn"></param>
        static void ColorLeave(Button btn)
        {
            btn.ForeColor = SystemColors.ButtonHighlight;

        }
        #region Boton Inicio
        private void btnInicio_Click(object sender, EventArgs e)
        {
            ColorHover(btnInicio);
            btnInicio.Focus();
            AbrirFormEnCuerpo(new FormInicio());

        }
        private void btnInicio_MouseHover(object sender, EventArgs e)
        {
            ColorHover(btnInicio);

        }
        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            if (!btnInicio.Focused)
            {
                ColorLeave(btnInicio);
            }

        }
        private void btnInicio_Leave(object sender, EventArgs e)
        {
            ColorLeave(btnInicio);

        }
        #endregion
        #region Boton Productos
        private void btnProductos_Click(object sender, EventArgs e)
        {
            ColorHover(btnProductos);
            btnProductos.Focus();
            AbrirFormEnCuerpo(new FormProductos());


        }
        private void btnProductos_MouseHover(object sender, EventArgs e)
        {
            ColorHover(btnProductos);
        }

        private void btnProductos_MouseLeave(object sender, EventArgs e)
        {
            if (!btnProductos.Focused)
            {

                ColorLeave(btnProductos);
            }
        }
        private void btnProductos_Leave(object sender, EventArgs e)
        {
            ColorLeave(btnProductos);
        }
        #endregion
        #region Boton Clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            ColorHover(btnClientes);
            btnClientes.Focus();
            AbrirFormEnCuerpo(new FormClientes());

        }
        private void btnClientes_MouseHover(object sender, EventArgs e)
        {
            ColorHover(btnClientes);

        }
        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
            if (!btnClientes.Focused)
            {

                ColorLeave(btnClientes);
            }
        }

        private void btnClientes_Leave(object sender, EventArgs e)
        {
            ColorLeave(btnClientes);
        }
        #endregion
        #region Boton Empleados
        private void btnEmpleados_MouseHover(object sender, EventArgs e)
        {
            ColorHover(btnEmpleados);

        }
        private void btnEmpleados_MouseLeave(object sender, EventArgs e)
        {
            if (!btnEmpleados.Focused)
            {

                ColorLeave(btnEmpleados);
            }
        }

        private void btnEmpleados_Leave(object sender, EventArgs e)
        {
            ColorLeave(btnEmpleados);

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ColorHover(btnEmpleados);
            btnEmpleados.Focus();
            AbrirFormEnCuerpo(new FormEmpleados());

        }
        #endregion
        #region Boton Facturacion

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            ColorHover(btnFacturacion);
            btnFacturacion.Focus();
            AbrirFormEnCuerpo(new FormFacturacion());

        }
        private void btnFacturacion_MouseHover(object sender, EventArgs e)
        {
            ColorHover(btnFacturacion);

        }

        private void btnFacturacion_MouseLeave(object sender, EventArgs e)
        {
            if (!btnFacturacion.Focused)
            {
                ColorLeave(btnFacturacion);
            }
        }

        private void btnFacturacion_Leave(object sender, EventArgs e)
        {
            ColorLeave(btnFacturacion);
        }
        #endregion
        ///
        private void tiempoSesion_Tick(object sender, EventArgs e)
        {

            VerificarActividad(Menu.Controls);
            VerificarActividad(MainPanel.Controls);


            if (timeOut <= 0)
            {
                this.tiempoSesion.Enabled = false;
                Form cerrarSesion = new DialogTimeOut();
                if (cerrarSesion.DialogResult == DialogResult.OK)
                {
                    this.login.Show();
                    this.Close();

                }

            }
            timeOut--;
        }

        private void Control_Click(object sender, EventArgs e)
        {
            RenovarSesion();
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            RenovarSesion();
        }

        private void MenuBase_Load(object sender, EventArgs e)
        {
            this.tiempoSesion.Enabled = true;
        }
        /// <summary>
        /// Abre el formulario correspondiente a la opcion del menu
        /// </summary>
        /// <param name="abrirForm"></param>
        private void AbrirFormEnCuerpo(Form abrirForm)
        {
            if (formActivo != null && formActivo != abrirForm)
            {
                formActivo.Close();
            }
            formActivo = abrirForm;
            abrirForm.TopLevel = false;
            abrirForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(abrirForm);
            MainPanel.Tag = abrirForm;
            abrirForm.BringToFront();
            abrirForm.Show();
        }
        /// <summary>
        /// Verifica que haya actividad en el formulario
        /// </summary>
        /// <param name="controles"></param>
        private void VerificarActividad(Control.ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is Button)
                {
                    Button btn = control as Button;
                    btn.Click += Btn_Click;
                }
                if (control is TextBox)
                {
                    TextBox txt = control as TextBox;
                    txt.TextChanged += Txt_TextChanged;
                }
                if (control is ListView)
                {
                    ListView list = control as ListView;
                    list.Click += List_Click;
                }
            }
        }

        private void List_Click(object sender, EventArgs e)
        {
            RenovarSesion();
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            RenovarSesion();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            RenovarSesion();
        }
        /// <summary>
        /// Renueva el tiempo de la sesion
        /// </summary>
        private void RenovarSesion()
        {
            timeOut = 3;
        }
    }
}
