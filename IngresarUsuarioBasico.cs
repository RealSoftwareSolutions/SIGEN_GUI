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
            lblDescripcionDificultad.Visible = false;
            btnModificar.Enabled = false;
            txtDescripcionDificultad.Visible = false;
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
                lblDescripcionDificultad.Visible = true;
                txtDescripcionDificultad.Visible = true;
            }
            else
            {
                lblDescripcionDificultad.Visible = false;
                txtDescripcionDificultad.Visible = false;
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

            // Verifico si todos los campos obligatorios están completos
            if (cbDocumentoTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de documento.");
            }
            else if (txtDocumentoId == null || string.IsNullOrEmpty(txtDocumentoId.Text))
            {
                MessageBox.Show("Por favor, ingrese un Documento ID.");
            }
            else if (txtNombre == null || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese un Nombre.");
            }
            else if (cboGenero.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un Género.");
            }
            else if (cboDepartamento.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un Departamento.");
            }
            else if (txtDireccionLoc == null || string.IsNullOrEmpty(txtDireccionLoc.Text))
            {
                MessageBox.Show("Por favor, ingrese una Dirección o Calle.");
            }
            else if (txtGmail == null || string.IsNullOrEmpty(txtGmail.Text))
            {
                MessageBox.Show("Por favor, ingrese un Gmail.");
            }
            else if (txtTelefono == null || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, ingrese un Teléfono.");
            }
            else
            {

                string tipoDocumento = cbDocumentoTipo.SelectedItem.ToString();
                string documentoId = txtDocumentoId.Text.Trim(); // Captura el documento como string

                // Validar según el tipo de documento
                if (tipoDocumento == "C.I")
                {
                    //g Asegurarse de que el documento solo contena números
                    if (!int.TryParse(documentoId, out _)) // verifica si es un numerico
                    {
                        MessageBox.Show("La C.I. debe ser numérica.");
                        return; // Salir si la validación falla
                    }


                }
                else if (tipoDocumento == "Pasaporte")
                {

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
                else if (txtTelefono.Text.Length > 9)
                {
                    MessageBox.Show("El teléfono debe tener un máximo de 9 números.");
                    return; // Salir si la longitud es incorrecta
                }

                // Validar el correo
                if (!IsGmail(txtGmail.Text))
                {
                    MessageBox.Show("El correo debe ser un Gmail válido. Ejemplo: gonzalo@gmail.com");
                    return; // Salir si la validación falla
                }

                // Si todo es válido, aquí puedes continuar con la operación de guardado o el siguiente paso


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
            }

            c = null; // Limpiar referencia
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
            // Limpiare los txtbox :D
            foreach (Control ctrl in gbDatos.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear(); // Limpiare todos los campos pero algunos se me excaparan xd
                    txtBuscar.Clear();
                }
            }

            // Restablecer los ComboBox 
            cbDocumentoTipo.SelectedIndex = -1;
            cboTipoDocumento.SelectedIndex = -1;
            cboGenero.SelectedIndex = -1;
            cboDepartamento.SelectedIndex = -1;


            // Habilitar el GroupBox de búsqueda 
            gbBuscar.Enabled = true; // Habilitar el gbBuscar
            gbDatos.Enabled = false; // Desabilitara el otro 

            // Limpiar combobox :d
            foreach (Control ctrl in gbDatos.Controls)
            {
                if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Checked = false; // Deseleccionar CheckBox
                }
                else if (ctrl is RadioButton)
                {
                    ((RadioButton)ctrl).Checked = false; // Deseleccionar RadioButton
                }
            }

            // Si tienes DateTimepicker se reinicia por defualt a la fecha actual
            foreach (Control ctrl in gbDatos.Controls)
            {
                if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Value = DateTime.Now; // Restablecer a la fecha actual
                }
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Selecciona el tipo de documento en cbDocumentoTipo
            cbDocumentoTipo.SelectedItem = cboTipoDocumento.SelectedItem;
            cbDocumentoTipo.Enabled = false; // Deshabilita el cbDocumentoTipo

            string documento = txtBuscar.Text.Trim(); // Captura el documento como string
            string tipoDocumento = cboTipoDocumento.SelectedItem?.ToString(); // Obtener el tipo de documento seleccionado

            // Validar el tipo de documento y el documento ingresado
            if (!ValidarDocumento(tipoDocumento, documento))
            {
                return; // Salir si hay un error en la validación
            }

            Cliente cliente = new Cliente
            {
                Conexion = Program.cn,
                iddocumento = documento,
                tipodocumento = tipoDocumento
            };

            try
            {
                switch (cliente.Buscar())
                {
                    case 0: // Cliente encontrado
                        ManejarClienteEncontrado(cliente);
                        break;

                    case 1:
                        MessageBox.Show("Ha perdido la sesión. Debe loguearse nuevamente.");
                        break;

                    case 2:
                        MessageBox.Show("Error en la búsqueda.");
                        break;

                    case 3: // No encontrado
                        ManejarClienteNoEncontrado(cliente);
                        break;

                    case 4:
                        MessageBox.Show("Hubo errores al buscar. En caso de repetirse, avisar al administrador.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}");
            }
        }

        private bool ValidarDocumento(string tipoDocumento, string documento)
        {
            if (string.IsNullOrWhiteSpace(tipoDocumento))
            {
                MessageBox.Show("Por favor, seleccione un tipo de documento.");
                return false; // Salir si no hay selección
            }

            if (string.IsNullOrWhiteSpace(documento))
            {
                MessageBox.Show("El documento no puede estar vacío.");
                return false; // Salir si la validación falla
            }

            // Validar el formato del documento según el tipo
            if (tipoDocumento == "C.I")
            {
                if (documento.Length != 8 || !documento.All(char.IsDigit))
                {
                    MessageBox.Show("El documento de tipo C.I debe contener exactamente 8 dígitos.");
                    return false; // Salir si la validación falla
                }
            }
            else if (tipoDocumento == "Pasaporte")
            {
                if (documento.Length < 8 || documento.Any(c => !char.IsLetterOrDigit(c)))
                {
                    MessageBox.Show("El documento de tipo Pasaporte debe tener al menos 8 caracteres y solo puede contener letras y números.");
                    return false; // Salir si la validación falla
                }
            }

            return true; // Todo es válido
        }

        private void ManejarClienteEncontrado(Cliente cliente)
        {
            gbBuscar.Enabled = true;
            MessageBox.Show("El usuario con documento " + cliente.iddocumento + " ya está registrado.");
            lblDescripcionDificultad.Visible = false;
            txtDescripcionDificultad.Visible = false;

            // desea ?eliminar el cliente
            DialogResult resultadoEliminar = MessageBox.Show("¿Desea eliminar al usuario con documento " + cliente.iddocumento + "?", "Eliminar usuario", MessageBoxButtons.YesNo);
            if (resultadoEliminar == DialogResult.Yes)
            {
                if (cliente.Eliminar())
                {
                    MessageBox.Show("El usuario ha sido eliminado.");
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar el usuario. Inténtelo de nuevo.");
                }
            }
            else
            {
                // Si no se desea eliminar, preguntar si desea modificar
                DialogResult resultadoModificar = MessageBox.Show("¿Desea modificar los datos del usuario?", "Modificar usuario", MessageBoxButtons.YesNo);
                if (resultadoModificar == DialogResult.Yes)
                {
                    CargarDatosCliente(cliente);
                }
            }
        }

        private void ManejarClienteNoEncontrado(Cliente cliente)
        {
            MessageBox.Show("El documento " + cliente.iddocumento + " no fue encontrado.");
            DialogResult resultadoAgregar = MessageBox.Show("¿Desea agregar el usuario?", "¿Agregar?", MessageBoxButtons.YesNo);
            if (resultadoAgregar == DialogResult.Yes)
            {
                gbBuscar.Enabled = false;
                btnModificar.Enabled = false;
                txtDocumentoId.Enabled = true;
                txtNombre.Enabled = true;

                gbDatos.Visible = true; // Mostrar la sección de datos
                gbDatos.Enabled = true; // Habilitar la sección de datos
                txtNombre.Clear(); // Limpiar el campo de nombre

                lblDescripcionDificultad.Visible = false;
                txtDescripcionDificultad.Visible = false;
                btnGuardar.Text = "Guardar"; // Cambiar el texto del botón a "Guardar"
            }
        }

        private void CargarDatosCliente(Cliente cliente)
        {
            // activo y desactivo
            btnBuscar.Enabled = false;
            txtBuscar.Enabled = false; // Desactivar el campo de búsqueda
            gbDatos.Enabled = true;
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;

            // Cargar los datos del cliente en los campos de gbDatos
            txtDocumentoId.Text = cliente.iddocumento;
            txtDocumentoId.Enabled = false; // desabilito la modificasion
            txtNombre.Enabled = false;



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
            cbDocumentoTipo.SelectedItem = cboTipoDocumento.SelectedItem;

            // Deshabilita el cbDocumentoTipo para que no pueda modificarse
            cbDocumentoTipo.Enabled = false;
        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedItem != null)
            {
                // Obtiene el texto seleccionado del ComboBox
                string tipoDocumentoSeleccionado = cboTipoDocumento.SelectedItem.ToString();

                // Asigna el texto seleccionado al Label
                lblQueCambia.Text = tipoDocumentoSeleccionado;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int telefono = 0; // Solo se requiere para el teléfono
            Cliente c;

            // Verifico si todos los campos obligatorios están completos
            if (cbDocumentoTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de documento.");
                return; // Salir si la validación falla
            }
            else if (string.IsNullOrEmpty(txtDocumentoId.Text))
            {
                MessageBox.Show("Por favor, ingrese un Documento ID.");
                return; // Salir si la validación falla
            }
            else if (cboGenero.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un Género.");
                return; // Salir si la validación falla
            }
            else if (cboDepartamento.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un Departamento.");
                return; // Salir si la validación falla
            }
            else if (string.IsNullOrEmpty(txtDireccionLoc.Text))
            {
                MessageBox.Show("Por favor, ingrese una Dirección o Calle.");
                return; // Salir si la validación falla
            }
            else if (string.IsNullOrEmpty(txtGmail.Text))
            {
                MessageBox.Show("Por favor, ingrese un Gmail.");
                return; // Salir si la validación falla
            }
            else if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, ingrese un Teléfono.");
                return; // Salir si la validación falla
            }

            string tipoDocumento = cbDocumentoTipo.SelectedItem.ToString();
            string documentoId = txtDocumentoId.Text; // Captura el documento como string

            // Validar según el tipo de documento
            if (tipoDocumento == "C.I")
            {
                // Asegurarse de que el documento solo contenga números
                if (!int.TryParse(documentoId, out _)) // Verifica si es numérico
                {
                    MessageBox.Show("La C.I. debe ser numérica.");
                    return; // Salir si la validación falla
                }
            }
            else if (tipoDocumento == "Pasaporte")
            {
                // Si necesitas alguna validación específica para el pasaporte, inclúyela aquí
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
            else if (txtTelefono.Text.Length > 9)
            {
                MessageBox.Show("El teléfono debe tener un máximo de 9 números.");
                return; // Salir si la longitud es incorrecta
            }

            // Validar el correo
            if (!IsGmail(txtGmail.Text))
            {
                MessageBox.Show("El correo debe ser un Gmail válido. Ejemplo: gonzalo@gmail.com");
                return; // Salir si la validación falla
            }

            // Crear la instancia del Cliente para modificación
            c = new Cliente
            {
                iddocumento = documentoId, // Asignar el documento como string
                tipodocumento = tipoDocumento, // Asignar el tipo de documento
                Conexion = Program.cn, // Conexión a la base de datos
                Nombre = string.IsNullOrEmpty(txtNombre.Text) ? null : txtNombre.Text, // Asignar nombre, puede ser nulo
                Direccion = txtDireccionLoc.Text, // Asignar dirección
                Departamentos = cboDepartamento.SelectedItem.ToString(), // Asignar departamento
                Gmail = txtGmail.Text, // Asignar correo electrónico
                Genero = cboGenero.SelectedItem.ToString(), // Asignar género
                FechaNacimiento = dpkFechaNacimiento.Value, // Asignar fecha de nacimiento
                Dificultad = cbSi.Checked, // Asignar dificultad
                DescripcionDificultad = txtDescripcionDificultad.Text, // Asignar descripción de dificultad
                Telefono = telefono // Asignar teléfono
            };

            // Modificar datos del cliente
            byte resultado = c.Modificar(true); // Llamar al método Modificar con true

            // Manejar el resultado de la modificación
            switch (resultado)
            {
                case 0:
                    MessageBox.Show("Modificación exitosa.");
                    LimpiarFormulario(); // Opcional, si quieres limpiar el formulario después
                    gbDatos.Enabled = false;
                    gbBuscar.Enabled = true;
                    btnBuscar.Enabled = true;
                    txtBuscar.Enabled = true;
                    cboTipoDocumento.Enabled = true;
                    break;

                case 1:
                    MessageBox.Show("Perdió la sesión. Debe loguearse nuevamente.");
                    break;

                case 2:
                    MessageBox.Show("Error al modificar el cliente.");
                    break;

                case 3:
                    MessageBox.Show("Error al insertar teléfonos.");
                    break;

                default:
                    MessageBox.Show("Ocurrió un error inesperado.");
                    break;
            }

            c = null; // Limpiar todo
        }

    }
}
