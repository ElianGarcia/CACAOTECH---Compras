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
    public class PrestamosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Prestamos d = new Prestamos(0, DateTime.Now, 1, 10, 50000, 50000, Convert.ToDecimal(0.05), 50500, 1);
            bool saved = PrestamosBLL.Guardar(d);
            Assert.AreEqual(true, saved);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Prestamos d = new Prestamos(0, DateTime.Now, 1, 10, 50000, 42310, Convert.ToDecimal(0.05), 50500, 1);
            bool guardado = PrestamosBLL.Modificar(d);
            Assert.AreEqual(true, guardado);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool realizado = PrestamosBLL.Eliminar(1);
            Assert.AreEqual(realizado, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var realizado = PrestamosBLL.Buscar(1);
            Assert.IsNotNull(realizado);
        }

        [TestMethod()]
        public void GetListTest()
        {
            GenericaBLL<Prestamos> genericaBLL = new GenericaBLL<Prestamos>();
            List<Prestamos> lista = new List<Prestamos>();
            lista = PrestamosBLL.GetList(l => true);
            Assert.IsNotNull(lista);
        }
    }
}