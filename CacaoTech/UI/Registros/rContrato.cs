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
        public List<ContratosDetalle> contratosDetalle { get; set; }
        GenericaBLL<Vendedores> genericaVendedorBLL;
        GenericaBLL<Cacao> genericaCacaoBLL;
        public rContrato()
        {
            genericaVendedorBLL = new GenericaBLL<Vendedores>();
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
            List<Vendedores> lista = genericaVendedorBLL.GetList(p => true);
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
            Contratos contrato = new Contratos();

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

        private void LlenaCampos(Contratos contrato)
        {
            throw new NotImplementedException();
        }

        private void AgregarDepositobutton_Click(object sender, EventArgs e)
        {
            Contexto db = new Contexto();
            Cacao cacao;

            if (dataGridView.DataSource != null)
            {
                this.contratosDetalle = (List<ContratosDetalle>)dataGridView.DataSource;
            }

            this.contratosDetalle.Add(
                new ContratosDetalle(
                    contratosDetalleID: 0,
                    cacaoID: TipoCacaocomboBox.SelectedIndex,
                    cantidad: ToDecimal(CantidadtextBox.Text),
                    precio: ToDecimal(PreciotextBox.Text)
                    )
                );

            CargarGrid();
            TipoCacaocomboBox.Focus();
            TipoCacaocomboBox.SelectedIndex = 0;
            CantidadtextBox.Clear();
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
            //this.depositosDetalles = new List<DepositosDetalle>();
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
            Depositos deposito = new Depositos();
            bool realizado = false;

            if (!Validar())
                return;

            deposito = LlenaClase();


            if (IDnumericUpDown.Value == 0)
                realizado = DepositosBLL.Guardar(deposito);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("NO SE PUEDE MODIFICAR UN Deposito INEXISTENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                realizado = DepositosBLL.Modificar(deposito);
            }

            if (realizado)
            {
                Limpiar();
                MessageBox.Show("GUARDADO EXITOSAMENTE", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("NO SE PUDO GUARDAR", "NO GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Depositos LlenaClase()
        {
            throw new NotImplementedException();
        }

        private bool Existe()
        {
            Contratos contrato = ContratosBLL.Buscar((int)IDnumericUpDown.Value);

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
            if (this.contratosDetalle.Count == 0)
            {
                errorProvider.SetError(dataGridView, obligatorio);
                TipoCacaocomboBox.Focus();
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView.CurrentCell.ColumnIndex == 0)
            {
                if (dataGridView.Rows.Count > 0 && dataGridView.CurrentRow != null && contratosDetalle != null)
                {
                    decimal valorEliminar = Convert.ToDecimal(dataGridView.CurrentRow.Cells[4].Value);
                    //todo: calcular monto total
                    contratosDetalle.RemoveAt(dataGridView.CurrentRow.Index);
                    CargarGrid();
                }
            }
        }

        private void RegistrarVendedorbutton_Click(object sender, EventArgs e)
        {
            rVendedor registroVendedor = new rVendedor();
            registroVendedor.ShowDialog();
            LlenarCombos();
        }
    }
}
