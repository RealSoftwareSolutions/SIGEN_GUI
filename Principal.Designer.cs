namespace SIGEN_GUI
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAplicasiones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEntrenador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIngresar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAplicasiones,
            this.menuIngresar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1220, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAplicasiones
            // 
            this.menuAplicasiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuEntrenador,
            this.menuAdministrador});
            this.menuAplicasiones.Name = "menuAplicasiones";
            this.menuAplicasiones.Size = new System.Drawing.Size(106, 24);
            this.menuAplicasiones.Text = "Aplicasiones";
            this.menuAplicasiones.Click += new System.EventHandler(this.menuAplicasiones_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(187, 26);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuEntrenador
            // 
            this.menuEntrenador.Name = "menuEntrenador";
            this.menuEntrenador.Size = new System.Drawing.Size(187, 26);
            this.menuEntrenador.Text = "Entrenador";
            this.menuEntrenador.Click += new System.EventHandler(this.menuEntrenador_Click);
            // 
            // menuAdministrador
            // 
            this.menuAdministrador.Name = "menuAdministrador";
            this.menuAdministrador.Size = new System.Drawing.Size(187, 26);
            this.menuAdministrador.Text = "Administrador";
            this.menuAdministrador.Click += new System.EventHandler(this.menuAdministrador_Click);
            // 
            // menuIngresar
            // 
            this.menuIngresar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.menuSalir});
            this.menuIngresar.Name = "menuIngresar";
            this.menuIngresar.Size = new System.Drawing.Size(76, 24);
            this.menuIngresar.Text = "Ingresar";
            this.menuIngresar.Click += new System.EventHandler(this.menuIngresar_Click);
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(224, 26);
            this.menuLogin.Text = "Login";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(224, 26);
            this.menuSalir.Text = "Salir";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 547);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem menuAplicasiones;
        public System.Windows.Forms.ToolStripMenuItem menuClientes;
        public System.Windows.Forms.ToolStripMenuItem menuEntrenador;
        public System.Windows.Forms.ToolStripMenuItem menuAdministrador;
        private System.Windows.Forms.ToolStripMenuItem menuIngresar;
        private System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
    }
}