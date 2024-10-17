namespace SIGEN_GUI
{
    partial class IngresarUsuarioBasico
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarUsuarioBasico));
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cbDocumentoTipo = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.dpkFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcionDificultad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbFechaNacimiento = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSi = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtDocumentoId = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDireccionLoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblQueCambia = new System.Windows.Forms.Label();
            this.streamClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbDatos.SuspendLayout();
            this.gbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.streamClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(559, 424);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 26);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblTipoDocumento);
            this.gbDatos.Controls.Add(this.cbDocumentoTipo);
            this.gbDatos.Controls.Add(this.txtTelefono);
            this.gbDatos.Controls.Add(this.cboGenero);
            this.gbDatos.Controls.Add(this.cboDepartamento);
            this.gbDatos.Controls.Add(this.dpkFechaNacimiento);
            this.gbDatos.Controls.Add(this.txtDescripcionDificultad);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.lbFechaNacimiento);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.cbSi);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.txtGmail);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.lblDepartamento);
            this.gbDatos.Controls.Add(this.txtDocumentoId);
            this.gbDatos.Controls.Add(this.lblDocumento);
            this.gbDatos.Controls.Add(this.txtDireccionLoc);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.btnCancelar);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.btnGuardar);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Location = new System.Drawing.Point(13, 12);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatos.Size = new System.Drawing.Size(977, 358);
            this.gbDatos.TabIndex = 5;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Ingresar Datos";
            this.gbDatos.Enter += new System.EventHandler(this.gbDatos_Enter);
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(9, 28);
            this.lblTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(81, 15);
            this.lblTipoDocumento.TabIndex = 33;
            this.lblTipoDocumento.Text = "Documento";
            this.lblTipoDocumento.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbDocumentoTipo
            // 
            this.cbDocumentoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocumentoTipo.FormattingEnabled = true;
            this.cbDocumentoTipo.Items.AddRange(new object[] {
            "C.I",
            "Pasaporte"});
            this.cbDocumentoTipo.Location = new System.Drawing.Point(97, 23);
            this.cbDocumentoTipo.Name = "cbDocumentoTipo";
            this.cbDocumentoTipo.Size = new System.Drawing.Size(121, 23);
            this.cbDocumentoTipo.TabIndex = 32;
            this.cbDocumentoTipo.SelectedIndexChanged += new System.EventHandler(this.cbDocumentoTipo_SelectedIndexChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(420, 90);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(132, 25);
            this.txtTelefono.TabIndex = 31;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Otro"});
            this.cboGenero.Location = new System.Drawing.Point(834, 22);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 23);
            this.cboGenero.TabIndex = 30;
            this.cboGenero.SelectedIndexChanged += new System.EventHandler(this.cboGenero_SelectedIndexChanged);
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
            this.cboDepartamento.Location = new System.Drawing.Point(120, 57);
            this.cboDepartamento.MaxDropDownItems = 19;
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(121, 23);
            this.cboDepartamento.TabIndex = 29;
            this.cboDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            // 
            // dpkFechaNacimiento
            // 
            this.dpkFechaNacimiento.Location = new System.Drawing.Point(615, 56);
            this.dpkFechaNacimiento.Name = "dpkFechaNacimiento";
            this.dpkFechaNacimiento.Size = new System.Drawing.Size(192, 25);
            this.dpkFechaNacimiento.TabIndex = 28;
            this.dpkFechaNacimiento.ValueChanged += new System.EventHandler(this.dpkFechaNacimiento_ValueChanged);
            // 
            // txtDescripcionDificultad
            // 
            this.txtDescripcionDificultad.Location = new System.Drawing.Point(333, 140);
            this.txtDescripcionDificultad.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionDificultad.Multiline = true;
            this.txtDescripcionDificultad.Name = "txtDescripcionDificultad";
            this.txtDescripcionDificultad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcionDificultad.Size = new System.Drawing.Size(175, 57);
            this.txtDescripcionDificultad.TabIndex = 27;
            this.txtDescripcionDificultad.TextChanged += new System.EventHandler(this.txtDescripcionDificultad_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Descripcion de Dificultad";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbFechaNacimiento
            // 
            this.lbFechaNacimiento.AutoSize = true;
            this.lbFechaNacimiento.Location = new System.Drawing.Point(462, 60);
            this.lbFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaNacimiento.Name = "lbFechaNacimiento";
            this.lbFechaNacimiento.Size = new System.Drawing.Size(146, 15);
            this.lbFechaNacimiento.TabIndex = 24;
            this.lbFechaNacimiento.Text = "Fecha de Nacimiento";
            this.lbFechaNacimiento.Click += new System.EventHandler(this.lbFechaNacimiento_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Dificultad?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbSi
            // 
            this.cbSi.AutoSize = true;
            this.cbSi.Location = new System.Drawing.Point(97, 139);
            this.cbSi.Name = "cbSi";
            this.cbSi.Size = new System.Drawing.Size(46, 19);
            this.cbSi.TabIndex = 22;
            this.cbSi.Text = "Si?";
            this.cbSi.UseVisualStyleBackColor = true;
            this.cbSi.CheckedChanged += new System.EventHandler(this.cbSi_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(771, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Genero";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtGmail
            // 
            this.txtGmail.Location = new System.Drawing.Point(142, 85);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(193, 25);
            this.txtGmail.TabIndex = 19;
            this.txtGmail.TextChanged += new System.EventHandler(this.txtGmail_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Correo Electronico";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(4, 60);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(109, 15);
            this.lblDepartamento.TabIndex = 14;
            this.lblDepartamento.Text = "Departamento";
            this.lblDepartamento.Click += new System.EventHandler(this.lblDepartamento_Click);
            // 
            // txtDocumentoId
            // 
            this.txtDocumentoId.Location = new System.Drawing.Point(329, 20);
            this.txtDocumentoId.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumentoId.Name = "txtDocumentoId";
            this.txtDocumentoId.Size = new System.Drawing.Size(132, 25);
            this.txtDocumentoId.TabIndex = 13;
            this.txtDocumentoId.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(228, 25);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(93, 15);
            this.lblDocumento.TabIndex = 12;
            this.lblDocumento.Text = "DocumentoID";
            this.lblDocumento.Click += new System.EventHandler(this.lblCi_Click);
            // 
            // txtDireccionLoc
            // 
            this.txtDireccionLoc.Location = new System.Drawing.Point(322, 57);
            this.txtDireccionLoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionLoc.Name = "txtDireccionLoc";
            this.txtDireccionLoc.Size = new System.Drawing.Size(132, 25);
            this.txtDireccionLoc.TabIndex = 11;
            this.txtDireccionLoc.TextChanged += new System.EventHandler(this.txtDireccionLoc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Direccion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(328, 211);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 26);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teléfono";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(221, 211);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 26);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(615, 20);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 25);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = " Nombre Completo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.label7);
            this.gbBuscar.Controls.Add(this.cboTipoDocumento);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Controls.Add(this.txtBuscar);
            this.gbBuscar.Controls.Add(this.lblQueCambia);
            this.gbBuscar.Location = new System.Drawing.Point(1035, 72);
            this.gbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.gbBuscar.Size = new System.Drawing.Size(284, 188);
            this.gbBuscar.TabIndex = 7;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar";
            this.gbBuscar.Enter += new System.EventHandler(this.gbBuscar_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Documento";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Items.AddRange(new object[] {
            "C.I",
            "Pasaporte"});
            this.cboTipoDocumento.Location = new System.Drawing.Point(92, 34);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(121, 23);
            this.cboTipoDocumento.TabIndex = 34;
            this.cboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cboTipoDocumento_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(92, 151);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 26);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(92, 92);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.MaxLength = 8;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(132, 25);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblQueCambia
            // 
            this.lblQueCambia.AutoSize = true;
            this.lblQueCambia.Location = new System.Drawing.Point(8, 95);
            this.lblQueCambia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQueCambia.Name = "lblQueCambia";
            this.lblQueCambia.Size = new System.Drawing.Size(45, 15);
            this.lblQueCambia.TabIndex = 0;
            this.lblQueCambia.Text = "VACIO";
            this.lblQueCambia.Click += new System.EventHandler(this.label9_Click);
            // 
            // streamClassBindingSource
            // 
            this.streamClassBindingSource.CurrentChanged += new System.EventHandler(this.streamClassBindingSource_CurrentChanged);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(SIGEN_GUI.Cliente);
            this.clienteBindingSource.CurrentChanged += new System.EventHandler(this.clienteBindingSource_CurrentChanged);
            // 
            // IngresarUsuarioBasico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 572);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbDatos);
            this.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IngresarUsuarioBasico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarUsuarioBasico";
            this.Load += new System.EventHandler(this.IngresarUsuarioBasico_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.streamClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccionLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumentoId;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbSi;
        private System.Windows.Forms.Label lbFechaNacimiento;
        private System.Windows.Forms.TextBox txtDescripcionDificultad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblQueCambia;
        private System.Windows.Forms.DateTimePicker dpkFechaNacimiento;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.BindingSource streamClassBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cbDocumentoTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
    }
}