using ADODB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

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
            gbDatos.Enabled = false;
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
        private void LimpiarFormulario()
        {
            // Limpiar todos los campos del formulario
            txtCedula.Text = "";    
            txtNombre.Text = "";
            txtDireccionLoc.Text = "";
            cboDepartamento.SelectedItem = -1;
            txtGmail.Text = "";
            cboGenero.SelectedItem = -1;
            txtDescripcionDificultad.Text = "";
            txtTelefono.Text = "";  // Nuevo txtTelefono
            cbSi.Checked = false;
            dpkFechaNacimiento.Value = DateTime.Now;

        }
        static bool IsGmail(string email) //funcion que hace 1 numerador nulo
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cedula = 0;
            int telefono = 0;
            Cliente c;

            if (!int.TryParse(txtCedula.Text, out cedula))
            {
                MessageBox.Show("CI debe ser numérico");
            }
            else if (!int.TryParse(txtTelefono.Text, out telefono))
            {
                MessageBox.Show("El teléfono debe ser numérico");
            }
            else if (!IsGmail(txtGmail.Text))
            {
                MessageBox.Show("El gmail tiene que ser @gmail.com ejemplo: gonzalo@gmail.com");
            }
            else
            {
                c = new Cliente
                {
                    Ci = cedula,
                    Conexion = Program.cn,
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccionLoc.Text,
                    Departamentos = cboDepartamento.SelectedItem.ToString(),
                    Gmail = txtGmail.Text,
                    Genero = cboGenero.SelectedItem.ToString(),
                    FechaNacimiento = dpkFechaNacimiento.Value,
                    Dificultad = cbSi.Checked,
                    DescripcionDificultad = txtDescripcionDificultad.Text,
                    Telefono = telefono
                };

                // Aquí agregamos el teléfono ingresado en txtTelefono

                // Guardar datos del cliente
                switch (c.Guardar())
                {
                    case 0:
                        LimpiarFormulario();
                        gbDatos.Enabled = false;
                        gbBuscar.Enabled = true;
                        break;

                    case 1:
                        MessageBox.Show("Perdió la sesión. Debe loguearse nuevamente.");
                        break;

                    case 2:
                        MessageBox.Show("Error al guardar el cliente.");
                        break;

                    case 3:
                        MessageBox.Show("Error al insertar teléfonos.");
                        break;
                }

                c = null;
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {  
           
          
        }
        private void txtDescripcionDificultad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitarTelefono_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            int documento;

            // Verificar que el documento sea numérico
            if (!Int32.TryParse(txtBuscar.Text, out documento))
            {
                MessageBox.Show("El documento debe ser numérico: " + txtBuscar.Text);
                return; // Salir del método si la validación falla
            }

            c.Conexion = Program.cn;
            c.Ci = documento; // Asignar directamente el documento como cédula

            switch (c.Buscar())
            {
                case 0: // Cliente encontrado
                    gbBuscar.Enabled = true;
                    MessageBox.Show("El usuario con cédula " + c.Ci + " ya está registrado.");
                    gbDatos.Enabled = false;
                    txtBuscar.Text = "";
                    break;

                case 1:
                    MessageBox.Show("Ha perdido la sesión. Debe loguearse nuevamente.");
                    break;

                
                case 2:
                    MessageBox.Show("deha");
                    break;

                case 3: // No encontrado
                    MessageBox.Show("Error:"+ c.Ci);
                    DialogResult resultado = MessageBox.Show("¿Desea agregar el usuario?", "¿Agregar?", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                       
                        gbBuscar.Enabled = false;
                        gbDatos.Visible = true;
                        gbDatos.Enabled = true;
                        txtNombre.Clear();
                        btnGuardar.Text = "Guardar";
                    }
                    break;

                case 4:
                    MessageBox.Show("Hubo errores al buscar. En caso de repetirse, avisar al administrador.");
                    break;
            }
        }


        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCi_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    




