using CacaoTech.BLL;
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

namespace CacaoTech.UI
{
    public partial class RecuperarContraseña : Form
    {
        int ID;
        public RecuperarContraseña(int id)
        {
            ID = id;
            InitializeComponent();
            DataUsuario();
        }

        public void DataUsuario()
        {
            GenericaBLL<Usuarios> genericaBLL = new GenericaBLL<Usuarios>();
            
            Usuarios usuario = genericaBLL.Buscar(ID);
            ObtenerPregunta(usuario);
        }

        public void ObtenerPregunta(Usuarios usuario)
        {
            Seguridad seguridad = new Seguridad();
            PreguntatextBox.Text = seguridad.descifrarTexto(usuario.PreguntaSeguridad);
        }

        private void ValidarRespuesta()
        {
            GenericaBLL<Usuarios> genericaBLL = new GenericaBLL<Usuarios>();
            Seguridad seguridad = new Seguridad();
            Usuarios usuario = genericaBLL.Buscar(ID);

            if(seguridad.descifrarTexto(usuario.RespuestaSeguridad) == RespuestatextBox.Text)
            {
                MessageBox.Show("La contraseña es: " + seguridad.descifrarTexto(usuario.Contraseña));
            }
            else
            {
                MessageBox.Show("Respuesta Incorrecta");
            }
        }

        private bool Validar()
        {
            bool realizado = true;

            if (string.IsNullOrWhiteSpace(RespuestatextBox.Text))
            {
                errorProvider.SetError(RespuestatextBox, "Escriba una respuesta valida");
                RespuestatextBox.Focus();
                realizado = false;
                
            }

            return realizado;
        }


        private void Recuperarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            ValidarRespuesta();
        }
    }
}
