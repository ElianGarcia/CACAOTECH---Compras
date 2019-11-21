using CacaoTech.BLL;
using CacaoTech.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaoTech
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseData();
            Application.Run(new Login());
        }

        static void DatabaseData()
        {
            GenericaBLL<Usuarios> genericaBLL = new GenericaBLL<Usuarios>();
            List<Usuarios> usuario = genericaBLL.GetList(d => true);
            if(usuario == null)
            {
                Usuarios usuario1 = new Usuarios(0, "Administrador", "9e5d50a8bd1bfc52f4161fc0aefbf4817446096c", true);
                genericaBLL.Guardar(usuario1);
            }

            GenericaBLL<Cacao> genericaBLL1 = new GenericaBLL<Cacao>();
            List<Cacao> cacaos = genericaBLL1.GetList(d => true);
            if (cacaos == null)
            {
                Cacao cacao1 = new Cacao(0, "HISPANIOLA ORGANICO", Convert.ToDecimal(6030.36));
                genericaBLL1.Guardar(cacao1);
                Cacao cacao2 = new Cacao(0, "HISPANIOLA CONVENCIONAL", Convert.ToDecimal(5630.36));
                genericaBLL1.Guardar(cacao2);
                Cacao cacao3 = new Cacao(0, "SANCHEZ ORGANICO", Convert.ToDecimal(6250.36));
                genericaBLL1.Guardar(cacao3);
                Cacao cacao4 = new Cacao(0, "SANCHEZ CONVENCIONAL", Convert.ToDecimal(5820.36));
                genericaBLL1.Guardar(cacao4);
            }
        }
    }
}
