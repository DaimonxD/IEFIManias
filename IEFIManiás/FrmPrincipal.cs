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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace IEFIManiás
{
    public partial class FrmPrincipal : Form
    {
        private bool mouse;
        private Point UltUbicacion;
        frmCargaProducto CP = new frmCargaProducto();
        frmCargaVentas CV = new frmCargaVentas();
        frmListadosOG Lt = new frmListadosOG();
        public string[,] Formulario = { { "Carga de Producto", "Carga de Ventas", "Formulario de Listados" } };
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            UltUbicacion = e.Location;
        }

        private void FrmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouse)
            {
                this.Location = new Point((this.Location.X - UltUbicacion.X) + e.X, (this.Location.Y - UltUbicacion.Y) + e.Y);
                this.Update();
            }
        }

        private void FrmPrincipal_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void cmdCerrar1_MouseEnter(object sender, EventArgs e)
        {
            cmdCerrar1.ForeColor = Color.Black;
        }

        private void cmdCerrar1_MouseLeave(object sender, EventArgs e)
        {
            cmdCerrar1.ForeColor = Color.Red;
        }

        private void cmdCerrar1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            UltUbicacion = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                this.Location = new Point((this.Location.X - UltUbicacion.X) + e.X, (this.Location.Y - UltUbicacion.Y) + e.Y);
                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void cmdAceptar1_Click(object sender, EventArgs e)
        {
            string Formularios = cbox1.SelectedItem?.ToString();


            if(!string.IsNullOrEmpty(Formularios))
            {
                switch(true)
                {
                    case var _ when Formularios == Formulario[0, 0]:
                        CP.Show();
                        this.Hide();
                        break;
                    case var _ when Formularios == Formulario[0, 1]:
                        CV.Show();
                        this.Hide();
                        break;
                    case var _ when Formularios == Formulario[0, 2]:
                        Lt.Show();
                        this.Hide();
                        break;

                    default:
                        MessageBox.Show("Si sale esto me olvide de algo xd", "UwU", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Formulario para continuar...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
