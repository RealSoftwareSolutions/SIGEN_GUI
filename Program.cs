using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGEN_GUI
{

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
        public static void Doypermisos(string usuario)
        {

        }
        public static ADODB.Connection cn = new ADODB.Connection(); /*Conector a una base de datos - 21/05/2024 - Público para que lo tengan todos los archivos del proyecto y Est+atico porque est+a en la clase estática program*/
    }
}
