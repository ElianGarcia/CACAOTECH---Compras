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
    public partial class rProductores : Form
    {
        GenericaBLL<Productores> genericaBLL;
        int UsuarioID;
        public rProductores(int usuarioID)
        {
            genericaBLL = new GenericaBLL<Productores>();
            InitializeComponent();
            UsuarioID = usuarioID;
            BuscarUsuario(usuarioID);
        }

        private void BuscarUsuario(int ID)
        {
            GenericaBLL<Usuarios> genericaBLL = new GenericaBLL<Usuarios>();
            Usuarios usuario = genericaBLL.Buscar(ID);
            Usuariolabel.Text = usuario.Nombres;
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
            BalancetextBox.Text = string.Empty;
            AmbulanteradioButton.Checked = false;
            FijoradioButton.Checked = false;
        }

        private bool Existe()
        {
            Productores productor = genericaBLL.Buscar((int)IDnumericUpDown.Value);

            return (productor != null);
        }

        private Productores LlenaClase()
        {
            Productores productor = new Productores();
            productor.ProductorID = Convert.ToInt32(IDnumericUpDown.Value);
            productor.Nombres = NombretextBox.Text;
            productor.Apellidos = ApellidostextBox.Text;
            productor.Email = EmailtextBox.Text;
            productor.Direccion = DirecciontextBox.Text;
            productor.Telefono = TelefonomaskedTextBox.Text;
            productor.Celular = CelularmaskedTextBox.Text;
            productor.Cedula = CedulamaskedTextBox.Text;
            productor.Balance = ToDecimal(BalancetextBox.Text);
            productor.UsuarioID = UsuarioID;

            if(AmbulanteradioButton.Checked)
            {
                productor.Tipo = true;

            } else
            {
                productor.Tipo = false;
            }

            return productor;
        }

        private decimal ToDecimal(string text)
        {
            decimal resultado = 0;
            decimal.TryParse(text, out resultado);

            return resultado;
        }

        private void LlenaCampos(Productores productor)
        {
            IDnumericUpDown.Value = productor.ProductorID;
            NombretextBox.Text = productor.Nombres;
            ApellidostextBox.Text = productor.Apellidos;
            EmailtextBox.Text = productor.Email;
            DirecciontextBox.Text = productor.Direccion;
            TelefonomaskedTextBox.Text = productor.Telefono;
            CelularmaskedTextBox.Text = productor.Celular;
            CedulamaskedTextBox.Text = productor.Cedula;
            BalancetextBox.Text = productor.Balance.ToString();

            if (productor.Tipo)
            {
                AmbulanteradioButton.Checked = true;

            }
            else
            {
                FijoradioButton.Checked = true;
            }
        }

        private bool isAdministrador()
        {
            GenericaBLL<Usuarios> genericaBLL = new GenericaBLL<Usuarios>();
            Usuarios usuario = genericaBLL.Buscar(UsuarioID);

            return usuario.Nivel;
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

        private bool ValidarCedula()
        {
            bool realizado = true;
            GenericaBLL<Productores> genericaBLL = new GenericaBLL<Productores>();
            List<Productores> productores = genericaBLL.GetList(d => d.Cedula.Contains(CedulamaskedTextBox.Text));

            if (productores != null)
            {
                realizado = false;
            }
            return realizado;
        }

        private bool ValidarTelefono()
        {
            bool realizado = true;
            GenericaBLL<Productores> genericaBLL = new GenericaBLL<Productores>();
            List<Productores> productores = genericaBLL.GetList(d => d.Telefono.Contains(TelefonomaskedTextBox.Text));

            if (productores != null)
            {
                realizado = false;
            }
            return realizado;
        }

        private bool ValidarCelular()
        {
            bool realizado = true;
            GenericaBLL<Productores> genericaBLL = new GenericaBLL<Productores>();
            List<Productores> productores = genericaBLL.GetList(d => d.Celular.Contains(CelularmaskedTextBox.Text));

            if (productores != null)
            {
                realizado = false;
            }
            return realizado;
        }

        private bool ValidarNombre()
        {
            bool realizado = true;
            GenericaBLL<Productores> genericaBLL = new GenericaBLL<Productores>();
            List<Productores> productores = genericaBLL.GetList(d => (d.Nombres + d.Apellidos).Contains(NombretextBox.Text + ApellidostextBox.Text));
            
            if(productores != null)
            {
                realizado = false;
            }
            return realizado;
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
            if (string.IsNullOrWhiteSpace(CedulamaskedTextBox.Text.Replace("-", "")) || (CedulamaskedTextBox.MaskFull == false))
            {
                errorProvider.SetError(CedulamaskedTextBox, obligatorio);
                CedulamaskedTextBox.Focus();
                realizado = false;
            }
            if (string.IsNullOrWhiteSpace(CelularmaskedTextBox.Text.Replace("-", "")) || (CelularmaskedTextBox.MaskFull == false))
            {
                errorProvider.SetError(CelularmaskedTextBox, obligatorio);
                CelularmaskedTextBox.Focus();
                realizado = false;
            }
            if (string.IsNullOrWhiteSpace(TelefonomaskedTextBox.Text.Replace("-", "")) || (TelefonomaskedTextBox.MaskFull == false))
            {
                errorProvider.SetError(TelefonomaskedTextBox, obligatorio);
                TelefonomaskedTextBox.Focus();
                realizado = false;
            }
            if (TelefonomaskedTextBox.Text == CelularmaskedTextBox.Text)
            {
                errorProvider.SetError(CelularmaskedTextBox, obligatorio);
                CelularmaskedTextBox.Focus();
                realizado = false;
            }
            if (FijoradioButton.Checked == false && AmbulanteradioButton.Checked == false)
            {
                errorProvider.SetError(AmbulanteradioButton, obligatorio);
                FijoradioButton.Focus();
                AmbulanteradioButton.Focus();
                realizado = false;
            }
            if (ValidarNombre())
            {
                errorProvider.SetError(NombretextBox, "Ya existe un productor con este nombre \n vaya a Consultas->Productores para \n mas detalles");
                NombretextBox.Focus();
                realizado = false;
            }
            if (ValidarCedula())
            {
                errorProvider.SetError(CedulamaskedTextBox, "Ya existe un productor con esta cedula \n vaya a Consultas->Productores para \n mas detalles");
                CedulamaskedTextBox.Focus();
                realizado = false;
            }
            if (ValidarCelular())
            {
                errorProvider.SetError(CedulamaskedTextBox, "Ya existe un productor con este celular \n vaya a Consultas->Productores para \n mas detalles");
                CelularmaskedTextBox.Focus();
                realizado = false;
            }
            if (ValidarTelefono())
            {
                errorProvider.SetError(TelefonomaskedTextBox, "Ya existe un productor con este telefono \n vaya a Consultas->Productores para \n mas detalles");
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
            Productores productor = new Productores();
            bool realizado = false;

            if (!Validar())
                return;

            productor = LlenaClase();


            if (IDnumericUpDown.Value == 0)
                realizado = genericaBLL.Guardar(productor);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("NO SE PUEDE MODIFICAR UN Productor INEXISTENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                realizado = genericaBLL.Modificar(productor);
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
            if (isAdministrador())
            {
                if (ToDecimal(BalancetextBox.Text) > 0)
                {
                    MessageBox.Show("Este productor no puede ser eliminado" +
                        "porque tiene una deuda pendiente", "Denegado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int id;
                    int.TryParse(IDnumericUpDown.Text, out id);

                    Limpiar();

                    if (genericaBLL.Eliminar(id))
                    {
                        MessageBox.Show("Eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        errorProvider.SetError(IDnumericUpDown, "No se puede eliminar un productor inexistente");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe tener permisos de administrador" +
                                        "para realizar esta acción", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Productores productor = new Productores();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            productor = genericaBLL.Buscar(id);

            if (productor != null)
            {
                LlenaCampos(productor);
            }
            else
            {
                MessageBox.Show("Productor No Encontrado");
            }
        }
    }
}

