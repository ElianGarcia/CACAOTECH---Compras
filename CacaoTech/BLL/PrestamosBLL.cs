using CacaoTech.DAL;
using CacaoTech.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacaoTech.BLL
{
    public class PrestamosBLL
    {
        public static bool Guardar(Prestamos prestamo)
        {
            bool realizado = false;
            Contexto db = new Contexto();

            GenericaBLL<Productores> genericaBLL = new GenericaBLL<Productores>();

            Productores p = genericaBLL.Buscar(prestamo.ProductorID);
            p.Balance += prestamo.Total;
            genericaBLL.Modificar(p);

            try
            {
                if (db.Prestamo.Add(prestamo) != null)
                    realizado = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return realizado;
        }

        public static bool Modificar(Pagos pago)
        {
            bool realizado = false;
            Contexto db = new Contexto();

            try
            {
                var Anterior = PagosBLL.Buscar(pago.PagoID);
                foreach (var item in Anterior.PagosDetalle)
                {
                    if (!pago.PagosDetalle.Exists(d => d.PagosDetalleID == item.PagosDetalleID))
                        db.Entry(item).State = EntityState.Deleted;
                }
                db.Entry(pago).State = EntityState.Modified;
                realizado = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return realizado;
        }

        public static bool Eliminar(int ID)
        {
            bool realizado = false;
            Contexto db = new Contexto();

            try
            {
                var Eliminar = db.Pago.Find(ID);
                db.Entry(Eliminar).State = EntityState.Deleted;

                realizado = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return realizado;
        }

        public static Pagos Buscar(int ID)
        {
            Pagos pago = new Pagos();
            Contexto db = new Contexto();

            try
            {
                pago = db.Pago.Find(ID);
                if (pago != null)
                {
                    pago.PagosDetalle.Count();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return pago;
        }

        public static List<Pagos> GetList(Expression<Func<Pagos, bool>> pago)
        {
            List<Pagos> lista = new List<Pagos>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Pago.Where(pago).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return lista;
        }
    }
}
