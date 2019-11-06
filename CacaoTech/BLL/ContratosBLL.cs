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
        public static bool Guardar(Contratos contrato)
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

        public static bool Modificar(Contratos contrato)
        {
            bool realizado = false;
            Contexto db = new Contexto();

            try
            {
                var Anterior = db.Deposito.Find(contrato.ContratoID);
                foreach(var item in Anterior.DepositosDetalle)
                {
                    if (!contrato.DepositosDetalle.Exists(d => d.DepositosDetalleID == item.DepositosDetalleID))
                        db.Entry(item).State = EntityState.Deleted;
                }
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

        public static Contratos Buscar(int ID)
        {
            Contratos contrato = new Contratos();
            Contexto db = new Contexto();

            try
            {
                contrato = db.Contrato.Find(ID);
                contrato.ContratoDetalle.Count();
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

        public static List<Contratos> GetList(Expression<Func<Contratos, bool>> contratos)
        {
            List<Contratos> lista = new List<Contratos>();
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
