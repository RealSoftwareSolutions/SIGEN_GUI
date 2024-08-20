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

            {
                // debugMessageBox.Show($"Intentando conectar con:\nUsuario: {txtUsuario.Text}\nContraseña: {txtContrasenia.Text}");

                //Crear una cadena de conexión manualmente
               // string connectionString = "Driver={MySQL ODBC 8.0 Driver};Server=localhost;Database=miodbc;Trusted_Connection=yes;User=" + txtUsuario.Text + ";Password=" + txtContrasenia.Text + ";"; //fuerzo conexion
               // Program.cn.Open(connectionString);
               
                /*Primero la direccion de coneccion*/
                Program.cn.Open("miodbc", txtUsuario.Text, txtContrasenia.Text);
            }
            catch //(Exception ex) //debug donde nos dira la variable
            {
                //MessageBox.Show($"Error al intentar conectar: {ex.Message}"); //que error tendre? dira
                //return;
               MessageBox.Show("Usuario o Contraseña Incorrectos");
                return;
            }
            Program.cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            Program.frmPrincipal.menuAplicasiones.Enabled = true;
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
