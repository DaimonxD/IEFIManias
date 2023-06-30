namespace IEFIManiás
{
    partial class frmListadosOG
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboxContenido = new System.Windows.Forms.ComboBox();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(380, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Formulario de Ventas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1202, 22);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cid,
            this.Ccantidad,
            this.Cproducto,
            this.Cdia,
            this.Cmes,
            this.Caño});
            this.dataGridView2.Location = new System.Drawing.Point(276, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(743, 343);
            this.dataGridView2.TabIndex = 5;
            // 
            // Cid
            // 
            this.Cid.HeaderText = "ID";
            this.Cid.Name = "Cid";
            this.Cid.ReadOnly = true;
            // 
            // Ccantidad
            // 
            this.Ccantidad.HeaderText = "Cantidad";
            this.Ccantidad.Name = "Ccantidad";
            this.Ccantidad.ReadOnly = true;
            // 
            // Cproducto
            // 
            this.Cproducto.HeaderText = "Producto";
            this.Cproducto.Name = "Cproducto";
            this.Cproducto.ReadOnly = true;
            this.Cproducto.Width = 200;
            // 
            // Cdia
            // 
            this.Cdia.HeaderText = "Dia";
            this.Cdia.Name = "Cdia";
            this.Cdia.ReadOnly = true;
            // 
            // Cmes
            // 
            this.Cmes.HeaderText = "Mes";
            this.Cmes.Name = "Cmes";
            this.Cmes.ReadOnly = true;
            // 
            // Caño
            // 
            this.Caño.HeaderText = "Año";
            this.Caño.Name = "Caño";
            this.Caño.ReadOnly = true;
            // 
            // cboxContenido
            // 
            this.cboxContenido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxContenido.FormattingEnabled = true;
            this.cboxContenido.Items.AddRange(new object[] {
            "Productos",
            "Ventas"});
            this.cboxContenido.Location = new System.Drawing.Point(56, 25);
            this.cboxContenido.Name = "cboxContenido";
            this.cboxContenido.Size = new System.Drawing.Size(121, 28);
            this.cboxContenido.TabIndex = 6;
            // 
            // cmdVolver
            // 
            this.cmdVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVolver.Location = new System.Drawing.Point(12, 386);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(65, 31);
            this.cmdVolver.TabIndex = 7;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cboxContenido);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 343);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(177, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmListadosOG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1031, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListadosOG";
            this.Text = "frmListadosOG";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cboxContenido;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caño;
        private System.Windows.Forms.Button button1;
    }
}