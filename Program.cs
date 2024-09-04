using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SIGEN_GUI
{

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static LoginInicial frmLogin;
        public static IngresarUsuarioBasico frmBasico;

        public static Principal frmPrincipal;
        public static ADODB.Connection cn = new ADODB.Connection(); /*Conector a una base de datos - 21/05/2024 - Público para que lo tengan todos los archivos del proyecto y Est+atico porque est+a en la clase estática program*/


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
            frmPrincipal.menuAplicasiones.Enabled = false; //ponerlo como public 
            frmPrincipal.menuAvanzado.Enabled = false;
            frmPrincipal.menuClientes.Enabled = false;
            frmPrincipal.menuEntrenador.Enabled = false;
            frmPrincipal.menuAdministrador.Enabled = false;


            if (cn.State != 0) //conexion abierta del login
            {

                sql = "select rol from usuario_rol where usuario='" + usuario + "'";
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
                { //encontre uno, pues busque por PK(primary key)
                  // MessageBox.Show(rs.Fields.Count.ToString());
                    rol = Convert.ToByte(rs.Fields[0].Value);
                    switch (rol)
                    {


                        case 1:
                            frmPrincipal.menuAplicasiones.Enabled = true;
                            frmPrincipal.menuClientes.Enabled = true;

                            break;

                        case 2: //esto es 1 rol o se refiere al rol.
                            frmPrincipal.menuAplicasiones.Enabled = true;
                            frmPrincipal.menuClientes.Enabled = true;

                            break;
                        case 3:

                            break;

                        case 5: //rol de avanzado usuario
                            frmPrincipal.menuAplicasiones.Enabled = true;
                            frmPrincipal.menuAvanzado.Enabled = true;
                            frmPrincipal.menuIngresarUusarioBasicos.Enabled = true;
                            break;

                        case 6: //rol del dev :p osea el bagre que hizo este codigo feo xd
                            frmPrincipal.menuAplicasiones.Enabled = true;
                            frmPrincipal.menuAvanzado.Enabled = true;
                            frmPrincipal.menuIngresarUusarioBasicos.Enabled = true;
                            break;

                    }//switch

                }


            }
        }

    }
}
