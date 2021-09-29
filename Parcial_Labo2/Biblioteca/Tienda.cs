using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Tienda
    {
        private static string razonSocial;
        private static string cuit;
        private static string domicilio;
        private static string localidad;

        static Tienda() 
        {
            razonSocial = "MultiPet";
            cuit = "30-123456585-7";
            domicilio = "Av. Hipolito Yrigoyen 15000";
            localidad = "Lomas de Zamora";
        }

        public static string RazonSocial
        {
            get
            {
                return razonSocial;
            }
        }
        public static string Cuit
        {
            get
            {
                return cuit;
            }
        }
        public static string Domicilo
        {
            get
            {
                return domicilio;
            }
        }
        public static string Localidad
        {
            get
            {
                return localidad;
            }
        }
    }
}
