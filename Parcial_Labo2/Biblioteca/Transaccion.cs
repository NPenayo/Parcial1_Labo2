﻿using System;
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
        public Dictionary<Producto, int> Productos { get { return productos; } }

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
        /// <summary>
        /// Agrega un producto a la transaccion
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        /// <returns>true | false</returns>
        public bool AgregarProducto(Producto producto, int cantidad)
        {
            if (producto - cantidad && this.cliente - CalcularPacial(producto, cantidad))
            {
                foreach (KeyValuePair<Producto, int> item in this.Productos)
                {
                    if (item.Key == producto) {
                        cantidad += item.Value;
                        this.Productos.Remove(item.Key);
                    }
                }
                this.Productos.Add(producto, cantidad);
                this.CalcularTotal();
                return true;
            }

            return false;
        }
       
        /// <summary>
        /// Quita un producto de la transaccion
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool QuitarProducto(Producto producto)
        {

            if (this.Productos.ContainsKey(producto))
            {
                int cantidad = Productos[producto];
                if (this.Productos.Remove(producto))
                {
                    this.CalcularTotal();
                    return producto + cantidad && this.Cliente + CalcularPacial(producto, cantidad);
                }
            }

            return false;
        }

       /// <summary>
       /// Edita la cantidad de un producto de la transaccion
       /// </summary>
       /// <param name="producto"></param>
       /// <param name="cantidad"></param>
       /// <returns>true | false</returns>
        public bool EditarCantidad(Producto producto, int cantidad)
        {
            if (productos.ContainsKey(producto))
            {
                if (producto + cantidad && cliente + CalcularPacial(producto, cantidad))
                {
                    this.CalcularTotal();
                    return true;

                }
                return false;

            }
            return false;
        }

        /// <summary>
        /// Calcula el total de la transaccion
        /// </summary>
        private void CalcularTotal()
        {
            this.total = 0;
            if (this.Productos is not null)
            {
                foreach (KeyValuePair<Producto, int> item in this.Productos)
                {
                    this.total += this.CalcularPacial(item.Key, item.Value);
                }
            }

        }
        /// <summary>
        /// Calcula el subtotal de un producto
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        /// <returns>double</returns>
        public double CalcularPacial(Producto producto, int cantidad)
        {
            return producto * cantidad;
        }

    }
}
