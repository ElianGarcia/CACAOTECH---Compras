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
using CacaoTech.UI.Reportes;
using CacaoTech.Entidades;
using CacaoTech.BLL;

namespace CacaoTech
{
    public partial class CacaoTech : Form
    {
        public CacaoTech()
        {
            InitializeComponent();
        }

        //Registros
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

        //Reportes
        private void productoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenericaBLL<Productores> genericaBLL = new GenericaBLL<Productores>();
            List<Productores> listado = genericaBLL.GetList(p => true);

            if (listado.Count > 0)
            {
                ProductoresReportViewer reportViewer = new ProductoresReportViewer(listado);
                reportViewer.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se han encontrado datos", "Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenericaBLL<Prestamos> genericaBLL = new GenericaBLL<Prestamos>();
            List<Prestamos> listado = genericaBLL.GetList(p => true);

            if (listado.Count > 0)
            {
                PrestamosReportViewer reportViewer = new PrestamosReportViewer(listado);
                reportViewer.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se han encontrado datos", "Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cacaosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Prestamos> listado = PrestamosBLL.GetList(p => true);

            if (listado.Count > 0)
            {
                PrestamosReportViewer reportViewer = new PrestamosReportViewer(listado);
                reportViewer.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se han encontrado datos", "Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Pagos> listado = PagosBLL.GetList(p => true);

            if (listado.Count > 0)
            {
                PagosReportViewer reportViewer = new PagosReportViewer(listado);
                reportViewer.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se han encontrado datos", "Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Consultas
        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cProductores consulta = new cProductores();
            consulta.ShowDialog();
        }

        private void prestamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cPrestamos consulta = new cPrestamos();
            consulta.ShowDialog();
        }

        private void pagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cPagos consulta = new cPagos();
            consulta.ShowDialog();
        }

        private void cacaosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cCacao consulta = new cCacao();
            consulta.ShowDialog();
        }

        private void recepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cRecepciones consulta = new cRecepciones();
            consulta.ShowDialog();
        }
    }
}
