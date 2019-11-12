using CacaoTech.BLL;
using CacaoTech.DAL;
using CacaoTech.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaoTech.UI.Registros
{
    public partial class rContrato : Form
    {
        GenericaBLL<Productores> genericaVendedorBLL;
        GenericaBLL<Cacao> genericaCacaoBLL;
        public rContrato()
        {
            genericaVendedorBLL = new GenericaBLL<Productores>();
            genericaCacaoBLL = new GenericaBLL<Cacao>();
            InitializeComponent();
            LlenarCombos();
        }

        public void LlenarCombos()
        {
            //Llenando combobox de tipos de cacao
            TipoCacaocomboBox.DataSource = null;
            List<Cacao> lista1 = genericaCacaoBLL.GetList(p => true);
            TipoCacaocomboBox.DataSource = lista1;
            TipoCacaocomboBox.DisplayMember = "Tipo";
            TipoCacaocomboBox.ValueMember = "CacaoID";


            //Llenando combobox de vendedores
            VendedorescomboBox.DataSource = null;
            List<Productores> lista = genericaVendedorBLL.GetList(p => true);
            VendedorescomboBox.DataSource = lista;
            VendedorescomboBox.DisplayMember = "Nombre";
            VendedorescomboBox.ValueMember = "VendedorID";
        }

        private Decimal ToDecimal(string valor)
        {
            decimal resultado = 0;
            decimal.TryParse(valor, out resultado);

            return resultado;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Prestamos contrato = new Prestamos();

            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            contrato = ContratosBLL.Buscar(id);

            if (contrato != null)
            {
                LlenaCampos(contrato);
            }
            else
            {
                MessageBox.Show("Contrato no encontrado");
            }
        }

        private void LlenaCampos(Prestamos contrato)
        {
            IDnumericUpDown.Value = contrato.PrestamoID;
            //VendedorescomboBox.SelectedIndex = contrato.VendedorID;
            FechaIniciodateTimePicker.Value = contrato.FechaInicio;
            FechaFindateTimePicker.Value = contrato.FechaFin;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            VendedorescomboBox.Text = string.Empty;
            TipoCacaocomboBox.Text = string.Empty;
            FechaIniciodateTimePicker.Value = DateTime.Now;
            FechaFindateTimePicker.Value = DateTime.Now;
            CantidadtextBox.Text = string.Empty;
            errorProvider.Clear();
            CargarGrid();
        }

        private void CargarGrid()
        {
            DataGridViewCheckBoxColumn columna = new DataGridViewCheckBoxColumn();

            dataGridView.DataSource = null;
            //dataGridView.DataSource = this.depositosDetalles;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Prestamos contrato = new Prestamos();
            bool realizado = false;

            if (!Validar())
                return;

            contrato = LlenaClase();


            if (IDnumericUpDown.Value == 0)
                realizado = ContratosBLL.Guardar(contrato);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modificar un contrato inexistente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                realizado = ContratosBLL.Modificar(contrato);
            }

            if (realizado)
            {
                Limpiar();
                MessageBox.Show("Guardado exitosamente", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar", "NO GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ToInt(string valor)
        {
            int resultado = 0;
            int.TryParse(valor, out resultado);

            return resultado;
        }

        private Prestamos LlenaClase()
        {
            Prestamos contrato = new Prestamos();
            contrato.PrestamoID = ToInt(IDnumericUpDown.Value.ToString());
            //contrato.VendedorID = VendedorescomboBox.SelectedIndex;
            contrato.FechaInicio = FechaIniciodateTimePicker.Value;
            contrato.FechaFin = FechaFindateTimePicker.Value;

            return contrato;
        }

        private bool Existe()
        {
            Prestamos contrato = ContratosBLL.Buscar(ToInt(IDnumericUpDown.Value.ToString()));

            return (contrato != null);
        }

        private bool Validar()
        {
            bool validado = true;
            string obligatorio = "Campo obligatorio";

            if (string.IsNullOrWhiteSpace(IDnumericUpDown.Text))
            {
                errorProvider.SetError(IDnumericUpDown, obligatorio);
                IDnumericUpDown.Focus();
                validado = false;
            }

            return validado;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            Contexto db = new Contexto();

            Limpiar();

            if (ContratosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                errorProvider.SetError(IDnumericUpDown, "No se puede eliminar un deposito inexistente");
            }
        }

        private void PreciotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cultureInfo.NumberFormat.NumberDecimalSeparator)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void CantidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cultureInfo.NumberFormat.NumberDecimalSeparator)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void RegistrarVendedorbutton_Click(object sender, EventArgs e)
        {
            rProductores registroVendedor = new rProductores();
            registroVendedor.ShowDialog();
            LlenarCombos();
        }
    }
}
