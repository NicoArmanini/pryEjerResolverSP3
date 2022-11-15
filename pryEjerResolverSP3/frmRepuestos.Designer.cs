namespace pryEjerResolverSP3
{
    partial class frmRepuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepuestos));
            this.mrcDatosRep = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.mrcOrigen = new System.Windows.Forms.GroupBox();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.mrcRepIngresados = new System.Windows.Forms.GroupBox();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.cmbMarca1 = new System.Windows.Forms.ComboBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.mrcOrigen1 = new System.Windows.Forms.GroupBox();
            this.optImportado1 = new System.Windows.Forms.RadioButton();
            this.optNacional1 = new System.Windows.Forms.RadioButton();
            this.lblMarca1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mrcDatosRep.SuspendLayout();
            this.mrcOrigen.SuspendLayout();
            this.mrcRepIngresados.SuspendLayout();
            this.mrcOrigen1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcDatosRep
            // 
            this.mrcDatosRep.Controls.Add(this.txtDescripcion);
            this.mrcDatosRep.Controls.Add(this.cmbMarca);
            this.mrcDatosRep.Controls.Add(this.lblDescripcion);
            this.mrcDatosRep.Controls.Add(this.mrcOrigen);
            this.mrcDatosRep.Controls.Add(this.txtPrecio);
            this.mrcDatosRep.Controls.Add(this.txtNumero);
            this.mrcDatosRep.Controls.Add(this.lblPrecio);
            this.mrcDatosRep.Controls.Add(this.lblNumero);
            this.mrcDatosRep.Controls.Add(this.lblMarca);
            this.mrcDatosRep.Location = new System.Drawing.Point(21, 32);
            this.mrcDatosRep.Margin = new System.Windows.Forms.Padding(4);
            this.mrcDatosRep.Name = "mrcDatosRep";
            this.mrcDatosRep.Padding = new System.Windows.Forms.Padding(4);
            this.mrcDatosRep.Size = new System.Drawing.Size(703, 281);
            this.mrcDatosRep.TabIndex = 0;
            this.mrcDatosRep.TabStop = false;
            this.mrcDatosRep.Text = "Datos de Repuestos";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(155, 164);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(485, 101);
            this.txtDescripcion.TabIndex = 10;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Peugeot",
            "Fiat",
            "Renault"});
            this.cmbMarca.Location = new System.Drawing.Point(111, 32);
            this.cmbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(123, 24);
            this.cmbMarca.TabIndex = 9;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Enabled = false;
            this.lblDescripcion.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(31, 203);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(101, 20);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // mrcOrigen
            // 
            this.mrcOrigen.BackColor = System.Drawing.Color.Transparent;
            this.mrcOrigen.Controls.Add(this.optImportado);
            this.mrcOrigen.Controls.Add(this.optNacional);
            this.mrcOrigen.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcOrigen.Location = new System.Drawing.Point(35, 71);
            this.mrcOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.mrcOrigen.Name = "mrcOrigen";
            this.mrcOrigen.Padding = new System.Windows.Forms.Padding(4);
            this.mrcOrigen.Size = new System.Drawing.Size(165, 85);
            this.mrcOrigen.TabIndex = 5;
            this.mrcOrigen.TabStop = false;
            this.mrcOrigen.Text = "Origen";
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optImportado.Location = new System.Drawing.Point(16, 58);
            this.optImportado.Margin = new System.Windows.Forms.Padding(4);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(102, 24);
            this.optImportado.TabIndex = 4;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Checked = true;
            this.optNacional.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNacional.Location = new System.Drawing.Point(17, 30);
            this.optNacional.Margin = new System.Windows.Forms.Padding(4);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(92, 24);
            this.optNacional.TabIndex = 3;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(473, 105);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.MaxLength = 10000;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(123, 22);
            this.txtPrecio.TabIndex = 7;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(473, 36);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.MaxLength = 6;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(123, 22);
            this.txtNumero.TabIndex = 8;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNmero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNmero_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Enabled = false;
            this.lblPrecio.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(400, 111);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(60, 20);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Enabled = false;
            this.lblNumero.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(394, 36);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(71, 20);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numero";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(31, 36);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(59, 20);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // mrcRepIngresados
            // 
            this.mrcRepIngresados.Controls.Add(this.lstDatos);
            this.mrcRepIngresados.Controls.Add(this.cmbMarca1);
            this.mrcRepIngresados.Controls.Add(this.lblDatos);
            this.mrcRepIngresados.Controls.Add(this.mrcOrigen1);
            this.mrcRepIngresados.Controls.Add(this.lblMarca1);
            this.mrcRepIngresados.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcRepIngresados.Location = new System.Drawing.Point(21, 321);
            this.mrcRepIngresados.Margin = new System.Windows.Forms.Padding(4);
            this.mrcRepIngresados.Name = "mrcRepIngresados";
            this.mrcRepIngresados.Padding = new System.Windows.Forms.Padding(4);
            this.mrcRepIngresados.Size = new System.Drawing.Size(703, 275);
            this.mrcRepIngresados.TabIndex = 1;
            this.mrcRepIngresados.TabStop = false;
            this.mrcRepIngresados.Text = "Repuestos Ingresados";
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 20;
            this.lstDatos.Location = new System.Drawing.Point(270, 62);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(406, 204);
            this.lstDatos.TabIndex = 10;
            // 
            // cmbMarca1
            // 
            this.cmbMarca1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca1.FormattingEnabled = true;
            this.cmbMarca1.Items.AddRange(new object[] {
            "Peugeot",
            "Fiat",
            "Renault"});
            this.cmbMarca1.Location = new System.Drawing.Point(111, 39);
            this.cmbMarca1.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMarca1.Name = "cmbMarca1";
            this.cmbMarca1.Size = new System.Drawing.Size(123, 28);
            this.cmbMarca1.TabIndex = 9;
            this.cmbMarca1.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(275, 39);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(159, 20);
            this.lblDatos.TabIndex = 9;
            this.lblDatos.Text = "Datos de Repuestos";
            // 
            // mrcOrigen1
            // 
            this.mrcOrigen1.BackColor = System.Drawing.Color.Transparent;
            this.mrcOrigen1.Controls.Add(this.optImportado1);
            this.mrcOrigen1.Controls.Add(this.optNacional1);
            this.mrcOrigen1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcOrigen1.Location = new System.Drawing.Point(29, 81);
            this.mrcOrigen1.Margin = new System.Windows.Forms.Padding(4);
            this.mrcOrigen1.Name = "mrcOrigen1";
            this.mrcOrigen1.Padding = new System.Windows.Forms.Padding(4);
            this.mrcOrigen1.Size = new System.Drawing.Size(165, 85);
            this.mrcOrigen1.TabIndex = 5;
            this.mrcOrigen1.TabStop = false;
            this.mrcOrigen1.Text = "Origen";
            // 
            // optImportado1
            // 
            this.optImportado1.AutoSize = true;
            this.optImportado1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optImportado1.Location = new System.Drawing.Point(16, 58);
            this.optImportado1.Margin = new System.Windows.Forms.Padding(4);
            this.optImportado1.Name = "optImportado1";
            this.optImportado1.Size = new System.Drawing.Size(102, 24);
            this.optImportado1.TabIndex = 4;
            this.optImportado1.Text = "Importado";
            this.optImportado1.UseVisualStyleBackColor = true;
            // 
            // optNacional1
            // 
            this.optNacional1.AutoSize = true;
            this.optNacional1.Checked = true;
            this.optNacional1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNacional1.Location = new System.Drawing.Point(17, 30);
            this.optNacional1.Margin = new System.Windows.Forms.Padding(4);
            this.optNacional1.Name = "optNacional1";
            this.optNacional1.Size = new System.Drawing.Size(92, 24);
            this.optNacional1.TabIndex = 3;
            this.optNacional1.TabStop = true;
            this.optNacional1.Text = "Nacional";
            this.optNacional1.UseVisualStyleBackColor = true;
            // 
            // lblMarca1
            // 
            this.lblMarca1.AutoSize = true;
            this.lblMarca1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca1.Location = new System.Drawing.Point(35, 43);
            this.lblMarca1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca1.Name = "lblMarca1";
            this.lblMarca1.Size = new System.Drawing.Size(59, 20);
            this.lblMarca1.TabIndex = 0;
            this.lblMarca1.Text = "Marca";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(763, 75);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(115, 39);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(765, 145);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 43);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(766, 337);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(112, 47);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(905, 609);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mrcRepIngresados);
            this.Controls.Add(this.mrcDatosRep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRepuestos";
            this.Text = "Repuestos";
            this.mrcDatosRep.ResumeLayout(false);
            this.mrcDatosRep.PerformLayout();
            this.mrcOrigen.ResumeLayout(false);
            this.mrcOrigen.PerformLayout();
            this.mrcRepIngresados.ResumeLayout(false);
            this.mrcRepIngresados.PerformLayout();
            this.mrcOrigen1.ResumeLayout(false);
            this.mrcOrigen1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDatosRep;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox mrcRepIngresados;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.GroupBox mrcOrigen1;
        private System.Windows.Forms.RadioButton optImportado1;
        private System.Windows.Forms.RadioButton optNacional1;
        private System.Windows.Forms.Label lblMarca1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbMarca1;
        private System.Windows.Forms.GroupBox mrcOrigen;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.ListBox lstDatos;
    }
}

