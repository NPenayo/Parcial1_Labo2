using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
namespace Biblioteca
{
    public static class Validacion
    {

        public static bool Fecha(string fecha)
        {
            if (DateTime.TryParseExact(fecha, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime nacimiento))
            {
                return true;
            }
            return false;
        }
        public static bool Dni(string dni)
        {
            string patron = @"^([0-9]{2}|[0-9])([0-9]){6}";
            Regex reg = new Regex(patron);
            if (reg.IsMatch(dni))
            {
                return true;
            }
            return false;
        }
        public static bool Cuil(string cuil)
        {
            string patron = @"^([0-9]{2})[\-][0-9]{8}[\-][0-9]";
            Regex reg = new Regex(patron);
            if (reg.IsMatch(cuil))
            {
                return true;
            }
            return false;
        }
        public static bool FormatoPassword(string password)
        {
            string patron = @"(?=.*[A-Z])(^[a-z]|[0-9]|[A-Z])+[^\%\-\$\'\?\¿\¡\!]([\w\d]){8,15}";
            Regex reg = new Regex(patron);
            if (reg.IsMatch(password))
            {
                return true;
            }
            return false;
        }

        public static bool Credenciales(List<Empleado> empleados, string nombreDeUsuario, string password)
        {

            foreach (Empleado item in empleados)
            {
                if (String.Equals(item.NombreUsuario,nombreDeUsuario,StringComparison.OrdinalIgnoreCase) && item.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool NumeroEntero(int numero)
        {
            if (numero > 0)
            {
                return true;
            }
            return false;
        }
        public static bool NumeroEntero(double numero)
        {
            if (numero > 0)
            {
                return true;
            }
            return false;
        }
        public static bool NumeroEntero(string numero)
        {
            if (int.TryParse(numero, out int entero) && entero > 0)
            {
                return true;
            }
            return false;
        }
        public static string EncriptarPassword(string password)
        {
            byte[] passwordEncodead = new UTF8Encoding().GetBytes(password);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(passwordEncodead);
            return BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
        }
    }
}
