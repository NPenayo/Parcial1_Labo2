using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum ETipoProducto
    {
        Alimento,
        Juguete,
        Cama,
        Limpieza,
        Farmacia
    }
    public class Producto
    {
        private string idProducto;
        private ETipoProducto tipo;
        private double precio;
        private string marca;
        private string descripcion;
        private int stock;
        /// <summary>
        /// Setea todas las propiedades del producto
        /// </summary>
        private Producto()
        {
            this.Stock = 0;
            this.Precio = 0;
            this.IdProducto = null;
            this.Marca = null;
            this.Descripcion = null;
        }
        public Producto(ETipoProducto tipo, double precio, string marca, string descripcion, int stock) : this()
        {
            Tipo = tipo;
            Marca = marca;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
            IdProducto = CrearIdDeProducto();
        }

        public string IdProducto { get { return this.idProducto; } private set { this.idProducto = value; } }
        public ETipoProducto Tipo { get { return this.tipo; }  set { this.tipo = value; } }
        public double Precio { get { return this.precio; }  set { this.precio = value; } }
        public string Marca { get { return this.marca; } set { this.marca = value; } }
        public string Descripcion { get { return this.descripcion; } set { this.descripcion = value; } }
        public int Stock { get { return this.stock; } set { this.stock = value; } }
        /// <summary>
        /// Crea ID unico por producto
        /// </summary>
        /// <returns>ID de producto</returns>
        private string CrearIdDeProducto()
        {
            return $"{Tipo.ToString().Substring(0, 2)}{Marca.Substring(0, 4)}{Descripcion.Substring(0, 5)}".Trim();
        }
        /// <summary>
        /// Agregar stock a un producto
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="stock"></param>
        /// <returns>true || false </returns>
        public static bool operator +(Producto producto, int stock)
        {
            if (Validacion.NumeroEntero(stock))
            {
                producto.Stock += stock;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Restar stock a un producto
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="stock"></param>
        /// <returns>true || false</returns>
        public static bool operator -(Producto producto, int stock)
        {
            if (Validacion.NumeroEntero(stock) && producto.Stock - stock >=0)
            {
                producto.Stock -= stock;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Calcular el precio de un producto por x cantidad
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        /// <returns>El precio unitario del producto por la cantidad deseada</returns>
        public static double operator *(Producto producto, int cantidad)
        {
            return producto.Precio * cantidad;
        }

    }
}
