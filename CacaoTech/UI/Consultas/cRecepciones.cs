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
    public partial class cRecepciones : Form
    {
        List<Recepciones> recepciones;
        public cRecepciones()
        {
            InitializeComponent();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            Expression<Func<Recepciones, bool>> filtro = c => true;
            GenericaBLL<Recepciones> genericaBLL = new GenericaBLL<Recepciones>();
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0:
                    filtro = c => true;
                    break;
                case 1://Filtrando por ID de la Recepcion.
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = c => c.CacaoID == id;
                    break;
            }

            recepciones = genericaBLL.GetList(filtro);
            ConsultaDataGridView.DataSource = recepciones;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (recepciones.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar en el Reporte");
                return;
            }
            //RecepcionesReportViewer CacaoReviewer = new RecepcionesReportViewer(recepciones);
            //CacaoReviewer.ShowDialog();
        }
    }
}
