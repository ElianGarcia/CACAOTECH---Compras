using Microsoft.VisualStudio.TestTools.UnitTesting;
using CacaoTech.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CacaoTech.Entidades;

namespace CacaoTech.BLL.Tests
{
    [TestClass()]
    public class RecepcionesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Recepciones r = new Recepciones(1, DateTime.Now, 3, 5);
            var realizado = RecepcionesBLL.Guardar(r);
            Assert.AreEqual(true, realizado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Recepciones r = new Recepciones(1, DateTime.Now, 4, 5);
            var realizado = RecepcionesBLL.Guardar(r);
            Assert.AreEqual(true, realizado);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool realizado = RecepcionesBLL.Eliminar(1);
            Assert.AreEqual(realizado, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var encontrado = RecepcionesBLL.Buscar(1);
            Assert.IsNotNull(encontrado);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Recepciones> lista = new List<Recepciones>();
            lista = RecepcionesBLL.GetList(l => true);
            Assert.IsNotNull(lista);
        }
    }
}