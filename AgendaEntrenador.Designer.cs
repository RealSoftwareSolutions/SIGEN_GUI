namespace SIGEN_GUI
{
    partial class AgendaEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaEntrenador));
            this.dgvEntrenadorAgenda = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.idBuscador = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblCupos = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblVacio = new System.Windows.Forms.Label();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.gbAgendar = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.lblVacioAgendar = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.cboDocumento = new System.Windows.Forms.ComboBox();
            this.cbDocumento = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dpkFecha = new System.Windows.Forms.DateTimePicker();
            this.txtClaseNumero = new System.Windows.Forms.TextBox();
            this.lblNumberoClase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadorAgenda)).BeginInit();
            this.gbBuscar.SuspendLayout();
            this.gbAgendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEntrenadorAgenda
            // 
            this.dgvEntrenadorAgenda.AllowUserToAddRows = false;
            this.dgvEntrenadorAgenda.AllowUserToDeleteRows = false;
            this.dgvEntrenadorAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrenadorAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Turno,
            this.Horas,
            this.Nombre_Completo,
            this.Cupos});
            this.dgvEntrenadorAgenda.Location = new System.Drawing.Point(28, 43);
            this.dgvEntrenadorAgenda.Name = "dgvEntrenadorAgenda";
            this.dgvEntrenadorAgenda.ReadOnly = true;
            this.dgvEntrenadorAgenda.RowHeadersWidth = 51;
            this.dgvEntrenadorAgenda.RowTemplate.Height = 24;
            this.dgvEntrenadorAgenda.Size = new System.Drawing.Size(679, 342);
            this.dgvEntrenadorAgenda.TabIndex = 0;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 125;
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.MinimumWidth = 6;
            this.Turno.Name = "Turno";
            this.Turno.ReadOnly = true;
            this.Turno.Width = 125;
            // 
            // Horas
            // 
            this.Horas.HeaderText = "Horas";
            this.Horas.MinimumWidth = 6;
            this.Horas.Name = "Horas";
            this.Horas.ReadOnly = true;
            this.Horas.Width = 125;
            // 
            // Nombre_Completo
            // 
            this.Nombre_Completo.HeaderText = "Entrenador";
            this.Nombre_Completo.MinimumWidth = 6;
            this.Nombre_Completo.Name = "Nombre_Completo";
            this.Nombre_Completo.ReadOnly = true;
            this.Nombre_Completo.Width = 125;
            // 
            // Cupos
            // 
            this.Cupos.HeaderText = "Cupos";
            this.Cupos.MinimumWidth = 6;
            this.Cupos.Name = "Cupos";
            this.Cupos.ReadOnly = true;
            this.Cupos.Width = 125;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(308, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 22);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Items.AddRange(new object[] {
            "6",
            "12",
            "18",
            "24",
            "50"});
            this.cbClientes.Location = new System.Drawing.Point(70, 27);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(121, 23);
            this.cbClientes.TabIndex = 2;
            // 
            // idBuscador
            // 
            this.idBuscador.Location = new System.Drawing.Point(137, 73);
            this.idBuscador.Name = "idBuscador";
            this.idBuscador.Size = new System.Drawing.Size(121, 25);
            this.idBuscador.TabIndex = 3;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(28, 400);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(117, 22);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // lblCupos
            // 
            this.lblCupos.AutoSize = true;
            this.lblCupos.Location = new System.Drawing.Point(18, 35);
            this.lblCupos.Name = "lblCupos";
            this.lblCupos.Size = new System.Drawing.Size(46, 15);
            this.lblCupos.TabIndex = 5;
            this.lblCupos.Text = "Cupos";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(19, 37);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(112, 15);
            this.lblTipoDocumento.TabIndex = 7;
            this.lblTipoDocumento.Text = "Tipo Documento";
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Items.AddRange(new object[] {
            "C.I",
            "Pasaporte"});
            this.cbTipoDocumento.Location = new System.Drawing.Point(137, 34);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(121, 23);
            this.cbTipoDocumento.TabIndex = 6;
            // 
            // lblVacio
            // 
            this.lblVacio.AutoSize = true;
            this.lblVacio.Location = new System.Drawing.Point(19, 83);
            this.lblVacio.Name = "lblVacio";
            this.lblVacio.Size = new System.Drawing.Size(45, 15);
            this.lblVacio.TabIndex = 8;
            this.lblVacio.Text = "Vacio";
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.lblVacio);
            this.gbBuscar.Controls.Add(this.lblTipoDocumento);
            this.gbBuscar.Controls.Add(this.cbTipoDocumento);
            this.gbBuscar.Controls.Add(this.idBuscador);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Location = new System.Drawing.Point(723, 29);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(415, 142);
            this.gbBuscar.TabIndex = 9;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar";
            // 
            // gbAgendar
            // 
            this.gbAgendar.Controls.Add(this.btnCancelar);
            this.gbAgendar.Controls.Add(this.btnAgendar);
            this.gbAgendar.Controls.Add(this.lblVacioAgendar);
            this.gbAgendar.Controls.Add(this.lblDocumento);
            this.gbAgendar.Controls.Add(this.cboDocumento);
            this.gbAgendar.Controls.Add(this.cbDocumento);
            this.gbAgendar.Controls.Add(this.txtHora);
            this.gbAgendar.Controls.Add(this.lblHora);
            this.gbAgendar.Controls.Add(this.lblFecha);
            this.gbAgendar.Controls.Add(this.dpkFecha);
            this.gbAgendar.Controls.Add(this.txtClaseNumero);
            this.gbAgendar.Controls.Add(this.lblNumberoClase);
            this.gbAgendar.Controls.Add(this.lblCupos);
            this.gbAgendar.Controls.Add(this.cbClientes);
            this.gbAgendar.Location = new System.Drawing.Point(712, 192);
            this.gbAgendar.Name = "gbAgendar";
            this.gbAgendar.Size = new System.Drawing.Size(439, 229);
            this.gbAgendar.TabIndex = 10;
            this.gbAgendar.TabStop = false;
            this.gbAgendar.Text = "Agendar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(337, 171);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 22);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(228, 171);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(75, 22);
            this.btnAgendar.TabIndex = 9;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            // 
            // lblVacioAgendar
            // 
            this.lblVacioAgendar.AutoSize = true;
            this.lblVacioAgendar.Location = new System.Drawing.Point(211, 61);
            this.lblVacioAgendar.Name = "lblVacioAgendar";
            this.lblVacioAgendar.Size = new System.Drawing.Size(45, 15);
            this.lblVacioAgendar.TabIndex = 9;
            this.lblVacioAgendar.Text = "Vacio";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(197, 35);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(81, 15);
            this.lblDocumento.TabIndex = 9;
            this.lblDocumento.Text = "Documento";
            // 
            // cboDocumento
            // 
            this.cboDocumento.FormattingEnabled = true;
            this.cboDocumento.Items.AddRange(new object[] {
            "C.I",
            "Pasaporte"});
            this.cboDocumento.Location = new System.Drawing.Point(312, 32);
            this.cboDocumento.Name = "cboDocumento";
            this.cboDocumento.Size = new System.Drawing.Size(121, 23);
            this.cboDocumento.TabIndex = 9;
            // 
            // cbDocumento
            // 
            this.cbDocumento.Location = new System.Drawing.Point(312, 61);
            this.cbDocumento.Name = "cbDocumento";
            this.cbDocumento.Size = new System.Drawing.Size(121, 25);
            this.cbDocumento.TabIndex = 9;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(74, 159);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(121, 25);
            this.txtHora.TabIndex = 13;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(18, 162);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 5, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(41, 15);
            this.lblHora.TabIndex = 12;
            this.lblHora.Text = "Hora";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(18, 128);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 5, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 15);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha";
            // 
            // dpkFecha
            // 
            this.dpkFecha.Location = new System.Drawing.Point(74, 121);
            this.dpkFecha.MinDate = new System.DateTime(2024, 11, 10, 0, 0, 0, 0);
            this.dpkFecha.Name = "dpkFecha";
            this.dpkFecha.Size = new System.Drawing.Size(200, 25);
            this.dpkFecha.TabIndex = 10;
            this.dpkFecha.Value = new System.DateTime(2024, 11, 10, 0, 0, 0, 0);
            // 
            // txtClaseNumero
            // 
            this.txtClaseNumero.Location = new System.Drawing.Point(88, 77);
            this.txtClaseNumero.Name = "txtClaseNumero";
            this.txtClaseNumero.Size = new System.Drawing.Size(121, 25);
            this.txtClaseNumero.TabIndex = 9;
            this.txtClaseNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNumberoClase
            // 
            this.lblNumberoClase.AutoSize = true;
            this.lblNumberoClase.Location = new System.Drawing.Point(18, 80);
            this.lblNumberoClase.Margin = new System.Windows.Forms.Padding(4, 0, 5, 0);
            this.lblNumberoClase.Name = "lblNumberoClase";
            this.lblNumberoClase.Size = new System.Drawing.Size(62, 15);
            this.lblNumberoClase.TabIndex = 6;
            this.lblNumberoClase.Text = "Clase N°";
            this.lblNumberoClase.Click += new System.EventHandler(this.lblNumberoClase_Click);
            // 
            // AgendaEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 469);
            this.Controls.Add(this.gbAgendar);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvEntrenadorAgenda);
            this.Font = new System.Drawing.Font("Algerian", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgendaEntrenador";
            this.Text = "AgendaEntrenador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadorAgenda)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.gbAgendar.ResumeLayout(false);
            this.gbAgendar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEntrenadorAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.TextBox idBuscador;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblCupos;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private System.Windows.Forms.Label lblVacio;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.GroupBox gbAgendar;
        private System.Windows.Forms.TextBox txtClaseNumero;
        private System.Windows.Forms.Label lblNumberoClase;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dpkFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblVacioAgendar;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.ComboBox cboDocumento;
        private System.Windows.Forms.TextBox cbDocumento;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Button btnCancelar;
    }
}