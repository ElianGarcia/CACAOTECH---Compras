using CacaoTech.UI.Registros;
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
    public partial class CacaoTech : Form
    {
        public CacaoTech()
        {
            InitializeComponent();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVendedor registroVendedores = new rVendedor();
            registroVendedores.ShowDialog();
        }

        private void cacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCacao registroCacao = new rCacao();
            registroCacao.ShowDialog();
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void depositoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rDeposito registroDeposito = new rDeposito();
            registroDeposito.ShowDialog();
        }
    }
}
