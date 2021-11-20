using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_P
{
    class MostrarPanel
    {
        public Form formularioActivo = null;
        
        public void MostrarPanelHijo(Form formularioHijo)
        {
            Inicio inicio = new Inicio();

            if (formularioActivo != null)
                formularioActivo.Close();
            
            
            formularioActivo = formularioHijo; //pasamos el form hijo  al activo
            formularioHijo.TopLevel = false; //Indicamos al form como control
            formularioHijo.FormBorderStyle = FormBorderStyle.None; //Se quita el border el form
            formularioHijo.Dock = DockStyle.Fill;  //Para llenar el panel
            inicio.panelContenedor.Controls.Add(formularioHijo); //Se asigna el form al panel
            inicio.panelContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront(); //Se pone al form hasta arriba de todo
            formularioHijo.Show(); //Se muestra el form
        }
    }
}
