namespace FormularioSimpleACT1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnValidar = new System.Windows.Forms.Button();
            this.txtPrimeracontraseña = new System.Windows.Forms.TextBox();
            this.txtrepetircontraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(253, 265);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(276, 71);
            this.btnValidar.TabIndex = 0;
            this.btnValidar.Text = "VALIDAR";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // txtPrimeracontraseña
            // 
            this.txtPrimeracontraseña.Location = new System.Drawing.Point(206, 91);
            this.txtPrimeracontraseña.Name = "txtPrimeracontraseña";
            this.txtPrimeracontraseña.Size = new System.Drawing.Size(365, 20);
            this.txtPrimeracontraseña.TabIndex = 1;
            // 
            // txtrepetircontraseña
            // 
            this.txtrepetircontraseña.Location = new System.Drawing.Point(205, 158);
            this.txtrepetircontraseña.Name = "txtrepetircontraseña";
            this.txtrepetircontraseña.Size = new System.Drawing.Size(366, 20);
            this.txtrepetircontraseña.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Repetir Contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrepetircontraseña);
            this.Controls.Add(this.txtPrimeracontraseña);
            this.Controls.Add(this.btnValidar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TextBox txtPrimeracontraseña;
        private System.Windows.Forms.TextBox txtrepetircontraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

