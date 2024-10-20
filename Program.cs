using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SIGEN_GUI
{
    /// <summary>
    
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static LoginInicial frmLogin;
        public static IngresarUsuarioBasico frmBasico;
        public static EjercicioIngresar frmEjercicosIng;
        public static IngresarDeporte frmDeporteIng;
        public static Rutina frmRutina;
        public static Rendimiento frmRendimiento;
        public static Agenda frmAgenda;
        public static AgendaEntrenador frmAgendaEntrenador;
        public static CalificarEntrenador frmcalificarEntrenador;

        public static Principal frmPrincipal;
        public static ADODB.Connection cn = new ADODB.Connection(); /*Conector a una base de datos - 21/05/2024 - Público para que lo tengan todos los archivos del proyecto y Est+atico porque est+a en la clase estática program*/

        // Método para cambiar el estado y el color de los ítems del menú
        public static void CambiarEstadoMenuItem(ToolStripMenuItem menuStrip1, bool habilitado)
        {
            if (habilitado)
            {
                menuStrip1.Enabled = true;
                menuStrip1.BackColor = Color.LightGreen; // Color verde si tiene permisos
            }
            else
            {
                menuStrip1.Enabled = false;
                menuStrip1.BackColor = Color.DarkRed; // Color gris si no tiene permisos
            }
        }

        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(frmPrincipal = new Principal()); //istacia ecesaria
        }
        
        public static void Doypermisos(string usuario)
        {
            string sql;// cada vez que tengamos que hacer un select uvamos a tener que hacer esto
            object filasafectadas;
            ADODB.Recordset rs;
            byte rol = 0;
            CambiarEstadoMenuItem(frmPrincipal.menuAplicasiones, false); //0 Principal 
            CambiarEstadoMenuItem(frmPrincipal.menuClientes, false); //1 rol
            CambiarEstadoMenuItem(frmPrincipal.menuEntrenador, false); //2
            CambiarEstadoMenuItem(frmPrincipal.menuSeleccionador, false);
            CambiarEstadoMenuItem(frmPrincipal.menuAdministrativo, false); //3
            CambiarEstadoMenuItem(frmPrincipal.menuAvanzado, false); //4
            CambiarEstadoMenuItem(frmPrincipal.menuAdministradorTI, false); //5


            if (cn.State != 0) //conexion abierta del login
            {

                sql = "SELECT Rol FROM Usuario_Login WHERE Login ='" + usuario + "'";
                try
                {
                    rs = cn.Execute(sql, out filasafectadas); // ejecucion

                }
                catch



                {
                    MessageBox.Show("error al obtener rol del usuario"); // prevee un error en la base de datos o conexion de red (IMPORNATE PARA EL PROYECTO)
                    return;
                }

                if (rs.RecordCount == 0)
                {

                    MessageBox.Show("el usuario no time rol asignado. Avisa al administrador");
                }
                else
                { //encontre uno, pues busque por PK(primary key en este caso login :o)
                  // MessageBox.Show(rs.Fields.Count.ToString());
                    rol = Convert.ToByte(rs.Fields[0].Value);
                    switch (rol)
                    {

                        case 1: //Rol de cliente
                            CambiarEstadoMenuItem(frmPrincipal.menuAplicasiones, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuClientes, true);
                            break;

                        case 2: // Rol de administrativo
                            CambiarEstadoMenuItem(frmPrincipal.menuAplicasiones, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuClientes, true);
                            break;

                        case 3:// Rol de avanzado
                            CambiarEstadoMenuItem(frmPrincipal.menuAplicasiones, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuAvanzado, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuIngresarUusarioBasicos, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuingresarDeportes, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuIngresarEjercicios, true);
                            break;

                        case 4: // Rol de entrenador
                            CambiarEstadoMenuItem(frmPrincipal.menuAplicasiones, true);
                            break;


                        case 5: // Rol de seleccionador
                            CambiarEstadoMenuItem(frmPrincipal.menuAplicasiones, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuAvanzado, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuIngresarUusarioBasicos, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuingresarDeportes, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuIngresarEjercicios, true);
                            break;

                        case 6: // Rol del administradorti
                            CambiarEstadoMenuItem(frmPrincipal.menuAplicasiones, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuAvanzado, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuIngresarUusarioBasicos, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuingresarDeportes, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuIngresarEjercicios, true);
                            break;


                        case 7: // Rol del desarrollador
                            CambiarEstadoMenuItem(frmPrincipal.menuAplicasiones, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuClientes, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuEntrenador, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuAgendaEntrenador, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuAgenda, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuRutina, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuRendimiento, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuAvanzado, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuIngresarUusarioBasicos, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuingresarDeportes, true);
                            CambiarEstadoMenuItem(frmPrincipal.menuIngresarEjercicios, true);
                            break;




                    }//switch



                }


            }
            
        }

    }
}
