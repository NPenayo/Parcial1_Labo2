using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Biblioteca
{
    public class Empleado : Usuario
    {
        private string nombreUsuario;
        private string password;
        private string cuil;

        public Empleado(string dni, string nombre, string apellido, string fechanacimiento, string direccion, string localidad, string cuil, string clave) : base(dni, nombre, apellido, fechanacimiento, direccion, localidad)
        {
            this.nombreUsuario = ArmarNombreUsuario();
            Cuil = cuil;
            Password = clave;
        }
        public string NombreUsuario
        {
            get
            {
                return this.nombreUsuario;
            }
        }
        public string Cuil
        {
            get
            {
                return this.cuil;
            }
            protected set
            {
                if (Validacion.Cuil(value))
                {
                    this.cuil = value;
                }
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
            private set
            {
                if (Validacion.FormatoPassword(value))
                {


                    this.password = Validacion.EncriptarPassword(value);

                }
            }
        }

        private string ArmarNombreUsuario()
        {
            return $"{this.Apellido.Substring(0, 1)}{this.Nombre.Substring(0, 1)}{this.DNI.Substring(4, 4)}";
        }
        protected static List<Cliente> ObtenerClientes(List<Usuario> usuarios)
        {
            List<Cliente> listaClientes = new List<Cliente>();
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].GetType().Name == "Cliente")
                {
                    listaClientes.Add((Cliente)usuarios[i]);
                }
            }
            return listaClientes;
        }

        public virtual bool Agregar(List<object> clientes, object cliente)
        {
            if (cliente.GetType().Name == "Cliente" && clientes.GetType().Name == "Cliente")
            {
                if (!clientes.Contains(cliente))
                {
                    clientes.Add(cliente);
                    return true;
                }
            }
            return false;
        }
        public virtual bool Editar(Usuario usuario, Dictionary<string, string> campos)
        {
            return false;
        }

    }
}
