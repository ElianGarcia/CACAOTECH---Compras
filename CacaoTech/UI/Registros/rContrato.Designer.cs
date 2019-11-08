namespace CacaoTech.UI.Registros
{
    partial class rContrato
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rContrato));
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Quitarbutton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCacaocomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.AgregarTipobutton = new System.Windows.Forms.Button();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FechaFindateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaIniciodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.VendedorescomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RegistrarVendedorbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.PreciotextBox.Location = new System.Drawing.Point(119, 53);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(317, 25);
            this.PreciotextBox.TabIndex = 38;
            this.PreciotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreciotextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(8, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 37;
            this.label6.Text = "Precio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Controls.Add(this.TipoCacaocomboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CantidadtextBox);
            this.groupBox1.Controls.Add(this.AgregarTipobutton);
            this.groupBox1.Controls.Add(this.PreciotextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(9, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 189);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contratos";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quitarbutton,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView.Location = new System.Drawing.Point(0, 84);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(497, 102);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // Quitarbutton
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Quitarbutton.DefaultCellStyle = dataGridViewCellStyle1;
            this.Quitarbutton.FillWeight = 50F;
            this.Quitarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quitarbutton.HeaderText = "Quitar";
            this.Quitarbutton.Name = "Quitarbutton";
            this.Quitarbutton.Text = "-";
            this.Quitarbutton.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Monto";
            this.Column4.Name = "Column4";
            // 
            // TipoCacaocomboBox
            // 
            this.TipoCacaocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoCacaocomboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.TipoCacaocomboBox.FormattingEnabled = true;
            this.TipoCacaocomboBox.Location = new System.Drawing.Point(119, 21);
            this.TipoCacaocomboBox.Name = "TipoCacaocomboBox";
            this.TipoCacaocomboBox.Size = new System.Drawing.Size(142, 25);
            this.TipoCacaocomboBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tipo de cacao:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(269, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Cantidad:";
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.CantidadtextBox.Location = new System.Drawing.Point(343, 21);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(93, 25);
            this.CantidadtextBox.TabIndex = 31;
            this.CantidadtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadtextBox_KeyPress);
            // 
            // AgregarTipobutton
            // 
            this.AgregarTipobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.AgregarTipobutton.FlatAppearance.BorderSize = 2;
            this.AgregarTipobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarTipobutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.AgregarTipobutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AgregarTipobutton.Image = global::CacaoTech.Properties.Resources.Add_32;
            this.AgregarTipobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarTipobutton.Location = new System.Drawing.Point(443, 21);
            this.AgregarTipobutton.Name = "AgregarTipobutton";
            this.AgregarTipobutton.Size = new System.Drawing.Size(45, 56);
            this.AgregarTipobutton.TabIndex = 33;
            this.AgregarTipobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarTipobutton.UseVisualStyleBackColor = false;
            this.AgregarTipobutton.Click += new System.EventHandler(this.AgregarDepositobutton_Click);
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.IDnumericUpDown.Location = new System.Drawing.Point(116, 14);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(88, 25);
            this.IDnumericUpDown.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // FechaFindateTimePicker
            // 
            this.FechaFindateTimePicker.CalendarFont = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold);
            this.FechaFindateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaFindateTimePicker.Enabled = false;
            this.FechaFindateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.FechaFindateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaFindateTimePicker.Location = new System.Drawing.Point(374, 44);
            this.FechaFindateTimePicker.Name = "FechaFindateTimePicker";
            this.FechaFindateTimePicker.Size = new System.Drawing.Size(132, 25);
            this.FechaFindateTimePicker.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(280, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Fecha de fin:";
            // 
            // FechaIniciodateTimePicker
            // 
            this.FechaIniciodateTimePicker.CalendarFont = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold);
            this.FechaIniciodateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaIniciodateTimePicker.Enabled = false;
            this.FechaIniciodateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.FechaIniciodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIniciodateTimePicker.Location = new System.Drawing.Point(116, 44);
            this.FechaIniciodateTimePicker.Name = "FechaIniciodateTimePicker";
            this.FechaIniciodateTimePicker.Size = new System.Drawing.Size(128, 25);
            this.FechaIniciodateTimePicker.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(5, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 19);
            this.label7.TabIndex = 41;
            this.label7.Text = "Fecha de inicio:";
            // 
            // VendedorescomboBox
            // 
            this.VendedorescomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VendedorescomboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.VendedorescomboBox.FormattingEnabled = true;
            this.VendedorescomboBox.Location = new System.Drawing.Point(116, 82);
            this.VendedorescomboBox.Name = "VendedorescomboBox";
            this.VendedorescomboBox.Size = new System.Drawing.Size(342, 25);
            this.VendedorescomboBox.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(5, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Vendedor:";
            // 
            // RegistrarVendedorbutton
            // 
            this.RegistrarVendedorbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.RegistrarVendedorbutton.FlatAppearance.BorderSize = 2;
            this.RegistrarVendedorbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrarVendedorbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.RegistrarVendedorbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegistrarVendedorbutton.Image = global::CacaoTech.Properties.Resources.Add_User_Male_32;
            this.RegistrarVendedorbutton.Location = new System.Drawing.Point(461, 76);
            this.RegistrarVendedorbutton.Name = "RegistrarVendedorbutton";
            this.RegistrarVendedorbutton.Size = new System.Drawing.Size(45, 35);
            this.RegistrarVendedorbutton.TabIndex = 45;
            this.RegistrarVendedorbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegistrarVendedorbutton.UseVisualStyleBackColor = false;
            this.RegistrarVendedorbutton.Click += new System.EventHandler(this.RegistrarVendedorbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Eliminarbutton.FlatAppearance.BorderSize = 2;
            this.Eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Eliminarbutton.Image = global::CacaoTech.Properties.Resources.Trash_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(376, 326);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(130, 60);
            this.Eliminarbutton.TabIndex = 36;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = false;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Guardarbutton.FlatAppearance.BorderSize = 2;
            this.Guardarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardarbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Guardarbutton.Image = global::CacaoTech.Properties.Resources.Save_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(193, 326);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(130, 60);
            this.Guardarbutton.TabIndex = 35;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = false;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Nuevobutton.FlatAppearance.BorderSize = 2;
            this.Nuevobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevobutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Nuevobutton.Image = global::CacaoTech.Properties.Resources.Plus_Math_32;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(9, 326);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(130, 60);
            this.Nuevobutton.TabIndex = 34;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Buscarbutton.FlatAppearance.BorderSize = 2;
            this.Buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Buscarbutton.Image = global::CacaoTech.Properties.Resources.Search_32;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(223, 4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(93, 35);
            this.Buscarbutton.TabIndex = 25;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // rContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(536, 396);
            this.Controls.Add(this.RegistrarVendedorbutton);
            this.Controls.Add(this.VendedorescomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaIniciodateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FechaFindateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "rContrato";
            this.Text = "Nuevo Contrato";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button AgregarTipobutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TipoCacaocomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox VendedorescomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechaIniciodateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker FechaFindateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn Quitarbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button RegistrarVendedorbutton;
    }
}