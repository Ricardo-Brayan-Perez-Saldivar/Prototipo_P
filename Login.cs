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
    public partial class Login : Form
    {
        int intento = 0, conteo = 0;
        string EstadoUsuario;

        Modelos modelo = new Modelos();
        Controles control = new Controles();
        Session sesion = new Session();
        
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccesarLogin_Click(object sender, EventArgs e)
        {
            string nickname = txtNickname.Text;
            string pwd = txtPass.Text;
            //Controles control = new Controles();

            sesion.Ubicacion1 = control.ctrlLocalizar();

            string respuesta = control.ctrlLogin(nickname,pwd);

            if(respuesta.Length > 0)
            {
                MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (intento == 2)
                {

                    MessageBox.Show("Intentos fallitos, Negacion de acceso por 3 minutos");
                    btnAccesarLogin.Enabled = false;
                    btn_Cancelar.Enabled = false;
                    TimAcceso.Start();
                    intento = 0;
                }
                else
                {
                    intento += 1;

                    //Modelos modelo = new Modelos();
                    Usuario datosUsuario = modelo.porUsaurio(nickname);
                    //Session sesion = new Session();

                    if (datosUsuario != null)
                    {
                        sesion.Id = datosUsuario.ID_U1;

                        EstadoUsuario = "F";
                        Logeo(EstadoUsuario, nickname);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bienvenido " + Session.nickname, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                EstadoUsuario = "A";
                Logeo(EstadoUsuario,nickname);

                btnAccesarLogin.DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private void Limpiar()
        {
            txtNickname.Text = "";
            txtPass.Text = "";
        }

        private void TimAcceso_Tick(object sender, EventArgs e)
        {
            conteo++;
            if (conteo >= 200)
            {
                btnAccesarLogin.Enabled = true;
                btn_Cancelar.Enabled = true;
                TimAcceso.Stop();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Controles control = new Controles();
            control.ctrlLocalizar();
        }

        private void btnRestaConrasena_Click(object sender, EventArgs e)
        {
            
        }

        public void Logeo(string est, string nic)
        {
            Session session = new Session();
            Controles control = new Controles();

            session.Estado1 = est;
            session.IpPublica1 = control.ctrlgetExternalIP();
            session.Hostnme1 = control.ctrlGetHostName();
            //session.Ubicacion1 = control.ctrlLocalizar();

            try
            {
                control.ctrlLogeo(session, nic);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { }
        }
    }
}
