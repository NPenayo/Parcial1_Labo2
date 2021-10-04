using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionTienda
{
    public partial class MenuEmpleado : MenuBase
    {
        public MenuEmpleado(Login form):base(form,$"{Program.sesion.Usuario.Nombre} {Program.sesion.Usuario.Apellido}".ToUpper())
        {
            InitializeComponent();
           
        }

    }
}
