namespace SIGEN_GUI
{
    partial class MenuPrincipalCliente
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
            this.AgendaClienteButton = new System.Windows.Forms.Button();
            this.RendimientoClienteButton = new System.Windows.Forms.Button();
            this.RutinaClienteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AgendaClienteButton
            // 
            this.AgendaClienteButton.Location = new System.Drawing.Point(260, 195);
            this.AgendaClienteButton.Name = "AgendaClienteButton";
            this.AgendaClienteButton.Size = new System.Drawing.Size(75, 23);
            this.AgendaClienteButton.TabIndex = 0;
            this.AgendaClienteButton.Text = "Agenda";
            this.AgendaClienteButton.UseVisualStyleBackColor = true;
            this.AgendaClienteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RendimientoClienteButton
            // 
            this.RendimientoClienteButton.Location = new System.Drawing.Point(422, 195);
            this.RendimientoClienteButton.Name = "RendimientoClienteButton";
            this.RendimientoClienteButton.Size = new System.Drawing.Size(100, 23);
            this.RendimientoClienteButton.TabIndex = 1;
            this.RendimientoClienteButton.Text = "Rendimiento";
            this.RendimientoClienteButton.UseVisualStyleBackColor = true;
            this.RendimientoClienteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // RutinaClienteButton
            // 
            this.RutinaClienteButton.Location = new System.Drawing.Point(341, 195);
            this.RutinaClienteButton.Name = "RutinaClienteButton";
            this.RutinaClienteButton.Size = new System.Drawing.Size(75, 23);
            this.RutinaClienteButton.TabIndex = 2;
            this.RutinaClienteButton.Text = "Rutina";
            this.RutinaClienteButton.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipalCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RutinaClienteButton);
            this.Controls.Add(this.RendimientoClienteButton);
            this.Controls.Add(this.AgendaClienteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MenuPrincipalCliente";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipalCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AgendaClienteButton;
        private System.Windows.Forms.Button RendimientoClienteButton;
        private System.Windows.Forms.Button RutinaClienteButton;
    }
}