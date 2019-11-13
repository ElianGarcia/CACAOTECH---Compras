using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaoTech.UI.Registros
{
    public partial class rPagos : Form
    {
        public rPagos()
        {
            InitializeComponent();
        }

        public Recepciones LlenaClase()
        {
            Recepciones recepcion = new Recepciones();
            recepcion.RecepcionID = Convert.ToInt32(IDnumericUpDown.Value);
            recepcion.Fecha = FechadateTimePicker.Value;
            recepcion.ProductorID = ProductorescomboBox.SelectedIndex;
            recepcion.Cantidad = ToDecimal(CantidadtextBox.Text);

            return recepcion;
        }

        private void LlenaCampos(Recepciones recepcion)
        {
            IDnumericUpDown.Value = recepcion.RecepcionID;
            ProductorescomboBox.Text = recepcion.Productor.Nombres;
            TipoCacaocomboBox.Text = string.Empty;
            FechadateTimePicker.Value = recepcion.Fecha;
            CantidadtextBox.Text = string.Empty;
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
            ProductorescomboBox.DataSource = null;
            List<Productores> lista = genericaVendedorBLL.GetList(p => true);
            ProductorescomboBox.DataSource = lista;
            ProductorescomboBox.DisplayMember = "Nombres";
            ProductorescomboBox.ValueMember = "ProductorID";
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Recepciones recepcion = new Recepciones();

            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            recepcion = genericaRecepcionBLL.Buscar(id);

            if (recepcion != null)
            {
                LlenaCampos(recepcion);
            }
            else
            {
                MessageBox.Show("Recepcion no encontrado");
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
            TipoCacaocomboBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            CantidadtextBox.Text = string.Empty;
            errorProvider.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

        }

        private bool Existe()
        {
            Recepciones recepcion = genericaRecepcionBLL.Buscar((int)IDnumericUpDown.Value);

            return (recepcion != null);
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

        }

        private void rDeposito_Load(object sender, EventArgs e)
        {
            LlenarCombos();
        }

        private void TipoCacaocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Cacao> Lista = new List<Cacao>();
            Cacao cacao = new Cacao();
            decimal precio;

            int opcion = Convert.ToInt32(TipoCacaocomboBox.SelectedIndex);
            cacao = genericaCacaoBLL.Buscar(opcion);
            if (cacao != null)
            {
                precio = cacao.Precio;
                PreciotextBox.Text = cacao.Precio.ToString();
            }
        }

        private Decimal ToDecimal(string valor)
        {
            decimal resultado = 0;
            decimal.TryParse(valor, out resultado);

            return resultado;
        }

        private void CantidadtextBox_TextChanged(object sender, EventArgs e)
        {
            decimal cantidad = ToDecimal(CantidadtextBox.Text);
            decimal precio = ToDecimal(PreciotextBox.Text);

            ImportetextBox.Text = genericaRecepcionBLL.CalcularImporte(precio, cantidad).ToString();
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
    }
}
