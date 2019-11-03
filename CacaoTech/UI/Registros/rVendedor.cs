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
    public partial class rVendedor : Form
    {
        GenericaBLL<Vendedores> genericaBLL;
        public rVendedor()
        {
            genericaBLL = new GenericaBLL<Vendedores>();
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            ApellidostextBox.Text = string.Empty;
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

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Vendedores vendedor = new Vendedores();
            bool realizado = false;

            if (!Validar())
                return;

            vendedor = LlenaClase();


            if (IDnumericUpDown.Value == 0)
                realizado = genericaBLL.Guardar(vendedor);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("NO SE PUEDE MODIFICAR UN CACAO INEXISTENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                realizado = genericaBLL.Modificar(vendedor);
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
            Vendedores vendedor = new Vendedores();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            vendedor = genericaBLL.Buscar(id);

            if (vendedor != null)
            {
                LlenaCampos(vendedor);
            }
            else
            {
                MessageBox.Show("Cacao No Encontrado");
            }
        }
    }
}

