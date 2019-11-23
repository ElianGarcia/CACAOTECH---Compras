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
        }

        public void DataUsuario()
        {
            GenericaBLL<Usuarios> genericaBLL = new GenericaBLL<Usuarios>();
            Seguridad seguridad = new Seguridad();
            Usuarios usuario = genericaBLL.Buscar(ID);
        }
    }
}
