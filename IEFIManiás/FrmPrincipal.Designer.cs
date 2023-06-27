namespace IEFIManiás
{
    partial class FrmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.cmdCerrar1 = new System.Windows.Forms.Button();
            this.cbox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAceptar1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.lblTitulo1);
            this.panel1.Controls.Add(this.cmdCerrar1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 22);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo1.Location = new System.Drawing.Point(140, 4);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(126, 16);
            this.lblTitulo1.TabIndex = 1;
            this.lblTitulo1.Text = "Formulario Principal";
            // 
            // cmdCerrar1
            // 
            this.cmdCerrar1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.cmdCerrar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdCerrar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cmdCerrar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar1.ForeColor = System.Drawing.Color.Red;
            this.cmdCerrar1.Location = new System.Drawing.Point(363, 0);
            this.cmdCerrar1.Name = "cmdCerrar1";
            this.cmdCerrar1.Size = new System.Drawing.Size(34, 22);
            this.cmdCerrar1.TabIndex = 0;
            this.cmdCerrar1.Text = "X";
            this.cmdCerrar1.UseVisualStyleBackColor = true;
            this.cmdCerrar1.Click += new System.EventHandler(this.cmdCerrar1_Click);
            this.cmdCerrar1.MouseEnter += new System.EventHandler(this.cmdCerrar1_MouseEnter);
            this.cmdCerrar1.MouseLeave += new System.EventHandler(this.cmdCerrar1_MouseLeave);
            // 
            // cbox1
            // 
            this.cbox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox1.FormattingEnabled = true;
            this.cbox1.Items.AddRange(new object[] {
            "Carga de Producto",
            "Carga de Ventas",
            "Formulario de Listados"});
            this.cbox1.Location = new System.Drawing.Point(119, 91);
            this.cbox1.Name = "cbox1";
            this.cbox1.Size = new System.Drawing.Size(159, 21);
            this.cbox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el Formulario que desea ver...";
            // 
            // cmdAceptar1
            // 
            this.cmdAceptar1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.cmdAceptar1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.cmdAceptar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.cmdAceptar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.cmdAceptar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAceptar1.ForeColor = System.Drawing.Color.Black;
            this.cmdAceptar1.Location = new System.Drawing.Point(167, 166);
            this.cmdAceptar1.Name = "cmdAceptar1";
            this.cmdAceptar1.Size = new System.Drawing.Size(75, 23);
            this.cmdAceptar1.TabIndex = 3;
            this.cmdAceptar1.Text = "Aceptar";
            this.cmdAceptar1.UseVisualStyleBackColor = false;
            this.cmdAceptar1.Click += new System.EventHandler(this.cmdAceptar1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(397, 212);
            this.Controls.Add(this.cmdAceptar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPrincipal_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPrincipal_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmPrincipal_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdCerrar1;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.ComboBox cbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAceptar1;
    }
}

