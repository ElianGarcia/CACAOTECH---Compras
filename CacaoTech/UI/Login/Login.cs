using CacaoTech.BLL;
using CacaoTech.Entidades;
using CacaoTech.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            Seguridad seguridad = new Seguridad();

            Usuarios usuario = genericaBLL.Buscar(id);

            if (string.IsNullOrWhiteSpace(ContraseñatextBox.Text))
                return;

            string c = seguridad.descifrarTexto(usuario.Contraseña);

            if (c == ContraseñatextBox.Text)
            {
                CacaoTech formPrincipal = new CacaoTech(usuario.UsuarioID);
                this.Hide();
                formPrincipal.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            int id = ToInt(UsuarioscomboBox.SelectedValue.ToString());
            RecuperarContraseña recovery = new RecuperarContraseña(id);
            recovery.ShowDialog();
        }

        private void VerContraseñabutton_Click(object sender, EventArgs e)
        {
            string contraseña = ContraseñatextBox.Text;
            if (VerContraseñacheckBox.Checked)
            {
                ContraseñatextBox.UseSystemPasswordChar = false;
                ContraseñatextBox.Text = contraseña;
            }
            else
            {
                ContraseñatextBox.UseSystemPasswordChar = true;
                ContraseñatextBox.Text = contraseña;
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
