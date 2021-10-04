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
        /// <summary>
        /// Valida que el formato de la fecha sea dd/MM/yyyy
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns>true | false</returns>
        public static bool Fecha(string fecha)
        {
            if (DateTime.TryParseExact(fecha, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime nacimiento))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Valida que el DNI este conformado por 8 numeros
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>true | false</returns>
        public static bool Dni(string dni)
        {
            string patron = @"^(\d){8}$";
            Regex reg = new Regex(patron);
            if (reg.IsMatch(dni))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Valida que el formato del CUIL sea {2}-{8}-{2}
        /// </summary>
        /// <param name="cuil"></param>
        /// <returns>true | false</returns>
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
        /// <summary>
        /// Valida que la clave tenga solo numeros, letras, al menos una mayucula y entre 8 y 15 caracteres
        /// </summary>
        /// <param name="password"></param>
        /// <returns>true | false</returns>
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
        /// <summary>
        /// Valida que el usuario y contraseña sean validos
        /// </summary>
        /// <param name="empleados"></param>
        /// <param name="nombreDeUsuario"></param>
        /// <param name="password"></param>
        /// <returns>true | false</returns>
        public static bool Credenciales(List<Usuario> empleados, string nombreDeUsuario, string password)
        {

            foreach (Usuario item in empleados)
            {
                if (item is not Cliente)
                {

                    if (String.Equals(((Empleado)item).NombreUsuario, nombreDeUsuario, StringComparison.OrdinalIgnoreCase) && ((Empleado)item).Password == password)
                    {
                        return true;
                    }
                }

            }
            return false;
        }
       /// <summary>
       /// Valida que sea un numero entero
       /// </summary>
       /// <param name="numero"></param>
       /// <returns>true | false</returns>
        public static bool NumeroEntero(int numero)
        {
            if (numero > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Valida que sea un numero entero
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>true | false</returns>
        public static bool NumeroEntero(double numero)
        {
            if (numero > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Valida que sea un numero entero
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>true | false</returns>
        public static bool NumeroEntero(string numero)
        {
            if (int.TryParse(numero, out int entero) && entero > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Encripta la clave
        /// </summary>
        /// <param name="password"></param>
        /// <returns>string</returns>
        public static string EncriptarPassword(string password)
        {
            byte[] passwordEncodead = new UTF8Encoding().GetBytes(password);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(passwordEncodead);
            return BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
        }
    }
}
