﻿using CacaoTech.DAL;
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
    public class PagosBLL : GenericaBLL<Pagos>
    {
        public override bool Guardar(Pagos pagos)
        {
            bool realizado = false;
            Contexto db;
            GenericaBLL<Productores> genericaBLL = new GenericaBLL<Productores>();

            try
            {
                foreach(var item in pagos.PagosDetalle)
                {
                    //Afectando el Balance de la tabla de Productores
                    var productor = genericaBLL.Buscar(pagos.ProductorID);
                    if(productor != null)
                    {
                        productor.Balance -= item.Monto;
                    }
                       
                    //Afectando el Balance de la tabla de Prestamos
                    var prestamo = PrestamosBLL.Buscar(pagos.PrestamoID);
                    if (prestamo != null)
                    {
                        prestamo.Balance -= item.Monto;
                    }
                }

                db = new Contexto();
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
