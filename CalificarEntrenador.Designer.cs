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
            this.Nombre_Completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.lblVacio = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificarEntrenador)).BeginInit();
            this.gbBuscar.SuspendLayout();
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
            this.Nombre_Completo,
            this.ID_Cliente,
            this.Tipo_Documento,
            this.Fecha_Nacimiento,
            this.Direccion,
            this.Genero,
            this.Descripcion});
            this.dgvCalificarEntrenador.Location = new System.Drawing.Point(12, 66);
            this.dgvCalificarEntrenador.Name = "dgvCalificarEntrenador";
            this.dgvCalificarEntrenador.RowHeadersWidth = 51;
            this.dgvCalificarEntrenador.RowTemplate.Height = 24;
            this.dgvCalificarEntrenador.Size = new System.Drawing.Size(934, 325);
            this.dgvCalificarEntrenador.TabIndex = 0;
            this.dgvCalificarEntrenador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalificarEntrenador_CellContentClick);
            // 
            // Nombre_Completo
            // 
            this.Nombre_Completo.HeaderText = "Nombre Completo";
            this.Nombre_Completo.MinimumWidth = 6;
            this.Nombre_Completo.Name = "Nombre_Completo";
            this.Nombre_Completo.Width = 125;
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
            // Fecha_Nacimiento
            // 
            this.Fecha_Nacimiento.HeaderText = "Fecha Nacimiento";
            this.Fecha_Nacimiento.MinimumWidth = 6;
            this.Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            this.Fecha_Nacimiento.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 125;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            this.Genero.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.lblVacio);
            this.gbBuscar.Controls.Add(this.lblTipoDocumento);
            this.gbBuscar.Controls.Add(this.cbTipoDocumento);
            this.gbBuscar.Controls.Add(this.txtBuscar);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Location = new System.Drawing.Point(29, 455);
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
            // CalificarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 731);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCalificarEntrenador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Label lblVacio;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}