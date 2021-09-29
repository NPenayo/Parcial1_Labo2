using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente : Usuario
    {
        private static int ultimoId;
        private int idCliente;
        private double saldo;

        static Cliente()
        {
            ultimoId = 0;
        }
        public Cliente(string dni, string nombre, string apellido, double saldo) : base(dni, nombre, apellido)
        {

            IdCliente = ultimoId + 1;
            ultimoId++;
            Saldo = saldo;
        }

        public int IdCliente { get { return this.idCliente; } private set { this.idCliente = value; } }

        public double Saldo { get { return this.saldo; } private set { this.saldo = value; } }

        /// <summary>
        /// Restarle el precio de un producto al saldo de un cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="precio"></param>
        /// <returns>True si se pudo descontar del saldo</returns>
        public static bool operator -(Cliente cliente, double precio)
        {
            if(cliente.Saldo - precio >= 0)
            {
                cliente.Saldo -= cliente.Saldo - precio;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Sumarle el precio de un producto al saldo de un cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="precio"></param>
        /// <returns>True</returns>
        public static bool operator +(Cliente cliente, double precio)
        {

            cliente.Saldo += cliente.Saldo + precio;
            return true;
        }



    }
}
