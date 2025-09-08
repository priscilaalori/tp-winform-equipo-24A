namespace WindowsFormsApp1
{
    partial class FmrInicio
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
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(164, 83);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(139, 33);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar artículos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(164, 132);
            this.btnCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(139, 36);
            this.btnCategoria.TabIndex = 5;
            this.btnCategoria.Text = "Listar Categorías";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnMarca
            // 
            this.btnMarca.Location = new System.Drawing.Point(164, 185);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(139, 36);
            this.btnMarca.TabIndex = 5;
            this.btnMarca.Text = "Administrar Marcas";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // FmrInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 374);
            this.Controls.Add(this.btnMarca);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.btnListar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FmrInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidx";
            this.Load += new System.EventHandler(this.FmrInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnMarca;
    }
}