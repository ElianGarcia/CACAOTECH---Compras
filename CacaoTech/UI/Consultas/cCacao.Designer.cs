namespace CacaoTech.UI.Consultas
{
    partial class cCacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cCacao));
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.Imrimirbutton = new System.Windows.Forms.Button();
            this.btConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(9, 55);
            this.ConsultaDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.ReadOnly = true;
            this.ConsultaDataGridView.RowTemplate.Height = 24;
            this.ConsultaDataGridView.Size = new System.Drawing.Size(620, 320);
            this.ConsultaDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(283, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Criterio";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todo",
            "ID",
            "Nombre"});
            this.FiltroComboBox.Location = new System.Drawing.Point(9, 26);
            this.FiltroComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(273, 25);
            this.FiltroComboBox.TabIndex = 3;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CriterioTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.CriterioTextBox.Location = new System.Drawing.Point(286, 26);
            this.CriterioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(222, 25);
            this.CriterioTextBox.TabIndex = 4;
            // 
            // Imrimirbutton
            // 
            this.Imrimirbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Imrimirbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Imrimirbutton.FlatAppearance.BorderSize = 2;
            this.Imrimirbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Imrimirbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Imrimirbutton.Image = ((System.Drawing.Image)(resources.GetObject("Imrimirbutton.Image")));
            this.Imrimirbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imrimirbutton.Location = new System.Drawing.Point(253, 382);
            this.Imrimirbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Imrimirbutton.Name = "Imrimirbutton";
            this.Imrimirbutton.Size = new System.Drawing.Size(108, 46);
            this.Imrimirbutton.TabIndex = 10;
            this.Imrimirbutton.Text = "Imprimir";
            this.Imrimirbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Imrimirbutton.UseVisualStyleBackColor = false;
            this.Imrimirbutton.Click += new System.EventHandler(this.Imrimirbutton_Click);
            // 
            // btConsulta
            // 
            this.btConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btConsulta.FlatAppearance.BorderSize = 2;
            this.btConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsulta.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btConsulta.Image")));
            this.btConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsulta.Location = new System.Drawing.Point(512, 15);
            this.btConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(117, 36);
            this.btConsulta.TabIndex = 5;
            this.btConsulta.Text = "Consultar";
            this.btConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btConsulta.UseVisualStyleBackColor = false;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // cCacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(640, 436);
            this.Controls.Add(this.Imrimirbutton);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsultaDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "cCacao";
            this.Text = "Consulta de Cacao";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultaDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Button Imrimirbutton;
    }
}