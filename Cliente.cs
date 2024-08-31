using ADODB;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SIGEN_GUI
{
    class Cliente
    {
        protected int _ci;
        protected string _nombre;
        protected List<string> _telefonos;
        protected DateTime? _fechanacimiento;
        protected string _direccion;
        protected string _departamentos;
        protected string _gmail;
        protected string _genero;
        protected bool _dificultad;
        protected string _descripciondificultad;
        protected ADODB.Connection _conexion;

        public Cliente()
        {
            _ci = 0;
            _nombre = "";
            _telefonos = new List<string>();
            _fechanacimiento = null;
            _direccion = "";
            _departamentos = "";
            _gmail = "";
            _genero = "";
            _dificultad = false;
            _descripciondificultad = "";
            _conexion = new ADODB.Connection();
        }

        public Cliente(int ci, string nombre, List<string> telefonos, DateTime? fechanacimiento, string direccion, string departamentos, string gmail, string genero, bool dificultad, string descripciondificultad, Connection conexion)
        {
            _ci = ci;
            _nombre = nombre;
            _telefonos = telefonos;
            _fechanacimiento = null;
            _direccion = direccion;
            _departamentos = departamentos;
            _gmail = gmail;
            _genero = genero;
            _dificultad = dificultad;
            _descripciondificultad = descripciondificultad;
            _conexion = conexion;
        }

        // Propiedades públicas (getters y setters)
        public int Ci
        {
            get { return _ci; }
            set { _ci = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public List<string> Telefonos
        {
            get { return _telefonos; }
            set { _telefonos = value; }
        }

        public DateTime? FechaNacimiento
        {
            get { return _fechanacimiento; }
            set { _fechanacimiento = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Departamentos
        {
            get { return _departamentos; }
            set { _departamentos = value; }
        }

        public string Gmail
        {
            get { return _gmail; }
            set { _gmail = value; }
        }

        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        public bool Dificultad
        {
            get { return _dificultad; }
            set { _dificultad = value; }
        }

        public string DescripcionDificultad
        {
            get { return _descripciondificultad; }
            set { _descripciondificultad = value; }
        }

        public Connection Conexion
        {
            get { return _conexion; }
            set { _conexion = value; }
        }

        internal class UsuPass
        {
            public string Usuario { get; set; }
            public string Contrasenia { get; set; }
        }
        public byte Guardar(bool modificacion)
        {
            string sql = "";
            Cliente c = new Cliente();
            List<string> telefonos = c.Telefonos;

            // Construye la consulta SQL para insertar/actualizar el cliente
            if (modificacion)
            {
                sql = $"UPDATE clientes SET " +
                      $"nombre = '{EscapeSql(c.Nombre)}', " +
                      $"direccion = '{EscapeSql(c.Direccion)}', " +
                      $"genero = '{EscapeSql(c.Genero)}', " +
                      $"departamento = '{EscapeSql(c.Departamentos)}', " +
                      $"correo_gmail = '{EscapeSql(c.Gmail)}', " +
                      $"dificultad = {(c.Dificultad ? 1 : 0)}, " +
                      $"descripcion_dificultad = '{EscapeSql(c.DescripcionDificultad)}', " +
                      $"fecha_nacimiento = {(c.FechaNacimiento.HasValue ? $"'{c.FechaNacimiento:yyyy-MM-dd}'" : "NULL")} " +
                      $"WHERE ci = {c.Ci};";
            }
            else
            {
                sql = $"INSERT INTO clientes (ci, nombre, direccion, genero, departamento, correo_gmail, dificultad, descripcion_dificultad, fecha_nacimiento) VALUES " +
                      $"({c.Ci}, '{EscapeSql(c.Nombre)}', '{EscapeSql(c.Direccion)}', '{EscapeSql(c.Genero)}', '{EscapeSql(c.Departamentos)}', " +
                      $"'{EscapeSql(c.Gmail)}', {(c.Dificultad ? 1 : 0)}, '{EscapeSql(c.DescripcionDificultad)}', " +
                      $"{(c.FechaNacimiento.HasValue ? $"'{c.FechaNacimiento:yyyy-MM-dd}'" : "NULL")});";
            }

            // Mostrar la consulta SQL en un cuadro de mensaje para depuración
            MessageBox.Show($"Consulta SQL: {sql}");

            try
            {
                // Ejecutar la consulta SQL
                c.Conexion.Execute(sql, out object filasAfectadas);

                // Manejo de eliminación e inserción de teléfonos
                foreach (string telefono in telefonos)
                {
                    string sqlTelefono = $"INSERT INTO cliente_telefonos (cliente, telefono) VALUES ({c.Ci}, '{EscapeSql(telefono)}');";

                    // Mostrar la consulta SQL para teléfonos en un cuadro de mensaje para depuración
                    MessageBox.Show($"Consulta SQL Teléfono: {sqlTelefono}");

                    c.Conexion.Execute(sqlTelefono, out object filasTelefonoAfectadas);
                }
            }
            catch (COMException comEx)
            {
                MessageBox.Show($"COM Error: {comEx.Message}");
                return 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return 2;
            }

            return 0; // Éxito
        }
        // Método para escapar caracteres especiales en SQL
        private string EscapeSql(string input)
        {
            return input.Replace("'", "''"); // Escapa comillas simples
        }

    }
}