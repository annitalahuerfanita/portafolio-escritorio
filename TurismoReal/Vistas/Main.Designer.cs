namespace TurismoReal
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lbDeptos = new System.Windows.Forms.Label();
            this.lbFunc = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.btnFunc = new System.Windows.Forms.Button();
            this.btnDeptos = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.colorDeptos = new System.Windows.Forms.Panel();
            this.colorFunc = new System.Windows.Forms.Panel();
            this.panelSubmenu = new System.Windows.Forms.Panel();
            this.colorDisp = new System.Windows.Forms.Panel();
            this.btnDisponibles = new System.Windows.Forms.Button();
            this.colorMant = new System.Windows.Forms.Panel();
            this.btnMantencion = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitulo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelSubmenu.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panelTitulo.Controls.Add(this.lbDeptos);
            this.panelTitulo.Controls.Add(this.lbFunc);
            this.panelTitulo.Controls.Add(this.lbTitulo);
            this.panelTitulo.Controls.Add(this.btnMin);
            this.panelTitulo.Controls.Add(this.btnClose);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(240, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1160, 95);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // lbDeptos
            // 
            this.lbDeptos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDeptos.AutoSize = true;
            this.lbDeptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeptos.ForeColor = System.Drawing.Color.White;
            this.lbDeptos.Location = new System.Drawing.Point(451, 32);
            this.lbDeptos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDeptos.Name = "lbDeptos";
            this.lbDeptos.Size = new System.Drawing.Size(259, 31);
            this.lbDeptos.TabIndex = 7;
            this.lbDeptos.Text = "DEPARTAMENTOS";
            this.lbDeptos.Visible = false;
            // 
            // lbFunc
            // 
            this.lbFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFunc.AutoSize = true;
            this.lbFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFunc.ForeColor = System.Drawing.Color.White;
            this.lbFunc.Location = new System.Drawing.Point(468, 32);
            this.lbFunc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFunc.Name = "lbFunc";
            this.lbFunc.Size = new System.Drawing.Size(225, 31);
            this.lbFunc.TabIndex = 6;
            this.lbFunc.Text = "FUNCIONARIOS";
            this.lbFunc.Visible = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(471, 32);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(218, 31);
            this.lbTitulo.TabIndex = 4;
            this.lbTitulo.Text = "TURISMO REAL";
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(1059, -6);
            this.btnMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 40);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = " __";
            this.btnMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMin.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1110, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelCentral.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(240, 95);
            this.panelCentral.Margin = new System.Windows.Forms.Padding(2);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1160, 605);
            this.panelCentral.TabIndex = 2;
            // 
            // btnFunc
            // 
            this.btnFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFunc.FlatAppearance.BorderSize = 0;
            this.btnFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.ForeColor = System.Drawing.Color.White;
            this.btnFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnFunc.Image")));
            this.btnFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunc.Location = new System.Drawing.Point(0, 95);
            this.btnFunc.Margin = new System.Windows.Forms.Padding(2);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnFunc.Size = new System.Drawing.Size(240, 75);
            this.btnFunc.TabIndex = 2;
            this.btnFunc.Text = "  FUNCIONARIOS";
            this.btnFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFunc.UseVisualStyleBackColor = true;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            this.btnFunc.Leave += new System.EventHandler(this.btnFunc_Leave);
            // 
            // btnDeptos
            // 
            this.btnDeptos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeptos.FlatAppearance.BorderSize = 0;
            this.btnDeptos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnDeptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeptos.ForeColor = System.Drawing.Color.White;
            this.btnDeptos.Image = ((System.Drawing.Image)(resources.GetObject("btnDeptos.Image")));
            this.btnDeptos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeptos.Location = new System.Drawing.Point(0, 170);
            this.btnDeptos.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeptos.Name = "btnDeptos";
            this.btnDeptos.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnDeptos.Size = new System.Drawing.Size(240, 75);
            this.btnDeptos.TabIndex = 1;
            this.btnDeptos.Text = " DEPARTAMENTOS";
            this.btnDeptos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeptos.UseVisualStyleBackColor = true;
            this.btnDeptos.Click += new System.EventHandler(this.btnDeptos_Click);
            this.btnDeptos.Leave += new System.EventHandler(this.btnDeptos_Leave);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panelMenu.Controls.Add(this.colorDeptos);
            this.panelMenu.Controls.Add(this.colorFunc);
            this.panelMenu.Controls.Add(this.panelSubmenu);
            this.panelMenu.Controls.Add(this.btnDeptos);
            this.panelMenu.Controls.Add(this.panelUser);
            this.panelMenu.Controls.Add(this.btnFunc);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 700);
            this.panelMenu.TabIndex = 0;
            // 
            // colorDeptos
            // 
            this.colorDeptos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.colorDeptos.ForeColor = System.Drawing.Color.Transparent;
            this.colorDeptos.Location = new System.Drawing.Point(0, 170);
            this.colorDeptos.Margin = new System.Windows.Forms.Padding(2);
            this.colorDeptos.Name = "colorDeptos";
            this.colorDeptos.Size = new System.Drawing.Size(10, 75);
            this.colorDeptos.TabIndex = 6;
            this.colorDeptos.Visible = false;
            // 
            // colorFunc
            // 
            this.colorFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.colorFunc.ForeColor = System.Drawing.Color.Transparent;
            this.colorFunc.Location = new System.Drawing.Point(0, 95);
            this.colorFunc.Margin = new System.Windows.Forms.Padding(2);
            this.colorFunc.Name = "colorFunc";
            this.colorFunc.Size = new System.Drawing.Size(10, 75);
            this.colorFunc.TabIndex = 5;
            this.colorFunc.Visible = false;
            // 
            // panelSubmenu
            // 
            this.panelSubmenu.Controls.Add(this.colorDisp);
            this.panelSubmenu.Controls.Add(this.btnDisponibles);
            this.panelSubmenu.Controls.Add(this.colorMant);
            this.panelSubmenu.Controls.Add(this.btnMantencion);
            this.panelSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenu.Location = new System.Drawing.Point(0, 245);
            this.panelSubmenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelSubmenu.Name = "panelSubmenu";
            this.panelSubmenu.Size = new System.Drawing.Size(240, 110);
            this.panelSubmenu.TabIndex = 3;
            this.panelSubmenu.Visible = false;
            // 
            // colorDisp
            // 
            this.colorDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.colorDisp.ForeColor = System.Drawing.Color.Transparent;
            this.colorDisp.Location = new System.Drawing.Point(40, 52);
            this.colorDisp.Margin = new System.Windows.Forms.Padding(2);
            this.colorDisp.Name = "colorDisp";
            this.colorDisp.Size = new System.Drawing.Size(10, 50);
            this.colorDisp.TabIndex = 6;
            this.colorDisp.Visible = false;
            // 
            // btnDisponibles
            // 
            this.btnDisponibles.FlatAppearance.BorderSize = 0;
            this.btnDisponibles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnDisponibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponibles.ForeColor = System.Drawing.Color.White;
            this.btnDisponibles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisponibles.Location = new System.Drawing.Point(40, 52);
            this.btnDisponibles.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisponibles.Name = "btnDisponibles";
            this.btnDisponibles.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDisponibles.Size = new System.Drawing.Size(200, 50);
            this.btnDisponibles.TabIndex = 7;
            this.btnDisponibles.Text = "  DISPONIBLES";
            this.btnDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisponibles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisponibles.UseVisualStyleBackColor = true;
            this.btnDisponibles.Click += new System.EventHandler(this.btnDisponibles_Click);
            this.btnDisponibles.Leave += new System.EventHandler(this.btnDisponibles_Leave);
            // 
            // colorMant
            // 
            this.colorMant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.colorMant.ForeColor = System.Drawing.Color.Transparent;
            this.colorMant.Location = new System.Drawing.Point(40, 1);
            this.colorMant.Margin = new System.Windows.Forms.Padding(2);
            this.colorMant.Name = "colorMant";
            this.colorMant.Size = new System.Drawing.Size(10, 50);
            this.colorMant.TabIndex = 4;
            this.colorMant.Visible = false;
            // 
            // btnMantencion
            // 
            this.btnMantencion.FlatAppearance.BorderSize = 0;
            this.btnMantencion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnMantencion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantencion.ForeColor = System.Drawing.Color.White;
            this.btnMantencion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantencion.Location = new System.Drawing.Point(40, 1);
            this.btnMantencion.Margin = new System.Windows.Forms.Padding(2);
            this.btnMantencion.Name = "btnMantencion";
            this.btnMantencion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMantencion.Size = new System.Drawing.Size(200, 50);
            this.btnMantencion.TabIndex = 6;
            this.btnMantencion.Text = "  EN MANTENCIÓN";
            this.btnMantencion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantencion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMantencion.UseVisualStyleBackColor = true;
            this.btnMantencion.Click += new System.EventHandler(this.btnMantencion_Click);
            this.btnMantencion.Leave += new System.EventHandler(this.btnMantencion_Leave);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panelUser.Controls.Add(this.pictureBox1);
            this.panelUser.Controls.Add(this.lbUser);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUser.Location = new System.Drawing.Point(0, 620);
            this.panelUser.Margin = new System.Windows.Forms.Padding(2);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(240, 80);
            this.panelUser.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.White;
            this.lbUser.Location = new System.Drawing.Point(62, 30);
            this.lbUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(149, 20);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "ADMINISTRADOR";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 95);
            this.panelLogo.TabIndex = 0;
            // 
            // Main
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelSubmenu.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Button btnDeptos;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel colorMant;
        private System.Windows.Forms.Panel panelSubmenu;
        private System.Windows.Forms.Panel colorDisp;
        private System.Windows.Forms.Button btnDisponibles;
        private System.Windows.Forms.Button btnMantencion;
        private System.Windows.Forms.Label lbDeptos;
        private System.Windows.Forms.Label lbFunc;
        private System.Windows.Forms.Panel colorDeptos;
        private System.Windows.Forms.Panel colorFunc;
    }
}

