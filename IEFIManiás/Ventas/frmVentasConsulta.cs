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

namespace IEFIManiás.Ventas
{
    public partial class frmVentasConsulta : Form
    {
        private bool mouse;
        private Point UltUbicacion;

        frmCargaVentas ventas = new frmCargaVentas();
        public frmVentasConsulta()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmVentasConsulta_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            UltUbicacion = e.Location;
        }

        private void frmVentasConsulta_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                this.Location = new Point((this.Location.X - UltUbicacion.X) + e.X, (this.Location.Y - UltUbicacion.Y) + e.Y);
                this.Update();
            }
        }

        private void frmVentasConsulta_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            UltUbicacion = e.Location;
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                this.Location = new Point((this.Location.X - UltUbicacion.X) + e.X, (this.Location.Y - UltUbicacion.Y) + e.Y);
                this.Update();
            }
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            UltUbicacion = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                this.Location = new Point((this.Location.X - UltUbicacion.X) + e.X, (this.Location.Y - UltUbicacion.Y) + e.Y);
                this.Update();
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }
    }
}
