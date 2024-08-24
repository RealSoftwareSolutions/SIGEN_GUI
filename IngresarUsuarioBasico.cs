using ADODB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SIGEN_GUI
{
    public partial class IngresarUsuarioBasico : Form
    {
        public IngresarUsuarioBasico()
        {
            InitializeComponent();
            
        }

        private void IngresarUsuarioBasico_Load(object sender, EventArgs e)
        {

        }

        private void cboTelefonos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void cbSi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSi.Checked)
            {

            }
            else
            {
                cbSi.Checked = false;
            }
        }
        private Connection _conexion;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            _conexion = new Connection();
            _conexion.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};Server=localhost;Database=miodbc;User=pepe;Password=1234;Option=3;";
            _conexion.Open();
            // Asume que 'c' es una instancia válida de la clase Cliente
            Cliente c = new Cliente
            {
                Nombre = txtNombre.Text,
                Direccion = txtDireccionLoc.Text,
                Edad = new List<int> { /* Asigna edades si hay datos en el formulario */ },
                Departamentos = new List<string> { /* Asigna departamentos si hay datos en el formulario */ },
                Gmail = new List<string> { /* Asigna correos Gmail si hay datos en el formulario */ },
                Genero = txtGenero.Text,
                Dificultad = cbSi.Checked,
                DescripcionDificultad = txtDescripcionDificultad.Text,
                FechaNacimiento = DateTime.TryParse(txtFechaNacimiento.Text, out DateTime fechaNacimiento) ? fechaNacimiento : DateTime.MinValue,
                Telefonos = new List<string>(cboTelefonos.Items.Cast<string>()),
                Conexion = Program.cn
            };

            // Construir la consulta SQL 
            string sql = $"UPDATE clientes SET " +
                          $"nombre = '{EscapeSql(c.Nombre)}', " +
                          $"direccion = '{EscapeSql(c.Direccion)}', " +
                          $"genero = '{EscapeSql(c.Genero)}', " +
                          $"departamento = '{EscapeSql(string.Join(",", c.Departamentos))}', " +
                          $"edad = '{string.Join(",", c.Edad)}', " +
                          $"correo_gmail = '{string.Join(",", c.Gmail)}', " +
                          $"dificultad = {(c.Dificultad ? 1 : 0)}, " +
                          $"descripcion_dificultad = '{EscapeSql(c.DescripcionDificultad)}', " +
                          $"fecha_nacimiento = {(c.FechaNacimiento != DateTime.MinValue ? $"'{c.FechaNacimiento:yyyy-MM-dd}'" : "NULL")} " +
                          $"WHERE ci = {c.Ci};";

            // Mostrar la consulta SQL en un cuadro de mensaje para depuración
            MessageBox.Show($"Consulta SQL: {sql}");

            try
            {
                // Ejecutar la consulta SQL
                _conexion.Execute(sql, out object filasAfectadas);
            }
            catch (COMException comEx)
            {
                MessageBox.Show($"COM Error: {comEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Método para escapar caracteres especiales en SQL
        private string EscapeSql(string input)
        {
            return input.Replace("'", "''"); // Escapa comillas simples
        }

        private void txtDescripcionDificultad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaNacimiento_TextChanged(object sender, EventArgs e)
        {

        }
    }

}


