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

        private void CloseAllChildForms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close(); // Cerrar todos los formularios hijos
            }
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
            if (Program.cn.State == 0) // Conexión Abierta
            {
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

                    // Llama a un método para deshabilitar permisos
                    DeshabilitarPermisos();
                    CloseAllChildForms();
                }
            }

            this.LayoutMdi(MdiLayout.TileHorizontal);
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        // Método para deshabilitar permisos
        private void DeshabilitarPermisos()
        {
            Program.CambiarEstadoMenuItem(Program.frmPrincipal.menuAplicasiones, false);
            Program.CambiarEstadoMenuItem(Program.frmPrincipal.menuAvanzado, false);
            Program.CambiarEstadoMenuItem(Program.frmPrincipal.menuClientes, false);
            Program.CambiarEstadoMenuItem(Program.frmPrincipal.menuEntrenador, false);
            Program.CambiarEstadoMenuItem(Program.frmPrincipal.menuAdministradorTI, false);
            Program.CambiarEstadoMenuItem(Program.frmPrincipal.menuIngresarUusarioBasicos, false);
            Program.CambiarEstadoMenuItem(Program.frmPrincipal.menuingresarDeportes, false);
            Program.CambiarEstadoMenuItem(Program.frmPrincipal.menuIngresarEjercicios, false);
        }

        private void menuIngresar_Click(object sender, EventArgs e)
        {

        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            CloseAllChildForms();
            Program.frmRutina = new Rutina();
            Program.frmRutina.MdiParent = this;
            Program.frmRutina.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuAgenda_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Program.frmAgenda = new Agenda();
            Program.frmAgenda.MdiParent = this;
            Program.frmAgenda.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuAvanzado_Click(object sender, EventArgs e)
        {

        }

        private void menuIngresarUusarioBasicos_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Program.frmBasico = new IngresarUsuarioBasico();
            Program.frmBasico.MdiParent = this;
            Program.frmBasico.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuingresarDeportes_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Program.frmDeporteIng = new IngresarDeporte();
            Program.frmDeporteIng.MdiParent = this;
            Program.frmDeporteIng.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuIngresarEjercicios_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Program.frmEjercicosIng = new EjercicioIngresar();
            Program.frmEjercicosIng.MdiParent = this;
            Program.frmEjercicosIng.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuAdministrativo_Click(object sender, EventArgs e)
        {

        }

        private void menuSeleccionador_Click(object sender, EventArgs e)
        {

        }

        private void menuRendimiento_Click(object sender, EventArgs e)
        {
            //frmRendimiento
            CloseAllChildForms();
            Program.frmRendimiento = new Rendimiento();
            Program.frmRendimiento.MdiParent = this;
            Program.frmRendimiento.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
