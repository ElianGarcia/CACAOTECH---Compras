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
    public class PagosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            PagosDetalle pagosDetalle = new PagosDetalle(1, DateTime.Now, 5000, 5200);
            List<PagosDetalle> list = new List<PagosDetalle>();
            list.Add(pagosDetalle);
            Pagos pagos = new Pagos(1, 1, 1, 1, list);
            bool realizado = PagosBLL.Guardar(pagos);
            Assert.AreEqual(true, realizado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            PagosDetalle pagosDetalle = new PagosDetalle(1, DateTime.Now, 5000, 5200);
            PagosDetalle pagosDetalle1 = new PagosDetalle(1, DateTime.Now, 4200, 5200);
            List<PagosDetalle> list = new List<PagosDetalle>();
            list.Add(pagosDetalle);
            list.Add(pagosDetalle1);
            Pagos pagos = new Pagos(1, 1, null, 1, 1, null, list);
            bool realizado = PagosBLL.Modificar(pagos);
            Assert.AreEqual(true, realizado);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool realizado = PagosBLL.Eliminar(1);
            Assert.AreEqual(realizado, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var encontrado = PagosBLL.Buscar(1);
            Assert.IsNotNull(encontrado);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Pagos> lista = new List<Pagos>();
            lista = PagosBLL.GetList(l => true);
            Assert.IsNotNull(lista);
        }
    }
}