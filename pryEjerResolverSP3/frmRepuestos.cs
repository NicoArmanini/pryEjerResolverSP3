using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryEjerResolverSP3
{
    public partial class frmRepuestos : Form
    {
        // declaración de la estructura para los turnos
        public struct Repuestos
        {
            public string strMarca;
            public string strOrigen;
            public int intNumero;
            public string strDescripcion;
            public float floPrecio;
        }

        // variable para controlar la cantidad de elementos cargados

        Repuestos[] vecRepuestos = new Repuestos[100];
        public int intRegistro = 0;
        public int intConsulta = 0;

        public void LimpiarControles()
        {
            cmbMarca.SelectedIndex = -1;
            optNacional.Checked = true;
            txtNumero.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
        }


        public frmRepuestos()
        {
            InitializeComponent();
        }

        private void txtNmero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool existeNroRepuesto = false;
            intConsulta = 0;
            while (intConsulta < vecRepuestos.Length)
            {
                if (vecRepuestos[intConsulta].intNumero == int.Parse(txtNumero.Text))
                {
                    existeNroRepuesto = true;
                    MessageBox.Show("El Nº de Repuesto " + txtNumero.Text +
                    " ya está registrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                intConsulta++;
            }
            if (existeNroRepuesto == false)
            {
                vecRepuestos[intRegistro].strMarca = cmbMarca.Text;
                if (optNacional.Checked == true)
                {
                    vecRepuestos[intRegistro].strOrigen = "Nacional";
                }
                else
                {
                    vecRepuestos[intRegistro].strOrigen = "Importado";
                }

                vecRepuestos[intRegistro].intNumero = int.Parse(txtNumero.Text);
                vecRepuestos[intRegistro].strDescripcion = txtDescripcion.Text;
                vecRepuestos[intRegistro].floPrecio = float.Parse(txtPrecio.Text);
                intRegistro++;
                MessageBox.Show("Repuesto Ingresado Correctamente!", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                mrcRepIngresados.Enabled = true;
                LimpiarControles();

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Clear();
            intConsulta = 0;
            if (optNacional1.Checked == true)
            {
                lstDatos.Items.Add("Repuestos " + cmbMarca1.Text + " Origen Nacional:");
                lstDatos.Items.Add("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
                while (intConsulta < vecRepuestos.Length)
                {
                    if (vecRepuestos[intConsulta].strMarca == cmbMarca1.Text)
                    {
                        if (vecRepuestos[intConsulta].strOrigen == "Nacional")
                        {
                            lstDatos.Items.Add("Nº de Repuesto: " + vecRepuestos[intConsulta].intNumero);
                            lstDatos.Items.Add("Precio: " + vecRepuestos[intConsulta].floPrecio);
                            lstDatos.Items.Add("Descripción: " + vecRepuestos[intConsulta].strDescripcion);
                            lstDatos.Items.Add("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
                        }
                    }
                    intConsulta++;
                }
            }
            else
            {
                lstDatos.Items.Add("Repuestos " + cmbMarca1.Text + " Origen Importado");
                lstDatos.Items.Add("────────────────────");
                while (intConsulta < vecRepuestos.Length)
                {
                    if (vecRepuestos[intConsulta].strMarca == cmbMarca1.Text)
                    {
                        if (vecRepuestos[intConsulta].strOrigen == "Importado")
                        {
                            lstDatos.Items.Add("Nº de Repuesto: " + vecRepuestos[intConsulta].intNumero);
                            lstDatos.Items.Add("Precio: " + vecRepuestos[intConsulta].floPrecio);
                            lstDatos.Items.Add("Descripción: " + vecRepuestos[intConsulta].strDescripcion);
                            lstDatos.Items.Add("────────────────────");
                        }
                    }
                    intConsulta++;
                }
            }
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedIndex != -1)
            {
                lblNumero.Enabled = true;
                txtNumero.Enabled = true;
            }
            else
            {
                lblNumero.Enabled = false;
                txtNumero.Enabled = false;
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "")
            {
               lblPrecio.Enabled = true;
               txtPrecio.Enabled = true;
            }
            else
            {
                lblPrecio.Enabled= false;
                txtPrecio.Enabled= false;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text != "")
            {
                lblDescripcion.Enabled = true;
                txtDescripcion.Enabled = true;
            }
            else
            {
                lblDescripcion.Enabled = false;
                txtDescripcion.Enabled = false;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;    
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Clear();
        }

        private void cmbMarca1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca1.SelectedIndex != -1)
            {
                btnConsultar.Enabled = true;
            }
            else
            {
                btnConsultar.Enabled = false;
            }
        }
    }
}
