using CacaoTech.DAL;
using CacaoTech.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}