namespace CacaoTech.UI
{
    partial class RecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseña));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PreguntatextBox = new System.Windows.Forms.TextBox();
            this.RespuestatextBox = new System.Windows.Forms.TextBox();
            this.Recuperarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregunta de Seguridad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Respuesta:";
            // 
            // PreguntatextBox
            // 
            this.PreguntatextBox.Enabled = false;
            this.PreguntatextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.PreguntatextBox.Location = new System.Drawing.Point(16, 32);
            this.PreguntatextBox.Name = "PreguntatextBox";
            this.PreguntatextBox.Size = new System.Drawing.Size(388, 25);
            this.PreguntatextBox.TabIndex = 2;
            // 
            // RespuestatextBox
            // 
            this.RespuestatextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.RespuestatextBox.Location = new System.Drawing.Point(16, 72);
            this.RespuestatextBox.Name = "RespuestatextBox";
            this.RespuestatextBox.Size = new System.Drawing.Size(388, 25);
            this.RespuestatextBox.TabIndex = 3;
            // 
            // Recuperarbutton
            // 
            this.Recuperarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Recuperarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Recuperarbutton.FlatAppearance.BorderSize = 2;
            this.Recuperarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Recuperarbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Recuperarbutton.Location = new System.Drawing.Point(152, 103);
            this.Recuperarbutton.Name = "Recuperarbutton";
            this.Recuperarbutton.Size = new System.Drawing.Size(91, 32);
            this.Recuperarbutton.TabIndex = 4;
            this.Recuperarbutton.Text = "Recuperar";
            this.Recuperarbutton.UseVisualStyleBackColor = false;
            this.Recuperarbutton.Click += new System.EventHandler(this.Recuperarbutton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(418, 148);
            this.Controls.Add(this.Recuperarbutton);
            this.Controls.Add(this.RespuestatextBox);
            this.Controls.Add(this.PreguntatextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecuperarContraseña";
            this.Text = "Recuperar Contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PreguntatextBox;
        private System.Windows.Forms.TextBox RespuestatextBox;
        private System.Windows.Forms.Button Recuperarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}