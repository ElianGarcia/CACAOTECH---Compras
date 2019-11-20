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
    public partial class rRecepciones : Form
    {
        GenericaBLL<Productores> genericaVendedorBLL;
        GenericaBLL<Recepciones> genericaRecepcionBLL;
        GenericaBLL<Cacao> genericaCacaoBLL;
        public rRecepciones()
        {
            genericaVendedorBLL = new GenericaBLL<Productores>();
            genericaCacaoBLL = new GenericaBLL<Cacao>();
            genericaRecepcionBLL = new GenericaBLL<Recepciones>();
            InitializeComponent();
            LlenarCombos();
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
            ProductorescomboBox.Text = recepcion.ProductorID.ToString();
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

            recepcion = RecepcionesBLL.Buscar(id);

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
            Recepciones recepcion = new Recepciones();
            bool realizado = false;

            if (!Validar())
                return;

            recepcion = LlenaClase();


            if (IDnumericUpDown.Value == 0)
                realizado = RecepcionesBLL.Guardar(recepcion);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("NO SE PUEDE MODIFICAR UNA RECEPCION INEXISTENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                realizado = RecepcionesBLL.Modificar(recepcion);
            }

            if (realizado)
            {
                Limpiar();
                MessageBox.Show("GUARDADA EXITOSAMENTE", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("NO SE PUDO GUARDAR", "NO GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Existe()
        {
            Recepciones recepcion = RecepcionesBLL.Buscar((int)IDnumericUpDown.Value);

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
            errorProvider.Clear();

            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            Contexto db = new Contexto();

            Limpiar();

            if (RecepcionesBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                errorProvider.SetError(IDnumericUpDown, "No se puede eliminar una recepcion inexistente");
            }
        }

        private void rDeposito_Load(object sender, EventArgs e)
        {
            LlenarCombos();
        }

        private void TipoCacaocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Cacao> Lista = new List<Cacao>();
            Cacao cacao = new Cacao();

            int opcion = ToInt(TipoCacaocomboBox.SelectedValue.ToString());
            cacao = genericaCacaoBLL.Buscar(opcion);
            if (cacao != null)
            {
                PreciotextBox.Text = cacao.Precio.ToString();
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