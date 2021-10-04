using System;
using System.Collections.Generic;
using System.Globalization;
namespace Biblioteca
{
    public abstract class Usuario
    {
        private string dni;
        private string nombre;
        private string apellido;
        private string fechaNacimiento;
        private string direccion;
        private string localidad;
        private string edad;

        public Usuario(string dni, string nombre, string apellido)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
        }
        public Usuario(string dni, string nombre, string apellido, string fechaNacimiento, string direccion, string localidad) : this(dni, nombre, apellido)
        {
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
            Localidad = localidad;
        }
        public string DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (Validacion.Dni(value))
                {
                    this.dni = value;
                }
            }
        }
        public string Nombre
        {
            get
            {
                return FormatearString(nombre);
            }
            set
            {
                this.nombre = value.ToLower();
            }
        }
        public string Apellido
        {
            get
            {
                return FormatearString(apellido);
            }
            set
            {
                this.apellido = value.ToLower();
            }
        }
        public string FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
            set
            {
                if (Validacion.Fecha(value))
                {
                    this.fechaNacimiento = value;
                    this.Edad = value;
                }
            }
        }
        public string Direccion
        {
            get
            {
                return FormatearString(this.direccion);
            }
            set
            {
                this.direccion = value.ToLower();
            }
        }
        public string Localidad
        {
            get
            {
                return FormatearString(this.localidad);
            }
            set
            {
                this.localidad = value.ToLower();
            }
        }
        public string Edad
        {
            get
            {
                return this.edad;
            }
            private set
            {
                this.edad = CalcularEdad(value);
            }
        }




        private string CalcularEdad(string fecha)
        {
            DateTime nacimiento = DateTime.ParseExact(fecha, "dd/MM/yyyy", null);
            DateTime fechaActual = DateTime.Now;
            TimeSpan diferencia = fechaActual - nacimiento;
            double dias = diferencia.TotalDays;
            return ((int)dias / 365).ToString();
        }

        private string FormatearString(string entrada)
        {

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(entrada);
        }

    }
}
