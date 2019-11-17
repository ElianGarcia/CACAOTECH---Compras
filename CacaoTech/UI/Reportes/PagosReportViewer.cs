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
    public partial class PagosReportViewer : Form
    {
        List<Pagos> ListaPagos;
        public PagosReportViewer(List<Pagos> listaPagos)
        {
            this.ListaPagos = listaPagos;
            InitializeComponent();
        }

        private void pagosReportViewer1_Load(object sender, EventArgs e)
        {
            ListadoPagos PagosCrystalReport = new ListadoPagos();
            PagosCrystalReport.SetDataSource(ListaPagos);

            pagosReportViewer1.ReportSource = PagosCrystalReport;
            PagosCrystalReport.Refresh();
        }
    }
}
