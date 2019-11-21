using CacaoTech.BLL;
using CacaoTech.DAL;
using CacaoTech.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; 
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaoTech.UI.Registros
{
    public partial class rCacao : Form
    {
        GenericaBLL<Cacao> genericaBLL;
        int UsuarioID;
        public rCacao(int usuarioID)
        {
            genericaBLL = new GenericaBLL<Cacao>();
            InitializeComponent();
            LlenarCombo();
            UsuarioID = usuarioID;
            BuscarUsuario(usuarioID);
        }

        private void BuscarUsuario(int ID)
        {
            GenericaBLL<Usuarios> genericaBLL = new GenericaBLL<Usuarios>();
            Usuarios usuario = genericaBLL.Buscar(ID);
            Usuariolabel.Text = usuario.Nombres;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            TipocomboBox.Text = string.Empty;
            PreciotextBox.Text = string.Empty;
        }

        private bool Existe()
        {
            Cacao cacao = genericaBLL.Buscar((int)IDnumericUpDown.Value);

            return (cacao != null);
        }

        public void LlenarCombo()
        {
            TipocomboBox.DataSource = null;
            List<Cacao> lista = genericaBLL.GetList(p => true);
            TipocomboBox.DataSource = lista;
            TipocomboBox.DisplayMember = "Tipo";
            TipocomboBox.ValueMember = "CacaoID";
            TipocomboBox.SelectedValue = 0;
        }

        private Cacao LlenaClase()
        {
            Cacao cacao = new Cacao();
            cacao.CacaoID = Convert.ToInt32(IDnumericUpDown.Value);
            cacao.Tipo = TipocomboBox.SelectedIndex.ToString();
            cacao.Precio = Convert.ToDecimal(PreciotextBox.Text);
            cacao.UsuarioID = UsuarioID;

            return cacao;
        }

        private void LlenaCampos(Cacao cacao)
        {
            IDnumericUpDown.Value = cacao.CacaoID;
            TipocomboBox.Text = cacao.Tipo;
            PreciotextBox.Text = cacao.Precio.ToString();
        }

        private bool Validar()
        {
            bool realizado = true;
            string obligatorio = "Este campo es obligatorio";

            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(IDnumericUpDown.Text))
            {
                errorProvider.SetError(IDnumericUpDown, obligatorio);
                IDnumericUpDown.Focus();
                realizado = false;
            }

            if (string.IsNullOrWhiteSpace(TipocomboBox.Text))
            {
                errorProvider.SetError(TipocomboBox, obligatorio);
                TipocomboBox.Focus();
                realizado = false;
            }

            if (string.IsNullOrWhiteSpace(PreciotextBox.Text))
            {
                errorProvider.SetError(PreciotextBox, obligatorio);
                PreciotextBox.Focus();
                realizado = false;
            }

            return realizado;
        }

        private bool isAdministrador()
        {
            GenericaBLL<Usuarios> genericaBLL = new GenericaBLL<Usuarios>();
            Usuarios usuario = genericaBLL.Buscar(UsuarioID);

            return usuario.Nivel;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Cacao cacao = new Cacao();
            bool realizado = false;

            if (!Validar())
                return;

            cacao = LlenaClase();


            if (IDnumericUpDown.Value == 0)
                realizado = genericaBLL.Guardar(cacao);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("NO SE PUEDE MODIFICAR UN CACAO INEXISTENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                realizado = genericaBLL.Modificar(cacao);
            }

            if (realizado)
            {
                Limpiar();
                MessageBox.Show("GUARDADO EXITOSAMENTE", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("NO SE PUDO GUARDAR", "NO GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (isAdministrador())
            {
                int id;
                int.TryParse(IDnumericUpDown.Text, out id);

                Limpiar();

                //if (genericaBLL.Eliminar(id))
                //{
                //    MessageBox.Show("Eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //}
                //else
                //{
                    errorProvider.SetError(IDnumericUpDown, "No se puede eliminar un tipo de cacao");
                //}
            }
            else
            {
                MessageBox.Show("Debe tener permisos de administrador" +
                                        "para realizar ésta acción", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Cacao cacao = new Cacao();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            cacao = genericaBLL.Buscar(id);

            if (cacao != null)
            {
                LlenaCampos(cacao);
            }
            else
            {
                MessageBox.Show("No Encontrado");
            }
        }

        private void rCacao_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void PreciotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cultureInfo.NumberFormat.NumberDecimalSeparator)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private int ToInt(string valor)
        {
            int resultado = 0;
            int.TryParse(valor, out resultado);

            return resultado;
        }

        private void TipocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenericaBLL<Cacao> genericaCacaoBLL = new GenericaBLL<Cacao>();
            Cacao cacao = genericaCacaoBLL.Buscar(ToInt(TipocomboBox.SelectedIndex.ToString()));
            if (cacao != null)
            {
                PreciotextBox.Text = cacao.Precio.ToString();
            }
        }
    }
}