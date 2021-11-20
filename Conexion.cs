using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prototipo_P
{
    class Conexion
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "fSuqw77uMdjTiokaqJASFKfnkr0bGHKamsf1MgGV",
            BasePath = "https://proyecto-firebase-ec93c-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public IFirebaseClient IniciarConexion()
        {
            client = new FireSharp.FirebaseClient(config);
            return client;

        }


    }
}
