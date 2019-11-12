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
            ///ejecutarScript();
            InitializeComponent();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductores registroVendedores = new rProductores();
            registroVendedores.ShowDialog();
        }

        private void cacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCacao registroCacao = new rCacao();
            registroCacao.ShowDialog();
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPrestamos registroContrato = new rPrestamos();
            registroContrato.ShowDialog();
        }

        private void depositoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rRecepciones registroDeposito = new rRecepciones();
            registroDeposito.ShowDialog();
        }

        private void CacaoTech_Load(object sender, EventArgs e)
        {
            //ejecutarScript();
        }

        private void ejecutarScript()
        {
            ProcessStartInfo cmd = new ProcessStartInfo("sqlcmd", ".\\SQLEXPRESS -i " + "C:/Users/ASUS/source/repos/ProyectoFinal/CacaoTech/DAL/Scripts.sql");
            cmd.UseShellExecute = false;
            cmd.CreateNoWindow = true;
            cmd.RedirectStandardOutput = true;

            Process ejecutar = new Process();
            ejecutar.StartInfo = cmd;
            ejecutar.Start();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cVendedores consultaVendedores = new cVendedores();
            consultaVendedores.ShowDialog();
        }
    }
}
