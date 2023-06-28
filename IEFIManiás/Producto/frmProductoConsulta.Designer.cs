namespace IEFIManiás.Producto
{
    partial class frmProductoConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.cmdRefrescar = new System.Windows.Forms.Button();
            this.Cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cfecha1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cfecha2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cfecha3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo2.Location = new System.Drawing.Point(323, 0);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(209, 16);
            this.lblTitulo2.TabIndex = 1;
            this.lblTitulo2.Text = "Formulario Consulta de Productos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.lblTitulo2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 22);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cid,
            this.Ccantidad,
            this.Cnombre,
            this.Cfecha1,
            this.Cfecha2,
            this.Cfecha3});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(808, 330);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAceptar.Location = new System.Drawing.Point(456, 364);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(111, 30);
            this.cmdAceptar.TabIndex = 10;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // cmdRefrescar
            // 
            this.cmdRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRefrescar.Location = new System.Drawing.Point(301, 364);
            this.cmdRefrescar.Name = "cmdRefrescar";
            this.cmdRefrescar.Size = new System.Drawing.Size(111, 30);
            this.cmdRefrescar.TabIndex = 9;
            this.cmdRefrescar.Text = "Refrescar";
            this.cmdRefrescar.UseVisualStyleBackColor = true;
            this.cmdRefrescar.Click += new System.EventHandler(this.cmdRefrescar_Click);
            // 
            // Cid
            // 
            this.Cid.Frozen = true;
            this.Cid.HeaderText = "ID";
            this.Cid.Name = "Cid";
            this.Cid.ReadOnly = true;
            this.Cid.Width = 150;
            // 
            // Ccantidad
            // 
            this.Ccantidad.Frozen = true;
            this.Ccantidad.HeaderText = "Cantidad";
            this.Ccantidad.Name = "Ccantidad";
            this.Ccantidad.ReadOnly = true;
            // 
            // Cnombre
            // 
            this.Cnombre.Frozen = true;
            this.Cnombre.HeaderText = "Nombre";
            this.Cnombre.Name = "Cnombre";
            this.Cnombre.ReadOnly = true;
            this.Cnombre.Width = 250;
            // 
            // Cfecha1
            // 
            this.Cfecha1.Frozen = true;
            this.Cfecha1.HeaderText = "Día";
            this.Cfecha1.Name = "Cfecha1";
            this.Cfecha1.ReadOnly = true;
            // 
            // Cfecha2
            // 
            this.Cfecha2.Frozen = true;
            this.Cfecha2.HeaderText = "Mes";
            this.Cfecha2.Name = "Cfecha2";
            this.Cfecha2.ReadOnly = true;
            // 
            // Cfecha3
            // 
            this.Cfecha3.Frozen = true;
            this.Cfecha3.HeaderText = "Año";
            this.Cfecha3.Name = "Cfecha3";
            this.Cfecha3.ReadOnly = true;
            // 
            // frmProductoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(832, 406);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.cmdRefrescar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductoConsulta";
            this.Text = "FormularioProductoConsulta";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmProductoConsulta_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmProductoConsulta_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmProductoConsulta_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.Button cmdRefrescar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cfecha1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cfecha2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cfecha3;
    }
}