using IEFIManiás.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFIManiás
{
    public partial class frmCargaVentas : Form
    {
        public frmCargaVentas()
        {
            InitializeComponent();
        }

        private void cmdConsultar2_Click(object sender, EventArgs e)
        {
            frmVentasConsulta consulta = new frmVentasConsulta();
            consulta.Show();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            FrmPrincipal prn = new FrmPrincipal();

            prn.Show();
            this.Hide();
        }
    }
}
