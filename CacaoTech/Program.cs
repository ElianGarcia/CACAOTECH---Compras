using CacaoTech.BLL;
using CacaoTech.DAL;
using CacaoTech.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            Contexto db = new Contexto();
            
            GenericaBLL<Usuarios> genericaBLL = new GenericaBLL<Usuarios>();
            Usuarios usuario = genericaBLL.Buscar(1);
            Seguridad seguridad = new Seguridad();
            if(usuario == null)
            {
                string c = seguridad.cifrarTexto("CACAOTECH");

                Usuarios usuario1 = new Usuarios(0, "Administrador", c, true);
                db.Usuario.Add(usuario1);
                db.SaveChanges();
            }

            GenericaBLL<Cacao> genericaBLL1 = new GenericaBLL<Cacao>();
            Cacao cacaos = genericaBLL1.Buscar(1);
            if (cacaos == null)
            {
                Cacao cacao1 = new Cacao(0, "HISPANIOLA ORGANICO", Convert.ToDecimal(6030.36), 1);
                db.Cacao.Add(cacao1);
                Cacao cacao2 = new Cacao(0, "HISPANIOLA CONVENCIONAL", Convert.ToDecimal(5630.36), 1);
                db.Cacao.Add(cacao2);
                Cacao cacao3 = new Cacao(0, "SANCHEZ ORGANICO", Convert.ToDecimal(6250.36), 1);
                db.Cacao.Add(cacao3);
                Cacao cacao4 = new Cacao(0, "SANCHEZ CONVENCIONAL", Convert.ToDecimal(5820.36), 1);
                db.Cacao.Add(cacao4);
                db.SaveChanges();
            }
        }
    }
}
