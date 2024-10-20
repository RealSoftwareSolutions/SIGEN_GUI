namespace SIGEN_GUI
{
    partial class CalificarEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalificarEntrenador));
            this.dgvCalificarEntrenador = new System.Windows.Forms.DataGridView();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.lblVacio = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.gbCalificar = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.lblVacioID = new System.Windows.Forms.Label();
            this.lblTipoDocumentoCalificar = new System.Windows.Forms.Label();
            this.cboDocumento = new System.Windows.Forms.ComboBox();
            this.cbDocumento = new System.Windows.Forms.TextBox();
            this.txtClaseNumbero = new System.Windows.Forms.TextBox();
            this.lblNumberoClase = new System.Windows.Forms.Label();
            this.ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dpkFecha = new System.Windows.Forms.DateTimePicker();
            this.txtPuntaje = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.txtDescripcionEntrenamiento = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificarEntrenador)).BeginInit();
            this.gbBuscar.SuspendLayout();
            this.gbCalificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCalificarEntrenador
            // 
            this.dgvCalificarEntrenador.AllowUserToAddRows = false;
            this.dgvCalificarEntrenador.AllowUserToDeleteRows = false;
            this.dgvCalificarEntrenador.AllowUserToResizeColumns = false;
            this.dgvCalificarEntrenador.AllowUserToResizeRows = false;
            this.dgvCalificarEntrenador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificarEntrenador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Cliente,
            this.Tipo_Documento,
            this.Nombre_Completo,
            this.Genero,
            this.Fecha,
            this.Nombre,
            this.Puntaje,
            this.Descripcion});
            this.dgvCalificarEntrenador.Location = new System.Drawing.Point(6, 35);
            this.dgvCalificarEntrenador.Name = "dgvCalificarEntrenador";
            this.dgvCalificarEntrenador.RowHeadersWidth = 51;
            this.dgvCalificarEntrenador.RowTemplate.Height = 24;
            this.dgvCalificarEntrenador.Size = new System.Drawing.Size(1054, 325);
            this.dgvCalificarEntrenador.TabIndex = 0;
            this.dgvCalificarEntrenador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalificarEntrenador_CellContentClick);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.lblVacio);
            this.gbBuscar.Controls.Add(this.lblTipoDocumento);
            this.gbBuscar.Controls.Add(this.cboTipoDocumento);
            this.gbBuscar.Controls.Add(this.txtBuscar);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Location = new System.Drawing.Point(24, 418);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(415, 142);
            this.gbBuscar.TabIndex = 10;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar";
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
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(19, 37);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(112, 15);
            this.lblTipoDocumento.TabIndex = 7;
            this.lblTipoDocumento.Text = "Tipo Documento";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Items.AddRange(new object[] {
            "C.I",
            "Pasaporte"});
            this.cboTipoDocumento.Location = new System.Drawing.Point(137, 34);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(121, 23);
            this.cboTipoDocumento.TabIndex = 6;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(137, 73);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(121, 25);
            this.txtBuscar.TabIndex = 3;
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
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(943, 366);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(117, 22);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // gbCalificar
            // 
            this.gbCalificar.Controls.Add(this.textBox1);
            this.gbCalificar.Controls.Add(this.lblDescripcion);
            this.gbCalificar.Controls.Add(this.txtDescripcionEntrenamiento);
            this.gbCalificar.Controls.Add(this.lblPuntaje);
            this.gbCalificar.Controls.Add(this.txtPuntaje);
            this.gbCalificar.Controls.Add(this.lblFecha);
            this.gbCalificar.Controls.Add(this.btnCancelar);
            this.gbCalificar.Controls.Add(this.dpkFecha);
            this.gbCalificar.Controls.Add(this.btnCalificar);
            this.gbCalificar.Controls.Add(this.lblVacioID);
            this.gbCalificar.Controls.Add(this.lblTipoDocumentoCalificar);
            this.gbCalificar.Controls.Add(this.cboDocumento);
            this.gbCalificar.Controls.Add(this.cbDocumento);
            this.gbCalificar.Controls.Add(this.txtClaseNumbero);
            this.gbCalificar.Controls.Add(this.lblNumberoClase);
            this.gbCalificar.Location = new System.Drawing.Point(496, 418);
            this.gbCalificar.Name = "gbCalificar";
            this.gbCalificar.Size = new System.Drawing.Size(564, 270);
            this.gbCalificar.TabIndex = 11;
            this.gbCalificar.TabStop = false;
            this.gbCalificar.Text = "Calificar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(100, 242);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 22);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(9, 242);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(75, 22);
            this.btnCalificar.TabIndex = 9;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            // 
            // lblVacioID
            // 
            this.lblVacioID.AutoSize = true;
            this.lblVacioID.Location = new System.Drawing.Point(205, 64);
            this.lblVacioID.Name = "lblVacioID";
            this.lblVacioID.Size = new System.Drawing.Size(45, 15);
            this.lblVacioID.TabIndex = 9;
            this.lblVacioID.Text = "VACIO";
            // 
            // lblTipoDocumentoCalificar
            // 
            this.lblTipoDocumentoCalificar.AutoSize = true;
            this.lblTipoDocumentoCalificar.Location = new System.Drawing.Point(205, 35);
            this.lblTipoDocumentoCalificar.Name = "lblTipoDocumentoCalificar";
            this.lblTipoDocumentoCalificar.Size = new System.Drawing.Size(81, 15);
            this.lblTipoDocumentoCalificar.TabIndex = 9;
            this.lblTipoDocumentoCalificar.Text = "Documento";
            // 
            // cboDocumento
            // 
            this.cboDocumento.FormattingEnabled = true;
            this.cboDocumento.Items.AddRange(new object[] {
            "C.I",
            "Pasaporte"});
            this.cboDocumento.Location = new System.Drawing.Point(291, 32);
            this.cboDocumento.Name = "cboDocumento";
            this.cboDocumento.Size = new System.Drawing.Size(121, 23);
            this.cboDocumento.TabIndex = 9;
            // 
            // cbDocumento
            // 
            this.cbDocumento.Location = new System.Drawing.Point(291, 64);
            this.cbDocumento.Name = "cbDocumento";
            this.cbDocumento.Size = new System.Drawing.Size(121, 25);
            this.cbDocumento.TabIndex = 9;
            // 
            // txtClaseNumbero
            // 
            this.txtClaseNumbero.Location = new System.Drawing.Point(64, 34);
            this.txtClaseNumbero.Name = "txtClaseNumbero";
            this.txtClaseNumbero.Size = new System.Drawing.Size(135, 25);
            this.txtClaseNumbero.TabIndex = 9;
            // 
            // lblNumberoClase
            // 
            this.lblNumberoClase.AutoSize = true;
            this.lblNumberoClase.Location = new System.Drawing.Point(1, 37);
            this.lblNumberoClase.Margin = new System.Windows.Forms.Padding(4, 0, 5, 0);
            this.lblNumberoClase.Name = "lblNumberoClase";
            this.lblNumberoClase.Size = new System.Drawing.Size(62, 15);
            this.lblNumberoClase.TabIndex = 6;
            this.lblNumberoClase.Text = "Clase N°";
            // 
            // ID_Cliente
            // 
            this.ID_Cliente.HeaderText = "Documento N°";
            this.ID_Cliente.MinimumWidth = 6;
            this.ID_Cliente.Name = "ID_Cliente";
            this.ID_Cliente.Width = 125;
            // 
            // Tipo_Documento
            // 
            this.Tipo_Documento.HeaderText = "Tipo Documento";
            this.Tipo_Documento.MinimumWidth = 6;
            this.Tipo_Documento.Name = "Tipo_Documento";
            this.Tipo_Documento.Width = 125;
            // 
            // Nombre_Completo
            // 
            this.Nombre_Completo.HeaderText = "Nombre Completo";
            this.Nombre_Completo.MinimumWidth = 6;
            this.Nombre_Completo.Name = "Nombre_Completo";
            this.Nombre_Completo.Width = 125;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            this.Genero.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Ejercicio";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Puntaje
            // 
            this.Puntaje.HeaderText = "Puntos";
            this.Puntaje.MinimumWidth = 6;
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.Width = 125;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 127);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 5, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 15);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha";
            // 
            // dpkFecha
            // 
            this.dpkFecha.Location = new System.Drawing.Point(62, 120);
            this.dpkFecha.MinDate = new System.DateTime(2024, 11, 10, 0, 0, 0, 0);
            this.dpkFecha.Name = "dpkFecha";
            this.dpkFecha.Size = new System.Drawing.Size(200, 25);
            this.dpkFecha.TabIndex = 12;
            this.dpkFecha.Value = new System.DateTime(2024, 11, 10, 0, 0, 0, 0);
            // 
            // txtPuntaje
            // 
            this.txtPuntaje.Location = new System.Drawing.Point(69, 71);
            this.txtPuntaje.Name = "txtPuntaje";
            this.txtPuntaje.Size = new System.Drawing.Size(135, 25);
            this.txtPuntaje.TabIndex = 15;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(3, 75);
            this.lblPuntaje.Margin = new System.Windows.Forms.Padding(4, 0, 5, 0);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(64, 15);
            this.lblPuntaje.TabIndex = 16;
            this.lblPuntaje.Text = "Puntaje";
            // 
            // txtDescripcionEntrenamiento
            // 
            this.txtDescripcionEntrenamiento.Location = new System.Drawing.Point(321, 120);
            this.txtDescripcionEntrenamiento.Multiline = true;
            this.txtDescripcionEntrenamiento.Name = "txtDescripcionEntrenamiento";
            this.txtDescripcionEntrenamiento.Size = new System.Drawing.Size(225, 121);
            this.txtDescripcionEntrenamiento.TabIndex = 17;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(227, 168);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 5, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 15);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 25);
            this.textBox1.TabIndex = 19;
            // 
            // CalificarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 731);
            this.Controls.Add(this.gbCalificar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.dgvCalificarEntrenador);
            this.Font = new System.Drawing.Font("Algerian", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalificarEntrenador";
            this.Text = "CalificarEntrenador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificarEntrenador)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.gbCalificar.ResumeLayout(false);
            this.gbCalificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCalificarEntrenador;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Label lblVacio;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.GroupBox gbCalificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Label lblVacioID;
        private System.Windows.Forms.Label lblTipoDocumentoCalificar;
        private System.Windows.Forms.ComboBox cboDocumento;
        private System.Windows.Forms.TextBox cbDocumento;
        private System.Windows.Forms.TextBox txtClaseNumbero;
        private System.Windows.Forms.Label lblNumberoClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntaje;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dpkFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.TextBox txtPuntaje;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.TextBox txtDescripcionEntrenamiento;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox textBox1;
    }
}