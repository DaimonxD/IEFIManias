using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFIManiás
{
    public partial class frmListadosOG : Form
    {
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
    }
}
