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
    public class RecepcionesBLL
    {
        public static bool Guardar(Recepciones r)
        {
            bool realizado = false;
            Contexto db = new Contexto();

            AfectarTablaCacao(r);

            try
            {
                if (db.Recepcion.Add(r) != null)
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

        private static void AfectarTablaCacao(Recepciones r)
        {
            GenericaBLL<Cacao> genericaBLL = new GenericaBLL<Cacao>();
            Cacao c = genericaBLL.Buscar(r.CacaoID);
            c.Existencia += r.Cantidad;
            genericaBLL.Modificar(c);
        }

        public static bool Modificar(Recepciones r)
        {
            bool realizado = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(r).State = EntityState.Modified;
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
                var Eliminar = db.Recepcion.Find(ID);
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

        public static Recepciones Buscar(int ID)
        {
            Recepciones r = new Recepciones();
            Contexto db = new Contexto();

            try
            {
                r = db.Recepcion.Find(ID);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return r;
        }

        public static List<Recepciones> GetList(Expression<Func<Recepciones, bool>> r)
        {
            List<Recepciones> lista = new List<Recepciones>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Recepcion.Where(r).ToList();
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