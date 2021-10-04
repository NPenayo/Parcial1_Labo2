using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace AdministracionTienda
{
    static class Program
    {
        public static Sesion sesion;
        public static List<Transaccion> transacciones = new List<Transaccion>();
        public static List<Usuario> usuarios = new List<Usuario>();
        public static List<Producto> productos = new List<Producto>();
        public static string adminName = "Admin";
        public static string adminSurname = "Istrador";
        public static string adminUserName = "IA5678";
        public static string adminPass = "Admin12345";
        public static string programName = "Pet Shop";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
