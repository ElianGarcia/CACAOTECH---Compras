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
    public class ContratosBLL
    {
        public static bool Guardar(Prestamos contrato)
        {
            bool realizado = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Contrato.Add(contrato) != null)
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

        public static bool Modificar(Prestamos contrato)
        {
            bool realizado = false;
            Contexto db = new Contexto();

            try
            {
                var Anterior = db.Contrato.Find(contrato.PrestamoID);
                db.Entry(contrato).State = EntityState.Modified;
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
                var Eliminar = db.Contrato.Find(ID);
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
            Prestamos contrato = new Prestamos();
            Contexto db = new Contexto();

            try
            {
                contrato = db.Contrato.Find(ID);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return contrato;
        }

        public static List<Prestamos> GetList(Expression<Func<Prestamos, bool>> contratos)
        {
            List<Prestamos> lista = new List<Prestamos>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Contrato.Where(contratos).ToList();
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
