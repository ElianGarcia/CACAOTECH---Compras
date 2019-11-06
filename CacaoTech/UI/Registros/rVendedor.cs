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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaoTech.UI.Registros
{
    public partial class rVendedor : Form
    {
        GenericaBLL<Vendedores> genericaBLL;
        public rVendedor()
        {
            genericaBLL = new GenericaBLL<Vendedores>();
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            ApellidostextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            CelularmaskedTextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
        }

        private bool Existe()
        {
            Vendedores vendedor = genericaBLL.Buscar((int)IDnumericUpDown.Value);

            return (vendedor != null);
        }

        private Vendedores LlenaClase()
        {
            Vendedores vendedor = new Vendedores();
            vendedor.VendedorID = Convert.ToInt32(IDnumericUpDown.Value);
            vendedor.Nombre = NombretextBox.Text;
            vendedor.Apellidos = ApellidostextBox.Text;
            vendedor.Email = ApellidostextBox.Text;
            vendedor.Direccion = DirecciontextBox.Text;
            vendedor.Telefono = TelefonomaskedTextBox.Text;
            vendedor.Celular = CelularmaskedTextBox.Text;

            return vendedor;
        }

        private void LlenaCampos(Vendedores vendedor)
        {
            IDnumericUpDown.Value = vendedor.VendedorID;
            NombretextBox.Text = vendedor.Nombre;
            ApellidostextBox.Text = vendedor.Apellidos;
            EmailtextBox.Text = vendedor.Email;
            DirecciontextBox.Text = vendedor.Direccion;
            TelefonomaskedTextBox.Text = vendedor.Telefono;
            CelularmaskedTextBox.Text = vendedor.Celular;
        }

        private Boolean EmailValido(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool Validar()
        {
            bool realizado = true;
            string obligatorio = "Este campo es obligatorio";

            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(IDnumericUpDown.Text))
            {
                errorProvider.SetError(IDnumericUpDown, obligatorio);
                IDnumericUpDown.Focus();
                realizado = false;
            }
            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider.SetError(NombretextBox, obligatorio);
                NombretextBox.Focus();
                realizado = false;
            }
            if (string.IsNullOrWhiteSpace(ApellidostextBox.Text))
            {
                errorProvider.SetError(ApellidostextBox, obligatorio);
                ApellidostextBox.Focus();
                realizado = false;
            }
            if (string.IsNullOrWhiteSpace(DirecciontextBox.Text))
            {
                errorProvider.SetError(DirecciontextBox, obligatorio);
                DirecciontextBox.Focus();
                realizado = false;
            }
            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                errorProvider.SetError(EmailtextBox, obligatorio);
                EmailtextBox.Focus();
                realizado = false;
            }
            if (!EmailValido(EmailtextBox.Text))
            {
                errorProvider.SetError(EmailtextBox, "Email no valido");
                EmailtextBox.Focus();
                realizado = false;
            }
            if (string.IsNullOrWhiteSpace(CedulamaskedTextBox.Text.Replace("-", "")) && (CedulamaskedTextBox.MaskFull))
            {
                errorProvider.SetError(CedulamaskedTextBox, obligatorio);
                CedulamaskedTextBox.Focus();
                realizado = false;
            }
            if (string.IsNullOrWhiteSpace(CelularmaskedTextBox.Text.Replace("-", "")) && (CelularmaskedTextBox.MaskFull))
            {
                errorProvider.SetError(CelularmaskedTextBox, obligatorio);
                CelularmaskedTextBox.Focus();
                realizado = false;
            }
            if (string.IsNullOrWhiteSpace(TelefonomaskedTextBox.Text.Replace("-", "")) && (TelefonomaskedTextBox.MaskFull))
            {
                errorProvider.SetError(TelefonomaskedTextBox, obligatorio);
                TelefonomaskedTextBox.Focus();
                realizado = false;
            }

            return realizado;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Vendedores vendedor = new Vendedores();
            bool realizado = false;

            if (!Validar())
                return;

            vendedor = LlenaClase();


            if (IDnumericUpDown.Value == 0)
                realizado = genericaBLL.Guardar(vendedor);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("NO SE PUEDE MODIFICAR UN CACAO INEXISTENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                realizado = genericaBLL.Modificar(vendedor);
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

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            if (genericaBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                errorProvider.SetError(IDnumericUpDown, "No se puede eliminar un cacao inexistente");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Vendedores vendedor = new Vendedores();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            vendedor = genericaBLL.Buscar(id);

            if (vendedor != null)
            {
                LlenaCampos(vendedor);
            }
            else
            {
                MessageBox.Show("Cacao No Encontrado");
            }
        }
    }
}

