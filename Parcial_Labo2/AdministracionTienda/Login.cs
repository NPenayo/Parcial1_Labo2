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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }
        ///
        private void btnLogAdmin_Click(object sender, EventArgs e)
        {
            txtUserName.Text = $"{Program.adminUserName}";
            txtPassword.Text = $"{Program.adminPass}";
        }

        private void btnLogEmployee_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "LM6898";
            txtPassword.Text = "Gatito3213";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text;
            string password = Validacion.EncriptarPassword(txtPassword.Text);
            if (Validacion.Credenciales(Program.usuarios, user, password))
            {
                Empleado logueado = ObtenerLogueado(user, password);
                if (logueado is not null)
                {
                    this.AbrirMenu(logueado);
                }

            }
            else
            {
                MessageBox.Show("Usuario y/o Password incorrectos");
            }
        }

        /// <summary>
        /// Obtiene el usuario logueado
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns>Empleado</returns>
        static Empleado ObtenerLogueado(string user, string pass)
        {
            foreach (Usuario item in Program.usuarios)
            {
                if (item is Empleado)
                {
                    Empleado empleado = item as Empleado;
                    if (String.Equals(empleado.NombreUsuario, user, StringComparison.OrdinalIgnoreCase) && empleado.Password == pass)
                    {
                        return empleado;
                    }

                }
            }
            return null;
        }
        /// <summary>
        /// Abre el menu principal
        /// </summary>
        /// <param name="usuario"></param>
        private void AbrirMenu(Empleado usuario)
        {
            Program.sesion = new Sesion(usuario);
            if (usuario.GetType().Name == "Administrador")
            {
                MenuAdmin menu = new MenuAdmin(this);
                menu.Show();
                this.Hide();
            }
            if (usuario.GetType().Name == "Empleado")
            {

                MenuEmpleado menu = new MenuEmpleado(this);
                menu.Show();
                this.Hide();

            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            Usuario admin = new Administrador("12345678", $"{Program.adminName}", $"{Program.adminSurname}", "06/06/1996", "Calle Cualquiera 1200", "Lomas de Zamora", "20-12345678-9", $"{Program.adminPass}");
            Usuario empleado1 = new Empleado("25346898", "Maria", "Lopez", "25/12/1985", "Avenida Transitada 25000", "Lanus", "24-25346898-5", "Gatito3213");
            Usuario empleado2 = new Empleado("30946898", "Jose", "Gonzales", "10/03/1999", "Calle de Barrio 200 1C", "Lanus", "20-30946898-7", "Coche55566");
            Usuario cliente1 = new Cliente("29578031", "Juan Carlos", "Fantasma", 25000.00);
            Usuario cliente2 = new Cliente("32198320", "Martina", "Perez", 5000.00);
            Producto producto1 = new Producto(ETipoProducto.Alimento, 3200.50, "Pro Plan", "5Kg Cachorros", 25);
            Producto producto2 = new Producto(ETipoProducto.Cama, 1500, "ComfortPet", "50Cm Diametro", 8);
            Producto producto3 = new Producto(ETipoProducto.Farmacia, 2700.80, "PetFarma", "Desparacitante", 10);
            Producto producto4 = new Producto(ETipoProducto.Juguete, 500, "Bicho Feliz", "Pelota Goma", 7);
            Producto producto5 = new Producto(ETipoProducto.Alimento, 7800, "Pro Plan", "10Kg Adulto", 15);
            Producto producto6 = new Producto(ETipoProducto.Limpieza, 1200, "Shampoo", "Perro", 32);
            Program.usuarios.Add(admin);
            Program.usuarios.Add(empleado1);
            Program.usuarios.Add(empleado2);
            Program.usuarios.Add(cliente1);
            Program.usuarios.Add(cliente2);
            Program.productos.Add(producto6);
            Program.productos.Add(producto5);
            Program.productos.Add(producto4);
            Program.productos.Add(producto3);
            Program.productos.Add(producto2);
            Program.productos.Add(producto1);
            Transaccion trx1 = new Transaccion((Cliente)cliente1, (Empleado)empleado1);
            trx1.AgregarProducto(producto1, 2);
            trx1.AgregarProducto(producto4, 1);
            trx1.AgregarProducto(producto6, 1);
            Transaccion trx2 = new Transaccion((Cliente)cliente2, (Empleado)empleado2);
            trx2.AgregarProducto(producto2, 1);
            trx2.AgregarProducto(producto4, 3);
            Program.transacciones.Add(trx1);
            Program.transacciones.Add(trx2);
            Factura factura1 = new(ETipoFactura.B, trx1);
            factura1.Guardar();
            Factura factura2 = new(ETipoFactura.B, trx2);
            factura2.Guardar();
        }
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="menu"></param>
        public static void CerrarMenu(Form menu)
        {
            menu.Close();
        }
    }
}
