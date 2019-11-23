using CacaoTech.BLL;
using CacaoTech.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaoTech.UI.Registros
{
    public partial class rUsuarios : Form
    {
        GenericaBLL<Usuarios> genericaBLL;
        int UsuarioID;
        public rUsuarios(int usuarioID)
        {
            genericaBLL = new GenericaBLL<Usuarios>();
            InitializeComponent();
            UsuarioID = usuarioID;
        }

        private int ToInt(string valor)
        {
            int resultado = 0;
            int.TryParse(valor, out resultado);

            return resultado;
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuario = new Usuarios();
            Seguridad seguridad = new Seguridad();

            usuario.UsuarioID = ToInt(IDnumericUpDown.Value.ToString());
            usuario.Nombres = NombreTextBox.Text;
            string c = seguridad.cifrarTexto(ContraseñaTextBox.Text);
            usuario.Contraseña = c;
            usuario.PreguntaSeguridad = PreguntaSeguridadtextBox.Text;
            usuario.RespuestaSeguridad = seguridad.cifrarTexto(RespuestaSeguridadtextBox.Text);
            if(AdministradorradioButton.Checked)
            {
                usuario.Nivel = true;
            }

            if(EstandarradioButton.Checked)
            {
                usuario.Nivel = false;
            }
            
            return usuario;
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
            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                errorProvider.SetError(NombreTextBox, obligatorio);
                NombreTextBox.Focus();
                realizado = false;
            }
            if (string.IsNullOrWhiteSpace(ContraseñaTextBox.Text))
            {
                errorProvider.SetError(ContraseñaTextBox, obligatorio);
                ContraseñaTextBox.Focus();
                realizado = false;
            }
            if (string.IsNullOrWhiteSpace(PreguntaSeguridadtextBox.Text))
            {
                errorProvider.SetError(PreguntaSeguridadtextBox, obligatorio + "\n será necesario en caso de \n pérdida de la contraseña");
                PreguntaSeguridadtextBox.Focus();
                realizado = false;
            }
            if (string.IsNullOrWhiteSpace(RespuestaSeguridadtextBox.Text))
            {
                errorProvider.SetError(RespuestaSeguridadtextBox, obligatorio + "\n será necesario en caso de \n pérdida de la contraseña");
                RespuestaSeguridadtextBox.Focus();
                realizado = false;
            }
            if (ContraseñaTextBox.Text == NombreTextBox.Text)
            {
                errorProvider.SetError(ContraseñaTextBox, "La contraseña no debe ser igual al nombre");
                ContraseñaTextBox.Focus();
                realizado = false;
            }
            if (ContraseñaTextBox.Text != ConfirmarContraseñatextBox.Text)
            {
                errorProvider.SetError(ContraseñaTextBox, "Las contraseñas no coinciden");
                ContraseñaTextBox.Focus();
                realizado = false;
            }
            if (AdministradorradioButton.Checked == false && EstandarradioButton.Checked == false)
            {
                errorProvider.SetError(EstandarradioButton, "Debe elegir una de las opciones");
                EstandarradioButton.Focus();
                realizado = false;
            }

            return realizado;
        }

        private void Limpiar()
        {
            errorProvider.Clear();
            IDnumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            ContraseñaTextBox.Text = string.Empty;
            ConfirmarContraseñatextBox.Text = string.Empty;
            PreguntaSeguridadtextBox.Text = string.Empty;
            RespuestaSeguridadtextBox.Text = string.Empty;
            AdministradorradioButton.Checked = false;
            EstandarradioButton.Checked = false;
        }

        private void LlenaCampos(Usuarios usuario)
        {
            Seguridad seguridad = new Seguridad();

            IDnumericUpDown.Value = usuario.UsuarioID;
            NombreTextBox.Text = usuario.Nombres;
            
            if (isAdministrador())
            {
                PreguntaSeguridadtextBox.Text = usuario.PreguntaSeguridad;
                RespuestaSeguridadtextBox.Text = usuario.RespuestaSeguridad;
                ContraseñaTextBox.Text = seguridad.descifrarTexto(usuario.Contraseña);
                ConfirmarContraseñatextBox.Text = seguridad.descifrarTexto(usuario.Contraseña);
            }
            else
            {
                PreguntaSeguridadtextBox.Text = seguridad.cifrarTexto(usuario.PreguntaSeguridad);
                RespuestaSeguridadtextBox.Text = seguridad.cifrarTexto(usuario.RespuestaSeguridad);
                ContraseñaTextBox.Text = seguridad.cifrarTexto(usuario.Contraseña);
                ConfirmarContraseñatextBox.Text = seguridad.cifrarTexto(usuario.Contraseña);
            }

            if (usuario.Nivel)
            {
                AdministradorradioButton.Checked = true;
            } 
            else 
            {
                EstandarradioButton.Checked = true;
            }
        }

        private bool Existe()
        {
            Usuarios usuario = genericaBLL.Buscar((int)IDnumericUpDown.Value);

            return (usuario != null);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            bool realizado = false;

            if (!Validar())
                return;

            usuario = LlenaClase();


            if (IDnumericUpDown.Value == 0)
                realizado = genericaBLL.Guardar(usuario);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("NO SE PUEDE MODIFICAR UN USUARIO INEXISTENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                realizado = genericaBLL.Modificar(usuario);
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

                if (genericaBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    errorProvider.SetError(IDnumericUpDown, "No se puede eliminar un usuario inexistente");
                }
            }
            else
            {
                MessageBox.Show("Debe tener permisos de administrador" +
                                        "para realizar ésta acción", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Usuarios usuario = new Usuarios();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            usuario = genericaBLL.Buscar(id);

            if (usuario != null)
            {
                LlenaCampos(usuario);
            }
            else
            {
                MessageBox.Show("No Encontrado");
            }
        }
    }
}
