namespace SIGEN_GUI
{
    partial class IngresarClub
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbIngresarClub = new System.Windows.Forms.GroupBox();
            this.txtNombreClub = new System.Windows.Forms.TextBox();
            this.lblNombreClub = new System.Windows.Forms.Label();
            this.lblDireccionCalle = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblListaEntrenadores = new System.Windows.Forms.Label();
            this.lblDeportesDisponibles = new System.Windows.Forms.Label();
            this.lblTelefonosDeContacto = new System.Windows.Forms.Label();
            this.lblCapacidadDelClub = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.txtListaEntrenadores = new System.Windows.Forms.TextBox();
            this.txtTelefonoContacto = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDeportesDisponibles = new System.Windows.Forms.TextBox();
            this.gbIngresarClub.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIngresarClub
            // 
            this.gbIngresarClub.Controls.Add(this.txtDeportesDisponibles);
            this.gbIngresarClub.Controls.Add(this.txtDireccion);
            this.gbIngresarClub.Controls.Add(this.txtCapacidad);
            this.gbIngresarClub.Controls.Add(this.txtEmail);
            this.gbIngresarClub.Controls.Add(this.txtTelefonoContacto);
            this.gbIngresarClub.Controls.Add(this.txtListaEntrenadores);
            this.gbIngresarClub.Controls.Add(this.cbDepartamento);
            this.gbIngresarClub.Controls.Add(this.btnGuardar);
            this.gbIngresarClub.Controls.Add(this.lblEmail);
            this.gbIngresarClub.Controls.Add(this.lblCapacidadDelClub);
            this.gbIngresarClub.Controls.Add(this.lblTelefonosDeContacto);
            this.gbIngresarClub.Controls.Add(this.lblDeportesDisponibles);
            this.gbIngresarClub.Controls.Add(this.lblListaEntrenadores);
            this.gbIngresarClub.Controls.Add(this.lblDepartamento);
            this.gbIngresarClub.Controls.Add(this.lblDireccionCalle);
            this.gbIngresarClub.Controls.Add(this.txtNombreClub);
            this.gbIngresarClub.Controls.Add(this.lblNombreClub);
            this.gbIngresarClub.Location = new System.Drawing.Point(13, 70);
            this.gbIngresarClub.Margin = new System.Windows.Forms.Padding(4);
            this.gbIngresarClub.Name = "gbIngresarClub";
            this.gbIngresarClub.Padding = new System.Windows.Forms.Padding(4);
            this.gbIngresarClub.Size = new System.Drawing.Size(832, 308);
            this.gbIngresarClub.TabIndex = 7;
            this.gbIngresarClub.TabStop = false;
            this.gbIngresarClub.Text = "Ingresar Club";
            // 
            // txtNombreClub
            // 
            this.txtNombreClub.Location = new System.Drawing.Point(99, 34);
            this.txtNombreClub.Name = "txtNombreClub";
            this.txtNombreClub.Size = new System.Drawing.Size(180, 22);
            this.txtNombreClub.TabIndex = 5;
            // 
            // lblNombreClub
            // 
            this.lblNombreClub.AutoSize = true;
            this.lblNombreClub.Location = new System.Drawing.Point(7, 40);
            this.lblNombreClub.Name = "lblNombreClub";
            this.lblNombreClub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombreClub.Size = new System.Drawing.Size(86, 16);
            this.lblNombreClub.TabIndex = 0;
            this.lblNombreClub.Text = "Nombre Club";
            // 
            // lblDireccionCalle
            // 
            this.lblDireccionCalle.AutoSize = true;
            this.lblDireccionCalle.Location = new System.Drawing.Point(515, 43);
            this.lblDireccionCalle.Name = "lblDireccionCalle";
            this.lblDireccionCalle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDireccionCalle.Size = new System.Drawing.Size(64, 16);
            this.lblDireccionCalle.TabIndex = 6;
            this.lblDireccionCalle.Text = "Direccion";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(296, 40);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDepartamento.Size = new System.Drawing.Size(93, 16);
            this.lblDepartamento.TabIndex = 7;
            this.lblDepartamento.Text = "Departamento";
            this.lblDepartamento.Click += new System.EventHandler(this.lblDepartamento_Click);
            // 
            // lblListaEntrenadores
            // 
            this.lblListaEntrenadores.AutoSize = true;
            this.lblListaEntrenadores.Location = new System.Drawing.Point(7, 136);
            this.lblListaEntrenadores.Name = "lblListaEntrenadores";
            this.lblListaEntrenadores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblListaEntrenadores.Size = new System.Drawing.Size(138, 16);
            this.lblListaEntrenadores.TabIndex = 8;
            this.lblListaEntrenadores.Text = "Lista de Entrenadores";
            // 
            // lblDeportesDisponibles
            // 
            this.lblDeportesDisponibles.AutoSize = true;
            this.lblDeportesDisponibles.Location = new System.Drawing.Point(504, 136);
            this.lblDeportesDisponibles.Name = "lblDeportesDisponibles";
            this.lblDeportesDisponibles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDeportesDisponibles.Size = new System.Drawing.Size(138, 16);
            this.lblDeportesDisponibles.TabIndex = 9;
            this.lblDeportesDisponibles.Text = "Deportes Disponibles";
            // 
            // lblTelefonosDeContacto
            // 
            this.lblTelefonosDeContacto.AutoSize = true;
            this.lblTelefonosDeContacto.Location = new System.Drawing.Point(9, 208);
            this.lblTelefonosDeContacto.Name = "lblTelefonosDeContacto";
            this.lblTelefonosDeContacto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTelefonosDeContacto.Size = new System.Drawing.Size(136, 16);
            this.lblTelefonosDeContacto.TabIndex = 10;
            this.lblTelefonosDeContacto.Text = "Telefono de Contacto";
            // 
            // lblCapacidadDelClub
            // 
            this.lblCapacidadDelClub.AutoSize = true;
            this.lblCapacidadDelClub.Location = new System.Drawing.Point(253, 136);
            this.lblCapacidadDelClub.Name = "lblCapacidadDelClub";
            this.lblCapacidadDelClub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCapacidadDelClub.Size = new System.Drawing.Size(126, 16);
            this.lblCapacidadDelClub.TabIndex = 11;
            this.lblCapacidadDelClub.Text = "Capacidad del Club";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(253, 208);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmail.Size = new System.Drawing.Size(115, 16);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "CorreoElectronico";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(334, 254);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbDepartamento.Items.AddRange(new object[] {
            "Artigas",
            "Canelones",
            "Cerro Largo",
            "Colonia",
            "Durazno",
            "Flores",
            "Florida",
            "Lavalleja",
            "Maldonado",
            "Montevideo",
            "Paysandú",
            "Río Negro",
            "Rivera",
            "Rocha",
            "Salto",
            "San José",
            "Soriano",
            "Tacuarembó",
            "Treinta y Tres"});
            this.cbDepartamento.Location = new System.Drawing.Point(388, 40);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(121, 24);
            this.cbDepartamento.TabIndex = 14;
            // 
            // txtListaEntrenadores
            // 
            this.txtListaEntrenadores.Location = new System.Drawing.Point(147, 136);
            this.txtListaEntrenadores.Name = "txtListaEntrenadores";
            this.txtListaEntrenadores.Size = new System.Drawing.Size(100, 22);
            this.txtListaEntrenadores.TabIndex = 15;
            // 
            // txtTelefonoContacto
            // 
            this.txtTelefonoContacto.Location = new System.Drawing.Point(147, 205);
            this.txtTelefonoContacto.Name = "txtTelefonoContacto";
            this.txtTelefonoContacto.Size = new System.Drawing.Size(100, 22);
            this.txtTelefonoContacto.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(374, 202);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 17;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(385, 133);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 22);
            this.txtCapacidad.TabIndex = 18;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(585, 43);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(171, 22);
            this.txtDireccion.TabIndex = 19;
            // 
            // txtDeportesDisponibles
            // 
            this.txtDeportesDisponibles.Location = new System.Drawing.Point(648, 130);
            this.txtDeportesDisponibles.Name = "txtDeportesDisponibles";
            this.txtDeportesDisponibles.Size = new System.Drawing.Size(171, 22);
            this.txtDeportesDisponibles.TabIndex = 20;
            // 
            // IngresarClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.gbIngresarClub);
            this.Name = "IngresarClub";
            this.Text = "IngresarClub";
            this.Load += new System.EventHandler(this.IngresarClub_Load);
            this.gbIngresarClub.ResumeLayout(false);
            this.gbIngresarClub.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIngresarClub;
        private System.Windows.Forms.TextBox txtNombreClub;
        private System.Windows.Forms.Label lblNombreClub;
        private System.Windows.Forms.Label lblDeportesDisponibles;
        private System.Windows.Forms.Label lblListaEntrenadores;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblDireccionCalle;
        private System.Windows.Forms.Label lblTelefonosDeContacto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCapacidadDelClub;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefonoContacto;
        private System.Windows.Forms.TextBox txtListaEntrenadores;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtDeportesDisponibles;
        private System.Windows.Forms.TextBox txtDireccion;
    }
}