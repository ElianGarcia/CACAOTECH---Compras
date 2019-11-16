using CacaoTech.DAL;
using CacaoTech.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace CacaoTech.BLL
{
    public class PagosBLL
    {
        public static bool Guardar(Pagos pagos)
        {
            bool realizado = false;

            try
            {
                //Afectando el Balance de la tabla de Productores
                AfectarTablaProductores(pagos);
                //Afectando el Balance de la tabla de Prestamos
                AfectarTablaPrestamos(pagos);

                Contexto db = new Contexto();
                if (db.Pago.Add(pagos) != null)
                    realizado = db.SaveChanges() > 0;
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
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
                if(pago != null)
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

        public static void AfectarTablaProductores(Pagos pago)
        {
            //Afectando el Balance de la tabla de Productores
            GenericaBLL<Productores> genericaBLL = new GenericaBLL<Productores>();
            Contexto db = new Contexto();
            var productor = genericaBLL.Buscar(pago.ProductorID);

            foreach (var item in pago.PagosDetalle)
            {
                if (productor != null)
                {
                    productor.Balance -= item.Monto;
                    db.Entry(productor).State = EntityState.Modified;
                }
            }
        }

        public static void AfectarTablaPrestamos(Pagos pago)
        {
            //Afectando el Balance de la tabla de Prestamos
            GenericaBLL<Prestamos> genericaBLL = new GenericaBLL<Prestamos>();
            Contexto db = new Contexto();
            var prestamo = genericaBLL.Buscar(pago.ProductorID);

            foreach (var item in pago.PagosDetalle)
            {
                if (prestamo != null)
                {
                    prestamo.Balance -= item.Monto;
                    db.Entry(prestamo).State = EntityState.Modified;
                }
            }
        }
    }
}
