namespace SIGEN_GUI
{
    partial class Login
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
            this.LoginUser = new System.Windows.Forms.TextBox();
            this.PassWorldLogin = new System.Windows.Forms.TextBox();
            this.IngresarLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginUser
            // 
            this.LoginUser.Location = new System.Drawing.Point(339, 195);
            this.LoginUser.Name = "LoginUser";
            this.LoginUser.Size = new System.Drawing.Size(100, 22);
            this.LoginUser.TabIndex = 0;
            this.LoginUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PassWorldLogin
            // 
            this.PassWorldLogin.Location = new System.Drawing.Point(339, 223);
            this.PassWorldLogin.Name = "PassWorldLogin";
            this.PassWorldLogin.Size = new System.Drawing.Size(100, 22);
            this.PassWorldLogin.TabIndex = 1;
            // 
            // IngresarLogin
            // 
            this.IngresarLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.IngresarLogin.Location = new System.Drawing.Point(351, 251);
            this.IngresarLogin.Name = "IngresarLogin";
            this.IngresarLogin.Size = new System.Drawing.Size(75, 23);
            this.IngresarLogin.TabIndex = 2;
            this.IngresarLogin.Text = "Ingresar";
            this.IngresarLogin.UseVisualStyleBackColor = false;
            this.IngresarLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IngresarLogin);
            this.Controls.Add(this.PassWorldLogin);
            this.Controls.Add(this.LoginUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginUser;
        private System.Windows.Forms.TextBox PassWorldLogin;
        private System.Windows.Forms.Button IngresarLogin;
    }
}