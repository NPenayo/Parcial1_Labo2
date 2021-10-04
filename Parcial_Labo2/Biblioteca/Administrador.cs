using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Administrador : Empleado
    {
 
        public Administrador(string dni, string nombre, string apellido, string fechanacimiento, string direccion, string localidad, string cuil, string clave) : base(dni, nombre, apellido, fechanacimiento, direccion, localidad, cuil, clave)
        { 

        }
        /// <summary>
        /// Agregar un elemento a una lista
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="objeto"></param>
        /// <returns>true | false</returns>
        public override bool Agregar(List<object> lista, object objeto)
        {
            if (!lista.Contains(objeto))
            {
                lista.Add(objeto);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Eliminar un elemento de una lista
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="objeto"></param>
        /// <returns>true | false</returns>
        private bool Eliminar(List<object> lista, object objeto)
        {
            if (lista.Contains(objeto))
            {
                lista.Remove(objeto);
                return true;
            }
            return false;

        }
        /// <summary>
        /// Obtener una lista de empleados a partir de una lista de usuarios
        /// </summary>
        /// <param name="usuarios"></param>
        /// <returns>List<Empleado></returns>
        public static List<Empleado> ObtenerEmpleados(List<Usuario> usuarios)
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            for (int i = 0; i < usuarios.Count; i++)
            {

                if (usuarios[i].GetType().Name == "Empleado")
                {
                    listaEmpleados.Add((Empleado)usuarios[i]);
                }
            }
            return listaEmpleados;
        }
        /// <summary>
        /// Editar propiedades de un usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="campos"></param>
        /// <returns>true | false</returns>
        public override bool Editar(Usuario usuario, Dictionary<string, string> campos)
        {
            foreach (KeyValuePair<string, string> item in campos)
            {

                if (item.Key.Contains(nameof(usuario.Apellido)))
                {
                    usuario.Apellido = item.Value;
                }
                if (item.Key.Contains(nameof(usuario.Nombre)))
                {
                    usuario.Nombre = item.Value;
                }
                if (item.Key.Contains(nameof(usuario.Direccion)))
                {
                    usuario.Direccion = item.Value;
                }
                if (item.Key.Contains(nameof(usuario.FechaNacimiento)))
                {
                    usuario.FechaNacimiento = item.Value;
                }
                if (item.Key.Contains(nameof(usuario.Localidad)))
                {
                    usuario.Localidad = item.Value;
                }
            }
            return true;
        }
    }
}
