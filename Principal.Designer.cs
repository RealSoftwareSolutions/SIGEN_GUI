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
            this.menuAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRutina = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRendimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEntrenador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgendaEntrenador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalificarEntrenador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAsignarEntrenamiento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalendario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClienteAdministrativo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAvanzado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIngresarUusarioBasicos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuingresarDeportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIngresarEjercicios = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(1220, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAplicasiones
            // 
            this.menuAplicasiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuEntrenador,
            this.menuAdministrador,
            this.administrativoToolStripMenuItem,
            this.menuAvanzado});
            this.menuAplicasiones.Name = "menuAplicasiones";
            this.menuAplicasiones.Size = new System.Drawing.Size(106, 24);
            this.menuAplicasiones.Text = "Aplicasiones";
            this.menuAplicasiones.Click += new System.EventHandler(this.menuAplicasiones_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAgenda,
            this.menuRutina,
            this.menuRendimiento});
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(224, 26);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuAgenda
            // 
            this.menuAgenda.Name = "menuAgenda";
            this.menuAgenda.Size = new System.Drawing.Size(177, 26);
            this.menuAgenda.Text = "Agenda";
            this.menuAgenda.Click += new System.EventHandler(this.menuAgenda_Click);
            // 
            // menuRutina
            // 
            this.menuRutina.Name = "menuRutina";
            this.menuRutina.Size = new System.Drawing.Size(177, 26);
            this.menuRutina.Text = "Rutina";
            this.menuRutina.Click += new System.EventHandler(this.menuRutina_Click);
            // 
            // menuRendimiento
            // 
            this.menuRendimiento.Name = "menuRendimiento";
            this.menuRendimiento.Size = new System.Drawing.Size(177, 26);
            this.menuRendimiento.Text = "Rendimiento";
            // 
            // menuEntrenador
            // 
            this.menuEntrenador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAgendaEntrenador,
            this.menuCalificarEntrenador,
            this.menuAsignarEntrenamiento});
            this.menuEntrenador.Name = "menuEntrenador";
            this.menuEntrenador.Size = new System.Drawing.Size(224, 26);
            this.menuEntrenador.Text = "Entrenador";
            this.menuEntrenador.Click += new System.EventHandler(this.menuEntrenador_Click);
            // 
            // menuAgendaEntrenador
            // 
            this.menuAgendaEntrenador.Name = "menuAgendaEntrenador";
            this.menuAgendaEntrenador.Size = new System.Drawing.Size(243, 26);
            this.menuAgendaEntrenador.Text = "Agenda";
            this.menuAgendaEntrenador.Click += new System.EventHandler(this.menuAgendaEntrenador_Click);
            // 
            // menuCalificarEntrenador
            // 
            this.menuCalificarEntrenador.Name = "menuCalificarEntrenador";
            this.menuCalificarEntrenador.Size = new System.Drawing.Size(243, 26);
            this.menuCalificarEntrenador.Text = "Calificar";
            this.menuCalificarEntrenador.Click += new System.EventHandler(this.menuCalificarEntrenador_Click);
            // 
            // menuAsignarEntrenamiento
            // 
            this.menuAsignarEntrenamiento.Name = "menuAsignarEntrenamiento";
            this.menuAsignarEntrenamiento.Size = new System.Drawing.Size(243, 26);
            this.menuAsignarEntrenamiento.Text = "Asignar Entrenamiento";
            this.menuAsignarEntrenamiento.Click += new System.EventHandler(this.menuAsignarEntrenamiento_Click);
            // 
            // menuAdministrador
            // 
            this.menuAdministrador.Name = "menuAdministrador";
            this.menuAdministrador.Size = new System.Drawing.Size(224, 26);
            this.menuAdministrador.Text = "Administrador";
            this.menuAdministrador.Click += new System.EventHandler(this.menuAdministrador_Click);
            // 
            // administrativoToolStripMenuItem
            // 
            this.administrativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCalendario,
            this.menuClienteAdministrativo});
            this.administrativoToolStripMenuItem.Name = "administrativoToolStripMenuItem";
            this.administrativoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.administrativoToolStripMenuItem.Text = "Administrativo";
            // 
            // menuCalendario
            // 
            this.menuCalendario.Name = "menuCalendario";
            this.menuCalendario.Size = new System.Drawing.Size(224, 26);
            this.menuCalendario.Text = "Calendario";
            this.menuCalendario.Click += new System.EventHandler(this.menuCalendario_Click);
            // 
            // menuClienteAdministrativo
            // 
            this.menuClienteAdministrativo.Name = "menuClienteAdministrativo";
            this.menuClienteAdministrativo.Size = new System.Drawing.Size(224, 26);
            this.menuClienteAdministrativo.Text = "Cliente";
            this.menuClienteAdministrativo.Click += new System.EventHandler(this.menuClienteAdministrativo_Click);
            // 
            // menuAvanzado
            // 
            this.menuAvanzado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuIngresarUusarioBasicos,
            this.menuingresarDeportes,
            this.menuIngresarEjercicios});
            this.menuAvanzado.Name = "menuAvanzado";
            this.menuAvanzado.Size = new System.Drawing.Size(224, 26);
            this.menuAvanzado.Text = "Avanzado";
            this.menuAvanzado.Click += new System.EventHandler(this.menuAvanzado_Click);
            // 
            // menuIngresarUusarioBasicos
            // 
            this.menuIngresarUusarioBasicos.Name = "menuIngresarUusarioBasicos";
            this.menuIngresarUusarioBasicos.Size = new System.Drawing.Size(262, 26);
            this.menuIngresarUusarioBasicos.Text = " Ingresar Usuarios Básicos";
            this.menuIngresarUusarioBasicos.Click += new System.EventHandler(this.menuIngresarUusarioBasicos_Click);
            // 
            // menuingresarDeportes
            // 
            this.menuingresarDeportes.Name = "menuingresarDeportes";
            this.menuingresarDeportes.Size = new System.Drawing.Size(262, 26);
            this.menuingresarDeportes.Text = "  Deportes Ingresar";
            this.menuingresarDeportes.Click += new System.EventHandler(this.menuingresarDeportes_Click);
            // 
            // menuIngresarEjercicios
            // 
            this.menuIngresarEjercicios.Name = "menuIngresarEjercicios";
            this.menuIngresarEjercicios.Size = new System.Drawing.Size(262, 26);
            this.menuIngresarEjercicios.Text = "Ingresar Ejercicios";
            this.menuIngresarEjercicios.Click += new System.EventHandler(this.menuIngresarEjercicios_Click);
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
            this.menuLogin.Size = new System.Drawing.Size(129, 26);
            this.menuLogin.Text = "Login";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(129, 26);
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
            this.IsMdiContainer = true;
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
        public System.Windows.Forms.ToolStripMenuItem menuIngresar;
        public System.Windows.Forms.ToolStripMenuItem menuLogin;
        public System.Windows.Forms.ToolStripMenuItem menuSalir;
        public System.Windows.Forms.ToolStripMenuItem menuAgenda;
        public System.Windows.Forms.ToolStripMenuItem menuRutina;
        public System.Windows.Forms.ToolStripMenuItem menuRendimiento;
        public System.Windows.Forms.ToolStripMenuItem menuAgendaEntrenador;
        public System.Windows.Forms.ToolStripMenuItem menuCalificarEntrenador;
        public System.Windows.Forms.ToolStripMenuItem menuAsignarEntrenamiento;
        public System.Windows.Forms.ToolStripMenuItem administrativoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menuCalendario;
        public System.Windows.Forms.ToolStripMenuItem menuClienteAdministrativo;
        public System.Windows.Forms.ToolStripMenuItem menuAvanzado;
        public System.Windows.Forms.ToolStripMenuItem menuIngresarUusarioBasicos;
        public System.Windows.Forms.ToolStripMenuItem menuingresarDeportes;
        public System.Windows.Forms.ToolStripMenuItem menuIngresarEjercicios;
    }
}