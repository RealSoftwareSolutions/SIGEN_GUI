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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EjercicioIngresar));
            this.gbDatosIngreso = new System.Windows.Forms.GroupBox();
            this.cbGrupoMuscular = new System.Windows.Forms.ComboBox();
            this.txtDescripcionEjercicio = new System.Windows.Forms.TextBox();
            this.txtNombreDeporte = new System.Windows.Forms.TextBox();
            this.lblDescripcionDeDeporte = new System.Windows.Forms.Label();
            this.lblcantidadjugadores = new System.Windows.Forms.Label();
            this.lblingresardeporte = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbDatosIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosIngreso
            // 
            this.gbDatosIngreso.BackColor = System.Drawing.Color.White;
            this.gbDatosIngreso.Controls.Add(this.btnGuardar);
            this.gbDatosIngreso.Controls.Add(this.cbGrupoMuscular);
            this.gbDatosIngreso.Controls.Add(this.txtDescripcionEjercicio);
            this.gbDatosIngreso.Controls.Add(this.txtNombreDeporte);
            this.gbDatosIngreso.Controls.Add(this.lblDescripcionDeDeporte);
            this.gbDatosIngreso.Controls.Add(this.lblcantidadjugadores);
            this.gbDatosIngreso.Controls.Add(this.lblingresardeporte);
            this.gbDatosIngreso.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosIngreso.Location = new System.Drawing.Point(52, 47);
            this.gbDatosIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosIngreso.Name = "gbDatosIngreso";
            this.gbDatosIngreso.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosIngreso.Size = new System.Drawing.Size(731, 258);
            this.gbDatosIngreso.TabIndex = 8;
            this.gbDatosIngreso.TabStop = false;
            this.gbDatosIngreso.Text = "Ingreso";
            this.gbDatosIngreso.Enter += new System.EventHandler(this.gbDatosIngreso_Enter);
            // 
            // cbGrupoMuscular
            // 
            this.cbGrupoMuscular.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupoMuscular.FormattingEnabled = true;
            this.cbGrupoMuscular.Location = new System.Drawing.Point(485, 38);
            this.cbGrupoMuscular.Name = "cbGrupoMuscular";
            this.cbGrupoMuscular.Size = new System.Drawing.Size(121, 23);
            this.cbGrupoMuscular.TabIndex = 10;
            // 
            // txtDescripcionEjercicio
            // 
            this.txtDescripcionEjercicio.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionEjercicio.Location = new System.Drawing.Point(213, 112);
            this.txtDescripcionEjercicio.Name = "txtDescripcionEjercicio";
            this.txtDescripcionEjercicio.Size = new System.Drawing.Size(180, 25);
            this.txtDescripcionEjercicio.TabIndex = 8;
            // 
            // txtNombreDeporte
            // 
            this.txtNombreDeporte.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDeporte.Location = new System.Drawing.Point(176, 36);
            this.txtNombreDeporte.Name = "txtNombreDeporte";
            this.txtNombreDeporte.Size = new System.Drawing.Size(180, 25);
            this.txtNombreDeporte.TabIndex = 5;
            // 
            // lblDescripcionDeDeporte
            // 
            this.lblDescripcionDeDeporte.AutoSize = true;
            this.lblDescripcionDeDeporte.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionDeDeporte.Location = new System.Drawing.Point(29, 115);
            this.lblDescripcionDeDeporte.Name = "lblDescripcionDeDeporte";
            this.lblDescripcionDeDeporte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescripcionDeDeporte.Size = new System.Drawing.Size(178, 15);
            this.lblDescripcionDeDeporte.TabIndex = 4;
            this.lblDescripcionDeDeporte.Text = "Descripcion del Ejercicio";
            // 
            // lblcantidadjugadores
            // 
            this.lblcantidadjugadores.AutoSize = true;
            this.lblcantidadjugadores.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadjugadores.Location = new System.Drawing.Point(362, 40);
            this.lblcantidadjugadores.Name = "lblcantidadjugadores";
            this.lblcantidadjugadores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblcantidadjugadores.Size = new System.Drawing.Size(117, 15);
            this.lblcantidadjugadores.TabIndex = 1;
            this.lblcantidadjugadores.Text = "Grupo Muscular";
            // 
            // lblingresardeporte
            // 
            this.lblingresardeporte.AutoSize = true;
            this.lblingresardeporte.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingresardeporte.Location = new System.Drawing.Point(25, 40);
            this.lblingresardeporte.Name = "lblingresardeporte";
            this.lblingresardeporte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblingresardeporte.Size = new System.Drawing.Size(149, 15);
            this.lblingresardeporte.TabIndex = 0;
            this.lblingresardeporte.Text = "Nombre Del Ejercicio";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(338, 188);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 20);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(375, 322);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 24);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // EjercicioIngresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 358);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbDatosIngreso);
            this.Font = new System.Drawing.Font("Algerian", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EjercicioIngresar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
    }
}