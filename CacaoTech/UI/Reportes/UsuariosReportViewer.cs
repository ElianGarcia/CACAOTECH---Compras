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
    public partial class UsuariosReportViewer : Form
    {
        private List<Usuarios> ListaUsuarios;
        public UsuariosReportViewer(List<Usuarios> usuarios)
        {
            ListaUsuarios = usuarios;
            InitializeComponent();
        }

        private void crystalReportViewer_Load(object sender, EventArgs e)
        {
            ListadoUsuarios report = new ListadoUsuarios();
            report.SetDataSource(ListaUsuarios);

            crystalReportViewer.ReportSource = report;
            report.Refresh();
        }
    }
}
