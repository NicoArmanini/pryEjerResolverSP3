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
        public struct TURNO
        {
            public int NumeroTurno;
            public string Dominio;
            public int AnioFabricacion;
            public string Titular;
        };
        // constante para la cantidad total de elementos del arreglo
        const int MAX = 50;
        // declaración del arreglo unidimensional de 50 elementos
        public TURNO[] turnos;
        // variable para controlar la cantidad de elementos cargados
        public int Cantidad = 0;


        public frmRepuestos()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNmero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNmero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
