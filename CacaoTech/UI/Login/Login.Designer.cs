namespace CacaoTech
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.UsuarioscomboBox = new System.Windows.Forms.ComboBox();
            this.ContraseñatextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VerContraseñacheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Loginbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Loginbutton.FlatAppearance.BorderSize = 2;
            this.Loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Loginbutton.Location = new System.Drawing.Point(13, 99);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(298, 31);
            this.Loginbutton.TabIndex = 2;
            this.Loginbutton.Text = "INICIAR SESIÓN";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // UsuarioscomboBox
            // 
            this.UsuarioscomboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UsuarioscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsuarioscomboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.UsuarioscomboBox.FormattingEnabled = true;
            this.UsuarioscomboBox.Location = new System.Drawing.Point(97, 18);
            this.UsuarioscomboBox.Name = "UsuarioscomboBox";
            this.UsuarioscomboBox.Size = new System.Drawing.Size(214, 25);
            this.UsuarioscomboBox.TabIndex = 3;
            // 
            // ContraseñatextBox
            // 
            this.ContraseñatextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.ContraseñatextBox.Location = new System.Drawing.Point(97, 56);
            this.ContraseñatextBox.Name = "ContraseñatextBox";
            this.ContraseñatextBox.PasswordChar = '*';
            this.ContraseñatextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContraseñatextBox.Size = new System.Drawing.Size(214, 25);
            this.ContraseñatextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(78, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "¿Olvidaste tu contraseña?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // VerContraseñacheckBox
            // 
            this.VerContraseñacheckBox.AutoSize = true;
            this.VerContraseñacheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerContraseñacheckBox.Image = ((System.Drawing.Image)(resources.GetObject("VerContraseñacheckBox.Image")));
            this.VerContraseñacheckBox.Location = new System.Drawing.Point(317, 52);
            this.VerContraseñacheckBox.Name = "VerContraseñacheckBox";
            this.VerContraseñacheckBox.Size = new System.Drawing.Size(44, 32);
            this.VerContraseñacheckBox.TabIndex = 7;
            this.VerContraseñacheckBox.UseVisualStyleBackColor = true;
            this.VerContraseñacheckBox.CheckedChanged += new System.EventHandler(this.VerContraseñabutton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 173);
            this.Controls.Add(this.VerContraseñacheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ContraseñatextBox);
            this.Controls.Add(this.UsuarioscomboBox);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.ComboBox UsuarioscomboBox;
        private System.Windows.Forms.TextBox ContraseñatextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox VerContraseñacheckBox;
    }
}