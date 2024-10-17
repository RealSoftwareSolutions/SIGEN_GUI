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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.mstPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuAplicasiones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRutina = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRendimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEntrenador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgendaEntrenador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalificarEntrenador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAsignarEntrenamiento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeleccionador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdministrativo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalendario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClienteAdministrativo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAvanzado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIngresarUusarioBasicos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuingresarDeportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIngresarEjercicios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdministradorTI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIngresarEntrenador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIngresarClub = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIngresar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mstPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstPrincipal
            // 
            this.mstPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAplicasiones,
            this.menuIngresar});
            this.mstPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstPrincipal.Name = "mstPrincipal";
            this.mstPrincipal.Size = new System.Drawing.Size(775, 24);
            this.mstPrincipal.TabIndex = 0;
            this.mstPrincipal.Text = "SIGEN";
            // 
            // menuAplicasiones
            // 
            this.menuAplicasiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuEntrenador,
            this.menuSeleccionador,
            this.menuAdministrativo,
            this.menuAvanzado,
            this.menuAdministradorTI});
            this.menuAplicasiones.Font = new System.Drawing.Font("Algerian", 9F);
            this.menuAplicasiones.Name = "menuAplicasiones";
            this.menuAplicasiones.Size = new System.Drawing.Size(122, 20);
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
            this.menuClientes.Text = "Cliente";
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuAgenda
            // 
            this.menuAgenda.Name = "menuAgenda";
            this.menuAgenda.Size = new System.Drawing.Size(182, 26);
            this.menuAgenda.Text = "Agenda";
            this.menuAgenda.Click += new System.EventHandler(this.menuAgenda_Click);
            // 
            // menuRutina
            // 
            this.menuRutina.Name = "menuRutina";
            this.menuRutina.Size = new System.Drawing.Size(182, 26);
            this.menuRutina.Text = "Rutina";
            this.menuRutina.Click += new System.EventHandler(this.menuRutina_Click);
            // 
            // menuRendimiento
            // 
            this.menuRendimiento.Name = "menuRendimiento";
            this.menuRendimiento.Size = new System.Drawing.Size(182, 26);
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
            this.menuAgendaEntrenador.Size = new System.Drawing.Size(274, 26);
            this.menuAgendaEntrenador.Text = "Agenda";
            this.menuAgendaEntrenador.Click += new System.EventHandler(this.menuAgendaEntrenador_Click);
            // 
            // menuCalificarEntrenador
            // 
            this.menuCalificarEntrenador.Name = "menuCalificarEntrenador";
            this.menuCalificarEntrenador.Size = new System.Drawing.Size(274, 26);
            this.menuCalificarEntrenador.Text = "Calificar";
            this.menuCalificarEntrenador.Click += new System.EventHandler(this.menuCalificarEntrenador_Click);
            // 
            // menuAsignarEntrenamiento
            // 
            this.menuAsignarEntrenamiento.Name = "menuAsignarEntrenamiento";
            this.menuAsignarEntrenamiento.Size = new System.Drawing.Size(274, 26);
            this.menuAsignarEntrenamiento.Text = "Asignar Entrenamiento";
            this.menuAsignarEntrenamiento.Click += new System.EventHandler(this.menuAsignarEntrenamiento_Click);
            // 
            // menuSeleccionador
            // 
            this.menuSeleccionador.Name = "menuSeleccionador";
            this.menuSeleccionador.Size = new System.Drawing.Size(224, 26);
            this.menuSeleccionador.Text = "Seleccionador";
            this.menuSeleccionador.Click += new System.EventHandler(this.menuSeleccionador_Click);
            // 
            // menuAdministrativo
            // 
            this.menuAdministrativo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCalendario,
            this.menuClienteAdministrativo});
            this.menuAdministrativo.Name = "menuAdministrativo";
            this.menuAdministrativo.Size = new System.Drawing.Size(224, 26);
            this.menuAdministrativo.Text = "Administrativo";
            this.menuAdministrativo.Click += new System.EventHandler(this.menuAdministrativo_Click);
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
            this.menuIngresarUusarioBasicos.Size = new System.Drawing.Size(301, 26);
            this.menuIngresarUusarioBasicos.Text = " Ingresar Usuarios Básicos";
            this.menuIngresarUusarioBasicos.Click += new System.EventHandler(this.menuIngresarUusarioBasicos_Click);
            // 
            // menuingresarDeportes
            // 
            this.menuingresarDeportes.Name = "menuingresarDeportes";
            this.menuingresarDeportes.Size = new System.Drawing.Size(301, 26);
            this.menuingresarDeportes.Text = "  Deportes Ingresar";
            this.menuingresarDeportes.Click += new System.EventHandler(this.menuingresarDeportes_Click);
            // 
            // menuIngresarEjercicios
            // 
            this.menuIngresarEjercicios.Name = "menuIngresarEjercicios";
            this.menuIngresarEjercicios.Size = new System.Drawing.Size(301, 26);
            this.menuIngresarEjercicios.Text = "Ingresar Ejercicios";
            this.menuIngresarEjercicios.Click += new System.EventHandler(this.menuIngresarEjercicios_Click);
            // 
            // menuAdministradorTI
            // 
            this.menuAdministradorTI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuIngresarEntrenador,
            this.menuIngresarClub});
            this.menuAdministradorTI.ForeColor = System.Drawing.Color.Cyan;
            this.menuAdministradorTI.Name = "menuAdministradorTI";
            this.menuAdministradorTI.Size = new System.Drawing.Size(224, 26);
            this.menuAdministradorTI.Text = "AdministradorTI";
            this.menuAdministradorTI.Click += new System.EventHandler(this.menuAdministrador_Click);
            // 
            // menuIngresarEntrenador
            // 
            this.menuIngresarEntrenador.Name = "menuIngresarEntrenador";
            this.menuIngresarEntrenador.Size = new System.Drawing.Size(258, 26);
            this.menuIngresarEntrenador.Text = "Ingresar Entrenador";
            // 
            // menuIngresarClub
            // 
            this.menuIngresarClub.Name = "menuIngresarClub";
            this.menuIngresarClub.Size = new System.Drawing.Size(258, 26);
            this.menuIngresarClub.Text = "Ingresar Club";
            // 
            // menuIngresar
            // 
            this.menuIngresar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.menuSalir});
            this.menuIngresar.Font = new System.Drawing.Font("Algerian", 9F);
            this.menuIngresar.Name = "menuIngresar";
            this.menuIngresar.Size = new System.Drawing.Size(93, 20);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 483);
            this.Controls.Add(this.mstPrincipal);
            this.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstPrincipal;
            this.Name = "Principal";
            this.Text = "SIGEN";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.mstPrincipal.ResumeLayout(false);
            this.mstPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstPrincipal;
        public System.Windows.Forms.ToolStripMenuItem menuAplicasiones;
        public System.Windows.Forms.ToolStripMenuItem menuClientes;
        public System.Windows.Forms.ToolStripMenuItem menuEntrenador;
        public System.Windows.Forms.ToolStripMenuItem menuAdministradorTI;
        public System.Windows.Forms.ToolStripMenuItem menuIngresar;
        public System.Windows.Forms.ToolStripMenuItem menuLogin;
        public System.Windows.Forms.ToolStripMenuItem menuSalir;
        public System.Windows.Forms.ToolStripMenuItem menuAgenda;
        public System.Windows.Forms.ToolStripMenuItem menuRutina;
        public System.Windows.Forms.ToolStripMenuItem menuRendimiento;
        public System.Windows.Forms.ToolStripMenuItem menuAgendaEntrenador;
        public System.Windows.Forms.ToolStripMenuItem menuCalificarEntrenador;
        public System.Windows.Forms.ToolStripMenuItem menuAsignarEntrenamiento;
        public System.Windows.Forms.ToolStripMenuItem menuAdministrativo;
        public System.Windows.Forms.ToolStripMenuItem menuCalendario;
        public System.Windows.Forms.ToolStripMenuItem menuClienteAdministrativo;
        public System.Windows.Forms.ToolStripMenuItem menuAvanzado;
        public System.Windows.Forms.ToolStripMenuItem menuIngresarUusarioBasicos;
        public System.Windows.Forms.ToolStripMenuItem menuingresarDeportes;
        public System.Windows.Forms.ToolStripMenuItem menuIngresarEjercicios;
        public System.Windows.Forms.ToolStripMenuItem menuIngresarEntrenador;
        public System.Windows.Forms.ToolStripMenuItem menuIngresarClub;
        public System.Windows.Forms.ToolStripMenuItem menuSeleccionador;
    }
}