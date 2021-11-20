using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_P
{
    class Session
    {
        public static string nickname, CodigoVerificacion, NuevaContraseña, tipo_U;

        private static string id, Ubicacion;
        string Estado, IpPublica, Hostnme;

        public string Ubicacion1 { get => Ubicacion; set => Ubicacion = value; }
        public string Id { get => id; set => id = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public string IpPublica1 { get => IpPublica; set => IpPublica = value; }
        public string Hostnme1 { get => Hostnme; set => Hostnme = value; }
        
    }
}
