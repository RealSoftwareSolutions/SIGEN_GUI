namespace SIGEN_GUI
{
    partial class Rutina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rutina));
            this.dGridViewRutina = new System.Windows.Forms.DataGridView();
            this.ID_Ejercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Grupo_Muscular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Repeticiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewRutina)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridViewRutina
            // 
            this.dGridViewRutina.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGridViewRutina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGridViewRutina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewRutina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Ejercicio,
            this.ID_Grupo_Muscular,
            this.Cantidad_Repeticiones,
            this.Cantidad_Series,
            this.Descripcion});
            this.dGridViewRutina.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dGridViewRutina.Location = new System.Drawing.Point(59, 43);
            this.dGridViewRutina.Name = "dGridViewRutina";
            this.dGridViewRutina.RowHeadersWidth = 51;
            this.dGridViewRutina.RowTemplate.Height = 24;
            this.dGridViewRutina.Size = new System.Drawing.Size(681, 316);
            this.dGridViewRutina.TabIndex = 0;
            this.dGridViewRutina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewRutina_CellContentClick);
            // 
            // ID_Ejercicio
            // 
            this.ID_Ejercicio.HeaderText = "Ejercicio";
            this.ID_Ejercicio.MinimumWidth = 6;
            this.ID_Ejercicio.Name = "ID_Ejercicio";
            this.ID_Ejercicio.Width = 125;
            // 
            // ID_Grupo_Muscular
            // 
            this.ID_Grupo_Muscular.HeaderText = "Grupo Muscular";
            this.ID_Grupo_Muscular.MinimumWidth = 6;
            this.ID_Grupo_Muscular.Name = "ID_Grupo_Muscular";
            this.ID_Grupo_Muscular.Width = 125;
            // 
            // Cantidad_Repeticiones
            // 
            this.Cantidad_Repeticiones.HeaderText = "Cantidad Repeticiones";
            this.Cantidad_Repeticiones.MinimumWidth = 6;
            this.Cantidad_Repeticiones.Name = "Cantidad_Repeticiones";
            this.Cantidad_Repeticiones.Width = 125;
            // 
            // Cantidad_Series
            // 
            this.Cantidad_Series.HeaderText = "Cantidad Series";
            this.Cantidad_Series.MinimumWidth = 6;
            this.Cantidad_Series.Name = "Cantidad_Series";
            this.Cantidad_Series.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Instrucciones";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(130, 373);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(165, 23);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(539, 373);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 26);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Rutina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dGridViewRutina);
            this.Font = new System.Drawing.Font("Algerian", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rutina";
            this.Text = "Rutina";
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewRutina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridViewRutina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Ejercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Grupo_Muscular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Repeticiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Series;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSalir;
    }
}