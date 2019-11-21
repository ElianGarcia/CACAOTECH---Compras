namespace CacaoTech
{
    partial class CacaoTech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CacaoTech));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cacaosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Usuariolabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendedorToolStripMenuItem,
            this.cacaoToolStripMenuItem,
            this.contratoToolStripMenuItem,
            this.depositoToolStripMenuItem,
            this.recepcionToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.vendedorToolStripMenuItem.Text = "Productor";
            this.vendedorToolStripMenuItem.Click += new System.EventHandler(this.productorToolStripMenuItem_Click);
            // 
            // cacaoToolStripMenuItem
            // 
            this.cacaoToolStripMenuItem.Name = "cacaoToolStripMenuItem";
            this.cacaoToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.cacaoToolStripMenuItem.Text = "Cacao";
            this.cacaoToolStripMenuItem.Click += new System.EventHandler(this.cacaoToolStripMenuItem_Click);
            // 
            // contratoToolStripMenuItem
            // 
            this.contratoToolStripMenuItem.Name = "contratoToolStripMenuItem";
            this.contratoToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.contratoToolStripMenuItem.Text = "Prestamo";
            this.contratoToolStripMenuItem.Click += new System.EventHandler(this.prestamoToolStripMenuItem_Click);
            // 
            // depositoToolStripMenuItem
            // 
            this.depositoToolStripMenuItem.Name = "depositoToolStripMenuItem";
            this.depositoToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.depositoToolStripMenuItem.Text = "Pago";
            this.depositoToolStripMenuItem.Click += new System.EventHandler(this.pagoToolStripMenuItem_Click);
            // 
            // recepcionToolStripMenuItem
            // 
            this.recepcionToolStripMenuItem.Name = "recepcionToolStripMenuItem";
            this.recepcionToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.recepcionToolStripMenuItem.Text = "Recepcion";
            this.recepcionToolStripMenuItem.Click += new System.EventHandler(this.recepcionToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendedoresToolStripMenuItem,
            this.prestamosToolStripMenuItem1,
            this.pagosToolStripMenuItem1,
            this.cacaosToolStripMenuItem1,
            this.recepcionesToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.vendedoresToolStripMenuItem.Text = "Productores";
            this.vendedoresToolStripMenuItem.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem1
            // 
            this.prestamosToolStripMenuItem1.Name = "prestamosToolStripMenuItem1";
            this.prestamosToolStripMenuItem1.Size = new System.Drawing.Size(164, 24);
            this.prestamosToolStripMenuItem1.Text = "Prestamos";
            this.prestamosToolStripMenuItem1.Click += new System.EventHandler(this.prestamosToolStripMenuItem1_Click);
            // 
            // pagosToolStripMenuItem1
            // 
            this.pagosToolStripMenuItem1.Name = "pagosToolStripMenuItem1";
            this.pagosToolStripMenuItem1.Size = new System.Drawing.Size(164, 24);
            this.pagosToolStripMenuItem1.Text = "Pagos";
            this.pagosToolStripMenuItem1.Click += new System.EventHandler(this.pagosToolStripMenuItem1_Click);
            // 
            // cacaosToolStripMenuItem1
            // 
            this.cacaosToolStripMenuItem1.Name = "cacaosToolStripMenuItem1";
            this.cacaosToolStripMenuItem1.Size = new System.Drawing.Size(164, 24);
            this.cacaosToolStripMenuItem1.Text = "Cacaos";
            this.cacaosToolStripMenuItem1.Click += new System.EventHandler(this.cacaosToolStripMenuItem1_Click);
            // 
            // recepcionesToolStripMenuItem
            // 
            this.recepcionesToolStripMenuItem.Name = "recepcionesToolStripMenuItem";
            this.recepcionesToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.recepcionesToolStripMenuItem.Text = "Recepciones";
            this.recepcionesToolStripMenuItem.Click += new System.EventHandler(this.recepcionesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CacaoTech.Properties.Resources.Male_User;
            this.pictureBox1.Location = new System.Drawing.Point(12, 421);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Usuariolabel
            // 
            this.Usuariolabel.AutoSize = true;
            this.Usuariolabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.Usuariolabel.Location = new System.Drawing.Point(38, 422);
            this.Usuariolabel.Name = "Usuariolabel";
            this.Usuariolabel.Size = new System.Drawing.Size(0, 17);
            this.Usuariolabel.TabIndex = 2;
            // 
            // CacaoTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::CacaoTech.Properties.Resources.Icono_Principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Usuariolabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CacaoTech";
            this.Text = "CacaoTech";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cacaosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recepcionesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Usuariolabel;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
    }
}

