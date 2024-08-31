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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Int32 cedula = 0; Cliente c;
            if (!Int32.TryParse(txtCedula.Text, out cedula))
            {
                MessageBox.Show("CI debe ser numerica");
            }
            else
            {
                c = new Cliente();
                c.Ci = cedula;
                c.Nombre = txtNombre.Text;
                c.Conexion = Program.cn;
                foreach (string telefono in cboTelefonos.Items)
                {
                    c.Telefonos.Add(telefono);

                }
                switch (c.Guardar(btnEliminar.Enabled))
                {
                    case 0:
                        gbDatos.Visible = false;
                        txtCedula.Text = "";

                        break;
                    case 1:
                        MessageBox.Show("perdio la sesiòn. Debe loguearse nuevamente");

                        break;

                    case 3: MessageBox.Show("Error 3"); break;// error borrar telefonos 
                    case 4: MessageBox.Show("Error 4"); break;// error al insertar telefonos 
                }//switch
                c = null;
            } // if
        }//btn guardar


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

        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }

}


