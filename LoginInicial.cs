using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGEN_GUI
{
    public partial class LoginInicial : Form
    {
        public LoginInicial()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {      /*Primero la direccion de coneccion*/
                Program.cn.Open("miodbc", txtUsuario.Text, txtContrasenia.Text);
            }
            catch
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
                return;
            }
            Program.cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            //Program.frmPrincipal.menuAplicacion.Enabled = true;
            Program.Doypermisos(txtUsuario.Text);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void LoginInicial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContrasenia.PasswordChar == '*')
            {
                txtContrasenia.PasswordChar = '\0';
            }
            else
            {
                txtContrasenia.PasswordChar = '*';
            }
                }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblContrasenia_Click(object sender, EventArgs e)
        {

        }
    }
}
