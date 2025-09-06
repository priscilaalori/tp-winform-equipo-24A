namespace WindowsFormsApp1
{
    partial class frmListaProductos
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
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.agregarArt = new System.Windows.Forms.Button();
            this.dgvArt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(418, 136);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(139, 30);
            this.btnDetalle.TabIndex = 11;
            this.btnDetalle.Text = "Ver detalle del artículo";
            this.btnDetalle.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(418, 188);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 35);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar artículo por código";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(418, 86);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(139, 36);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar artículo";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(418, 31);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(139, 36);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar artículos";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 77);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(4, 4);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // agregarArt
            // 
            this.agregarArt.Location = new System.Drawing.Point(418, 240);
            this.agregarArt.Margin = new System.Windows.Forms.Padding(2);
            this.agregarArt.Name = "agregarArt";
            this.agregarArt.Size = new System.Drawing.Size(139, 36);
            this.agregarArt.TabIndex = 12;
            this.agregarArt.Text = "Agregar articulo";
            this.agregarArt.UseVisualStyleBackColor = true;
            // 
            // dgvArt
            // 
            this.dgvArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArt.Location = new System.Drawing.Point(12, 31);
            this.dgvArt.Name = "dgvArt";
            this.dgvArt.Size = new System.Drawing.Size(360, 245);
            this.dgvArt.TabIndex = 13;
            this.dgvArt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArt_CellContentClick);
            // 
            // frmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 462);
            this.Controls.Add(this.dgvArt);
            this.Controls.Add(this.agregarArt);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListaProductos";
            this.Text = "frmListaProductos";
            this.Load += new System.EventHandler(this.frmLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button agregarArt;
        private System.Windows.Forms.DataGridView dgvArt;
    }
}