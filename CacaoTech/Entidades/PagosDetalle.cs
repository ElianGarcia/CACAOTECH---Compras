using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacaoTech.Entidades
{
    public class PagosDetalle
    {
        [Key]
        public int PagosDetalleID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }

        public PagosDetalle(int pagosDetalleID, DateTime fecha, decimal monto)
        {
            PagosDetalleID = pagosDetalleID;
            Fecha = fecha;
            Monto = monto;
        }

        public PagosDetalle()
        {

        }
    }
}