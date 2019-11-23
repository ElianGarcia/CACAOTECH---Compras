using Microsoft.VisualStudio.TestTools.UnitTesting;
using CacaoTech.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CacaoTech.Entidades;
using CacaoTech.DAL;

namespace CacaoTech.BLL.Tests
{
    [TestClass()]
    public class GenericaBLLTests
    {
        [TestMethod()]
        public void BuscarTest()
        {
            GenericaBLL<Cacao> genericaBLL = new GenericaBLL<Cacao>();
            var encontrado = genericaBLL.Buscar(1);
            Assert.IsNotNull(encontrado);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            GenericaBLL<Cacao> genericaBLL = new GenericaBLL<Cacao>();
            bool realizado = genericaBLL.Eliminar(1);
            Assert.AreEqual(realizado, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            GenericaBLL<Cacao> genericaBLL = new GenericaBLL<Cacao>();
            List<Cacao> lista = new List<Cacao>();
            lista = genericaBLL.GetList(l => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void GuardarTest()
        {
            DatabaseData();
            GenericaBLL<Cacao> genericaBLL = new GenericaBLL<Cacao>();
            Cacao cacao = new Cacao(0, "Convencional", Convert.ToDecimal(2500.45), 1);
            bool realizado = genericaBLL.Guardar(cacao);
            Assert.AreEqual(realizado, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            DatabaseData();
            GenericaBLL<Cacao> genericaBLL = new GenericaBLL<Cacao>();
            Cacao cacao = new Cacao(0, "Organico", Convert.ToDecimal(2500.45), 1);
            bool realizado = genericaBLL.Guardar(cacao);
            Assert.AreEqual(realizado, true);
        }

        static void DatabaseData()
        {
            Contexto db = new Contexto();

            GenericaBLL<Usuarios> genericaBLL = new GenericaBLL<Usuarios>();
            Usuarios usuario = genericaBLL.Buscar(1);
            Seguridad seguridad = new Seguridad();
            if (usuario == null)
            {
                string password = seguridad.cifrarTexto("CACAOTECH");
                string pregunta = seguridad.cifrarTexto("¿Cual es tu nombre?");
                string respuesta = seguridad.cifrarTexto("Elian Garcia");

                Usuarios usuario1 = new Usuarios(0, "Administrador", password, true, pregunta, respuesta);
                db.Usuario.Add(usuario1);
                db.SaveChanges();
            }
        }
    }
}