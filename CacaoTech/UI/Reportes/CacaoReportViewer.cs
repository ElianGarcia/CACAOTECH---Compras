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
    public partial class CacaoReportViewer : Form
    {
        private List<Cacao> ListaCacao;
        public CacaoReportViewer(List<Cacao> cacao)
        {
            this.ListaCacao = cacao;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ListadoCacao CacaoCrystalReport = new ListadoCacao();
            CacaoCrystalReport.SetDataSource(ListaCacao);

            crystalReportViewer1.ReportSource = CacaoCrystalReport;
            CacaoCrystalReport.Refresh();
        }
    }
}
