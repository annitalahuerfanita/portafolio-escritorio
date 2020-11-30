namespace TurismoReal.Vistas
{
    partial class InventarioDisp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgInventario = new System.Windows.Forms.DataGridView();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lineaabajo = new System.Windows.Forms.Panel();
            this.lineaarriba = new System.Windows.Forms.Panel();
            this.lineader = new System.Windows.Forms.Panel();
            this.lineaizq = new System.Windows.Forms.Panel();
            this.sombrahorz = new System.Windows.Forms.Panel();
            this.sombravert = new System.Windows.Forms.Panel();
            this.lbDepto = new System.Windows.Forms.Label();
            this.txtDepto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventario)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgInventario
            // 
            this.dgInventario.AllowUserToAddRows = false;
            this.dgInventario.AllowUserToDeleteRows = false;
            this.dgInventario.AllowUserToResizeColumns = false;
            this.dgInventario.AllowUserToResizeRows = false;
            this.dgInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.dgInventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(208)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgInventario.ColumnHeadersHeight = 30;
            this.dgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(208)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgInventario.Location = new System.Drawing.Point(37, 104);
            this.dgInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgInventario.Name = "dgInventario";
            this.dgInventario.ReadOnly = true;
            this.dgInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgInventario.RowHeadersVisible = false;
            this.dgInventario.RowHeadersWidth = 51;
            this.dgInventario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgInventario.RowTemplate.Height = 24;
            this.dgInventario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgInventario.Size = new System.Drawing.Size(464, 450);
            this.dgInventario.TabIndex = 77;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panelTitulo.Controls.Add(this.lbTitulo);
            this.panelTitulo.Controls.Add(this.btnClose);
            this.panelTitulo.Location = new System.Drawing.Point(1, 1);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(534, 44);
            this.panelTitulo.TabIndex = 76;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(200, 10);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(133, 25);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "INVENTARIO";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(487, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 46);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lineaabajo
            // 
            this.lineaabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lineaabajo.Location = new System.Drawing.Point(0, 585);
            this.lineaabajo.Margin = new System.Windows.Forms.Padding(4);
            this.lineaabajo.Name = "lineaabajo";
            this.lineaabajo.Size = new System.Drawing.Size(535, 1);
            this.lineaabajo.TabIndex = 78;
            // 
            // lineaarriba
            // 
            this.lineaarriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.lineaarriba.Location = new System.Drawing.Point(0, 0);
            this.lineaarriba.Margin = new System.Windows.Forms.Padding(4);
            this.lineaarriba.Name = "lineaarriba";
            this.lineaarriba.Size = new System.Drawing.Size(535, 1);
            this.lineaarriba.TabIndex = 79;
            // 
            // lineader
            // 
            this.lineader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lineader.Location = new System.Drawing.Point(535, 1);
            this.lineader.Margin = new System.Windows.Forms.Padding(4);
            this.lineader.Name = "lineader";
            this.lineader.Size = new System.Drawing.Size(1, 585);
            this.lineader.TabIndex = 80;
            // 
            // lineaizq
            // 
            this.lineaizq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lineaizq.Location = new System.Drawing.Point(0, 1);
            this.lineaizq.Margin = new System.Windows.Forms.Padding(4);
            this.lineaizq.Name = "lineaizq";
            this.lineaizq.Size = new System.Drawing.Size(1, 584);
            this.lineaizq.TabIndex = 70;
            // 
            // sombrahorz
            // 
            this.sombrahorz.BackColor = System.Drawing.Color.LightGray;
            this.sombrahorz.Location = new System.Drawing.Point(10, 586);
            this.sombrahorz.Margin = new System.Windows.Forms.Padding(4);
            this.sombrahorz.Name = "sombrahorz";
            this.sombrahorz.Size = new System.Drawing.Size(531, 5);
            this.sombrahorz.TabIndex = 81;
            // 
            // sombravert
            // 
            this.sombravert.BackColor = System.Drawing.Color.LightGray;
            this.sombravert.Location = new System.Drawing.Point(536, 10);
            this.sombravert.Margin = new System.Windows.Forms.Padding(4);
            this.sombravert.Name = "sombravert";
            this.sombravert.Size = new System.Drawing.Size(5, 578);
            this.sombravert.TabIndex = 82;
            // 
            // lbDepto
            // 
            this.lbDepto.AutoSize = true;
            this.lbDepto.Location = new System.Drawing.Point(7, 564);
            this.lbDepto.Name = "lbDepto";
            this.lbDepto.Size = new System.Drawing.Size(0, 17);
            this.lbDepto.TabIndex = 83;
            this.lbDepto.Visible = false;
            // 
            // txtDepto
            // 
            this.txtDepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtDepto.Enabled = false;
            this.txtDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepto.Location = new System.Drawing.Point(1, 62);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.ReadOnly = true;
            this.txtDepto.Size = new System.Drawing.Size(530, 26);
            this.txtDepto.TabIndex = 85;
            this.txtDepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InventarioDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(540, 590);
            this.Controls.Add(this.txtDepto);
            this.Controls.Add(this.lbDepto);
            this.Controls.Add(this.sombravert);
            this.Controls.Add(this.sombrahorz);
            this.Controls.Add(this.lineaizq);
            this.Controls.Add(this.lineader);
            this.Controls.Add(this.lineaarriba);
            this.Controls.Add(this.lineaabajo);
            this.Controls.Add(this.dgInventario);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(662, 208);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InventarioDisp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InventarioDisp";
            ((System.ComponentModel.ISupportInitialize)(this.dgInventario)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel lineaabajo;
        private System.Windows.Forms.Panel lineaarriba;
        private System.Windows.Forms.Panel lineader;
        private System.Windows.Forms.Panel lineaizq;
        private System.Windows.Forms.Panel sombrahorz;
        private System.Windows.Forms.Panel sombravert;
        public System.Windows.Forms.DataGridView dgInventario;
        public System.Windows.Forms.Label lbDepto;
        public System.Windows.Forms.TextBox txtDepto;
    }
}