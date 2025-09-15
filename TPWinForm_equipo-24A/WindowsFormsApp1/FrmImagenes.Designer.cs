namespace WindowsFormsApp1
{
    partial class FrmImagenes
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
            this.dvgImagen = new System.Windows.Forms.DataGridView();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgImagen
            // 
            this.dvgImagen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgImagen.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgImagen.Location = new System.Drawing.Point(54, 67);
            this.dvgImagen.MultiSelect = false;
            this.dvgImagen.Name = "dvgImagen";
            this.dvgImagen.RowHeadersWidth = 82;
            this.dvgImagen.RowTemplate.Height = 33;
            this.dvgImagen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgImagen.Size = new System.Drawing.Size(882, 427);
            this.dvgImagen.TabIndex = 0;
            this.dvgImagen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgImagen_CellContentClick);
            this.dvgImagen.SelectionChanged += new System.EventHandler(this.dvgImagen_SelectionChanged);
            // 
            // picImagen
            // 
            this.picImagen.Location = new System.Drawing.Point(969, 66);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(403, 427);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagen.TabIndex = 1;
            this.picImagen.TabStop = false;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(59, 536);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(204, 25);
            this.lblURL.TabIndex = 2;
            this.lblURL.Text = "URL Nueva imagen:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(269, 530);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(340, 31);
            this.txtURL.TabIndex = 3;
            this.txtURL.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(615, 528);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 41);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(969, 520);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(252, 41);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar seleccionado";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 645);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.dvgImagen);
            this.Name = "FrmImagenes";
            this.Text = "FrmImagenes";
            this.Load += new System.EventHandler(this.FrmImagenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgImagen;
        public System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
    }
}