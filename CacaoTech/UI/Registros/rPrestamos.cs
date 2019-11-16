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
    public partial class rPrestamos : Form
    {
        GenericaBLL<Productores> genericaProductores;
        public rPrestamos()
        {
            genericaProductores = new GenericaBLL<Productores>();
            InitializeComponent();
            LlenarCombos();
        }

        public void LlenarCombos()
        {
            //Llenando combobox de vendedores
            ProductorescomboBox.DataSource = null;
            List<Productores> lista = genericaProductores.GetList(p => p.Balance > 0);
            ProductorescomboBox.DataSource = lista;
            ProductorescomboBox.DisplayMember = "Nombres";
            ProductorescomboBox.ValueMember = "ProductorID";
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Prestamos prestamo = new Prestamos();

            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            prestamo = PrestamosBLL.Buscar(id);

            if (prestamo != null)
            {
                LlenaCampos(prestamo);
            }
            else
            {
                MessageBox.Show("Prestamo no encontrado");
            }
        }

        private void LlenaCampos(Prestamos prestamo)
        {
            IDnumericUpDown.Value = prestamo.PrestamoID;
            ProductorescomboBox.SelectedValue = prestamo.ProductorID;
            FechadateTimePicker.Value = prestamo.Fecha;
            MontotextBox.Text = prestamo.Monto.ToString();
            BalancetextBox.Text = prestamo.Balance.ToString();
            InterestextBox.Text = prestamo.Interes.ToString();
            TiempotextBox.Text = prestamo.Tiempo.ToString();
            TotaltextBox.Text = prestamo.Total.ToString();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            ProductorescomboBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            MontotextBox.Text = string.Empty;
            BalancetextBox.Text = string.Empty;
            InterestextBox.Text = string.Empty;
            TiempotextBox.Text = string.Empty;
            TotaltextBox.Text = string.Empty;
            errorProvider.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Prestamos contrato = new Prestamos();
            bool realizado = false;

            if (!Validar())
                return;

            contrato = LlenaClase();


            if (IDnumericUpDown.Value == 0)
                realizado = PrestamosBLL.Guardar(contrato);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modificar un contrato inexistente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                realizado = PrestamosBLL.Modificar(contrato);
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

        private Decimal ToDecimal(string valor)
        {
            decimal resultado = 0;
            decimal.TryParse(valor, out resultado);

            return resultado;
        }

        private Prestamos LlenaClase()
        {
            Prestamos prestamo = new Prestamos();
            prestamo.PrestamoID = ToInt(IDnumericUpDown.Value.ToString());
            prestamo.ProductorID = ToInt(ProductorescomboBox.SelectedValue.ToString());
            prestamo.Fecha = FechadateTimePicker.Value;
            prestamo.Monto = ToDecimal(MontotextBox.Text);
            prestamo.Balance = ToDecimal(BalancetextBox.Text);
            prestamo.Interes = ToDecimal(InterestextBox.Text);
            prestamo.Tiempo = ToInt(TiempotextBox.Text);
            prestamo.Total = ToDecimal(TotaltextBox.Text);

            return prestamo;
        }

        private bool Existe()
        {
            Prestamos prestamo = PrestamosBLL.Buscar(ToInt(IDnumericUpDown.Value.ToString()));

            return (prestamo != null);
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
            if (string.IsNullOrWhiteSpace(MontotextBox.Text))
            {
                errorProvider.SetError(MontotextBox, obligatorio);
                MontotextBox.Focus();
                validado = false;
            }
            if (ToDecimal(MontotextBox.Text) < 1)
            {
                errorProvider.SetError(MontotextBox, "El monto debe ser mayor a 0");
                MontotextBox.Focus();
                validado = false;
            }
            if (string.IsNullOrWhiteSpace(TiempotextBox.Text))
            {
                errorProvider.SetError(TiempotextBox, obligatorio);
                TiempotextBox.Focus();
                validado = false;
            }
            if (ToInt(TiempotextBox.Text) < 1)
            {
                errorProvider.SetError(TiempotextBox, "El tiempo debe ser mayor a un mes");
                TiempotextBox.Focus();
                validado = false;
            }
            if (string.IsNullOrWhiteSpace(FechadateTimePicker.Value.ToString()))
            {
                errorProvider.SetError(FechadateTimePicker, obligatorio);
                FechadateTimePicker.Focus();
                validado = false;
            }

            return validado;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            if (PagosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                errorProvider.SetError(IDnumericUpDown, "No se puede eliminar un prestamo inexistente");
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

        private void TiempotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void RegistrarVendedorbutton_Click(object sender, EventArgs e)
        {
            rProductores registroProductor = new rProductores();
            registroProductor.ShowDialog();
            LlenarCombos();
        }
    }
}
