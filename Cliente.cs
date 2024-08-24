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
        protected DateTime? _fechanacimiento; // Cambiado de List<string> a DateTime
        protected string _direccion = "";
        protected List<int> _edad;
        protected List<string> _departamentos;
        protected List<string> _gmail;
        protected string _genero;
        protected Boolean _dificultad;
        protected string _descripciondificultad;
        protected ADODB.Connection _conexion;

        public Cliente()
        {
            _ci = 0;
            _nombre = "";
            _telefonos = new List<string>();
            _fechanacimiento = null;
            _direccion = ""; // Inicialización
            _edad = new List<int>(); //  inicializar List<int> también
            _departamentos = new List<string>(); // Inicialización de listas
            _gmail = new List<string>();
            _genero = "";
            _dificultad = false; // Inicialización correcta
            _descripciondificultad = "";
            _conexion = new ADODB.Connection();
        }

        public Cliente(int ci, string nombre, List<string> telefonos, DateTime? fechanacimiento, string direccion, List<int> edad, List<string> departamentos, List<string> gmail, string genero, bool dificultad, string descripciondificultad, Connection conexion)
        {
            _ci = ci;
            _nombre = nombre;
            _telefonos = telefonos;
            _fechanacimiento = null;
            _direccion = direccion;
            _edad = edad;
            _departamentos = departamentos;
            _gmail = gmail;
            Genero = genero;
            _dificultad = dificultad;
            _descripciondificultad = descripciondificultad;
            _conexion = conexion;
            Genero = genero;
        }


        // Propiedades
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
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        private DateTime _fechaNacimiento;
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public List<int> Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public List<string> Departamentos
        {
            get { return _departamentos; }
            set { _departamentos = value; }
        }

        public List<string> Gmail
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
            public String Usuario { set; get; }
            public String Contrasenia { set; get; }

        }
        public byte Guardar(bool modificacion)
        {
            string sql = "";
            Cliente c = new Cliente();
            List<string> telefonos = c.Telefonos; // Obtén los teléfonos

            // Construye la consulta SQL para insertar/actualizar el cliente
            if (modificacion)
            {
                sql = $"UPDATE clientes SET " +
                      $"nombre = '{EscapeSql(c.Nombre)}', " +
                      $"direccion = '{EscapeSql(c.Direccion)}', " +
                      $"genero = '{EscapeSql(c.Genero)}', " +
                      $"departamento = '{EscapeSql(string.Join(",", c.Departamentos))}', " +
                      $"edad = '{string.Join(",", c.Edad)}', " +
                      $"correo_gmail = '{string.Join(",", c.Gmail)}', " +
                      $"dificultad = {(c.Dificultad ? 1 : 0)}, " +
                      $"descripcion_dificultad = '{EscapeSql(c.DescripcionDificultad)}', " +
                      $"fecha_nacimiento = '{(c.FechaNacimiento != DateTime.MinValue ? c.FechaNacimiento.ToString("yyyy-MM-dd") : "NULL")}' " +
                      $"WHERE ci = {c.Ci};";
            }
            else
            {
                sql = $"INSERT INTO clientes (ci, nombre, direccion, genero, departamento, edad, correo_gmail, dificultad, descripcion_dificultad, fecha_nacimiento) VALUES " +
                      $"({c.Ci}, '{EscapeSql(c.Nombre)}', '{EscapeSql(c.Direccion)}', '{EscapeSql(c.Genero)}', '{EscapeSql(string.Join(",", c.Departamentos))}', " +
                      $"'{string.Join(",", c.Edad)}', '{string.Join(",", c.Gmail)}', {(c.Dificultad ? 1 : 0)}, '{EscapeSql(c.DescripcionDificultad)}', " +
                      $"'{(c.FechaNacimiento != DateTime.MinValue ? c.FechaNacimiento.ToString("yyyy-MM-dd") : "NULL")}');";
            }

            // Mostrar la consulta SQL en un cuadro de mensaje para depuración
            MessageBox.Show($"Consulta SQL: {sql}");

            try
            {
                // Ejecutar la consulta SQL
                _conexion.Execute(sql, out object filasAfectadas);

                // Manejo de eliminación e inserción de teléfonos
                foreach (string telefono in telefonos)
                {
                    string sqlTelefono = $"INSERT INTO cliente_telefonos (cliente, telefono) VALUES ({c.Ci}, '{EscapeSql(telefono)}');";

                    // Mostrar la consulta SQL para teléfonos en un cuadro de mensaje para depuración
                    MessageBox.Show($"Consulta SQL Teléfono: {sqlTelefono}");

                    _conexion.Execute(sqlTelefono, out object filasTelefonoAfectadas);
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

