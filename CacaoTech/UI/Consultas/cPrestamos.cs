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
    public partial class cPrestamos : Form
    {
        List<Prestamos> prestamos;
        public cPrestamos()
        {
            prestamos = new List<Prestamos>();
            InitializeComponent();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            Expression<Func<Prestamos, bool>> filtro = c => true;
            GenericaBLL<Prestamos> genericaBLL = new GenericaBLL<Prestamos>();
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0:
                    filtro = c => true;
                    break;
                case 1://Filtrando por ID del Cacao.
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = c => c.PrestamoID == id;
                    break;
                case 2://Filtrando por Nombre del Productor.
                    filtro = c => c.Productor.Nombres.Contains(CriterioTextBox.Text);
                    break;
            }

            prestamos = genericaBLL.GetList(filtro);
            ConsultaDataGridView.DataSource = prestamos;
        }

        private void Imrimirbutton_Click(object sender, EventArgs e)
        {
            if (prestamos.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar en el Reporte");
                return;
            }

            PrestamosReportViewer CacaoReviewer = new PrestamosReportViewer(prestamos);
            CacaoReviewer.ShowDialog();
        }
    }
}
