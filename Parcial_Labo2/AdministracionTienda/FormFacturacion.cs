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
    public partial class FormFacturacion : Form
    {
        public FormFacturacion()
        {
            InitializeComponent();
            ListarTransacciones();
        }

        private void ListarTransacciones()
        {
            listTransacciones.Items.Clear();
            if (Program.transacciones is not null)
            {
                foreach (Transaccion trx in Program.transacciones)
                {

                    string[] fila = { trx.IdTransaccion.ToString(), trx.Fecha.ToString(), trx.Empleado.NombreUsuario, $"{trx.Cliente.Nombre} {trx.Cliente.Apellido}", trx.Total.ToString() };
                    ListViewItem item = new ListViewItem(fila);
                    listTransacciones.Items.Add(item);

                }
            }
        }
    }
}
