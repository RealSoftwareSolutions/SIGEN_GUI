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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        // 
        // label2
        // 
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuLogin_Click(object sender, EventArgs e)
        {
            if (Program.cn.State == 0)
            { //Coneccion Abierta
                menuLogin.Text = "Cerrar Sesión";
                
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("¿Desea cerrar sesión?", "Logout", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    Program.cn.Close();
                    menuLogin.Text = "Login";

                }

            }

            this.LayoutMdi(MdiLayout.TileHorizontal);
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
