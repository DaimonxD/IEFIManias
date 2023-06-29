using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFIManiás
{
    public partial class frmCargaProducto : Form
    {
        private string nombre2, fecha4, id2, fecha5, fecha6, cantidad;


        public string pnombre2
        {
            set
            {
                nombre2 = value;
            }
        }

        public string pfecha4
        {
            set
            {
                fecha4 = value;
            }
        }

        public string pid2
        {
            set
            {
                id2 = value;
            }
        }

        public string pfecha5
        {
            set
            {
                fecha5 = value;
            }
        }

        public string pfecha6
        {
            set
            {
                fecha6 = value;
            }
        }

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

                pnombre2 = txtNombre.Text;
                pfecha4 = txtFD.Text;
                pfecha5 = txtFM.Text;
                pfecha6 = txtFA.Text;
                pid2 = txtID.Text;

                grabarDatos();
                {
                    bool datosExistentes2 = dataGridView1.Rows
                    .Cast<DataGridViewRow>()
                    .Any(row =>
                    row.Cells["Cnombre"].Value?.ToString() == nombre &&
                    row.Cells["Cid"].Value?.ToString() == id &&
                    row.Cells["Cfecha1"].Value?.ToString() == fecha1 &&
                     row.Cells["Cfecha2"].Value?.ToString() == fecha2 &&
                    row.Cells["Cfecha3"].Value?.ToString() == fecha3);


                    if (!datosExistentes2)
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
        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            for (int f = 0; f < dataGridView1.Rows.Count; f++)
            {
                if (txtID.Text == dataGridView1.Rows[f].Cells[0].Value.ToString())
                {
                    dataGridView1.Rows.RemoveAt(f);
                    borrarDatos();
                    MessageBox.Show("Se ha eliminado este producto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void frmCargaProducto_Load(object sender, EventArgs e)
        {
            if (!File.Exists("productos.txt"))
            {
                StreamWriter archivo = new StreamWriter("productos.txt");
                archivo.Close();
            }
            else
            {
                StreamReader archivo = new StreamReader("productos.txt");
                while (!archivo.EndOfStream)
                {
                    string id = archivo.ReadLine();
                    string nombre = archivo.ReadLine();
                    string cantidad = archivo.ReadLine();
                    string fecha1 = archivo.ReadLine();
                    string fecha2 = archivo.ReadLine();
                    string fecha3 = archivo.ReadLine();
                    dataGridView1.Rows.Add(id, nombre, cantidad, fecha1, fecha2, fecha3);
                }
                archivo.Close();
            }
        }

        private void grabarDatos()
        {
            StreamWriter archivo = new StreamWriter("productos.txt", true);
            archivo.WriteLine(txtID.Text);
            archivo.WriteLine(txtNombre.Text);
            archivo.WriteLine(txtFD.Text);
            archivo.WriteLine(txtFM.Text);
            archivo.WriteLine(txtFA.Text);
            archivo.Close();
        }

        private void borrarDatos()
        {
            StreamWriter archivo = new StreamWriter("productos.txt");
            for (int f = 0; f < dataGridView1.Rows.Count; f++)
            {
                archivo.WriteLine(dataGridView1.Rows[f].Cells[0].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[f].Cells[1].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[f].Cells[2].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[f].Cells[3].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[f].Cells[4].Value.ToString());
            }
            archivo.Close();
        }



    }
}
