namespace ABMproductosRicardo
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lstProducto = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.rbtNetBook = new System.Windows.Forms.RadioButton();
            this.rbtNoteBook = new System.Windows.Forms.RadioButton();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lbldetalle = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(265, 296);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(61, 23);
            this.btnBorrar.TabIndex = 38;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(190, 296);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(61, 23);
            this.btnEditar.TabIndex = 37;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(193, 227);
            this.txtPrecio.MaxLength = 7;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 29;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(132, 227);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 36;
            this.lblprecio.Text = "Precio";
            // 
            // lstProducto
            // 
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.Location = new System.Drawing.Point(410, 55);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(120, 225);
            this.lstProducto.TabIndex = 35;
            this.lstProducto.SelectedIndexChanged += new System.EventHandler(this.lstProducto_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(490, 296);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(61, 23);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(415, 296);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(61, 23);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(340, 296);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(61, 23);
            this.btnGrabar.TabIndex = 32;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(115, 296);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(61, 23);
            this.btnNuevo.TabIndex = 31;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(193, 260);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 30;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // rbtNetBook
            // 
            this.rbtNetBook.AutoSize = true;
            this.rbtNetBook.Location = new System.Drawing.Point(193, 192);
            this.rbtNetBook.Name = "rbtNetBook";
            this.rbtNetBook.Size = new System.Drawing.Size(81, 17);
            this.rbtNetBook.TabIndex = 28;
            this.rbtNetBook.TabStop = true;
            this.rbtNetBook.Text = "2 - Netbook";
            this.rbtNetBook.UseVisualStyleBackColor = true;
            this.rbtNetBook.CheckedChanged += new System.EventHandler(this.rbtNetBook_CheckedChanged);
            // 
            // rbtNoteBook
            // 
            this.rbtNoteBook.AutoSize = true;
            this.rbtNoteBook.Location = new System.Drawing.Point(193, 159);
            this.rbtNoteBook.Name = "rbtNoteBook";
            this.rbtNoteBook.Size = new System.Drawing.Size(87, 17);
            this.rbtNoteBook.TabIndex = 26;
            this.rbtNoteBook.TabStop = true;
            this.rbtNoteBook.Text = "1 - Notebook";
            this.rbtNoteBook.UseVisualStyleBackColor = true;
            this.rbtNoteBook.CheckedChanged += new System.EventHandler(this.rbtNoteBook_CheckedChanged);
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(193, 122);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 24;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(193, 86);
            this.txtDetalle.MaxLength = 150;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(200, 20);
            this.txtDetalle.TabIndex = 21;
            this.txtDetalle.TextChanged += new System.EventHandler(this.txtDetalle_TextChanged);
            this.txtDetalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDetalle_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(193, 50);
            this.txtCodigo.MaxLength = 999;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 20;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(132, 262);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(37, 13);
            this.lblfecha.TabIndex = 27;
            this.lblfecha.Text = "Fecha";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(141, 174);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(28, 13);
            this.lbltipo.TabIndex = 25;
            this.lbltipo.Text = "Tipo";
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(132, 126);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(37, 13);
            this.lblmarca.TabIndex = 23;
            this.lblmarca.Text = "Marca";
            // 
            // lbldetalle
            // 
            this.lbldetalle.AutoSize = true;
            this.lbldetalle.Location = new System.Drawing.Point(129, 87);
            this.lbldetalle.Name = "lbldetalle";
            this.lbldetalle.Size = new System.Drawing.Size(40, 13);
            this.lbldetalle.TabIndex = 22;
            this.lbldetalle.Text = "Detalle";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(129, 52);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 19;
            this.lblcodigo.Text = "Código";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lstProducto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.rbtNetBook);
            this.Controls.Add(this.rbtNoteBook);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.lbldetalle);
            this.Controls.Add(this.lblcodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.ListBox lstProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.RadioButton rbtNetBook;
        private System.Windows.Forms.RadioButton rbtNoteBook;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lbldetalle;
        private System.Windows.Forms.Label lblcodigo;
    }
}

