using CacaoTech.BLL;
using CacaoTech.DAL;
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

namespace CacaoTech.UI.Registros
{
    public partial class rCacao : Form
    {
        GenericaBLL<Cacao> genericaBLL;
        public rCacao()
        {
            genericaBLL = new GenericaBLL<Cacao>();
            InitializeComponent();
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

        private Cacao LlenaClase()
        {
            Cacao cacao = new Cacao();
            cacao.CacaoID = Convert.ToInt32(IDnumericUpDown.Value);
            cacao.Tipo = TipocomboBox.SelectedIndex.ToString();
            cacao.Precio = PreciotextBox.Text;

            return cacao;
        }

        private void LlenaCampos(Cacao cacao)
        {
            IDnumericUpDown.Value = cacao.CacaoID;
            TipocomboBox.Text = cacao.Tipo;
            PreciotextBox.Text = cacao.Precio;
        }

        private bool Validar()
        {
            bool realizado = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(IDnumericUpDown.Text))
            {
                errorProvider.SetError(IDnumericUpDown, "EL CAMPO ID NO PUEDE ESTAR VACIO");
                IDnumericUpDown.Focus();
                realizado = false;
            }

            if (string.IsNullOrWhiteSpace(TipocomboBox.Text))
            {
                errorProvider.SetError(TipocomboBox, "EL CAMPO TIPO NO PUEDE ESTAR VACIO");
                TipocomboBox.Focus();
                realizado = false;
            }

            if (string.IsNullOrWhiteSpace(PreciotextBox.Text))
            {
                errorProvider.SetError(PreciotextBox, "EL CAMPO PRECIO NO PUEDE ESTAR VACIO");
                PreciotextBox.Focus();
                realizado = false;
            }

            return realizado;
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

            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            Contexto db = new Contexto();

            Limpiar();

            if (genericaBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                errorProvider.SetError(IDnumericUpDown, "No se puede eliminar un cacao inexistente");
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
                MessageBox.Show("Cacao No Encontrado");
            }
        }
    }
}
