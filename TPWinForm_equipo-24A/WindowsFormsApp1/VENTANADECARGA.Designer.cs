namespace WindowsFormsApp1
{
    partial class frmCarga
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblIdCat = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cboIdMarca = new System.Windows.Forms.ComboBox();
            this.cboIdCat = new System.Windows.Forms.ComboBox();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.lblImg = new System.Windows.Forms.Label();
            this.pictureBoxArt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(92, 100);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(80, 25);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(92, 167);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.Location = new System.Drawing.Point(92, 302);
            this.lblIdMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(98, 25);
            this.lblIdMarca.TabIndex = 3;
            this.lblIdMarca.Text = "ID Marca";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(92, 242);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(125, 25);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ingrese el producto:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(276, 167);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(238, 31);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(276, 242);
            this.txtDes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(238, 31);
            this.txtDes.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(276, 100);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(238, 31);
            this.txtCodigo.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(450, 569);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(184, 48);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(666, 569);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(190, 48);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(92, 425);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(73, 25);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio";
            // 
            // lblIdCat
            // 
            this.lblIdCat.AutoSize = true;
            this.lblIdCat.Location = new System.Drawing.Point(92, 365);
            this.lblIdCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdCat.Name = "lblIdCat";
            this.lblIdCat.Size = new System.Drawing.Size(131, 25);
            this.lblIdCat.TabIndex = 14;
            this.lblIdCat.Text = "ID Categoría";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(276, 425);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(238, 31);
            this.txtPrecio.TabIndex = 5;
            // 
            // cboIdMarca
            // 
            this.cboIdMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdMarca.FormattingEnabled = true;
            this.cboIdMarca.Location = new System.Drawing.Point(276, 296);
            this.cboIdMarca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboIdMarca.Name = "cboIdMarca";
            this.cboIdMarca.Size = new System.Drawing.Size(238, 33);
            this.cboIdMarca.TabIndex = 3;
            // 
            // cboIdCat
            // 
            this.cboIdCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdCat.FormattingEnabled = true;
            this.cboIdCat.Location = new System.Drawing.Point(276, 365);
            this.cboIdCat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboIdCat.Name = "cboIdCat";
            this.cboIdCat.Size = new System.Drawing.Size(238, 33);
            this.cboIdCat.TabIndex = 4;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(276, 492);
            this.txtUrlImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(238, 31);
            this.txtUrlImagen.TabIndex = 15;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Location = new System.Drawing.Point(92, 492);
            this.lblImg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(130, 25);
            this.lblImg.TabIndex = 16;
            this.lblImg.Text = "URL Imagen";
            // 
            // pictureBoxArt
            // 
            this.pictureBoxArt.Location = new System.Drawing.Point(666, 100);
            this.pictureBoxArt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBoxArt.Name = "pictureBoxArt";
            this.pictureBoxArt.Size = new System.Drawing.Size(572, 431);
            this.pictureBoxArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArt.TabIndex = 17;
            this.pictureBoxArt.TabStop = false;
            // 
            // frmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 683);
            this.Controls.Add(this.pictureBoxArt);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.cboIdCat);
            this.Controls.Add(this.cboIdMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblIdCat);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblIdMarca);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana de carga";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblIdCat;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cboIdMarca;
        private System.Windows.Forms.ComboBox cboIdCat;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.PictureBox pictureBoxArt;
    }
}

