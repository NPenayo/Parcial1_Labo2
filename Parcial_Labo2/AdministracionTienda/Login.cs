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

        private void btnLogAdmin_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            List<Usuario> usuarios = new List<Usuario>();
            List<Transaccion> transacciones = new List<Transaccion>();
            List<Producto> productos = new List<Producto>();
            Usuario admin = new Administrador("12345678", "Admin", "Istrador", "06/06/1996", "Calle Cualquiera 1200", "Lomas de Zamora", "20-12345678-9", "admin123");
            Usuario empleado1 = new Empleado("25346898", "Maria", "Lopez", "25/12/1985", "Avenida Transitada 25000", "Lanus", "24-25346898-5", "Gatito321");
            Usuario empleado2 = new Empleado("30946898", "Jose", "Gonzales", "10/03/1999", "Calle de Barrio 200 1C", "Lanus", "20-30946898-7", "Coche555");
            Usuario cliente1 = new Cliente("29578031", "Juan Carlos", "Fantasma", 25000);
            Usuario cliente2 = new Cliente("32198320", "Martina", "Perez", 5000);
            Producto producto1 = new Producto(ETipoProducto.Alimento, 3200.50, "Pro Plan", "5Kg Cachorros", 25);
            Producto producto2 = new Producto(ETipoProducto.Cama, 1500, "ComfortPet", "50Cm Diametro", 8);
            Producto producto3 = new Producto(ETipoProducto.Farmacia, 2700.80, "PetFarma", "Desparacitante", 10);
            Producto producto4 = new Producto(ETipoProducto.Juguete, 500, "Bicho Feliz", "Pelota Goma", 7);
            Producto producto5 = new Producto(ETipoProducto.Alimento, 7800, "Pro Plan", "10Kg Adulto", 15);
            Producto producto6 = new Producto(ETipoProducto.Limpieza, 1200, "Shampoo", "Perro", 32);
            usuarios.Add(admin);
            usuarios.Add(empleado1);
            usuarios.Add(empleado2);
            usuarios.Add(cliente1);
            usuarios.Add(cliente2);
            productos.Add(producto6);
            productos.Add(producto5);
            productos.Add(producto4);
            productos.Add(producto3);
            productos.Add(producto2);
            productos.Add(producto1);
        }
    }
}
