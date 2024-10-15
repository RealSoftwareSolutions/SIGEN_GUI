namespace SIGEN_GUI
{
    partial class EjercicioIngresar
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
            this.gbDatosIngreso = new System.Windows.Forms.GroupBox();
            this.cbGrupoMuscular = new System.Windows.Forms.ComboBox();
            this.txtDescripcionEjercicio = new System.Windows.Forms.TextBox();
            this.txtNombreDeporte = new System.Windows.Forms.TextBox();
            this.lblDescripcionDeDeporte = new System.Windows.Forms.Label();
            this.lblcantidadjugadores = new System.Windows.Forms.Label();
            this.lblingresardeporte = new System.Windows.Forms.Label();
            this.gbDatosIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosIngreso
            // 
            this.gbDatosIngreso.Controls.Add(this.cbGrupoMuscular);
            this.gbDatosIngreso.Controls.Add(this.txtDescripcionEjercicio);
            this.gbDatosIngreso.Controls.Add(this.txtNombreDeporte);
            this.gbDatosIngreso.Controls.Add(this.lblDescripcionDeDeporte);
            this.gbDatosIngreso.Controls.Add(this.lblcantidadjugadores);
            this.gbDatosIngreso.Controls.Add(this.lblingresardeporte);
            this.gbDatosIngreso.Location = new System.Drawing.Point(127, 82);
            this.gbDatosIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosIngreso.Name = "gbDatosIngreso";
            this.gbDatosIngreso.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosIngreso.Size = new System.Drawing.Size(731, 275);
            this.gbDatosIngreso.TabIndex = 8;
            this.gbDatosIngreso.TabStop = false;
            this.gbDatosIngreso.Text = "Ingreso";
            this.gbDatosIngreso.Enter += new System.EventHandler(this.gbDatosIngreso_Enter);
            // 
            // cbGrupoMuscular
            // 
            this.cbGrupoMuscular.FormattingEnabled = true;
            this.cbGrupoMuscular.Location = new System.Drawing.Point(505, 40);
            this.cbGrupoMuscular.Name = "cbGrupoMuscular";
            this.cbGrupoMuscular.Size = new System.Drawing.Size(121, 24);
            this.cbGrupoMuscular.TabIndex = 10;
            // 
            // txtDescripcionEjercicio
            // 
            this.txtDescripcionEjercicio.Location = new System.Drawing.Point(191, 123);
            this.txtDescripcionEjercicio.Name = "txtDescripcionEjercicio";
            this.txtDescripcionEjercicio.Size = new System.Drawing.Size(180, 22);
            this.txtDescripcionEjercicio.TabIndex = 8;
            // 
            // txtNombreDeporte
            // 
            this.txtNombreDeporte.Location = new System.Drawing.Point(166, 40);
            this.txtNombreDeporte.Name = "txtNombreDeporte";
            this.txtNombreDeporte.Size = new System.Drawing.Size(180, 22);
            this.txtNombreDeporte.TabIndex = 5;
            // 
            // lblDescripcionDeDeporte
            // 
            this.lblDescripcionDeDeporte.AutoSize = true;
            this.lblDescripcionDeDeporte.Location = new System.Drawing.Point(29, 123);
            this.lblDescripcionDeDeporte.Name = "lblDescripcionDeDeporte";
            this.lblDescripcionDeDeporte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescripcionDeDeporte.Size = new System.Drawing.Size(156, 16);
            this.lblDescripcionDeDeporte.TabIndex = 4;
            this.lblDescripcionDeDeporte.Text = "Descripcion del Ejercicio";
            // 
            // lblcantidadjugadores
            // 
            this.lblcantidadjugadores.AutoSize = true;
            this.lblcantidadjugadores.Location = new System.Drawing.Point(398, 43);
            this.lblcantidadjugadores.Name = "lblcantidadjugadores";
            this.lblcantidadjugadores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblcantidadjugadores.Size = new System.Drawing.Size(101, 16);
            this.lblcantidadjugadores.TabIndex = 1;
            this.lblcantidadjugadores.Text = "Grupo Muscular";
            // 
            // lblingresardeporte
            // 
            this.lblingresardeporte.AutoSize = true;
            this.lblingresardeporte.Location = new System.Drawing.Point(25, 43);
            this.lblingresardeporte.Name = "lblingresardeporte";
            this.lblingresardeporte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblingresardeporte.Size = new System.Drawing.Size(135, 16);
            this.lblingresardeporte.TabIndex = 0;
            this.lblingresardeporte.Text = "Nombre Del Ejercicio";
            // 
            // EjercicioIngresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 507);
            this.Controls.Add(this.gbDatosIngreso);
            this.Name = "EjercicioIngresar";
            this.Text = "EjercicioIngresar";
            this.Load += new System.EventHandler(this.EjercicioIngresar_Load);
            this.gbDatosIngreso.ResumeLayout(false);
            this.gbDatosIngreso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosIngreso;
        private System.Windows.Forms.TextBox txtDescripcionEjercicio;
        private System.Windows.Forms.TextBox txtNombreDeporte;
        private System.Windows.Forms.Label lblDescripcionDeDeporte;
        private System.Windows.Forms.Label lblcantidadjugadores;
        private System.Windows.Forms.Label lblingresardeporte;
        private System.Windows.Forms.ComboBox cbGrupoMuscular;
    }
}