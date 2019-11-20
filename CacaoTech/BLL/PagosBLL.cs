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
        public static void afectarPrestamos(Pagos pago)
        {
            GenericaBLL<Prestamos> genericaPrestamosBLL = new GenericaBLL<Prestamos>();
            var prestamo = genericaPrestamosBLL.Buscar(pago.PrestamoID);
            Contexto db = new Contexto();
            bool realizado = false;

            try
            {
                foreach (var item in pago.PagosDetalle)
                {
                    if (prestamo != null)
                    {
                        prestamo.Balance -= item.Monto;
                        db.Entry(prestamo).State = EntityState.Modified;
                        realizado = db.SaveChanges() > 0;
                    }
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
            
        }
        public static bool Guardar(Pagos pagos)
        {
            bool realizado = false;

            try
            {
                afectarPrestamos(pagos);

                GenericaBLL<Productores> genericaProductoresBLL = new GenericaBLL<Productores>();
                var productor = genericaProductoresBLL.Buscar(pagos.ProductorID);
                Contexto db = new Contexto();
                
                foreach (var item in pagos.PagosDetalle)
                {
                    if (productor != null)
                    {
                        productor.Balance -= item.Monto;
                        db.Entry(productor).State = EntityState.Modified;
                        realizado = db.SaveChanges() > 0;
                    }
                }

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
    }
}
