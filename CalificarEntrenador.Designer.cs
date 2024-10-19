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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificarEntrenador)).BeginInit();
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
            this.dgvCalificarEntrenador.Size = new System.Drawing.Size(933, 325);
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
            // CalificarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 525);
            this.Controls.Add(this.dgvCalificarEntrenador);
            this.Font = new System.Drawing.Font("Algerian", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalificarEntrenador";
            this.Text = "CalificarEntrenador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificarEntrenador)).EndInit();
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
    }
}