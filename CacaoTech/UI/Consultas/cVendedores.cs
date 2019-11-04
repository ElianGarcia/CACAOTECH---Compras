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
            /*var listado = new List<Estudiantes>();

            if (tbCriterio.Text.Trim().Length > 0)
            {
                switch (cbFiltrar.SelectedIndex)
                {
                    case 0:
                        listado = EstudiantesBLL.GetList(estudiante => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(tbCriterio.Text);
                        listado = EstudiantesBLL.GetList(estudiante => estudiante.EstudianteId == id);
                        break;

                    case 2:
                        listado = EstudiantesBLL.GetList(estudiante => estudiante.Nombres.Contains(tbCriterio.Text));
                        break; 33333
                    case 3:
                        listado = EstudiantesBLL.GetList(estudiante => estudiante.Cedula.Contains(tbCriterio.Text));
                        break;

                    case 4:
                        listado = EstudiantesBLL.GetList(estudiante => estudiante.Matricula.Contains(tbCriterio.Text));
                        break;
                }

                listado = listado.Where(c => c.FechaDeNacimiento.Date >= DesdeDateTimePicker.Value.Date && c.FechaDeNacimiento.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = EstudiantesBLL.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;*/
        }
    }
}
