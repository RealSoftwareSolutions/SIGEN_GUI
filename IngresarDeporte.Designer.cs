namespace SIGEN_GUI
{
    partial class IngresarDeporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarDeporte));
            this.gbDatosDeportes = new System.Windows.Forms.GroupBox();
            this.txtPosiciones = new System.Windows.Forms.TextBox();
            this.txtDescripcionDeporte = new System.Windows.Forms.TextBox();
            this.txtRequiereEquipamiento = new System.Windows.Forms.TextBox();
            this.txtCantidadJugadores = new System.Windows.Forms.TextBox();
            this.txtNombreDeporte = new System.Windows.Forms.TextBox();
            this.lblDescripcionDeDeporte = new System.Windows.Forms.Label();
            this.lblPosiciones = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcantidadjugadores = new System.Windows.Forms.Label();
            this.lblingresardeporte = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbDatosDeportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosDeportes
            // 
            this.gbDatosDeportes.Controls.Add(this.btnGuardar);
            this.gbDatosDeportes.Controls.Add(this.txtPosiciones);
            this.gbDatosDeportes.Controls.Add(this.txtDescripcionDeporte);
            this.gbDatosDeportes.Controls.Add(this.txtRequiereEquipamiento);
            this.gbDatosDeportes.Controls.Add(this.txtCantidadJugadores);
            this.gbDatosDeportes.Controls.Add(this.txtNombreDeporte);
            this.gbDatosDeportes.Controls.Add(this.lblDescripcionDeDeporte);
            this.gbDatosDeportes.Controls.Add(this.lblPosiciones);
            this.gbDatosDeportes.Controls.Add(this.label2);
            this.gbDatosDeportes.Controls.Add(this.lblcantidadjugadores);
            this.gbDatosDeportes.Controls.Add(this.lblingresardeporte);
            this.gbDatosDeportes.Location = new System.Drawing.Point(51, 38);
            this.gbDatosDeportes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbDatosDeportes.Name = "gbDatosDeportes";
            this.gbDatosDeportes.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbDatosDeportes.Size = new System.Drawing.Size(765, 272);
            this.gbDatosDeportes.TabIndex = 6;
            this.gbDatosDeportes.TabStop = false;
            this.gbDatosDeportes.Text = "Igresar Deporte";
            this.gbDatosDeportes.Enter += new System.EventHandler(this.gbDatosDeportes_Enter);
            // 
            // txtPosiciones
            // 
            this.txtPosiciones.Location = new System.Drawing.Point(105, 149);
            this.txtPosiciones.Name = "txtPosiciones";
            this.txtPosiciones.Size = new System.Drawing.Size(180, 25);
            this.txtPosiciones.TabIndex = 9;
            // 
            // txtDescripcionDeporte
            // 
            this.txtDescripcionDeporte.Location = new System.Drawing.Point(566, 88);
            this.txtDescripcionDeporte.Name = "txtDescripcionDeporte";
            this.txtDescripcionDeporte.Size = new System.Drawing.Size(180, 25);
            this.txtDescripcionDeporte.TabIndex = 8;
            // 
            // txtRequiereEquipamiento
            // 
            this.txtRequiereEquipamiento.Location = new System.Drawing.Point(193, 95);
            this.txtRequiereEquipamiento.Name = "txtRequiereEquipamiento";
            this.txtRequiereEquipamiento.Size = new System.Drawing.Size(180, 25);
            this.txtRequiereEquipamiento.TabIndex = 7;
            // 
            // txtCantidadJugadores
            // 
            this.txtCantidadJugadores.Location = new System.Drawing.Point(522, 38);
            this.txtCantidadJugadores.Name = "txtCantidadJugadores";
            this.txtCantidadJugadores.Size = new System.Drawing.Size(180, 25);
            this.txtCantidadJugadores.TabIndex = 6;
            // 
            // txtNombreDeporte
            // 
            this.txtNombreDeporte.Location = new System.Drawing.Point(147, 38);
            this.txtNombreDeporte.Name = "txtNombreDeporte";
            this.txtNombreDeporte.Size = new System.Drawing.Size(180, 25);
            this.txtNombreDeporte.TabIndex = 5;
            // 
            // lblDescripcionDeDeporte
            // 
            this.lblDescripcionDeDeporte.AutoSize = true;
            this.lblDescripcionDeDeporte.Location = new System.Drawing.Point(389, 98);
            this.lblDescripcionDeDeporte.Name = "lblDescripcionDeDeporte";
            this.lblDescripcionDeDeporte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescripcionDeDeporte.Size = new System.Drawing.Size(171, 15);
            this.lblDescripcionDeDeporte.TabIndex = 4;
            this.lblDescripcionDeDeporte.Text = "Descripcion del Deporte";
            // 
            // lblPosiciones
            // 
            this.lblPosiciones.AutoSize = true;
            this.lblPosiciones.Location = new System.Drawing.Point(25, 149);
            this.lblPosiciones.Name = "lblPosiciones";
            this.lblPosiciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPosiciones.Size = new System.Drawing.Size(77, 15);
            this.lblPosiciones.TabIndex = 3;
            this.lblPosiciones.Text = "Posiciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 98);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(162, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Requiere Equipamiento";
            // 
            // lblcantidadjugadores
            // 
            this.lblcantidadjugadores.AutoSize = true;
            this.lblcantidadjugadores.Location = new System.Drawing.Point(345, 40);
            this.lblcantidadjugadores.Name = "lblcantidadjugadores";
            this.lblcantidadjugadores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblcantidadjugadores.Size = new System.Drawing.Size(166, 15);
            this.lblcantidadjugadores.TabIndex = 1;
            this.lblcantidadjugadores.Text = "Cantidad de Jugadores";
            // 
            // lblingresardeporte
            // 
            this.lblingresardeporte.AutoSize = true;
            this.lblingresardeporte.Location = new System.Drawing.Point(25, 40);
            this.lblingresardeporte.Name = "lblingresardeporte";
            this.lblingresardeporte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblingresardeporte.Size = new System.Drawing.Size(116, 15);
            this.lblingresardeporte.TabIndex = 0;
            this.lblingresardeporte.Text = "Nombre Deporte";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(430, 335);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 26);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(392, 227);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 21);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // IngresarDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 392);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbDatosDeportes);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IngresarDeporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Deporte";
            this.Load += new System.EventHandler(this.lblrequiereequipo_Load);
            this.gbDatosDeportes.ResumeLayout(false);
            this.gbDatosDeportes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosDeportes;
        private System.Windows.Forms.Label lblingresardeporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcantidadjugadores;
        private System.Windows.Forms.Label lblDescripcionDeDeporte;
        private System.Windows.Forms.Label lblPosiciones;
        private System.Windows.Forms.TextBox txtDescripcionDeporte;
        private System.Windows.Forms.TextBox txtRequiereEquipamiento;
        private System.Windows.Forms.TextBox txtCantidadJugadores;
        private System.Windows.Forms.TextBox txtNombreDeporte;
        private System.Windows.Forms.TextBox txtPosiciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
    }
}