using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_P
{
    class Modelos
    {

        public void ingresarUsuario(Usuario usuario)
        {
            Conexion con = new Conexion();
            IFirebaseClient client = con.IniciarConexion();

            Guid g = Guid.NewGuid();
            string uuid = g.ToString();
            usuario.ID_U1 = uuid;

            FirebaseResponse response = client.Set("Usuarios/"+uuid,usuario);
        }

        public bool ExisteUsuario(string nickname) {
            Conexion con = new Conexion();
            IFirebaseClient client = con.IniciarConexion();

            Boolean bandera =false;

            FirebaseResponse response = client.Get("Usuarios/");

            Dictionary<string, Usuario> resultado = response.ResultAs<Dictionary<string, Usuario>>();

            if(resultado == null)
            {
                bandera = false;
            }
            else
            {
                foreach (var item in resultado)
                {
                    string usuario = item.Value.Nickname1;
                    if(nickname == usuario)
                    {
                        bandera = true;
                    }
                    
                }
            }
            return bandera;
        }

        public Usuario porUsaurio(string nickname)
        {
            Conexion con = new Conexion();
            IFirebaseClient client = con.IniciarConexion();

            FirebaseResponse responde = client.Get("Usuarios/");

            Dictionary<string, Usuario> resultado = responde.ResultAs<Dictionary<string, Usuario>>();
            Usuario usr = new Usuario();

            if (resultado != null)
            {
                foreach (var item in resultado)
                {
                    string usuario = item.Value.Nickname1;
                    if(nickname == usuario)
                    {
                        usr.ID_U1 = item.Value.ID_U1;
                        usr.Nickname1 = item.Value.Nickname1;
                        usr.Pass1 = item.Value.Pass1;
                        usr.Tipo_U1 = item.Value.Tipo_U1;
                    }                    
                }

                if (usr.ID_U1 == null)
                {
                    usr = null;
                }
                
                
            }
            else
            {
                usr = null;
            }
            
            return usr;
        }

        public void logeoRegistro(Session sesion)
        {
            Conexion con = new Conexion();
            IFirebaseClient client = con.IniciarConexion();

            Guid g = Guid.NewGuid();
            string uuid = g.ToString();
            
            FirebaseResponse responde = client.Set("Logeos/"+uuid,sesion);
        }


    }
}
