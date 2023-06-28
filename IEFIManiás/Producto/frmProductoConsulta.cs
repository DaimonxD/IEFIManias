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

namespace IEFIManiás.Producto
{
    public partial class frmProductoConsulta : Form
    {

        private string nombre, fecha1, id, fecha2, fecha3;


        public string pnombre
        {
            set
            {
                nombre = value;
            }
        }

        public string pfecha1
        {
            set
            {
                fecha1 = value;
            }
        }

        public string pid
        {
            set
            {
                id = value;
            }
        }

        public string pfecha2
        {
            set
            {
                fecha2 = value;
            }
        }

        public string pfecha3
        {
            set
            {
                fecha3 = value;
            }
        }






        private bool mouse;
        private Point UltUbicacion;


        public frmProductoConsulta()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmProductoConsulta_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            UltUbicacion = e.Location;
        }

        private void frmProductoConsulta_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void frmProductoConsulta_MouseMove(object sender, MouseEventArgs e)
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

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                this.Location = new Point((this.Location.X - UltUbicacion.X) + e.X, (this.Location.Y - UltUbicacion.Y) + e.Y);
                this.Update();
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            UltUbicacion = e.Location;
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

        private void cmdRefrescar_Click(object sender, EventArgs e)
        {
            bool datosExistentes = dataGridView1.Rows
            .Cast<DataGridViewRow>()
            .Any(row =>
             row.Cells["Cnombre"].Value?.ToString() == nombre &&
             row.Cells["Cid"].Value?.ToString() == id &&
             row.Cells["Cfecha1"].Value?.ToString() == fecha1 &&
             row.Cells["Cfecha2"].Value?.ToString() == fecha2 &&
             row.Cells["Cfecha3"].Value?.ToString() == fecha3);

            if (!datosExistentes)
            {
                int renglon = dataGridView1.Rows.Add();
                dataGridView1.Rows[renglon].Cells["Cnombre"].Value = nombre;
                dataGridView1.Rows[renglon].Cells["Cid"].Value = id;
                dataGridView1.Rows[renglon].Cells["Cfecha1"].Value = fecha1;
                dataGridView1.Rows[renglon].Cells["Cfecha2"].Value = fecha2;
                dataGridView1.Rows[renglon].Cells["Cfecha3"].Value = fecha3;
            }
            else
            {
                MessageBox.Show("Los datos ya existen en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }
    }
}
