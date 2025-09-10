namespace WindowsFormsApp1
{
    partial class frmListaMarcas
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(12, 24);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(253, 140);
            this.dgvMarcas.TabIndex = 0;
            this.dgvMarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarcas_CellContentClick);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(271, 24);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(150, 23);
            this.btnAgregarMarca.TabIndex = 1;
            this.btnAgregarMarca.Text = "Agregar Marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Location = new System.Drawing.Point(271, 71);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(150, 23);
            this.btnModificarMarca.TabIndex = 2;
            this.btnModificarMarca.Text = "Modificar Marca";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(271, 116);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(150, 23);
            this.btnEliminarMarca.TabIndex = 3;
            this.btnEliminarMarca.Text = "Eliminar Marca";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // frmListaMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.dgvMarcas);
            this.Name = "frmListaMarcas";
            this.Text = "frmListaMarca";
            this.Load += new System.EventHandler(this.frmListaMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
    }
}