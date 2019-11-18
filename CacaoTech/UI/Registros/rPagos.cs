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
    public partial class rPagos : Form
    {
        GenericaBLL<Productores> genericaProductorBLL;
        public List<PagosDetalle> pagosDetalles { get; set; }

        public rPagos()
        {
            genericaProductorBLL = new GenericaBLL<Productores>();
            InitializeComponent();
            this.pagosDetalles = new List<PagosDetalle>();
            CargarGrid();
            LlenarCombos();
        }

        private void CargarGrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = pagosDetalles;
        }

        public Pagos LlenaClase()
        {
            Pagos pago = new Pagos();
            pago.PagoID = ToInt(IDnumericUpDown.Value.ToString());
            pago.ProductorID = ToInt(ProductorescomboBox.SelectedValue.ToString());
            pago.PagosDetalle = this.pagosDetalles;
            Productores productor = genericaProductorBLL.Buscar(ToInt(IDnumericUpDown.Value.ToString()));

            return pago;
        }

        private void LlenaCampos(Pagos pago)
        {
            GenericaBLL<Productores> genericaBLL = new GenericaBLL<Productores>();
            Productores productor = genericaBLL.Buscar(pago.ProductorID);

            IDnumericUpDown.Value = pago.PagoID;
            ProductorescomboBox.SelectedIndex = pago.ProductorID;
            FechadateTimePicker.Value = DateTime.Now;
            BalancetextBox.Text = productor.Balance.ToString();
            dataGridView.DataSource = pago.PagosDetalle;
        }

        public void LlenarCombos()
        {
            //Llenando combobox de productores
            ProductorescomboBox.DataSource = null;
            List<Productores> lista = genericaProductorBLL.GetList(p => true);
            ProductorescomboBox.DataSource = lista;
            ProductorescomboBox.DisplayMember = "Nombres";
            ProductorescomboBox.ValueMember = "ProductorID";
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Pagos pago = new Pagos();

            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            pago = PagosBLL.Buscar(id);

            if (pago != null)
            {
                LlenaCampos(pago);
            }
            else
            {
                MessageBox.Show("Pago no encontrado");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            ProductorescomboBox.Text = string.Empty;
            MontotextBox.Text = string.Empty;
            BalancetextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            CantidadtextBox.Text = string.Empty;
            errorProvider.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Pagos pago = new Pagos();
            bool realizado = false;

            if (!Validar())
                return;

            pago = LlenaClase();


            if (IDnumericUpDown.Value == 0)
                realizado = PagosBLL.Guardar(pago);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("NO SE PUEDE MODIFICAR UN PAGO INEXISTENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                realizado = PagosBLL.Modificar(pago);
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

        private bool Existe()
        {
            Pagos pago = PagosBLL.Buscar((int)IDnumericUpDown.Value);

            return (pago != null);
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
            if (this.pagosDetalles.Count == 0)
            {
                errorProvider.SetError(dataGridView, obligatorio);
                CantidadtextBox.Focus();
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

            if (PagosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                errorProvider.SetError(IDnumericUpDown, "No se puede eliminar un pago inexistente");
            }
        }

        private void rDeposito_Load(object sender, EventArgs e)
        {
            LlenarCombos();
            CargarGrid();
        }

        private void ProductorescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Productores> Lista = new List<Productores>();
            Productores productor = new Productores();
            decimal balance;

            int opcion = ToInt(ProductorescomboBox.SelectedValue.ToString());
            productor = genericaProductorBLL.Buscar(opcion);
            if (productor != null)
            {
                balance = productor.Balance;
                BalancetextBox.Text = balance.ToString();
            }
        }

        private int ToInt(string valor)
        {
            int resultado = 0;
            int.TryParse(valor, out resultado);

            return resultado;
        }

        private Decimal ToDecimal(string valor)
        {
            decimal resultado = 0;
            decimal.TryParse(valor, out resultado);

            return resultado;
        }

        private void CantidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cultureInfo.NumberFormat.NumberDecimalSeparator)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void RegistrarProductorbutton_Click(object sender, EventArgs e)
        {
            rProductores registroProductor = new rProductores();
            registroProductor.ShowDialog();
            LlenarCombos();
        }

        private void AgregarPagobutton_Click(object sender, EventArgs e)
        {
            Contexto db = new Contexto();

            if (dataGridView.DataSource != null)
            {
                this.pagosDetalles = (List<PagosDetalle>)dataGridView.DataSource;
            }
            
            this.pagosDetalles.Add(
                new PagosDetalle(
                    pagosDetalleID: 0,
                    fecha: FechadateTimePicker.Value,
                    monto: ToDecimal(CantidadtextBox.Text)
                    )
                );

            CargarGrid();
            ProductorescomboBox.SelectedIndex = 0;
            CantidadtextBox.Clear();
        }
    }
}
