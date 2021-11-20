using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_P
{
    public partial class Inicio : Form
    {
        private Form formularioActivo = null;

        Controles control = new Controles();
        Session session = new Session();
        Login login = new Login();
        //MostrarPanel mostrar = new MostrarPanel();

        public Inicio()
        {
            InitializeComponent();
            DiseñosOcultosPanel();
            
        }

        private void DiseñosOcultosPanel()
        {
            panelMiCuenta.Visible = false;
            panelAcceso.Height = 40;

            subMenuAcceso.Visible = false;
            subMenuMiCuenta.Visible = false;                
        }

        private void OcultarsubMenu()
        {
            if (subMenuAcceso.Visible == true)
            {
                subMenuAcceso.Visible = false;
                panelAcceso.Height = 40;
            }
            if (subMenuMiCuenta.Visible == true)
            {
                subMenuMiCuenta.Visible = false;
                panelMiCuenta.Height = 40;
            }                       
        }

        private void MostrarSubMenu(Panel panel, Panel subMenu)
        {
            panel.Height = 137;

            if (subMenu.Visible == false)
            {
                OcultarsubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
                panel.Height = 40;
            }               
        }

        public void MostrarPanelHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formularioHijo; //pasamos el form hijo  al activo
            formularioHijo.TopLevel = false; //Indicamos al form como control
            formularioHijo.FormBorderStyle = FormBorderStyle.None; //Se quita el border el form
            formularioHijo.Dock = DockStyle.Fill;  //Para llenar el panel
            panelContenedor.Controls.Add(formularioHijo); //Se asigna el form al panel
            panelContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront(); //Se pone al form hasta arriba de todo
            formularioHijo.Show(); //Se muestra el form
        }

        private void btnAcceso_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelAcceso,subMenuAcceso);
        }

        private void btnMiCuenta_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelMiCuenta,subMenuMiCuenta);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //panelMiCuenta.Visible = false;
            //panelAcceso.Visible = true;
            if (session.Id != null)
            {
                Login log = new Login();
                string Estado = "D";
                log.Logeo(Estado, Session.nickname);

                session.Id = null;
                Session.nickname = null;
                Session.tipo_U = null;

                OcultarsubMenu();
            }
            else
            {
                MessageBox.Show("Sin usuario");
            }
            
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            MostrarPanelHijo(new Registro());
            OcultarsubMenu();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //panelMiCuenta.Visible = true;
            //panelAcceso.Visible = false;
            
            MostrarPanelHijo(new Login());
                        
            OcultarsubMenu();
        }

        private void btnMisDatos_Click(object sender, EventArgs e)
        {
            OcultarsubMenu();
        }

        public void ocultar()
        {
            panelAcceso.Visible = false;
        }

        public void Inicio_Load(object sender, EventArgs e)
        {
           control.ctrlLocalizar();
           Controles.Actualizar();
        }

        
    }
}
