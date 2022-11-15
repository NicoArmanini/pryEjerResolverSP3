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
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNmero = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.mrcRepIntegrados = new System.Windows.Forms.GroupBox();
            this.txtDescripcion1 = new System.Windows.Forms.TextBox();
            this.lblDescripcion1 = new System.Windows.Forms.Label();
            this.txtPrecio1 = new System.Windows.Forms.TextBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.mrcOrigen = new System.Windows.Forms.GroupBox();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPrecio1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblMarca1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbMarca2 = new System.Windows.Forms.ComboBox();
            this.mrcDatosRep.SuspendLayout();
            this.mrcRepIntegrados.SuspendLayout();
            this.mrcOrigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcDatosRep
            // 
            this.mrcDatosRep.Controls.Add(this.txtDescripcion);
            this.mrcDatosRep.Controls.Add(this.cmbMarca);
            this.mrcDatosRep.Controls.Add(this.cmbOrigen);
            this.mrcDatosRep.Controls.Add(this.lblDescripcion);
            this.mrcDatosRep.Controls.Add(this.txtPrecio);
            this.mrcDatosRep.Controls.Add(this.txtNmero);
            this.mrcDatosRep.Controls.Add(this.lblPrecio);
            this.mrcDatosRep.Controls.Add(this.lblOrigen);
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
            this.txtDescripcion.Location = new System.Drawing.Point(128, 176);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(429, 85);
            this.txtDescripcion.TabIndex = 10;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.Enabled = false;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Items.AddRange(new object[] {
            "Nacional",
            "Internacional"});
            this.cmbOrigen.Location = new System.Drawing.Point(111, 113);
            this.cmbOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(123, 24);
            this.cmbOrigen.TabIndex = 9;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(288, 152);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(101, 20);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(473, 105);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(123, 22);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtNmero
            // 
            this.txtNmero.Location = new System.Drawing.Point(473, 36);
            this.txtNmero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNmero.Name = "txtNmero";
            this.txtNmero.Size = new System.Drawing.Size(123, 22);
            this.txtNmero.TabIndex = 5;
            this.txtNmero.TextChanged += new System.EventHandler(this.txtNmero_TextChanged);
            this.txtNmero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNmero_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(400, 111);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(60, 20);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(32, 111);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(61, 20);
            this.lblOrigen.TabIndex = 2;
            this.lblOrigen.Text = "Origen";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
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
            // mrcRepIntegrados
            // 
            this.mrcRepIntegrados.Controls.Add(this.txtDescripcion1);
            this.mrcRepIntegrados.Controls.Add(this.cmbMarca2);
            this.mrcRepIntegrados.Controls.Add(this.lblDescripcion1);
            this.mrcRepIntegrados.Controls.Add(this.txtPrecio1);
            this.mrcRepIntegrados.Controls.Add(this.txtNumero1);
            this.mrcRepIntegrados.Controls.Add(this.mrcOrigen);
            this.mrcRepIntegrados.Controls.Add(this.lblPrecio1);
            this.mrcRepIntegrados.Controls.Add(this.label9);
            this.mrcRepIntegrados.Controls.Add(this.lblNumero1);
            this.mrcRepIntegrados.Controls.Add(this.lblMarca1);
            this.mrcRepIntegrados.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcRepIntegrados.Location = new System.Drawing.Point(21, 321);
            this.mrcRepIntegrados.Margin = new System.Windows.Forms.Padding(4);
            this.mrcRepIntegrados.Name = "mrcRepIntegrados";
            this.mrcRepIntegrados.Padding = new System.Windows.Forms.Padding(4);
            this.mrcRepIntegrados.Size = new System.Drawing.Size(703, 275);
            this.mrcRepIntegrados.TabIndex = 1;
            this.mrcRepIntegrados.TabStop = false;
            this.mrcRepIntegrados.Text = "Repuestos Ingresados";
            // 
            // txtDescripcion1
            // 
            this.txtDescripcion1.Enabled = false;
            this.txtDescripcion1.Location = new System.Drawing.Point(128, 179);
            this.txtDescripcion1.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion1.MaxLength = 50;
            this.txtDescripcion1.Multiline = true;
            this.txtDescripcion1.Name = "txtDescripcion1";
            this.txtDescripcion1.Size = new System.Drawing.Size(428, 86);
            this.txtDescripcion1.TabIndex = 10;
            // 
            // lblDescripcion1
            // 
            this.lblDescripcion1.AutoSize = true;
            this.lblDescripcion1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion1.Location = new System.Drawing.Point(304, 150);
            this.lblDescripcion1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion1.Name = "lblDescripcion1";
            this.lblDescripcion1.Size = new System.Drawing.Size(101, 20);
            this.lblDescripcion1.TabIndex = 9;
            this.lblDescripcion1.Text = "Descripcion";
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.Location = new System.Drawing.Point(484, 94);
            this.txtPrecio1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio1.Name = "txtPrecio1";
            this.txtPrecio1.Size = new System.Drawing.Size(128, 26);
            this.txtPrecio1.TabIndex = 8;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(481, 48);
            this.txtNumero1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(132, 26);
            this.txtNumero1.TabIndex = 7;
            // 
            // mrcOrigen
            // 
            this.mrcOrigen.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mrcOrigen.Controls.Add(this.optImportado);
            this.mrcOrigen.Controls.Add(this.optNacional);
            this.mrcOrigen.Controls.Add(this.label8);
            this.mrcOrigen.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcOrigen.Location = new System.Drawing.Point(29, 81);
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
            this.optImportado.Location = new System.Drawing.Point(16, 58);
            this.optImportado.Margin = new System.Windows.Forms.Padding(4);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(111, 24);
            this.optImportado.TabIndex = 4;
            this.optImportado.TabStop = true;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Location = new System.Drawing.Point(17, 30);
            this.optNacional.Margin = new System.Windows.Forms.Padding(4);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(100, 24);
            this.optNacional.TabIndex = 3;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 1);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 2;
            // 
            // lblPrecio1
            // 
            this.lblPrecio1.AutoSize = true;
            this.lblPrecio1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio1.Location = new System.Drawing.Point(403, 96);
            this.lblPrecio1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio1.Name = "lblPrecio1";
            this.lblPrecio1.Size = new System.Drawing.Size(60, 20);
            this.lblPrecio1.TabIndex = 4;
            this.lblPrecio1.Text = "Precio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 3;
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero1.Location = new System.Drawing.Point(403, 52);
            this.lblNumero1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(71, 20);
            this.lblNumero1.TabIndex = 1;
            this.lblNumero1.Text = "Numero";
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
            this.btnRegistrar.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(763, 75);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(115, 39);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
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
            // 
            // cmbMarca
            // 
            this.cmbMarca.Enabled = false;
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
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbMarca2
            // 
            this.cmbMarca2.Enabled = false;
            this.cmbMarca2.FormattingEnabled = true;
            this.cmbMarca2.Items.AddRange(new object[] {
            "Peugeot",
            "Fiat",
            "Renault"});
            this.cmbMarca2.Location = new System.Drawing.Point(111, 39);
            this.cmbMarca2.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMarca2.Name = "cmbMarca2";
            this.cmbMarca2.Size = new System.Drawing.Size(123, 28);
            this.cmbMarca2.TabIndex = 9;
            this.cmbMarca2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(905, 609);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mrcRepIntegrados);
            this.Controls.Add(this.mrcDatosRep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRepuestos";
            this.Text = "Repuestos";
            this.mrcDatosRep.ResumeLayout(false);
            this.mrcDatosRep.PerformLayout();
            this.mrcRepIntegrados.ResumeLayout(false);
            this.mrcRepIntegrados.PerformLayout();
            this.mrcOrigen.ResumeLayout(false);
            this.mrcOrigen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDatosRep;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNmero;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox mrcRepIntegrados;
        private System.Windows.Forms.TextBox txtDescripcion1;
        private System.Windows.Forms.Label lblDescripcion1;
        private System.Windows.Forms.TextBox txtPrecio1;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.GroupBox mrcOrigen;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPrecio1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblMarca1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbMarca2;
    }
}

