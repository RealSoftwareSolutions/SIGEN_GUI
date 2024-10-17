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
            txtDocumentoId.Text = "";
            cbDocumentoTipo.SelectedItem = -1;
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
            int telefono = 0; // Solo se requiere para el teléfono
            Cliente c;

            // Verificar si hay un elemento seleccionado en el ComboBox
            if (cbDocumentoTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de documento.");
                return; // Salir si no hay selección
            }

            if (cboDepartamento.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un departamento.");
                return;
            }

            if (cboGenero.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un departamento.");
                return;
            }


            // Obtener el tipo de documento seleccionado
            string tipoDocumento = cbDocumentoTipo.SelectedItem.ToString();
            string documentoId = txtDocumentoId.Text.Trim(); // Captura el documento como string

            // Validar según el tipo de documento
            if (tipoDocumento == "C.I")
            {
                // Asegurarse de que el documento solo contenga números
                if (!int.TryParse(documentoId, out _)) // Solo verificar que sea numérico, no guardamos en cedula
                {
                    MessageBox.Show("La C.I. debe ser numérica.");
                    return; // Salir si la validación falla
                }
            }
            else if (tipoDocumento == "Pasaporte")
            {
                // Para el pasaporte, no se requiere validación adicional aquí
                // Puedes agregar validaciones específicas si lo deseas
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de documento válido.");
                return; // Salir si no se selecciona un tipo
            }

            // Validar el teléfono
            if (!int.TryParse(txtTelefono.Text, out telefono))
            {
                MessageBox.Show("El teléfono debe ser numérico.");
                return; // Salir si la validación falla
            }

            // Validar el correo
            if (!IsGmail(txtGmail.Text))
            {
                MessageBox.Show("El gmail tiene que ser @gmail.com ejemplo: gonzalo@gmail.com");
                return; // Salir si la validación falla
            }

            c = new Cliente
            {
                iddocumento = documentoId, // Asignar el documento como string
                tipodocumento = cbDocumentoTipo.SelectedItem.ToString(), // Asignar el tipo de documento
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

            c = null; // Limpiar referencia
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
            string documento = txtBuscar.Text.Trim(); // Captura el documento como string

            // Verificar que el documento no esté vacío
            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("El documento no puede estar vacío.");
                return; // Salir del método si la validación falla
            }

            // Asignar el documento directamente
            c.Conexion = Program.cn;
            c.iddocumento = documento; // Asignar el documento como string

            switch (c.Buscar())
            {
                case 0: // Cliente encontrado
                    gbBuscar.Enabled = true;
                    MessageBox.Show("El usuario con documento " + c.iddocumento + " ya está registrado.");

                    // Preguntar si desea eliminar el cliente
                    DialogResult resultadoEliminar = MessageBox.Show("¿Desea eliminar al usuario con documento " + c.iddocumento + "?", "Eliminar usuario", MessageBoxButtons.YesNo);
                    if (resultadoEliminar == DialogResult.Yes)
                    {
                        // Llamar al método para eliminar el cliente
                        if (c.Eliminar())
                        {
                            MessageBox.Show("El usuario ha sido eliminado.");
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error al eliminar el usuario. Inténtelo de nuevo.");
                        }
                    }
                    gbDatos.Enabled = false;
                    txtBuscar.Text = ""; // Limpiar el campo de búsqueda
                    break;

                case 1:
                    MessageBox.Show("Ha perdido la sesión. Debe loguearse nuevamente.");
                    break;

                case 2:
                    MessageBox.Show("Error en la búsqueda.");
                    break;

                case 3: // No encontrado
                    MessageBox.Show("El documento " + c.iddocumento + " no fue encontrado.");
                    DialogResult resultadoAgregar = MessageBox.Show("¿Desea agregar el usuario?", "¿Agregar?", MessageBoxButtons.YesNo);
                    if (resultadoAgregar == DialogResult.Yes)
                    {
                        gbBuscar.Enabled = false;
                        gbDatos.Visible = true; // Mostrar la sección de datos
                        gbDatos.Enabled = true; // Habilitar la sección de datos
                        txtNombre.Clear(); // Limpiar el campo de nombre
                        btnGuardar.Text = "Guardar"; // Cambiar el texto del botón a "Guardar"
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dpkFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lbFechaNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblDepartamento_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccionLoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gbBuscar_Enter(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void streamClassBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void clienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbDocumentoTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    




