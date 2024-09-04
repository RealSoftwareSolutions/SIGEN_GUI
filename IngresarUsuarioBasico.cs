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
            cboDepartamento.Text = "";
            txtGmail.Text = "";
            txtGenero.Text = "";
            txtDescripcionDificultad.Text = "";
            cboTelefonos.Items.Clear();
            cboTelefonos.Text = "";
            cbSi.Checked = false;
            dpkFechaNacimiento.Value = DateTime.Now;

        }
        static bool IsGmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cedula = 0;
            Cliente c;

            if (!int.TryParse(txtCedula.Text, out cedula))
            {
                MessageBox.Show("CI debe ser numérico");
            }
            else if (!IsGmail(txtGmail.Text))
            {
              MessageBox.Show("El gmail tiene que ser @gmail.com ejemplo: gonzalo@gmail.com"); 

            } else {
                c = new Cliente
                {
                    Ci = cedula,
                    Conexion = Program.cn,
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccionLoc.Text,
                    Departamentos = cboDepartamento.SelectedItem.ToString(),
                    Gmail = txtGmail.Text,
                    Genero = txtGenero.Text,
                    FechaNacimiento = dpkFechaNacimiento.Value, // Asumiendo que tienes un DateTimePicker
                    Dificultad = cbSi.Checked, // Asumiendo que tienes un CheckBox
                    DescripcionDificultad = txtDescripcionDificultad.Text
                };

                // Agregar teléfonos
                c.Telefonos.Clear(); // Limpiar lista existente de teléfonos
                foreach (string telefono in cboTelefonos.Items)
                {
                    c.Telefonos.Add(telefono);
                }

                // Guardar datos del cliente
                switch (c.Guardar()) // Llamar al método Guardar sin argumentos
                {
                    case 0:
                        LimpiarFormulario();
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

            Cliente c;
            int documento;
            if (!Int32.TryParse(txtCi.Text, out documento))
            {
                MessageBox.Show("la cedula de indentidad debe ser numerica" + txtCedula);
            }
            else
            {
                c = new Cliente();
                c.Ci = documento;
                c.Conexion = Program.cn;
                switch (c.Buscar())
                {
                    case 0: //Encontre - Modificaciòn
                        gbBuscar.Enabled = false;
                        gbDatos.Visible = true;
                        btnEliminar.Enabled = true;
                        txtNombre.Text = c.Nombre;
                        cboTelefonos.Items.Clear();
                        btnGuardar.Text = "Modificar";

                        foreach (string telefono in c.Telefonos)
                        {
                            cboTelefonos.Items.Add(telefono);
                        }
                        cboTelefonos.SelectedIndex = 0; //MOSTRAR PRIMER NÙMERO SELECCIONADO
                        break;


                    case 1: MessageBox.Show("ha perdido la sesión. Debe loguearse nuevamente"); break;
                    case 2:
                    case 3: //no se encontró

                        DialogResult resultado = MessageBox.Show("¿desea agregar el usuario?" /*DAR DE ALTA*/, "¿Agregar?", MessageBoxButtons.YesNo);

                        if (resultado == DialogResult.Yes)
                        {
                            gbBuscar.Enabled = false;
                            gbDatos.Visible = true;
                            btnEliminar.Enabled = false;
                            txtNombre.Clear();
                            cboTelefonos.Items.Clear();
                            gbDatos.Visible = Enabled;
                            btnGuardar.Text = "Guardar";
                            cboTelefonos.Text = "";
                        }
                        /*PROPIEDAD ACCEPT BUTTON EN EL FORMULARIO PARA PODER DARLE ENTER*/
                        break;
                    case 4: MessageBox.Show("hubo errores al buscar. en caso de repetirse, avisar al administrador"); break;


                }
                c = null;

            }

        }

       
       }
    }
    




