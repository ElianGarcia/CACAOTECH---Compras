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
            List<Productores> lista = genericaProductores.GetList(p => true);
            ProductorescomboBox.DataSource = lista;
            ProductorescomboBox.DisplayMember = "Nombres";
            ProductorescomboBox.ValueMember = "ProductorID";
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
            ProductorescomboBox.SelectedIndex = prestamo.ProductorID;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            ProductorescomboBox.Text = string.Empty;
            FechaIniciodateTimePicker.Value = DateTime.Now;
            errorProvider.Clear();
            CargarGrid();
        }

        private void CargarGrid()
        {
            DataGridViewCheckBoxColumn columna = new DataGridViewCheckBoxColumn();

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

        private Prestamos LlenaClase()
        {
            Prestamos prestamo = new Prestamos();
            prestamo.PrestamoID = ToInt(IDnumericUpDown.Value.ToString());
            prestamo.ProductorID = ProductorescomboBox.SelectedIndex;

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

            return validado;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            if (PrestamosBLL.Eliminar(id))
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
            rProductores registroProductor = new rProductores();
            registroProductor.ShowDialog();
            LlenarCombos();
        }
    }
}
