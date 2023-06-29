namespace IEFIManiás
{
    partial class frmCargaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaProducto));
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFA = new System.Windows.Forms.TextBox();
            this.txtFM = new System.Windows.Forms.TextBox();
            this.txtFD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.Cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cfecha1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cfecha2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cfecha3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo2.Location = new System.Drawing.Point(85, 0);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(187, 16);
            this.lblTitulo2.TabIndex = 1;
            this.lblTitulo2.Text = "Formulario Carga de Porducto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.lblTitulo2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 22);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFA);
            this.groupBox1.Controls.Add(this.txtFM);
            this.groupBox1.Controls.Add(this.txtFD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 304);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // txtFA
            // 
            this.txtFA.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtFA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFA.Location = new System.Drawing.Point(224, 217);
            this.txtFA.MaxLength = 4;
            this.txtFA.Name = "txtFA";
            this.txtFA.Size = new System.Drawing.Size(43, 19);
            this.txtFA.TabIndex = 12;
            this.txtFA.Text = "YYYY";
            this.txtFA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFA.Click += new System.EventHandler(this.txtFA_Click);
            // 
            // txtFM
            // 
            this.txtFM.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtFM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFM.Location = new System.Drawing.Point(143, 217);
            this.txtFM.MaxLength = 2;
            this.txtFM.Name = "txtFM";
            this.txtFM.Size = new System.Drawing.Size(56, 19);
            this.txtFM.TabIndex = 11;
            this.txtFM.Text = "MM";
            this.txtFM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFM.Click += new System.EventHandler(this.txtFM_Click);
            // 
            // txtFD
            // 
            this.txtFD.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtFD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFD.Location = new System.Drawing.Point(69, 216);
            this.txtFD.MaxLength = 2;
            this.txtFD.Name = "txtFD";
            this.txtFD.Size = new System.Drawing.Size(56, 19);
            this.txtFD.TabIndex = 10;
            this.txtFD.Text = "DD";
            this.txtFD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFD.Click += new System.EventHandler(this.txtFD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "/";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(67, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 1);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(67, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(27, 216);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(67, 142);
            this.txtNombre.MaxLength = 10;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 19);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.WordWrap = false;
            this.txtNombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNombre_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(67, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtID.Location = new System.Drawing.Point(67, 55);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 19);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "ID";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.WordWrap = false;
            this.txtID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtID_MouseClick);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.ForeColor = System.Drawing.Color.Black;
            this.cmdCancelar.Location = new System.Drawing.Point(75, 396);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 3;
            this.cmdCancelar.Text = "&Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.cmdRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegistrar.ForeColor = System.Drawing.Color.LawnGreen;
            this.cmdRegistrar.Location = new System.Drawing.Point(1067, 394);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrar.TabIndex = 5;
            this.cmdRegistrar.Text = "&Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cid,
            this.Cnombre,
            this.Cfecha1,
            this.Cfecha2,
            this.Cfecha3});
            this.dataGridView1.Location = new System.Drawing.Point(351, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(808, 330);
            this.dataGridView1.TabIndex = 6;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.cmdBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBorrar.ForeColor = System.Drawing.Color.Red;
            this.cmdBorrar.Location = new System.Drawing.Point(952, 394);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrar.TabIndex = 7;
            this.cmdBorrar.Text = "&Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // Cid
            // 
            this.Cid.HeaderText = "ID";
            this.Cid.Name = "Cid";
            this.Cid.ReadOnly = true;
            this.Cid.Width = 250;
            // 
            // Cnombre
            // 
            this.Cnombre.HeaderText = "Nombre";
            this.Cnombre.Name = "Cnombre";
            this.Cnombre.ReadOnly = true;
            this.Cnombre.Width = 215;
            // 
            // Cfecha1
            // 
            this.Cfecha1.HeaderText = "Dia";
            this.Cfecha1.Name = "Cfecha1";
            this.Cfecha1.ReadOnly = true;
            // 
            // Cfecha2
            // 
            this.Cfecha2.HeaderText = "Mes";
            this.Cfecha2.Name = "Cfecha2";
            this.Cfecha2.ReadOnly = true;
            // 
            // Cfecha3
            // 
            this.Cfecha3.HeaderText = "Año";
            this.Cfecha3.Name = "Cfecha3";
            this.Cfecha3.ReadOnly = true;
            // 
            // frmCargaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1170, 429);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCargaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCargaProducto_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCargaProducto_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCargaProducto_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmCargaProducto_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtFA;
        private System.Windows.Forms.TextBox txtFM;
        private System.Windows.Forms.TextBox txtFD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cfecha1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cfecha2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cfecha3;
    }
}