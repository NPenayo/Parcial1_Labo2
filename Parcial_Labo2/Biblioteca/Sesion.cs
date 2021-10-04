using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Biblioteca
{
    public class Sesion
    {
        private string idSesion;
        private DateTime ultimaActividad;
        private Usuario usuario;

        public Sesion(Usuario usuario)
        {
            IdSesion = (usuario.DNI, usuario.Apellido).GetHashCode().ToString();
            UltimaActividad = DateTime.Now;
            this.usuario = usuario;

        }
        public string IdSesion
        {
            get { return this.idSesion; }
            private set { this.idSesion = value; }
        }
        public DateTime UltimaActividad
        {
            get
            {
                return this.ultimaActividad;
            }
            private set
            {
                this.ultimaActividad = value;
            }
        }
        public Usuario Usuario
        {
            get
            {
                return this.usuario;
            }
        }

        /// <summary>
        /// Verifica si la sesion sigue activa
        /// </summary>
        /// <returns>true | false</returns>
        public bool SesionActiva()
        {
            int diferencia = DateTime.Now.Minute - ultimaActividad.Minute;
            if (this.IdSesion is not null && diferencia <= 3)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Renueva el tiempo de la sesion
        /// </summary>
        public void RenovarSesion()
        {
            this.UltimaActividad = DateTime.Now;
        }
        /// <summary>
        /// Cierra la sesion
        /// </summary>
        public void CerrarSesion()
        {
            IdSesion = null;
        }

    }
}
