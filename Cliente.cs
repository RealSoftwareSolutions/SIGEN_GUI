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
        public byte Buscar()
        {
            string sql;
            ADODB.Recordset rs;
            object filasAfectadas;
            byte resultado = 0;// POR DEFECTO ASUME QUE LO ENCONTRE
            if (_conexion.State == 0)
            {
                resultado = 1; //CONEXION CERRADA

            }
            else
            {
                sql = "select nombre from clientes where ci=" + _ci;
                try
                {
                    rs = _conexion.Execute(sql, out filasAfectadas);
                }
                catch
                {
                    return (2);// ERROR AL CONSULTAR CLIENTE

                }
                if (rs.RecordCount == 0)
                {
                    resultado = 3;//NO ENCONTRE
                }
                else
                {
                    _nombre = Convert.ToString(rs.Fields[0].Value);
                    sql = "select telefono from cliente_telefonos where cliente=" + _ci;
                    try
                    {
                        rs = _conexion.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {
                        return (4);
                    }
                    _telefonos.Clear();
                    while (!rs.EOF)/*INDICADOR DE QUE TERMINO EL RECORRIDO */
                    {
                        _telefonos.Add(Convert.ToString(rs.Fields[0].Value));
                        rs.MoveNext();
                    }
                }//if Record Count
                rs = null;
                filasAfectadas = null;
            } //if conection State

            return resultado;


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
                sql = "INSERT INTO clientes (ci, nombre, fechanacimiento, direccion, departamentos, gmail, genero, dificultad, descripciondificultad) " +
                      "VALUES ('" + _ci + "', " +
                      "'" + _nombre + "', " +
                      (_fechanacimiento.HasValue ? "'" + _fechanacimiento.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'" : "NULL") + ", " +
                      "'" + _direccion + "', " +
                      "'" + _departamentos + "', " +
                      "'" + _gmail + "', " +
                      "'" + _genero + "', " +
                      (_dificultad ? "1" : "0") + ", " +
                      "'" + _descripciondificultad + "')";

                _conexion.Execute(sql, out filasAfectadas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                return 2; // ERROR AL GUARDAR CLIENTE
            }

            // Insertar teléfonos del cliente
            foreach (string tel in _telefonos)
            {
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

            return resultado;
        }// guardar

    }


}