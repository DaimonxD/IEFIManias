using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFIManiás
{
    public partial class frmCargaProducto : Form
    {
        private bool mouse;
        private Point UltUbicacion;

        public frmCargaProducto()
        {
            InitializeComponent();
        }

        private void cmdCerrar2_Click(object sender, EventArgs e)
        {
           Process.GetCurrentProcess().Kill();
        }

        private void frmCargaProducto_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            UltUbicacion = e.Location;
        }

        private void frmCargaProducto_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void frmCargaProducto_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                this.Location = new Point((this.Location.X - UltUbicacion.X) + e.X, (this.Location.Y - UltUbicacion.Y) + e.Y);
                this.Update();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            UltUbicacion = e.Location;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                this.Location = new Point((this.Location.X - UltUbicacion.X) + e.X, (this.Location.Y - UltUbicacion.Y) + e.Y);
                this.Update();
            }
        }
        private void txtID_MouseClick(object sender, MouseEventArgs e)
        {
            txtID.Text = ""; 
        }

        private void txtNombre_MouseClick(object sender, MouseEventArgs e)
        {
            txtNombre.Text = ""; 
        }

        private void txtFecha_MouseClick(object sender, MouseEventArgs e)
        {
            txtFecha.Text = "";
        }

        private void cmdCerrar2_MouseEnter(object sender, EventArgs e)
        {
            cmdCerrar2.ForeColor = Color.Black;
        }

        private void cmdCerrar2_MouseLeave(object sender, EventArgs e)
        {
            cmdCerrar2.ForeColor = Color.Red;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/')
            {
                e.Handled = true;
            }
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            string id = txtID.Text;
            string fecha = txtFecha.Text;
            

            if(!string.IsNullOrEmpty(id) && int.TryParse(id, out int idNum))
            {



                bd.Nombre = txtNombre.Text;
                bd.Fecha = txtFecha.Text;
                bd.Id = idNum;
                Console.WriteLine(bd.Id);

                MessageBox.Show("Guardado Correctamente...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
