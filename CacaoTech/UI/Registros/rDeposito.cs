using CacaoTech.BLL;
using CacaoTech.DAL;
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

namespace CacaoTech.UI.Registros
{
    public partial class rDeposito : Form
    {
        GenericaBLL<Vendedores> genericaVendedorBLL;
        GenericaBLL<Cacao> genericaCacaoBLL;
        public List<DepositosDetalle> depositosDetalles { get; set; }
        public rDeposito()
        {
            genericaVendedorBLL = new GenericaBLL<Vendedores>();
            genericaCacaoBLL = new GenericaBLL<Cacao>();
            InitializeComponent();
            LlenarCombos();
            this.depositosDetalles = new List<DepositosDetalle>();
            cargarGrid();
        }

        private void cargarGrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = depositosDetalles;
        }

        public Depositos LlenaClase()
        {
            Depositos deposito = new Depositos();
            deposito.DepositosDetalle = this.depositosDetalles;
            deposito.Fecha = FechadateTimePicker.Value;
            deposito.VendedorID = VendedorescomboBox.SelectedIndex;
            deposito.DepositoID = Convert.ToInt32(IDnumericUpDown.Value);

            return deposito;
        }

        private void LlenaCampos(Depositos deposito)
        {
            IDnumericUpDown.Value = deposito.DepositoID;
            VendedorescomboBox.Text = deposito.Vendedor.Nombre;
            TipoCacaocomboBox.Text = string.Empty;
            FechadateTimePicker.Value = deposito.Fecha;
            CantidadtextBox.Text = string.Empty;
            this.depositosDetalles = deposito.DepositosDetalle;
            cargarGrid();
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

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Depositos deposito = new Depositos();

            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            deposito = DepositosBLL.Buscar(id);

            if (deposito != null)
            {
                LlenaCampos(deposito);
            }
            else
            {
                MessageBox.Show("Deposito no encontrado");
            }
        }

        private void AgregarDepositobutton_Click(object sender, EventArgs e)
        {
            Contexto db = new Contexto();
            Cacao cacao;

            if(dataGridView.DataSource != null)
            {
                this.depositosDetalles = (List<DepositosDetalle>)dataGridView.DataSource;
            }

            cacao = db.Cacao.Find(TipoCacaocomboBox.SelectedIndex + 1);
            decimal importe = cacao.Precio * Convert.ToDecimal(CantidadtextBox.Text);

            this.depositosDetalles.Add(
                new DepositosDetalle(
                    cacao.Tipo,
                    cacao.Precio,
                    Convert.ToDecimal(CantidadtextBox.Text),
                    importe)
                );

            cargarGrid();
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
            FechadateTimePicker.Value = DateTime.Now;
            CantidadtextBox.Text = string.Empty;
            errorProvider.Clear();
            this.depositosDetalles = new List<DepositosDetalle>();
            CargarGrid();
        }

        private void CargarGrid()
        {
            DataGridViewCheckBoxColumn columna = new DataGridViewCheckBoxColumn();

            dataGridView.DataSource = null;
            dataGridView.DataSource = this.depositosDetalles;
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

        private bool Existe()
        {
            Depositos deposito = DepositosBLL.Buscar((int)IDnumericUpDown.Value);

            return (deposito != null);
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
            if (this.depositosDetalles.Count == 0)
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

            if (DepositosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                errorProvider.SetError(IDnumericUpDown, "No se puede eliminar un deposito inexistente");
            }
        }

        private void rDeposito_Load(object sender, EventArgs e)
        {
            LlenarCombos();
        }
    }
}
