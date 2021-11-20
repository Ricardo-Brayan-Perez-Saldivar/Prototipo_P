using System.Device.Location;
using System.Net;
using System.Text.RegularExpressions;

namespace Prototipo_P
{
    class Controles
    {
        public string Latitud, Longitud;

        public string ctrlIngresarNuevo(Usuario usuario)
        {
            Modelos model = new Modelos();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Nom_U1) || string.IsNullOrEmpty(usuario.Apa_U1) || string.IsNullOrEmpty(usuario.Ama_U1)
                || string.IsNullOrEmpty(usuario.Pass1) || string.IsNullOrEmpty(usuario.ConPass1) 
                || string.IsNullOrEmpty(usuario.Nickname1) || string.IsNullOrWhiteSpace(usuario.Pais1))
            {
                respuesta = "Debes llenar todos los datos";
            }
            else
            {
                if (usuario.Pass1 == usuario.ConPass1)
                {
                    if (model.ExisteUsuario(usuario.Nickname1))
                    {
                        respuesta = "El Nickname ya existe";
                    }
                    else
                    {
                        model.ingresarUsuario(usuario);               
                    }
                    
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }

            }
            return respuesta;

        }

        public string ctrlLogin(string nickname, string pwd)
        {
            Modelos modelo = new Modelos();
            Usuario datosUsuario;
            Session sesion = new Session();
            string respuesta = "";

            if(string.IsNullOrEmpty(nickname) || string.IsNullOrEmpty(pwd))
            {
                respuesta = "Debes llenar todos los campos";
            }
            else
            {
                datosUsuario = modelo.porUsaurio(nickname);

                if (datosUsuario != null)
                {
                    if (pwd != datosUsuario.Pass1)
                    {
                        respuesta = "El Usuario/Contraseña incorrecto";
                        sesion.Id = datosUsuario.ID_U1;
                    }
                    else
                    {
                        sesion.Id = datosUsuario.ID_U1;
                        Session.nickname = datosUsuario.Nickname1;
                        Session.tipo_U = datosUsuario.Tipo_U1;
                    }
                }
                else
                {
                    respuesta = "El Usuario no existe";
                }

            }
            return respuesta;

        }

        public void ctrlLogeo(Session session,string nickname)
        {
            Modelos modelo = new Modelos();

            if (modelo.ExisteUsuario(nickname))
            {
                modelo.logeoRegistro(session);
            }

        }

        public string ctrlGetHostName()
        {
            IPHostEntry iPHost = Dns.GetHostByName(Dns.GetHostName());
            string HostName = iPHost.HostName.ToString();
            return HostName;
        }

        public string ctrlgetExternalIP()
        {
            try
            {
                string externalIP;

                externalIP = (new WebClient()).DownloadString("http://checkip.dyndns.org/");
                externalIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")).Matches(externalIP)[0].ToString();
                return externalIP;
            }
            catch
            {
                return null;
            }
        }

        public string ctrlLocalizar()
        {
            string cadena;
            GeoCoordinateWatcher oWacher = new GeoCoordinateWatcher();
            oWacher.PositionChanged += (S, E) =>
            {
                var oCoordinate = E.Position.Location;
                Latitud = oCoordinate.Latitude.ToString();
                Longitud = oCoordinate.Longitude.ToString();

                oWacher.Stop();
            };

            oWacher.Start();

            cadena = Latitud + " , " + Longitud;
            return cadena;
        }

        public static void Actualizar()
        {
            Session session = new Session();
            Inicio inicio = new Inicio();

            if (session.Id != null)
            {
                inicio.panelMiCuenta.Visible = true;
            }
            else
            {
                inicio.panelMiCuenta.Visible = false;
            }

        }
    }
}
