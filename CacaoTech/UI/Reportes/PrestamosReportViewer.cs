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

namespace CacaoTech.UI.Reportes
{
    public partial class PrestamosReportViewer : Form
    {
        List<Prestamos> prestamos;
        public PrestamosReportViewer(List<Prestamos> listado)
        {
            this.prestamos = listado;
            InitializeComponent();
        }

        private void PrestamosReportViewer_Load(object sender, EventArgs e)
        {
            ListadoPrestamos PrestamosCrystalReport = new ListadoPrestamos();
            PrestamosCrystalReport.SetDataSource(prestamos);

            crystalReportViewer1.ReportSource = PrestamosCrystalReport;
            PrestamosCrystalReport.Refresh();
        }
    }
}
