using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFIManiás
{
    public partial class frmCargaVentas : Form
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

        public string pcant
        {
            set
            {
                cantidad = value;
            }
        }

        private bool mouse;
        private Point UltUbicacion;
        

        public frmCargaVentas()
        {
            InitializeComponent();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            FrmPrincipal prn = new FrmPrincipal();

            prn.Show();
            this.Hide();
        }

        private void txtID_Click(object sender, EventArgs e)
        {
            txtID2.Text = string.Empty;
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre2.Text = string.Empty;
        }

        private void txtFD_Click(object sender, EventArgs e)
        {
            txtFD2.Text = string.Empty;
        }

        private void txtFM_Click(object sender, EventArgs e)
        {
            txtFM2.Text = string.Empty;
        }

        private void txtFA_Click(object sender, EventArgs e)
        {
            txtFA2.Text = string.Empty;
        }

        private void txtCantidad_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = string.Empty;
        }

        private void frmCargaVentas_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            UltUbicacion = e.Location;
        }

        private void frmCargaVentas_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                this.Location = new Point((this.Location.X - UltUbicacion.X) + e.X, (this.Location.Y - UltUbicacion.Y) + e.Y);
                this.Update();
            }
        }

        private void frmCargaVentas_Load(object sender, EventArgs e)
        {
            if (!File.Exists("ventas.txt"))
            {
                StreamWriter archivo = new StreamWriter("ventas.txt");
                archivo.Close();
            }
            else
            {
                StreamReader archivo = new StreamReader("ventas.txt");
                while (!archivo.EndOfStream)
                {
                    string id = archivo.ReadLine();
                    string nombre = archivo.ReadLine();
                    string cantidad = archivo.ReadLine();
                    string fecha1 = archivo.ReadLine();
                    string fecha2 = archivo.ReadLine();
                    string fecha3 = archivo.ReadLine();
                    dataGridView2.Rows.Add(id, nombre, cantidad, fecha1, fecha2, fecha3);
                }
                archivo.Close();
            }
        }

        private void frmCargaVentas_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            for(int f=0; f<dataGridView2.Rows.Count; f++)
            {
                if(txtID2.Text == dataGridView2.Rows[f].Cells[0].Value.ToString())
                {
                    dataGridView2.Rows.RemoveAt(f);
                    borrarDatos();
                    MessageBox.Show("Se ha eliminado esa venta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            UltUbicacion = e.Location;
        }

        private void cmdFiltro_Click(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text.Trim();

            dataGridView2.Rows.Clear();

            using (StreamReader archivo = new StreamReader("ventas.txt"))
            {
                while (!archivo.EndOfStream)
                {
                    string id = archivo.ReadLine();
                    string nombre = archivo.ReadLine();
                    string cantidad = archivo.ReadLine();
                    string fecha1 = archivo.ReadLine();
                    string fecha2 = archivo.ReadLine();
                    string fecha3 = archivo.ReadLine();

                    if (string.IsNullOrEmpty(filtro) || cantidad == filtro)
                    {
                        dataGridView2.Rows.Add(id, cantidad, nombre, fecha1, fecha2, fecha3);
                    }
                }
            }
        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty;
        }

        private void txtNombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFiltroNombre_Click(object sender, EventArgs e)
        {
            txtFiltroNombre.Text = string.Empty;
        }

        private void cmdFiltrar2_Click(object sender, EventArgs e)
        {
            string filtro2 = txtFiltroNombre.Text.Trim();

            dataGridView2.Rows.Clear();

            using (StreamReader archivo = new StreamReader("ventas.txt"))
            {
                while (!archivo.EndOfStream)
                {
                    string id = archivo.ReadLine();
                    string nombre = archivo.ReadLine();
                    string cantidad = archivo.ReadLine();
                    string fecha1 = archivo.ReadLine();
                    string fecha2 = archivo.ReadLine();
                    string fecha3 = archivo.ReadLine();

                    if (string.IsNullOrEmpty(filtro2) || nombre == filtro2)
                    {
                        dataGridView2.Rows.Add(id, cantidad, nombre, fecha1, fecha2, fecha3);
                    }
                }
            }
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

        private void cmdRegistrar2_Click(object sender, EventArgs e)
        {

            string id2 = txtID2.Text;
            string fecha4 = txtFD2.Text;
            string fecha5 = txtFM2.Text;
            string fecha6 = txtFA2.Text;
            string cantidad = txtCantidad.Text;


            if (!string.IsNullOrEmpty(id2) && int.TryParse(id2, out int idNum) &&
                !string.IsNullOrEmpty(fecha4) && int.TryParse(fecha4, out int fechaNum1) &&
                !string.IsNullOrEmpty(fecha5) && int.TryParse(fecha5, out int fechaNum2) &&
                !string.IsNullOrEmpty(fecha6) && int.TryParse(fecha6, out int fechaNum3) &&
                !string.IsNullOrEmpty(cantidad) && int.TryParse(cantidad, out int cantidadNum1))
            {
                pnombre2 = txtNombre2.Text;
                pfecha4 = txtFD2.Text;
                pfecha5 = txtFM2.Text;
                pfecha6 = txtFA2.Text;
                pid2 = txtID2.Text;
                pcant = txtCantidad.Text;


                grabarDatos();
                {
                    bool datosExistentes2 = dataGridView2.Rows
                    .Cast<DataGridViewRow>()
                    .Any(row =>
                    row.Cells["Cnombre2"].Value?.ToString() == nombre2 &&
                    row.Cells["Cid2"].Value?.ToString() == id2 &&
                    row.Cells["Cfecha4"].Value?.ToString() == fecha4 &&
                     row.Cells["Cfecha5"].Value?.ToString() == fecha5 &&
                    row.Cells["Cfecha6"].Value?.ToString() == fecha6 &&
                    row.Cells["Ccantidad"].Value?.ToString() == cantidad);


                    if (!datosExistentes2)
                    {
                        int renglon = dataGridView2.Rows.Add();
                        dataGridView2.Rows[renglon].Cells["Cnombre2"].Value = nombre2;
                        dataGridView2.Rows[renglon].Cells["Cid2"].Value = id2;
                        dataGridView2.Rows[renglon].Cells["Cfecha4"].Value = fecha4;
                        dataGridView2.Rows[renglon].Cells["Cfecha5"].Value = fecha5;
                        dataGridView2.Rows[renglon].Cells["Cfecha6"].Value = fecha6;
                        dataGridView2.Rows[renglon].Cells["Ccantidad"].Value = cantidad;
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

        private void grabarDatos()
        {
            StreamWriter archivo = new StreamWriter("ventas.txt", true);
            archivo.WriteLine(txtID2.Text);
            archivo.WriteLine(txtNombre2.Text);
            archivo.WriteLine(txtCantidad.Text);
            archivo.WriteLine(txtFD2.Text);
            archivo.WriteLine(txtFM2.Text);
            archivo.WriteLine(txtFA2.Text);
            archivo.Close();
        }

        private void borrarDatos()
        {
            StreamWriter archivo = new StreamWriter("ventas.txt");
            for(int f = 0; f <dataGridView2.Rows.Count; f++)
            {
                archivo.WriteLine(dataGridView2.Rows[f].Cells[0].Value.ToString());
                archivo.WriteLine(dataGridView2.Rows[f].Cells[1].Value.ToString());
                archivo.WriteLine(dataGridView2.Rows[f].Cells[2].Value.ToString());
                archivo.WriteLine(dataGridView2.Rows[f].Cells[3].Value.ToString());
                archivo.WriteLine(dataGridView2.Rows[f].Cells[4].Value.ToString());
                archivo.WriteLine(dataGridView2.Rows[f].Cells[5].Value.ToString());
            }
            archivo.Close ();
        }

    }
}
