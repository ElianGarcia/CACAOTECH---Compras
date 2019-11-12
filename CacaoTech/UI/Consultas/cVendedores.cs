using CacaoTech.BLL;
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

namespace CacaoTech.UI.Consultas
{
    public partial class cVendedores : Form
    {
        public cVendedores()
        {
            InitializeComponent();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            var listado = new List<Productores>();
            GenericaBLL<Productores> genericaBLL = new GenericaBLL<Productores>();

            if (tbCriterio.Text.Trim().Length > 0)
            {
                switch (cbFiltrar.SelectedIndex)
                {
                    case 0:
                        listado = genericaBLL.GetList(estudiante => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(tbCriterio.Text);
                        listado = genericaBLL.GetList(vendedor => vendedor.ProductorID == id);
                        break;

                    case 2:
                        listado = genericaBLL.GetList(vendedor => vendedor.Nombres.Contains(tbCriterio.Text));
                        break;
                    case 3:
                        listado = genericaBLL.GetList(vendedor => vendedor.Cedula.Contains(tbCriterio.Text));
                        break;
                }

                listado = listado.Where(c => c.Fecha.Date >= DesdeDateTimePicker.Value.Date && c.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = genericaBLL.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
}
