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
    public partial class cProductores : Form
    {
        List<Productores> productores;
        public cProductores()
        {
            productores = new List<Productores>();
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Expression<Func<Productores, bool>> filtro = c => true;
            GenericaBLL<Productores> genericaBLL = new GenericaBLL<Productores>();
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0:
                    filtro = c => true;
                    break;
                case 1://Filtrando por ID del Cliente.
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = c => c.ProductorID == id;
                    break;
                case 2://Filtrando por Nombres del Cliente.
                    filtro = c => c.Nombres.Contains(CriterioTextBox.Text);
                    break;
                case 3://Filtrando por NoTelefono del Cliente.
                    filtro = c => c.Telefono.Equals(CriterioTextBox.Text);
                    break;
                case 4://Filtrando por NoCedula del Cliente.
                    filtro = c => c.Cedula.Equals(CriterioTextBox.Text);
                    break;
                case 5://Filtrando por Direccion del Cliente.
                    filtro = c => c.Direccion.Equals(CriterioTextBox.Text);
                    break;
            }

            productores = genericaBLL.GetList(filtro);
            ConsultaDataGridView.DataSource = productores;
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            if (productores.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar en el Reporte");
                return;
            }
            ProductoresReportViewer productoresReviewer = new ProductoresReportViewer(productores);
            productoresReviewer.ShowDialog();
        }
    }
}
