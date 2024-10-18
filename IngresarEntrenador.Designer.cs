namespace SIGEN_GUI
{
    partial class IngresarEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarEntrenador));
            this.gbIngresarEntrenador = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCi = new System.Windows.Forms.Label();
            this.txtDireccionLoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.lblNombreApelido = new System.Windows.Forms.Label();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbIngresarEntrenador.SuspendLayout();
            this.gbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIngresarEntrenador
            // 
            this.gbIngresarEntrenador.Controls.Add(this.btnGuardar);
            this.gbIngresarEntrenador.Controls.Add(this.txtEdad);
            this.gbIngresarEntrenador.Controls.Add(this.txtTelefono);
            this.gbIngresarEntrenador.Controls.Add(this.cboGenero);
            this.gbIngresarEntrenador.Controls.Add(this.cboDepartamento);
            this.gbIngresarEntrenador.Controls.Add(this.lblEdad);
            this.gbIngresarEntrenador.Controls.Add(this.label5);
            this.gbIngresarEntrenador.Controls.Add(this.txtGmail);
            this.gbIngresarEntrenador.Controls.Add(this.lblEmail);
            this.gbIngresarEntrenador.Controls.Add(this.lblDepartamento);
            this.gbIngresarEntrenador.Controls.Add(this.txtCedula);
            this.gbIngresarEntrenador.Controls.Add(this.lblCi);
            this.gbIngresarEntrenador.Controls.Add(this.txtDireccionLoc);
            this.gbIngresarEntrenador.Controls.Add(this.label1);
            this.gbIngresarEntrenador.Controls.Add(this.lblTelefono);
            this.gbIngresarEntrenador.Controls.Add(this.txtNombreApellido);
            this.gbIngresarEntrenador.Controls.Add(this.lblNombreApelido);
            this.gbIngresarEntrenador.Location = new System.Drawing.Point(34, 44);
            this.gbIngresarEntrenador.Name = "gbIngresarEntrenador";
            this.gbIngresarEntrenador.Size = new System.Drawing.Size(707, 250);
            this.gbIngresarEntrenador.TabIndex = 0;
            this.gbIngresarEntrenador.TabStop = false;
            this.gbIngresarEntrenador.Text = "Ingresar Entrenador";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(289, 189);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 26);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(53, 94);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(41, 25);
            this.txtEdad.TabIndex = 52;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(561, 18);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(132, 25);
            this.txtTelefono.TabIndex = 51;
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Otro"});
            this.cboGenero.Location = new System.Drawing.Point(61, 48);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 23);
            this.cboGenero.TabIndex = 50;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.ItemHeight = 15;
            this.cboDepartamento.Items.AddRange(new object[] {
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
            this.cboDepartamento.Location = new System.Drawing.Point(305, 52);
            this.cboDepartamento.MaxDropDownItems = 19;
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(121, 23);
            this.cboDepartamento.TabIndex = 49;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(5, 99);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(41, 15);
            this.lblEdad.TabIndex = 46;
            this.lblEdad.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Genero";
            // 
            // txtGmail
            // 
            this.txtGmail.Location = new System.Drawing.Point(251, 89);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(193, 25);
            this.txtGmail.TabIndex = 41;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(102, 97);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(141, 15);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "Correo Electronico";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(189, 55);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(109, 15);
            this.lblDepartamento.TabIndex = 39;
            this.lblDepartamento.Text = "Departamento";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(35, 18);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(132, 25);
            this.txtCedula.TabIndex = 38;
            // 
            // lblCi
            // 
            this.lblCi.AutoSize = true;
            this.lblCi.Location = new System.Drawing.Point(7, 21);
            this.lblCi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCi.Name = "lblCi";
            this.lblCi.Size = new System.Drawing.Size(22, 15);
            this.lblCi.TabIndex = 37;
            this.lblCi.Text = "C.I";
            // 
            // txtDireccionLoc
            // 
            this.txtDireccionLoc.Location = new System.Drawing.Point(505, 52);
            this.txtDireccionLoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionLoc.Name = "txtDireccionLoc";
            this.txtDireccionLoc.Size = new System.Drawing.Size(192, 25);
            this.txtDireccionLoc.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Direccion";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(485, 21);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(69, 15);
            this.lblTelefono.TabIndex = 34;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.Location = new System.Drawing.Point(314, 18);
            this.txtNombreApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(163, 25);
            this.txtNombreApellido.TabIndex = 33;
            this.txtNombreApellido.TextChanged += new System.EventHandler(this.txtNombreApellido_TextChanged);
            // 
            // lblNombreApelido
            // 
            this.lblNombreApelido.AutoSize = true;
            this.lblNombreApelido.Location = new System.Drawing.Point(175, 21);
            this.lblNombreApelido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreApelido.Name = "lblNombreApelido";
            this.lblNombreApelido.Size = new System.Drawing.Size(131, 15);
            this.lblNombreApelido.TabIndex = 32;
            this.lblNombreApelido.Text = "Nombre y Apellido";
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Controls.Add(this.txtBuscar);
            this.gbBuscar.Controls.Add(this.lblCedula);
            this.gbBuscar.Location = new System.Drawing.Point(787, 62);
            this.gbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.gbBuscar.Size = new System.Drawing.Size(203, 161);
            this.gbBuscar.TabIndex = 8;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(49, 98);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 26);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(49, 45);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.MaxLength = 8;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(132, 25);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(21, 48);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(22, 15);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "C.I";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(512, 445);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 26);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // IngresarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 520);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.gbIngresarEntrenador);
            this.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IngresarEntrenador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarEntrenador";
            this.gbIngresarEntrenador.ResumeLayout(false);
            this.gbIngresarEntrenador.PerformLayout();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIngresarEntrenador;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCi;
        private System.Windows.Forms.TextBox txtDireccionLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.Label lblNombreApelido;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Button btnSalir;
    }
}