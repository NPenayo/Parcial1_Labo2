using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Transaccion
    {
        private int idTransaccion;
        private static int ultimoId;
        private Cliente cliente;
        private Empleado empleado;
        private Dictionary<Producto, int> productos;
        private DateTime fecha;
        private double total;

        static Transaccion()
        {
            ultimoId = 0;
        }
        private Transaccion()
        {
            this.total = 0;
            this.productos = new Dictionary<Producto, int>();
        }

        public Transaccion(Cliente cliente, Empleado empleado) : this()
        {
            Cliente = cliente;
            Empleado = empleado;
            IdTransaccion = ultimoId + 1;
            ultimoId++;
            Fecha = DateTime.Now;

        }

        public int IdTransaccion { get { return this.idTransaccion; } private set { this.idTransaccion = value; } }
        public Cliente Cliente { get { return this.cliente; } private set { this.cliente = value; } }
        public Empleado Empleado { get { return this.empleado; } private set { this.empleado = value; } }
        public double Total { get { return this.total; } private set { this.total = value; } }
        public DateTime Fecha { get { return this.fecha; } private set { this.fecha = value; } }
        public Dictionary<Producto, int> Productos { get { return this.productos; } }

        /// <summary>
        /// Obtener listado de productos de una transaccion
        /// </summary>
        /// <param name="trx"></param>
        public static explicit operator List<Producto>(Transaccion trx)
        {
            List<Producto> listado = new List<Producto>();
            foreach (KeyValuePair<Producto, int> item in trx.Productos)
            {
                listado.Add(item.Key);

            }
            return listado;
        }
        public bool AgregarProducto(Producto producto, int cantidad)
        {
            if (producto.Stock - cantidad >= 0 && this.cliente.Saldo - CalcularPacial(producto, cantidad) >= 0)
            {
                this.productos.Add(producto, cantidad);
                this.CalcularTotal();
                return producto - cantidad && this.Cliente - CalcularPacial(producto, cantidad);
            }

            return false;
        }
        public bool QuitarProducto(Producto producto)
        {

            if (this.productos.ContainsKey(producto))
            {
                int cantidad = this.productos[producto];
                if (this.productos.Remove(producto, out int registros))
                {
                    this.CalcularTotal();
                    return producto + cantidad && this.Cliente + CalcularPacial(producto, cantidad);
                }
            }

            return false;
        }

        public bool EditarCantidad(Producto producto, int cantidad)
        {
            if (this.productos.ContainsKey(producto))
            {
                if (producto.Stock - cantidad >= 0 && this.cliente.Saldo - CalcularPacial(producto, cantidad) >= 0)
                {
                    this.productos[producto] = cantidad;
                    this.CalcularTotal();
                    return producto - cantidad && this.Cliente - CalcularPacial(producto, cantidad);

                }
                return false;

            }
            return false;
        }

        private void CalcularTotal()
        {
            this.Total = 0;
            if (this.productos is not null)
            {
                foreach (KeyValuePair<Producto, int> item in this.productos)
                {
                    this.Total += this.CalcularPacial(item.Key, item.Value);
                }
            }

        }
        public double CalcularPacial(Producto producto, int cantidad)
        {
            return producto * cantidad;
        }

    }
}
