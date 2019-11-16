using CacaoTech.DAL;
using CacaoTech.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
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

            //Afectando el Balance de la tabla de Productores
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

        public static bool Modificar(Prestamos prestamo)
        {
            bool realizado = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(prestamo).State = EntityState.Modified;
                var Anterior = PrestamosBLL.Buscar(prestamo.PrestamoID);
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
                var Eliminar = db.Prestamo.Find(ID);
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

        public static Prestamos Buscar(int ID)
        {
            Prestamos prestamos = new Prestamos();
            Contexto db = new Contexto();

            try
            {
                prestamos = db.Prestamo.Find(ID);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return prestamos;
        }

        public static List<Prestamos> GetList(Expression<Func<Prestamos, bool>> prestamo)
        {
            List<Prestamos> lista = new List<Prestamos>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Prestamo.Where(prestamo).ToList();
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
