﻿using CacaoTech.BLL;
using CacaoTech.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaoTech
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CargarCombo();
        }

        private void CargarCombo()
        {
            UsuarioscomboBox.DataSource = null;
            GenericaBLL<Usuarios> genericaBLL = new GenericaBLL<Usuarios>();
            List<Usuarios> lista = genericaBLL.GetList(p => true);
            UsuarioscomboBox.DataSource = lista;
            UsuarioscomboBox.DisplayMember = "Nombres";
            UsuarioscomboBox.ValueMember = "UsuarioID";
        }

        private int ToInt(string valor)
        {
            int resultado = 0;
            int.TryParse(valor, out resultado);

            return resultado;
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            GenericaBLL<Usuarios> genericaBLL = new GenericaBLL<Usuarios>();
            int id = ToInt(UsuarioscomboBox.SelectedValue.ToString());

            Usuarios usuario = genericaBLL.Buscar(id);

            if(usuario.Contraseña == ContraseñatextBox.Text)
            {
                CacaoTech formPrincipal = new CacaoTech();
                this.Hide();
                formPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
