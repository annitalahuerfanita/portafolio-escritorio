namespace TurismoReal
{
    partial class Mantencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantencion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgMantencion = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.pbDisableEll = new System.Windows.Forms.PictureBox();
            this.pbDisableEdd = new System.Windows.Forms.PictureBox();
            this.lbAgg = new System.Windows.Forms.Label();
            this.pbDisableAgg = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rbMant = new System.Windows.Forms.RadioButton();
            this.rbDisp = new System.Windows.Forms.RadioButton();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbPeso = new System.Windows.Forms.Label();
            this.cbZona = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtBanos = new System.Windows.Forms.TextBox();
            this.lbMetros = new System.Windows.Forms.Label();
            this.lbBanos = new System.Windows.Forms.Label();
            this.txtDorm = new System.Windows.Forms.TextBox();
            this.lbZona = new System.Windows.Forms.Label();
            this.lbDorm = new System.Windows.Forms.Label();
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMantencion)).BeginInit();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisableEll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisableEdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisableAgg)).BeginInit();
            this.gbEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(745, 44);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 39);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseCompatibleTextRendering = true;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrar.Image")));
            this.btnMostrar.Location = new System.Drawing.Point(831, 44);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(155, 39);
            this.btnMostrar.TabIndex = 46;
            this.btnMostrar.Text = "     ACTUALIZAR";
            this.btnMostrar.UseCompatibleTextRendering = true;
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgMantencion
            // 
            this.dgMantencion.AllowUserToDeleteRows = false;
            this.dgMantencion.AllowUserToResizeColumns = false;
            this.dgMantencion.AllowUserToResizeRows = false;
            this.dgMantencion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgMantencion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.dgMantencion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgMantencion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(208)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMantencion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgMantencion.ColumnHeadersHeight = 30;
            this.dgMantencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgMantencion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estado,
            this.Inventario});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(208)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMantencion.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgMantencion.Location = new System.Drawing.Point(348, 107);
            this.dgMantencion.MultiSelect = false;
            this.dgMantencion.Name = "dgMantencion";
            this.dgMantencion.ReadOnly = true;
            this.dgMantencion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMantencion.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgMantencion.RowHeadersVisible = false;
            this.dgMantencion.RowHeadersWidth = 51;
            this.dgMantencion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgMantencion.RowTemplate.Height = 24;
            this.dgMantencion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgMantencion.Size = new System.Drawing.Size(829, 455);
            this.dgMantencion.TabIndex = 45;
            this.dgMantencion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDeptos_CellClick);
            this.dgMantencion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDeptos_CellDoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(608, 50);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(129, 26);
            this.txtBuscar.TabIndex = 42;
            // 
            // lbBuscar
            // 
            this.lbBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.lbBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.Location = new System.Drawing.Point(523, 52);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(84, 25);
            this.lbBuscar.TabIndex = 43;
            this.lbBuscar.Text = "Buscar :";
            // 
            // gbDatos
            // 
            this.gbDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.gbDatos.Controls.Add(this.pbDisableEll);
            this.gbDatos.Controls.Add(this.pbDisableEdd);
            this.gbDatos.Controls.Add(this.lbAgg);
            this.gbDatos.Controls.Add(this.pbDisableAgg);
            this.gbDatos.Controls.Add(this.btnAgregar);
            this.gbDatos.Controls.Add(this.gbEstado);
            this.gbDatos.Controls.Add(this.lbEstado);
            this.gbDatos.Controls.Add(this.lbPeso);
            this.gbDatos.Controls.Add(this.cbZona);
            this.gbDatos.Controls.Add(this.btnEliminar);
            this.gbDatos.Controls.Add(this.txtPrecio);
            this.gbDatos.Controls.Add(this.lbDireccion);
            this.gbDatos.Controls.Add(this.lbPrecio);
            this.gbDatos.Controls.Add(this.btnEditar);
            this.gbDatos.Controls.Add(this.txtDireccion);
            this.gbDatos.Controls.Add(this.txtBanos);
            this.gbDatos.Controls.Add(this.lbMetros);
            this.gbDatos.Controls.Add(this.lbBanos);
            this.gbDatos.Controls.Add(this.txtDorm);
            this.gbDatos.Controls.Add(this.lbZona);
            this.gbDatos.Controls.Add(this.lbDorm);
            this.gbDatos.Controls.Add(this.txtMetros);
            this.gbDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDatos.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(-20, 34);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatos.Size = new System.Drawing.Size(360, 530);
            this.gbDatos.TabIndex = 49;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Departamento";
            // 
            // pbDisableEll
            // 
            this.pbDisableEll.BackColor = System.Drawing.Color.LightGray;
            this.pbDisableEll.Image = ((System.Drawing.Image)(resources.GetObject("pbDisableEll.Image")));
            this.pbDisableEll.Location = new System.Drawing.Point(269, 448);
            this.pbDisableEll.Name = "pbDisableEll";
            this.pbDisableEll.Size = new System.Drawing.Size(69, 48);
            this.pbDisableEll.TabIndex = 58;
            this.pbDisableEll.TabStop = false;
            // 
            // pbDisableEdd
            // 
            this.pbDisableEdd.BackColor = System.Drawing.Color.LightGray;
            this.pbDisableEdd.Image = ((System.Drawing.Image)(resources.GetObject("pbDisableEdd.Image")));
            this.pbDisableEdd.Location = new System.Drawing.Point(193, 448);
            this.pbDisableEdd.Name = "pbDisableEdd";
            this.pbDisableEdd.Size = new System.Drawing.Size(69, 48);
            this.pbDisableEdd.TabIndex = 57;
            this.pbDisableEdd.TabStop = false;
            // 
            // lbAgg
            // 
            this.lbAgg.AutoSize = true;
            this.lbAgg.BackColor = System.Drawing.Color.LightGray;
            this.lbAgg.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgg.ForeColor = System.Drawing.Color.DimGray;
            this.lbAgg.Location = new System.Drawing.Point(60, 461);
            this.lbAgg.Name = "lbAgg";
            this.lbAgg.Size = new System.Drawing.Size(89, 22);
            this.lbAgg.TabIndex = 56;
            this.lbAgg.Text = "AGREGAR";
            // 
            // pbDisableAgg
            // 
            this.pbDisableAgg.BackColor = System.Drawing.Color.LightGray;
            this.pbDisableAgg.Image = ((System.Drawing.Image)(resources.GetObject("pbDisableAgg.Image")));
            this.pbDisableAgg.Location = new System.Drawing.Point(19, 448);
            this.pbDisableAgg.Name = "pbDisableAgg";
            this.pbDisableAgg.Size = new System.Drawing.Size(154, 48);
            this.pbDisableAgg.TabIndex = 55;
            this.pbDisableAgg.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(196)))), ((int)(((byte)(107)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(19, 450);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(152, 48);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "   AGREGAR";
            this.btnAgregar.UseCompatibleTextRendering = true;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rbMant);
            this.gbEstado.Controls.Add(this.rbDisp);
            this.gbEstado.Location = new System.Drawing.Point(171, 336);
            this.gbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEstado.Size = new System.Drawing.Size(171, 90);
            this.gbEstado.TabIndex = 54;
            this.gbEstado.TabStop = false;
            // 
            // rbMant
            // 
            this.rbMant.AutoSize = true;
            this.rbMant.Checked = true;
            this.rbMant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbMant.Location = new System.Drawing.Point(9, 23);
            this.rbMant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMant.Name = "rbMant";
            this.rbMant.Size = new System.Drawing.Size(128, 22);
            this.rbMant.TabIndex = 52;
            this.rbMant.TabStop = true;
            this.rbMant.Text = "En mantención";
            this.rbMant.UseVisualStyleBackColor = true;
            // 
            // rbDisp
            // 
            this.rbDisp.AutoSize = true;
            this.rbDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbDisp.Location = new System.Drawing.Point(9, 55);
            this.rbDisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbDisp.Name = "rbDisp";
            this.rbDisp.Size = new System.Drawing.Size(98, 22);
            this.rbDisp.TabIndex = 53;
            this.rbDisp.Text = "Disponible";
            this.rbDisp.UseVisualStyleBackColor = true;
            // 
            // lbEstado
            // 
            this.lbEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEstado.AutoSize = true;
            this.lbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(17, 375);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(61, 20);
            this.lbEstado.TabIndex = 51;
            this.lbEstado.Text = "Estado";
            // 
            // lbPeso
            // 
            this.lbPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPeso.AutoSize = true;
            this.lbPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lbPeso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbPeso.Location = new System.Drawing.Point(215, 300);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(23, 25);
            this.lbPeso.TabIndex = 48;
            this.lbPeso.Text = "$";
            // 
            // cbZona
            // 
            this.cbZona.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbZona.FormattingEnabled = true;
            this.cbZona.ItemHeight = 20;
            this.cbZona.Items.AddRange(new object[] {
            "Norte",
            "Sur",
            "Este",
            "Oeste"});
            this.cbZona.Location = new System.Drawing.Point(171, 98);
            this.cbZona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbZona.Name = "cbZona";
            this.cbZona.Size = new System.Drawing.Size(169, 28);
            this.cbZona.TabIndex = 2;
            this.cbZona.Text = "Seleccionar zona";
            this.cbZona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbZona_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(269, 450);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(69, 48);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.UseCompatibleTextRendering = true;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(240, 300);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 24);
            this.txtPrecio.TabIndex = 6;
            // 
            // lbDireccion
            // 
            this.lbDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lbDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(17, 52);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(81, 20);
            this.lbDireccion.TabIndex = 0;
            this.lbDireccion.Text = "Dirección";
            // 
            // lbPrecio
            // 
            this.lbPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lbPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(17, 302);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(103, 20);
            this.lbPrecio.TabIndex = 18;
            this.lbPrecio.Text = "Precio diario";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(103)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(193, 450);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(69, 48);
            this.btnEditar.TabIndex = 44;
            this.btnEditar.UseCompatibleTextRendering = true;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(171, 50);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(169, 24);
            this.txtDireccion.TabIndex = 1;
            // 
            // txtBanos
            // 
            this.txtBanos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanos.Location = new System.Drawing.Point(240, 250);
            this.txtBanos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBanos.Name = "txtBanos";
            this.txtBanos.Size = new System.Drawing.Size(100, 24);
            this.txtBanos.TabIndex = 5;
            // 
            // lbMetros
            // 
            this.lbMetros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMetros.AutoSize = true;
            this.lbMetros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lbMetros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMetros.Location = new System.Drawing.Point(17, 153);
            this.lbMetros.Name = "lbMetros";
            this.lbMetros.Size = new System.Drawing.Size(72, 20);
            this.lbMetros.TabIndex = 9;
            this.lbMetros.Text = "Metros ²";
            // 
            // lbBanos
            // 
            this.lbBanos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBanos.AutoSize = true;
            this.lbBanos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lbBanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbBanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBanos.Location = new System.Drawing.Point(17, 252);
            this.lbBanos.Name = "lbBanos";
            this.lbBanos.Size = new System.Drawing.Size(125, 20);
            this.lbBanos.TabIndex = 15;
            this.lbBanos.Text = "Cantidad baños";
            // 
            // txtDorm
            // 
            this.txtDorm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDorm.Location = new System.Drawing.Point(240, 199);
            this.txtDorm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDorm.Name = "txtDorm";
            this.txtDorm.Size = new System.Drawing.Size(100, 24);
            this.txtDorm.TabIndex = 4;
            // 
            // lbZona
            // 
            this.lbZona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbZona.AutoSize = true;
            this.lbZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lbZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbZona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZona.Location = new System.Drawing.Point(17, 102);
            this.lbZona.Name = "lbZona";
            this.lbZona.Size = new System.Drawing.Size(45, 20);
            this.lbZona.TabIndex = 11;
            this.lbZona.Text = "Zona";
            // 
            // lbDorm
            // 
            this.lbDorm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDorm.AutoSize = true;
            this.lbDorm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lbDorm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDorm.Location = new System.Drawing.Point(17, 202);
            this.lbDorm.Name = "lbDorm";
            this.lbDorm.Size = new System.Drawing.Size(127, 20);
            this.lbDorm.TabIndex = 13;
            this.lbDorm.Text = "Cantidad dorms";
            // 
            // txtMetros
            // 
            this.txtMetros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetros.Location = new System.Drawing.Point(240, 150);
            this.txtMetros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(100, 24);
            this.txtMetros.TabIndex = 3;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 80;
            // 
            // Inventario
            // 
            this.Inventario.HeaderText = "Inventario";
            this.Inventario.MinimumWidth = 6;
            this.Inventario.Name = "Inventario";
            this.Inventario.ReadOnly = true;
            this.Inventario.Width = 80;
            // 
            // Mantencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1160, 606);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgMantencion);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lbBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Mantencion";
            this.Text = "Departamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgMantencion)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisableEll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisableEdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisableAgg)).EndInit();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dgMantencion;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtBanos;
        private System.Windows.Forms.Label lbMetros;
        private System.Windows.Forms.Label lbBanos;
        private System.Windows.Forms.TextBox txtDorm;
        private System.Windows.Forms.Label lbZona;
        private System.Windows.Forms.Label lbDorm;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.ComboBox cbZona;
        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.RadioButton rbMant;
        private System.Windows.Forms.RadioButton rbDisp;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.PictureBox pbDisableAgg;
        private System.Windows.Forms.Label lbAgg;
        private System.Windows.Forms.PictureBox pbDisableEll;
        private System.Windows.Forms.PictureBox pbDisableEdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventario;
    }
}