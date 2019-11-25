namespace CacaoTech.UI.Registros
{
    partial class rPagos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rPagos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.RemoverFilabutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.PrestamoComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AgregarPagobutton = new System.Windows.Forms.Button();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BalancetextBox = new System.Windows.Forms.TextBox();
            this.ProductorComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Usuariolabel = new System.Windows.Forms.Label();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.RegistrarProductoresbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Controls.Add(this.RemoverFilabutton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TotaltextBox);
            this.groupBox1.Controls.Add(this.PrestamoComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AgregarPagobutton);
            this.groupBox1.Controls.Add(this.CantidadtextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BalancetextBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 249);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagos:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(20, 73);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(393, 128);
            this.dataGridView.TabIndex = 86;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // RemoverFilabutton
            // 
            this.RemoverFilabutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RemoverFilabutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.RemoverFilabutton.FlatAppearance.BorderSize = 2;
            this.RemoverFilabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoverFilabutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.RemoverFilabutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RemoverFilabutton.Image = ((System.Drawing.Image)(resources.GetObject("RemoverFilabutton.Image")));
            this.RemoverFilabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverFilabutton.Location = new System.Drawing.Point(7, 207);
            this.RemoverFilabutton.Name = "RemoverFilabutton";
            this.RemoverFilabutton.Size = new System.Drawing.Size(136, 35);
            this.RemoverFilabutton.TabIndex = 85;
            this.RemoverFilabutton.Text = "Remover fila";
            this.RemoverFilabutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverFilabutton.UseVisualStyleBackColor = false;
            this.RemoverFilabutton.Click += new System.EventHandler(this.RemoverFilabutton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(249, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 83;
            this.label2.Text = "Total Pagado:";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotaltextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.TotaltextBox.Location = new System.Drawing.Point(345, 209);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(113, 25);
            this.TotaltextBox.TabIndex = 84;
            // 
            // PrestamoComboBox
            // 
            this.PrestamoComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PrestamoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrestamoComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.PrestamoComboBox.FormattingEnabled = true;
            this.PrestamoComboBox.Location = new System.Drawing.Point(20, 42);
            this.PrestamoComboBox.Name = "PrestamoComboBox";
            this.PrestamoComboBox.Size = new System.Drawing.Size(133, 25);
            this.PrestamoComboBox.TabIndex = 50;
            this.PrestamoComboBox.SelectedIndexChanged += new System.EventHandler(this.PrestamoComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(17, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "PrestamoID:";
            // 
            // AgregarPagobutton
            // 
            this.AgregarPagobutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AgregarPagobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.AgregarPagobutton.FlatAppearance.BorderSize = 2;
            this.AgregarPagobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarPagobutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.AgregarPagobutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AgregarPagobutton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarPagobutton.Image")));
            this.AgregarPagobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarPagobutton.Location = new System.Drawing.Point(413, 21);
            this.AgregarPagobutton.Name = "AgregarPagobutton";
            this.AgregarPagobutton.Size = new System.Drawing.Size(45, 46);
            this.AgregarPagobutton.TabIndex = 25;
            this.AgregarPagobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarPagobutton.UseVisualStyleBackColor = false;
            this.AgregarPagobutton.Click += new System.EventHandler(this.AgregarPagobutton_Click);
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CantidadtextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.CantidadtextBox.Location = new System.Drawing.Point(286, 42);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(121, 25);
            this.CantidadtextBox.TabIndex = 24;
            this.CantidadtextBox.TextChanged += new System.EventHandler(this.CantidadtextBox_TextChanged);
            this.CantidadtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadtextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(282, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(159, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 74;
            this.label1.Text = "Balance:";
            // 
            // BalancetextBox
            // 
            this.BalancetextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BalancetextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.BalancetextBox.Location = new System.Drawing.Point(163, 42);
            this.BalancetextBox.Name = "BalancetextBox";
            this.BalancetextBox.ReadOnly = true;
            this.BalancetextBox.Size = new System.Drawing.Size(113, 25);
            this.BalancetextBox.TabIndex = 75;
            // 
            // ProductorComboBox
            // 
            this.ProductorComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProductorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductorComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.ProductorComboBox.FormattingEnabled = true;
            this.ProductorComboBox.Location = new System.Drawing.Point(100, 53);
            this.ProductorComboBox.Name = "ProductorComboBox";
            this.ProductorComboBox.Size = new System.Drawing.Size(325, 25);
            this.ProductorComboBox.TabIndex = 72;
            this.ProductorComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductorescomboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 71;
            this.label3.Text = "Productor:";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FechadateTimePicker.CalendarFont = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold);
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(348, 18);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(128, 25);
            this.FechadateTimePicker.TabIndex = 62;
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IDnumericUpDown.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.IDnumericUpDown.Location = new System.Drawing.Point(100, 19);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(94, 25);
            this.IDnumericUpDown.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(294, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 19);
            this.label10.TabIndex = 59;
            this.label10.Text = "Fecha:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(15, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 19);
            this.label11.TabIndex = 58;
            this.label11.Text = "ID:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // Usuariolabel
            // 
            this.Usuariolabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Usuariolabel.AutoSize = true;
            this.Usuariolabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.Usuariolabel.Location = new System.Drawing.Point(41, 414);
            this.Usuariolabel.Name = "Usuariolabel";
            this.Usuariolabel.Size = new System.Drawing.Size(0, 17);
            this.Usuariolabel.TabIndex = 80;
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Imprimirbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Imprimirbutton.FlatAppearance.BorderSize = 2;
            this.Imprimirbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Imprimirbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Imprimirbutton.Image = ((System.Drawing.Image)(resources.GetObject("Imprimirbutton.Image")));
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Imprimirbutton.Location = new System.Drawing.Point(255, 343);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(100, 62);
            this.Imprimirbutton.TabIndex = 81;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Imprimirbutton.UseVisualStyleBackColor = false;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 413);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Eliminarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Eliminarbutton.FlatAppearance.BorderSize = 2;
            this.Eliminarbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(235)))), ((int)(((byte)(198)))));
            this.Eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(376, 343);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(100, 62);
            this.Eliminarbutton.TabIndex = 78;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = false;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Guardarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Guardarbutton.FlatAppearance.BorderSize = 2;
            this.Guardarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardarbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(134, 343);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(100, 62);
            this.Guardarbutton.TabIndex = 77;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = false;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Nuevobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Nuevobutton.FlatAppearance.BorderSize = 2;
            this.Nuevobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevobutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(12, 343);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(100, 62);
            this.Nuevobutton.TabIndex = 76;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // RegistrarProductoresbutton
            // 
            this.RegistrarProductoresbutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RegistrarProductoresbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.RegistrarProductoresbutton.FlatAppearance.BorderSize = 2;
            this.RegistrarProductoresbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrarProductoresbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.RegistrarProductoresbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegistrarProductoresbutton.Image = ((System.Drawing.Image)(resources.GetObject("RegistrarProductoresbutton.Image")));
            this.RegistrarProductoresbutton.Location = new System.Drawing.Point(431, 47);
            this.RegistrarProductoresbutton.Name = "RegistrarProductoresbutton";
            this.RegistrarProductoresbutton.Size = new System.Drawing.Size(45, 35);
            this.RegistrarProductoresbutton.TabIndex = 73;
            this.RegistrarProductoresbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegistrarProductoresbutton.UseVisualStyleBackColor = false;
            this.RegistrarProductoresbutton.Click += new System.EventHandler(this.RegistrarProductorbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Buscarbutton.FlatAppearance.BorderSize = 2;
            this.Buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(200, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(45, 35);
            this.Buscarbutton.TabIndex = 61;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // rPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(508, 434);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.Usuariolabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.RegistrarProductoresbutton);
            this.Controls.Add(this.ProductorComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rPagos";
            this.Text = "Registro de pagos";
            this.Load += new System.EventHandler(this.rDeposito_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AgregarPagobutton;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegistrarProductoresbutton;
        private System.Windows.Forms.ComboBox ProductorComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox BalancetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Label Usuariolabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox PrestamoComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Button RemoverFilabutton;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}