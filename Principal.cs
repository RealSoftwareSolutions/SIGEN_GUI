using System;
using System.Windows.Forms;

namespace SIGEN_GUI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.menuAplicasiones.Enabled = false;
        }

        private void menuAplicasiones_Click(object sender, EventArgs e)
        {

        }

        private void menuClientes_Click(object sender, EventArgs e)
        {

        }

        private void menuEntrenador_Click(object sender, EventArgs e)
        {

        }

        private void menuAdministrador_Click(object sender, EventArgs e)
        {

        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            if (Program.cn.State == 0)
            { //Coneccion Abierta
                menuLogin.Text = "Cerrar Sesión";
                Program.frmLogin = new LoginInicial();
                Program.frmLogin.MdiParent = this;
                Program.frmLogin.Show();
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

        private void menuIngresar_Click(object sender, EventArgs e)
        {

        }

        private void menuSalir_Click(object sender, EventArgs e)
        {

        }

        private void menuCalendario_Click(object sender, EventArgs e)
        {

        }

        private void menuClienteAdministrativo_Click(object sender, EventArgs e)
        {

        }

        private void menuAgendaEntrenador_Click(object sender, EventArgs e)
        {

        }

        private void menuCalificarEntrenador_Click(object sender, EventArgs e)
        {

        }

        private void menuAsignarEntrenamiento_Click(object sender, EventArgs e)
        {

        }

        private void menuRutina_Click(object sender, EventArgs e)
        {

        }

        private void menuAgenda_Click(object sender, EventArgs e)
        {

        }

        private void menuAvanzado_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// //////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuIngresarUusarioBasicos_Click(object sender, EventArgs e)
        {
            Program.frmBasico = new IngresarUsuarioBasico();
            Program.frmBasico.MdiParent = this;
            Program.frmBasico.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuingresarDeportes_Click(object sender, EventArgs e)
        {
            Program.frmDeporteIng = new IngresarDeporte();
            Program.frmDeporteIng.MdiParent = this;
            Program.frmDeporteIng.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuIngresarEjercicios_Click(object sender, EventArgs e)
        {
            Program.frmEjercicosIng = new EjercicioIngresar();
            Program.frmEjercicosIng.MdiParent = this;
            Program.frmEjercicosIng.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
