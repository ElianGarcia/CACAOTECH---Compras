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
    public partial class cCacao : Form
    {
        List<Cacao> cacaos;
        public cCacao()
        {
            cacaos = new List<Cacao>();
            InitializeComponent();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            Expression<Func<Cacao, bool>> filtro = c => true;
            GenericaBLL<Cacao> genericaBLL = new GenericaBLL<Cacao>();
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0:
                    filtro = c => true;
                    break;
                case 1://Filtrando por ID del Cacao.
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = c => c.CacaoID == id;
                    break;
                case 2://Filtrando por Nombre del Cacao.
                    filtro = c => c.Tipo.Contains(CriterioTextBox.Text);
                    break;
            }

            cacaos = genericaBLL.GetList(filtro);
            ConsultaDataGridView.DataSource = cacaos;
        }

        private void Imrimirbutton_Click(object sender, EventArgs e)
        {
            if (cacaos.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar en el Reporte");
                return;
            }
            CacaoReportViewer CacaoReviewer = new CacaoReportViewer(cacaos);
            CacaoReviewer.ShowDialog();
        }
    }
}
