using IEFIManiás.Producto;
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

        frmProductoConsulta pc = new frmProductoConsulta();
        private bool mouse;
        private Point UltUbicacion;

        public frmCargaProducto()
        {
            InitializeComponent();
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
            txtID.Text = string.Empty;
        }

        private void txtNombre_MouseClick(object sender, MouseEventArgs e)
        {
            txtNombre.Text = string.Empty;
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string nombre = txtNombre.Text;
            string fecha1 = txtFD.Text;
            string fecha2 = txtFM.Text;
            string fecha3 = txtFA.Text;
            
            

            if(!string.IsNullOrEmpty(id) && int.TryParse(id, out int idNum) && 
                !string.IsNullOrEmpty(fecha1) && int.TryParse(fecha1, out int fechaNum1) && 
                !string.IsNullOrEmpty(fecha2) && int.TryParse(fecha2, out int fechaNum2) && 
                !string.IsNullOrEmpty(fecha3) && int.TryParse(fecha3, out int fechaNum3))
            {
                pc.pnombre = txtNombre.Text;
                pc.pfecha1 = txtFD.Text;
                pc.pfecha2 = txtFM.Text;
                pc.pfecha3 = txtFA.Text;
                pc.pid = txtID.Text;


                MessageBox.Show("Datos guardados correctamente...", "",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese datos válidos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            FrmPrincipal prn = new FrmPrincipal();

            prn.Show();
            this.Hide();
        }

        private void txtFD_Click(object sender, EventArgs e)
        {
            txtFD.Text = string.Empty;
        }

        private void txtFM_Click(object sender, EventArgs e)
        {
            txtFM.Text = string.Empty;
        }

        private void txtFA_Click(object sender, EventArgs e)
        {
            txtFA.Text = string.Empty;
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            pc.Show();
        }
    }
}
