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
    public partial class Registro : Form
    {
        private int TU = 2;
        private string paisUsuario;

        public Registro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Nom_U1 = txtNombre.Text;
            usuario.Apa_U1 = txtApa.Text;
            usuario.Ama_U1 = txtAma.Text;
            usuario.Correo_U1 = txtCorreo.Text;
            usuario.Pass1 = txtContraseña.Text;
            usuario.ConPass1 = txtConConstraseña.Text;
            usuario.Nickname1 = txtNickname.Text;
            usuario.Pais1 = paisUsuario;
            usuario.Tipo_U1 = TU.ToString(); ;

            try
            {
                Controles control = new Controles();                    //Instanciamos clase control


                string respuesta = control.ctrlIngresarNuevo(usuario);   //Asignamos metodo ctrlRegistro a la variable respuesta

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                else
                {
                    MessageBox.Show("Usuario Registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApa.Text = "";
            txtAma.Text = "";
            txtCorreo.Text = "";
            txtContraseña.Text = "";
            txtConConstraseña.Text = "";
            txtNickname.Text = "";
            cbxPais.SelectedIndex = 0;

        }

        private void Tipo_usuario_Click(object sender, EventArgs e)
        {
            if (TU == 2)
            {
                TU = 1;
                //MessageBox.Show("Valor " + TU);
            }
            else
            {
                TU = 2;
                //MessageBox.Show("Valor " + TU);
            }
        }

        private void SeleccionPais(object sender, EventArgs e)
        {
            int indice = cbxPais.SelectedIndex;
            paisUsuario = cbxPais.Items[indice].ToString();
        }
    }
}
