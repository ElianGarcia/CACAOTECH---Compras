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
    public partial class PagosDetalleViewer : Form
    {
        private List<PagosDetalle> Lista;
        public PagosDetalleViewer(List<PagosDetalle> pagosDetalles)
        {
            this.Lista = pagosDetalles;
            InitializeComponent();
        }

        private void PagosDetalleViewer_Load(object sender, EventArgs e)
        {
            Recibo Report = new Recibo();
            Report.SetDataSource(Lista);

            crystalReportViewer1.ReportSource = Report;
            Report.Refresh();
        }
    }
}
