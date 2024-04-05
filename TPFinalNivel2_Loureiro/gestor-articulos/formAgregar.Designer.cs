namespace gestor_articulos
{
    partial class formAgregar
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTituloAgregar = new System.Windows.Forms.Label();
            this.btnCerrarAlta = new System.Windows.Forms.Button();
            this.btnMaximizarAlta = new System.Windows.Forms.Button();
            this.btnMinimizarAlta = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblImagenUrl = new System.Windows.Forms.Label();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.pictureBoxAgregar = new System.Windows.Forms.PictureBox();
            this.btnImagenLocal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(57, 67);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(57, 104);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(57, 139);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(122, 64);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(149, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(122, 136);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(149, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(152, 330);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 26);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(275, 330);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 26);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTituloAgregar
            // 
            this.lblTituloAgregar.AutoSize = true;
            this.lblTituloAgregar.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAgregar.Location = new System.Drawing.Point(16, 8);
            this.lblTituloAgregar.Name = "lblTituloAgregar";
            this.lblTituloAgregar.Size = new System.Drawing.Size(90, 14);
            this.lblTituloAgregar.TabIndex = 8;
            this.lblTituloAgregar.Text = "Nuevo Articulo";
            // 
            // btnCerrarAlta
            // 
            this.btnCerrarAlta.FlatAppearance.BorderSize = 0;
            this.btnCerrarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarAlta.Image = global::gestor_articulos.Properties.Resources.cerrarW__2_;
            this.btnCerrarAlta.Location = new System.Drawing.Point(535, 3);
            this.btnCerrarAlta.Name = "btnCerrarAlta";
            this.btnCerrarAlta.Size = new System.Drawing.Size(22, 22);
            this.btnCerrarAlta.TabIndex = 9;
            this.btnCerrarAlta.UseVisualStyleBackColor = true;
            this.btnCerrarAlta.Click += new System.EventHandler(this.btnCerrarAlta_Click);
            // 
            // btnMaximizarAlta
            // 
            this.btnMaximizarAlta.Enabled = false;
            this.btnMaximizarAlta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximizarAlta.FlatAppearance.BorderSize = 0;
            this.btnMaximizarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizarAlta.Image = global::gestor_articulos.Properties.Resources.maximizarW__1_;
            this.btnMaximizarAlta.Location = new System.Drawing.Point(505, 1);
            this.btnMaximizarAlta.Name = "btnMaximizarAlta";
            this.btnMaximizarAlta.Size = new System.Drawing.Size(24, 24);
            this.btnMaximizarAlta.TabIndex = 10;
            this.btnMaximizarAlta.UseVisualStyleBackColor = true;
            // 
            // btnMinimizarAlta
            // 
            this.btnMinimizarAlta.FlatAppearance.BorderSize = 0;
            this.btnMinimizarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarAlta.Image = global::gestor_articulos.Properties.Resources.minimizarW__1_;
            this.btnMinimizarAlta.Location = new System.Drawing.Point(478, 2);
            this.btnMinimizarAlta.Name = "btnMinimizarAlta";
            this.btnMinimizarAlta.Size = new System.Drawing.Size(21, 23);
            this.btnMinimizarAlta.TabIndex = 11;
            this.btnMinimizarAlta.UseVisualStyleBackColor = true;
            this.btnMinimizarAlta.Click += new System.EventHandler(this.btnMinimizarAlta_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(57, 247);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 12;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(57, 281);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoria";
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(122, 244);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(149, 21);
            this.cbxMarca.TabIndex = 5;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(122, 278);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(149, 21);
            this.cbxCategoria.TabIndex = 6;
            // 
            // lblImagenUrl
            // 
            this.lblImagenUrl.AutoSize = true;
            this.lblImagenUrl.Location = new System.Drawing.Point(57, 175);
            this.lblImagenUrl.Name = "lblImagenUrl";
            this.lblImagenUrl.Size = new System.Drawing.Size(55, 13);
            this.lblImagenUrl.TabIndex = 16;
            this.lblImagenUrl.Text = "ImagenUrl";
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.Location = new System.Drawing.Point(122, 172);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(149, 20);
            this.txtImagenUrl.TabIndex = 3;
            this.txtImagenUrl.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(122, 207);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(149, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(57, 210);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 19;
            this.lblPrecio.Text = "Precio";
            // 
            // pictureBoxAgregar
            // 
            this.pictureBoxAgregar.Location = new System.Drawing.Point(305, 81);
            this.pictureBoxAgregar.Name = "pictureBoxAgregar";
            this.pictureBoxAgregar.Size = new System.Drawing.Size(225, 195);
            this.pictureBoxAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAgregar.TabIndex = 20;
            this.pictureBoxAgregar.TabStop = false;
            // 
            // btnImagenLocal
            // 
            this.btnImagenLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagenLocal.Location = new System.Drawing.Point(275, 172);
            this.btnImagenLocal.Name = "btnImagenLocal";
            this.btnImagenLocal.Size = new System.Drawing.Size(24, 20);
            this.btnImagenLocal.TabIndex = 21;
            this.btnImagenLocal.Text = "+";
            this.btnImagenLocal.UseVisualStyleBackColor = true;
            this.btnImagenLocal.Click += new System.EventHandler(this.btnImagenLocal_Click);
            // 
            // formAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 378);
            this.Controls.Add(this.btnImagenLocal);
            this.Controls.Add(this.pictureBoxAgregar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.lblImagenUrl);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnMinimizarAlta);
            this.Controls.Add(this.btnMaximizarAlta);
            this.Controls.Add(this.btnCerrarAlta);
            this.Controls.Add(this.lblTituloAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formAgregar";
            this.Load += new System.EventHandler(this.formAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTituloAgregar;
        private System.Windows.Forms.Button btnCerrarAlta;
        private System.Windows.Forms.Button btnMaximizarAlta;
        private System.Windows.Forms.Button btnMinimizarAlta;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblImagenUrl;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.PictureBox pictureBoxAgregar;
        private System.Windows.Forms.Button btnImagenLocal;
    }
}