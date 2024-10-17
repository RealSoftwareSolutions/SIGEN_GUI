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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarClub));
            this.gbIngresarClub = new System.Windows.Forms.GroupBox();
            this.txtDeportesDisponibles = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefonoContacto = new System.Windows.Forms.TextBox();
            this.txtListaEntrenadores = new System.Windows.Forms.TextBox();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCapacidadDelClub = new System.Windows.Forms.Label();
            this.lblTelefonosDeContacto = new System.Windows.Forms.Label();
            this.lblDeportesDisponibles = new System.Windows.Forms.Label();
            this.lblListaEntrenadores = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblDireccionCalle = new System.Windows.Forms.Label();
            this.txtNombreClub = new System.Windows.Forms.TextBox();
            this.lblNombreClub = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
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
            this.gbIngresarClub.Location = new System.Drawing.Point(13, 66);
            this.gbIngresarClub.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbIngresarClub.Name = "gbIngresarClub";
            this.gbIngresarClub.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbIngresarClub.Size = new System.Drawing.Size(863, 289);
            this.gbIngresarClub.TabIndex = 7;
            this.gbIngresarClub.TabStop = false;
            this.gbIngresarClub.Text = "Ingresar Club";
            // 
            // txtDeportesDisponibles
            // 
            this.txtDeportesDisponibles.Location = new System.Drawing.Point(684, 125);
            this.txtDeportesDisponibles.Name = "txtDeportesDisponibles";
            this.txtDeportesDisponibles.Size = new System.Drawing.Size(171, 25);
            this.txtDeportesDisponibles.TabIndex = 20;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(602, 38);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(171, 25);
            this.txtDireccion.TabIndex = 19;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(426, 123);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 25);
            this.txtCapacidad.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(425, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 25);
            this.txtEmail.TabIndex = 17;
            // 
            // txtTelefonoContacto
            // 
            this.txtTelefonoContacto.Location = new System.Drawing.Point(172, 192);
            this.txtTelefonoContacto.Name = "txtTelefonoContacto";
            this.txtTelefonoContacto.Size = new System.Drawing.Size(100, 25);
            this.txtTelefonoContacto.TabIndex = 16;
            // 
            // txtListaEntrenadores
            // 
            this.txtListaEntrenadores.Location = new System.Drawing.Point(175, 125);
            this.txtListaEntrenadores.Name = "txtListaEntrenadores";
            this.txtListaEntrenadores.Size = new System.Drawing.Size(100, 25);
            this.txtListaEntrenadores.TabIndex = 15;
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
            this.cbDepartamento.Location = new System.Drawing.Point(405, 38);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(121, 23);
            this.cbDepartamento.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(334, 238);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 21);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(281, 198);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmail.Size = new System.Drawing.Size(138, 15);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "CorreoElectronico";
            // 
            // lblCapacidadDelClub
            // 
            this.lblCapacidadDelClub.AutoSize = true;
            this.lblCapacidadDelClub.Location = new System.Drawing.Point(281, 129);
            this.lblCapacidadDelClub.Name = "lblCapacidadDelClub";
            this.lblCapacidadDelClub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCapacidadDelClub.Size = new System.Drawing.Size(141, 15);
            this.lblCapacidadDelClub.TabIndex = 11;
            this.lblCapacidadDelClub.Text = "Capacidad del Club";
            // 
            // lblTelefonosDeContacto
            // 
            this.lblTelefonosDeContacto.AutoSize = true;
            this.lblTelefonosDeContacto.Location = new System.Drawing.Point(9, 195);
            this.lblTelefonosDeContacto.Name = "lblTelefonosDeContacto";
            this.lblTelefonosDeContacto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTelefonosDeContacto.Size = new System.Drawing.Size(157, 15);
            this.lblTelefonosDeContacto.TabIndex = 10;
            this.lblTelefonosDeContacto.Text = "Telefono de Contacto";
            // 
            // lblDeportesDisponibles
            // 
            this.lblDeportesDisponibles.AutoSize = true;
            this.lblDeportesDisponibles.Location = new System.Drawing.Point(532, 129);
            this.lblDeportesDisponibles.Name = "lblDeportesDisponibles";
            this.lblDeportesDisponibles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDeportesDisponibles.Size = new System.Drawing.Size(150, 15);
            this.lblDeportesDisponibles.TabIndex = 9;
            this.lblDeportesDisponibles.Text = "Deportes Disponibles";
            // 
            // lblListaEntrenadores
            // 
            this.lblListaEntrenadores.AutoSize = true;
            this.lblListaEntrenadores.Location = new System.Drawing.Point(7, 129);
            this.lblListaEntrenadores.Name = "lblListaEntrenadores";
            this.lblListaEntrenadores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblListaEntrenadores.Size = new System.Drawing.Size(162, 15);
            this.lblListaEntrenadores.TabIndex = 8;
            this.lblListaEntrenadores.Text = "Lista de Entrenadores";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(296, 38);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDepartamento.Size = new System.Drawing.Size(109, 15);
            this.lblDepartamento.TabIndex = 7;
            this.lblDepartamento.Text = "Departamento";
            this.lblDepartamento.Click += new System.EventHandler(this.lblDepartamento_Click);
            // 
            // lblDireccionCalle
            // 
            this.lblDireccionCalle.AutoSize = true;
            this.lblDireccionCalle.Location = new System.Drawing.Point(532, 38);
            this.lblDireccionCalle.Name = "lblDireccionCalle";
            this.lblDireccionCalle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDireccionCalle.Size = new System.Drawing.Size(71, 15);
            this.lblDireccionCalle.TabIndex = 6;
            this.lblDireccionCalle.Text = "Direccion";
            // 
            // txtNombreClub
            // 
            this.txtNombreClub.Location = new System.Drawing.Point(99, 32);
            this.txtNombreClub.Name = "txtNombreClub";
            this.txtNombreClub.Size = new System.Drawing.Size(180, 25);
            this.txtNombreClub.TabIndex = 5;
            // 
            // lblNombreClub
            // 
            this.lblNombreClub.AutoSize = true;
            this.lblNombreClub.Location = new System.Drawing.Point(7, 38);
            this.lblNombreClub.Name = "lblNombreClub";
            this.lblNombreClub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombreClub.Size = new System.Drawing.Size(91, 15);
            this.lblNombreClub.TabIndex = 0;
            this.lblNombreClub.Text = "Nombre Club";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(418, 381);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 26);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // IngresarClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 437);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbIngresarClub);
            this.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IngresarClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnSalir;
    }
}