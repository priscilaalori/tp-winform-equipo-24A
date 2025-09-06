namespace WindowsFormsApp1
{
    partial class frmAgregarMarca
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
            this.textMarca = new System.Windows.Forms.TextBox();
            this.labelAgregarMarca = new System.Windows.Forms.Label();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(121, 47);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(100, 20);
            this.textMarca.TabIndex = 0;
            // 
            // labelAgregarMarca
            // 
            this.labelAgregarMarca.AutoSize = true;
            this.labelAgregarMarca.Location = new System.Drawing.Point(128, 22);
            this.labelAgregarMarca.Name = "labelAgregarMarca";
            this.labelAgregarMarca.Size = new System.Drawing.Size(82, 13);
            this.labelAgregarMarca.TabIndex = 1;
            this.labelAgregarMarca.Text = "Ingrese Nombre";
            this.labelAgregarMarca.Click += new System.EventHandler(this.labelAgregarMarca_Click);
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.Location = new System.Drawing.Point(188, 85);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarMarca.TabIndex = 2;
            this.btnGuardarMarca.Text = "Guardar";
            this.btnGuardarMarca.UseVisualStyleBackColor = true;
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(90, 85);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 192);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarMarca);
            this.Controls.Add(this.labelAgregarMarca);
            this.Controls.Add(this.textMarca);
            this.Name = "frmAgregarMarca";
            this.Text = "Agregar Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.Label labelAgregarMarca;
        private System.Windows.Forms.Button btnGuardarMarca;
        private System.Windows.Forms.Button btnCancelar;
    }
}