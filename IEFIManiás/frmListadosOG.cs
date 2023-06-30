using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFIManiás
{
    public partial class frmListadosOG : Form
    {
        public string[,] contenidos = { { "Productos", "Ventas" } };

        public frmListadosOG()
        {
            InitializeComponent();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            FrmPrincipal pc = new FrmPrincipal();

            pc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string producto = cboxContenido.SelectedItem?.ToString();

            if(!string.IsNullOrEmpty(producto))
            {
                switch (producto)
                {
                    case var _ when producto == contenidos[0, 0]:




                        break;
                    case var _ when producto == contenidos[0, 1]:





                        break;
                    default:
                        MessageBox.Show("Seleccione el Contenido que quiere ver...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }
    }
}
