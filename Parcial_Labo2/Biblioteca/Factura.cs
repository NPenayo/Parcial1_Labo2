using System;
using System.Collections.Generic;
using System.IO;
namespace Biblioteca
{
    public enum ETipoFactura
    {
        A,
        B,
        C
    }
    public class Factura
    {
        private Transaccion detalle;
        private static int ultimoNroFactura;
        private string nroFactucra;
        private ETipoFactura tipo;
        private DateTime fecha;

        static Factura()
        {
            ultimoNroFactura = 0;

        }
        public Factura(ETipoFactura tipoFactura, Transaccion detalle)
        {
            Tipo = tipoFactura;
            Detalle = detalle;
            NumeroFactura = GenerarNroFactura();
            ultimoNroFactura++;
            Fecha = DateTime.Now;
        }
        public ETipoFactura Tipo { get { return this.tipo; } private set { this.tipo = value; } }
        public Transaccion Detalle { get { return this.detalle; } private set { if (value is not null) { detalle = value; } else { this.detalle = null; } } }
        public string NumeroFactura { get { return this.nroFactucra; } private set { this.nroFactucra = value; } }
        public DateTime Fecha { get { return this.fecha; } private set { this.fecha = value; } }
       /// <summary>
       /// Crea el numero de la factura
       /// </summary>
       /// <returns>string</returns>
        private string GenerarNroFactura()
        {
            string formato = $"{this.Tipo}-00000000-00";
            return (ultimoNroFactura + 1).ToString(formato);
        }
       /// <summary>
       /// Agregar una transaccion a una factura
       /// </summary>
       /// <param name="factura"></param>
        public static explicit operator Transaccion(Factura factura)
        {
            return factura.Detalle;
        }
       /// <summary>
       /// Guarda una factura
       /// </summary>
        public void Guardar()
        {

            string path = $"{Environment.CurrentDirectory}\\Facturas";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            StreamWriter facturaTxt = new StreamWriter($"{path}\\{DateTime.Now.Day}-{DateTime.Now.Month}-{this.NumeroFactura}.txt");

            facturaTxt.WriteLine($"Nro.Factura: {this.NumeroFactura} \t\t Fecha: {this.Fecha}\n");
            facturaTxt.WriteLine($"Razon Social: {Tienda.RazonSocial} \t\t CUIT: {Tienda.Cuit}");
            facturaTxt.WriteLine($"{Tienda.Domicilo},{Tienda.Localidad}");
            facturaTxt.WriteLine($"Cliente: {this.Detalle.Cliente.Nombre} {this.Detalle.Cliente.Apellido}");
            facturaTxt.WriteLine("Detalle\n\n");
            facturaTxt.WriteLine("Codigo\t\tCantidad\t\tDescripcion\t\tPrecio p/u \t\t Subtotal");
            foreach (KeyValuePair<Producto, int> item in this.Detalle.Productos)
            {
                facturaTxt.WriteLine($"{item.Key.IdProducto}\t{item.Value}\t\t\t{item.Key.Descripcion}\t\t${item.Key.Precio} \t\t  ${this.Detalle.CalcularPacial(item.Key, item.Value)}\n");
            }
            facturaTxt.WriteLine($"Total \t\t\t\t\t\t\t\t\t\t\t\t ${this.Detalle.Total}");
            facturaTxt.Close();
        }
    }
}
