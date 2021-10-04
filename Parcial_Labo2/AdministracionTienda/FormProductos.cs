using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Biblioteca;
namespace AdministracionTienda
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            listCategorias.View = View.Details;
            listCategorias.Columns.Add("Productos", 100);
            listCategorias.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            ImageList listaImagenes = new ImageList();
            listaImagenes.ImageSize = new Size(150, 150);
            string[] rutas = { };
            rutas = Directory.GetFiles($"{Environment.CurrentDirectory}/productos");
            foreach(String ruta in rutas)
            {
                listaImagenes.Images.Add(Image.FromFile(ruta));
            }
            listCategorias.SmallImageList = listaImagenes;
            listCategorias.Items.Add("Alimento", 0);
            listCategorias.Items.Add("Cama", 1);
            listCategorias.Items.Add("Farmacia", 2);
            listCategorias.Items.Add("Juguete", 3);
            listCategorias.Items.Add("Limpieza", 4);


        }
        private void MostrarProductos(string tipo)
        {
            listProductos.Items.Clear();
            foreach (Producto producto in Program.productos)
            {
                if (producto.Tipo.ToString() == tipo)
                {
                    string[] fila = { producto.IdProducto.Trim(), producto.Marca, producto.Descripcion, producto.Precio.ToString(), producto.Stock.ToString() };
                    ListViewItem item = new ListViewItem(fila);
                    listProductos.Items.Add(item);
                }

            }
        }

        private void listCategorias_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection seleccionado = listCategorias.SelectedItems;
            foreach (ListViewItem item in seleccionado)
            {
                string categoria = item.SubItems[0].Text;
                MostrarProductos(categoria);
                break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ModalProducto mdlProd = new ModalProducto();
            if(mdlProd.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Se cargó correctamente el producto");
                listProductos.Items.Clear();
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

        private void listProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection seleccionado = listProductos.SelectedItems;
            foreach (ListViewItem item in seleccionado)
            {
                
                Producto prod = ObtenerProducto(item.SubItems[0].Text);
                ModalProducto modalProducto = new ModalProducto(prod);
                if(modalProducto.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Se actualizó correctamente el producto");
                    listProductos.Items.Clear();
                }
                break;
            }
        }
    }
}
