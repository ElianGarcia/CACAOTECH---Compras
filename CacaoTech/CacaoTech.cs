using CacaoTech.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CacaoTech.DAL;
using CacaoTech.UI.Consultas;
using CacaoTech.UI.Reportes;
using CacaoTech.Entidades;
using CacaoTech.BLL;

namespace CacaoTech
{
    public partial class CacaoTech : Form
    {
        int ID;
        public CacaoTech(int usuarioID)
        {
            InitializeComponent();
            BuscarUsuario(usuarioID);
            ID = usuarioID;
        }

        private void BuscarUsuario(int ID)
        {
            GenericaBLL<Usuarios> genericaBLL = new GenericaBLL<Usuarios>();
            Usuarios usuario = genericaBLL.Buscar(ID);
            Usuariolabel.Text = usuario.Nombres;
        }

        //Registros
        private void productorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductores registroProductor = new rProductores(ID);
            registroProductor.MdiParent = this;
            registroProductor.Show();
        }

        private void cacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCacao registroCacao = new rCacao(ID);
            registroCacao.MdiParent = this;
            registroCacao.Show();
        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPrestamos registroPrestamo = new rPrestamos(ID);
            registroPrestamo.MdiParent = this;
            registroPrestamo.Show();
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPagos pagos = new rPagos(ID);
            pagos.MdiParent = this;
            pagos.Show();
        }

        private void recepcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rRecepciones registroRecepcion = new rRecepciones(ID);
            registroRecepcion.MdiParent = this;
            registroRecepcion.Show();
        }



        ////Reportes
        //private void productoresToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    GenericaBLL<Productores> genericaBLL = new GenericaBLL<Productores>();
        //    List<Productores> listado = genericaBLL.GetList(p => true);

        //    if (listado.Count > 0)
        //    {
        //        ProductoresReportViewer reportViewer = new ProductoresReportViewer(listado);
        //        reportViewer.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("No se han encontrado datos", "Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        //private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    GenericaBLL<Prestamos> genericaBLL = new GenericaBLL<Prestamos>();
        //    List<Prestamos> listado = genericaBLL.GetList(p => true);

        //    if (listado.Count > 0)
        //    {
        //        PrestamosReportViewer reportViewer = new PrestamosReportViewer(listado);
        //        reportViewer.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("No se han encontrado datos", "Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        //private void cacaosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    GenericaBLL<Cacao> genericaBLL = new GenericaBLL<Cacao>();
        //    List<Cacao> listado = genericaBLL.GetList(p => true);

        //    if (listado.Count > 0)
        //    {
        //        CacaoReportViewer reportViewer = new CacaoReportViewer(listado);
        //        reportViewer.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("No se han encontrado datos", "Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        //private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    List<Pagos> listado = PagosBLL.GetList(p => true);

        //    if (listado.Count > 0)
        //    {
        //        PagosReportViewer reportViewer = new PagosReportViewer(listado);
        //        reportViewer.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("No se han encontrado datos", "Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private void recepcionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En Proceso", "Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Consultas
        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cProductores consulta = new cProductores();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void prestamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cPrestamos consulta = new cPrestamos();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void pagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cPagos consulta = new cPagos();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void cacaosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cCacao consulta = new cCacao();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void recepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cRecepciones consulta = new cRecepciones();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private bool isAdministrador()
        {
            GenericaBLL<Usuarios> genericaBLL = new GenericaBLL<Usuarios>();
            Usuarios usuario = genericaBLL.Buscar(ID);

            return usuario.Nivel;
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(isAdministrador())
            {
                rUsuarios usuarios = new rUsuarios(ID);
                usuarios.MdiParent = this;
                usuarios.Show();
            } 
            else
            {
                MessageBox.Show("Debe tener permisos de administrador" +
                    " para registrar un nuevo usuario", 
                    "Permiso denegado", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
