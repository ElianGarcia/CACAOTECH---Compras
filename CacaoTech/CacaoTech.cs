using CacaoTech.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CacaoTech.DAL;
using CacaoTech.UI.Consultas;

namespace CacaoTech
{
    public partial class CacaoTech : Form
    {
        public CacaoTech()
        {
            InitializeComponent();
        }

        private void productorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductores registroProductor = new rProductores();
            registroProductor.ShowDialog();
        }

        private void cacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCacao registroCacao = new rCacao();
            registroCacao.ShowDialog();
        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPrestamos registroPrestamo = new rPrestamos();
            registroPrestamo.ShowDialog();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cVendedores consultaVendedores = new cVendedores();
            consultaVendedores.ShowDialog();
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPagos pagos = new rPagos();
            pagos.ShowDialog();
        }

        private void recepcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rRecepciones registroRecepcion = new rRecepciones();
            registroRecepcion.ShowDialog();
        }
    }
}
