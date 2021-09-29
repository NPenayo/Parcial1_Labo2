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
     
        public Sesion(Usuario usuario)
        {
            IdSesion = (usuario.DNI, usuario.Apellido).GetHashCode().ToString();
            UltimaActividad = DateTime.Now;

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
       
       
        public bool SesionActiva()
        {
            int diferencia = DateTime.Now.Minute - ultimaActividad.Minute;
            if (this.IdSesion is not null && diferencia <= 3 )
            {
                return true;
            }
            return false;
        }
        public void RenovarSesion()
        {
            this.UltimaActividad = DateTime.Now;
        }
        public void CerrarSesion()
        {
            IdSesion = null;
        }

    }
}
