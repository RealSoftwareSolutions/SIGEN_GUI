using System.Data.SqlTypes;

namespace SIGEN_GUI
{
    partial class SeleccionadordeIdioma
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
            this.btnButtonEspaniol = new System.Windows.Forms.Button();
            this.btnButtonIngles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnButtonEspaniol
            // 
            this.btnButtonEspaniol.BackColor = System.Drawing.SystemColors.Control;
            this.btnButtonEspaniol.Image = global::SIGEN_GUI.Properties.Resources.espanol_es;
            this.btnButtonEspaniol.Location = new System.Drawing.Point(465, 134);
            this.btnButtonEspaniol.Name = "btnButtonEspaniol";
            this.btnButtonEspaniol.Size = new System.Drawing.Size(282, 138);
            this.btnButtonEspaniol.TabIndex = 1;
            this.btnButtonEspaniol.UseVisualStyleBackColor = false;
            this.btnButtonEspaniol.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnButtonIngles
            // 
            this.btnButtonIngles.Image = global::SIGEN_GUI.Properties.Resources.ingles_en;
            this.btnButtonIngles.Location = new System.Drawing.Point(85, 134);
            this.btnButtonIngles.Name = "btnButtonIngles";
            this.btnButtonIngles.Size = new System.Drawing.Size(282, 138);
            this.btnButtonIngles.TabIndex = 2;
            this.btnButtonIngles.UseVisualStyleBackColor = true;
            // 
            // SeleccionadordeIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnButtonIngles);
            this.Controls.Add(this.btnButtonEspaniol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SeleccionadordeIdioma";
            this.Text = "Selecciona Idioma";
            this.Load += new System.EventHandler(this.SeleccionadorIdioma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnButtonEspaniol;
        private System.Windows.Forms.Button btnButtonIngles;
    }
}