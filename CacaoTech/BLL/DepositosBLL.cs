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
    public class DepositosBLL
    {
        public static bool Guardar(Depositos depositos)
        {
            bool realizado = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Deposito.Add(depositos) != null)
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

        public static bool Modificar(Depositos depositos)
        {
            bool realizado = false;
            Contexto db = new Contexto();

            try
            {
                var Anterior = db.Deposito.Find(depositos.DepositoID);
                foreach(var item in Anterior.DepositosDetalle)
                {
                    if (!depositos.DepositosDetalle.Exists(d => d.DepositosDetalleID == item.DepositosDetalleID))
                        db.Entry(item).State = EntityState.Deleted;
                }
                db.Entry(depositos).State = EntityState.Modified;
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
                var Eliminar = db.Deposito.Find(ID);
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

        public static Depositos Buscar(int ID)
        {
            Depositos deposito = new Depositos();
            Contexto db = new Contexto();

            try
            {
                deposito = db.Deposito.Find(ID);
                deposito.DepositosDetalle.Count();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return deposito;
        }

        public static List<Depositos> GetList(Expression<Func<Depositos, bool>> depositos)
        {
            List<Depositos> lista = new List<Depositos>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Deposito.Where(depositos).ToList();
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
