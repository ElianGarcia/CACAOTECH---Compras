using CacaoTech.BLL;
using CacaoTech.DAL;
using CacaoTech.Entidades;
using CacaoTech.UI.Reportes;
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
        GenericaBLL<Prestamos> genericaPrestamosBLL;
        public List<PagosDetalle> PagosDetalles;
        decimal Total;

        int UsuarioID;

        public rPagos(int usuarioID)
        {
            genericaProductorBLL = new GenericaBLL<Productores>();
            genericaPrestamosBLL = new GenericaBLL<Prestamos>();
            InitializeComponent();
            ProductorComboBox.SelectedValue = 1;
            this.PagosDetalles = new List<PagosDetalle>();
            CargarGrid();
            LlenarCombos();
            UsuarioID = usuarioID;
            BuscarUsuario(usuarioID);
            Total = 0;
        }

        private void BuscarUsuario(int ID)
        {
            GenericaBLL<Usuarios> genericaBLL = new GenericaBLL<Usuarios>();
            Usuarios usuario = genericaBLL.Buscar(ID);
            Usuariolabel.Text = usuario.Nombres;
        }

        private void CargarGrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = PagosDetalles;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[2].Visible = false;
        }

        public Pagos LlenaClase()
        {
            Pagos pago = new Pagos();
            pago.PagoID = ToInt(IDnumericUpDown.Value.ToString());
            pago.ProductorID = ToInt(ProductorComboBox.SelectedValue.ToString());
            pago.PagosDetalle = this.PagosDetalles;
            pago.productores = genericaProductorBLL.Buscar(ToInt(IDnumericUpDown.Value.ToString()));
            pago.UsuarioID = UsuarioID;

            return pago;
        }

        private void LlenaCampos(Pagos pago)
        {
            GenericaBLL<Productores> genericaBLL = new GenericaBLL<Productores>();
            Productores productor = genericaBLL.Buscar(pago.ProductorID);

            IDnumericUpDown.Value = pago.PagoID;
            ProductorComboBox.SelectedIndex = pago.ProductorID;
            FechadateTimePicker.Value = DateTime.Now;
            BalancetextBox.Text = productor.Balance.ToString();
            dataGridView.DataSource = pago.PagosDetalle;
        }

        public void LlenarCombos()
        {
            //Llenando combobox de productores
            ProductorComboBox.DataSource = null;
            List<Productores> lista = genericaProductorBLL.GetList(p => p.Balance > 0);
            ProductorComboBox.DataSource = lista;
            ProductorComboBox.DisplayMember = "Nombres";
            ProductorComboBox.ValueMember = "ProductorID";
        }

        public void LlenarComboPrestamos(int id)
        {
            //Llenando combo de Prestamos
            PrestamoComboBox.DataSource = null;
            List<Prestamos> lista1 = genericaPrestamosBLL.GetList(pr => pr.ProductorID == id);
            PrestamoComboBox.DataSource = lista1;
            PrestamoComboBox.DisplayMember = "PrestamoID";
            PrestamoComboBox.ValueMember = "PrestamoID";
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
            ProductorComboBox.Text = string.Empty;
            PrestamoComboBox.Text = string.Empty;
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
            if (this.PagosDetalles.Count == 0)
            {
                errorProvider.SetError(dataGridView, obligatorio);
                CantidadtextBox.Focus();
                validado = false;
            }

            return validado;
        }

        private bool isAdministrador()
        {
            GenericaBLL<Usuarios> genericaBLL = new GenericaBLL<Usuarios>();
            Usuarios usuario = genericaBLL.Buscar(UsuarioID);

            return usuario.Nivel;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (isAdministrador())
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
                    errorProvider.SetError(IDnumericUpDown, "No se puede eliminar un pago inexistente");
                }
            }
            else
            {
                MessageBox.Show("Debe tener permisos de administrador" +
                                        "para realizar ésta acción", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rDeposito_Load(object sender, EventArgs e)
        {
            LlenarCombos();
            CargarGrid();
        }

        private void ProductorescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Productores productor = new Productores();
            decimal balance;
            int opcion = 0;

            try
            {
                opcion = ToInt(ProductorComboBox.SelectedValue.ToString());
            }
            catch (Exception)
            {

            }
            
            LlenarComboPrestamos(opcion);
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
            rProductores registroProductor = new rProductores(UsuarioID);
            registroProductor.ShowDialog();
            LlenarCombos();
        }

        private void AgregarPagobutton_Click(object sender, EventArgs e)
        {
            if (!ValidarCantidad())
                return;

            if (dataGridView.DataSource != null)
            {
                this.PagosDetalles = (List<PagosDetalle>)dataGridView.DataSource;
            }
            
            this.PagosDetalles.Add(
                new PagosDetalle(
                    prestamoID: ToInt(PrestamoComboBox.SelectedValue.ToString()),
                    fecha: FechadateTimePicker.Value,
                    balance: ToDecimal(BalancetextBox.Text),
                    pagado: ToDecimal(CantidadtextBox.Text)
                    )
                );

            CargarGrid();
            CantidadtextBox.Clear();
            Total += ToDecimal(CantidadtextBox.Text);
            TotaltextBox.Text = Total.ToString();
        }

        private bool ValidarCantidad()
        {
            bool validado = true;
            string obligatorio = "Campo obligatorio";

            if (string.IsNullOrWhiteSpace(CantidadtextBox.Text))
            {
                errorProvider.SetError(CantidadtextBox, obligatorio);
                CantidadtextBox.Focus();
                validado = false;
            }
            if (ToDecimal(CantidadtextBox.Text) > ToDecimal(BalancetextBox.Text))
            {
                errorProvider.SetError(CantidadtextBox, "El monto a pagar no ha de ser mayor \n al balance del prestamo");
                CantidadtextBox.Focus();
                validado = false;
            }

            return validado;
        }

        private void CantidadtextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidarCantidad())
                return;
        }

        private void PrestamoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prestamos prestamo = new Prestamos();

            try
            {
                prestamo = genericaPrestamosBLL.Buscar(ToInt(PrestamoComboBox.SelectedValue.ToString()));
            }
            catch (Exception)
            {

            }
            
            if (prestamo != null)
            {
                BalancetextBox.Text = prestamo.Balance.ToString();
            }
        }

        private void RemoverFilabutton_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0 && dataGridView.CurrentRow != null)
            {
                decimal valorEliminar = Convert.ToDecimal(dataGridView.CurrentRow.Cells[3].Value);
                Total += valorEliminar;
                TotaltextBox.Text = Total.ToString();

                //PagosDetalle.RemoveAt(dataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ////List<PagosDetalle> pagos = PagosDetalle;

            //if (pagos.Count == 0)
            //{
            //    MessageBox.Show("No hay datos para mostrar en el Reporte");
            //    return;
            //}

            ////PagosReportViewer viewer = new PagosReportViewer(pagos);
            //viewer.ShowDialog();
        }
    }
}
