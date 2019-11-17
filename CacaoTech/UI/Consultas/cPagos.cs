using CacaoTech.BLL;
using CacaoTech.Entidades;
using CacaoTech.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaoTech.UI.Consultas
{
    public partial class cPagos : Form
    {
        List<Pagos> Listado;
        public cPagos()
        {
            Listado = new List<Pagos>();
            InitializeComponent();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            Expression<Func<Pagos, bool>> filtro = c => true;

            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0:
                    filtro = c => true;
                    break;
                case 1://Filtrando por ID del Pago.
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = c => c.PagoID == id;
                    break;
                case 2://Filtrando por Nombre del Productor.
                    filtro = c => c.productores.Nombres.Contains(CriterioTextBox.Text);
                    break;
            }

            Listado = PagosBLL.GetList(filtro);
            ConsultaDataGridView.DataSource = Listado;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (Listado.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar en el Reporte");
                return;
            }
            PagosReportViewer Reviewer = new PagosReportViewer(Listado);
            Reviewer.ShowDialog();
        }
    }
}
