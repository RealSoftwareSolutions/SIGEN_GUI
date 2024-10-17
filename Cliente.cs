using ADODB;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SIGEN_GUI
{
    class Cliente
    {
        protected string _iddocumento;
        protected string _tipodocumento;
        protected string _nombre;
        protected int _telefono;
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
            _iddocumento = "";
            _tipodocumento = "";
            _nombre = "";
            _telefono = 0;
            _fechanacimiento = null;
            _direccion = "";
            _departamentos = "";
            _gmail = "";
            _genero = "";
            _dificultad = false;
            _descripciondificultad = "";
            _conexion = new ADODB.Connection();
        }

        public Cliente(string iddocumento, string tipodocumento, string nombre, int telefono, DateTime? fechanacimiento, string direccion, string departamentos, string gmail, string genero, bool dificultad, string descripciondificultad, Connection conexion)
        {
            _iddocumento = iddocumento;
            _tipodocumento = tipodocumento;
            _nombre = nombre;
            _telefono = telefono;
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
        public string iddocumento
        {
            get { return _iddocumento; }
            set { _iddocumento = value; }
        }
        public string tipodocumento
        {
            get { return _tipodocumento; }
            set { _tipodocumento = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
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
        public bool Eliminar()
        {
            if (_conexion.State == 0) // Verificar si la conexión está cerrada
            {
                MessageBox.Show("Conexión cerrada. No se puede eliminar el cliente.");
                return false;
            }

            if (string.IsNullOrEmpty(_iddocumento)) // Verificar que el CI sea válido
            {
                MessageBox.Show("No hay CI válido para eliminar.");
                return false;
            }

            string sql = "DELETE FROM clientes WHERE id_documento = " + _iddocumento; // Consulta para eliminar al cliente
            try
            {
                _conexion.Execute(sql, out object filasAfectadas); // Ejecutar la consulta
                return true; // Eliminación exitosa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                return false; // Error en la eliminación
            }
        }

        public byte Buscar()
        {
            if (_conexion.State == 0)
            {
                return 1; // CONEXIÓN CERRADA
            }

            if (string.IsNullOrEmpty(_iddocumento))
            {
                return 2; // ERROR: No hay CI válido para buscar
            }

            string sql = "SELECT `id_documento` FROM `clientes` WHERE id_documento = " + _iddocumento;
            ADODB.Recordset rs = null; // Inicializamos rs como null

            try
            {
                rs = _conexion.Execute(sql, out object filasAfectadas);

                if (rs.RecordCount == 0)
                {
                    return 3; // NO ENCONTRÉ EL CLIENTE
                }

                _nombre = Convert.ToString(rs.Fields[0].Value); // Asignar el nombre del cliente encontrado
            }
            catch
            {
                return 4; // ERROR AL CONSULTAR CLIENTE
            }
            finally
            {
                if (rs != null)
                {
                    rs.Close(); // Asegurarse de cerrar el recordset si se abrió
                }
            }

            return 0; // CLIENTE ENCONTRADO
        }


        public byte Guardar()
        {
            string sql;
            object filasAfectadas;
            byte resultado = 0;
            if (_conexion.State == 0) // CONEXIÓN CERRADA
            {
                return 1; // ERROR DE CONEXIÓN
            }
            try
            {
                // Insertar nuevo cliente
                sql = "INSERT INTO clientes(id_documento, tipo_documento, nombre, fechanacimiento, direccion, departamentos, gmail, genero, dificultad, descripciondificultad, fecha_ingreso, telefono) " +
               "VALUES (" +
               "'" + _iddocumento + "', " + // ENTRE COMILLAS
               "'" + _tipodocumento + "', " + // ENTRE COMILLAS
               "'" + _nombre + "', " +
               (_fechanacimiento.HasValue ? "'" + _fechanacimiento.Value.ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
               "'" + _direccion + "', " +
               "'" + _departamentos + "', " +
               "'" + _gmail + "', " +
               "'" + _genero + "', " +
               (_dificultad ? "1" : "0") + ", " +
               "'" + _descripciondificultad + "', " +
               "'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
               "'" + _telefono + "')";

                _conexion.Execute(sql, out filasAfectadas);
            }
           
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                return 2; // ERROR AL GUARDAR CLIENTE
            }
           /*
            // Insertar teléfonos del cliente
            //foreach (string tel in _telefono)
            //{
                try
                {
                    sql = "INSERT INTO cliente_telefonos (cliente, telefono) VALUES (" + _ci + ", '" + tel + "')";
                    _conexion.Execute(sql, out filasAfectadas);
                }
                catch (Exception ex)

                {
                    MessageBox.Show("Error al insertar teléfono: " + ex.Message);
                    return 3; // ERROR AL INSERTAR TELÉFONO
                }
            }
        */
            return resultado;
        }// guardar
        }
    }

