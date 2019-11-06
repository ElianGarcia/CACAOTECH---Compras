using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacaoTech.Entidades
{
    public class ContratosDetalle
    {
        public int ContratosDetalleID { get; set; }
        public int CacaoID { get; set; }
        public DateTime Fecha { get; set; }
        //[ForeignKey("CacaoID")]
        //public Cacao Cacao { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }

        public ContratosDetalle(decimal cantidad, decimal precio)
        {
            Cantidad = cantidad;
            Precio = precio;
        }

        public ContratosDetalle(int contratosDetalleID, int cacaoID, DateTime fecha, decimal cantidad, decimal precio)
        {
            ContratosDetalleID = contratosDetalleID;
            CacaoID = cacaoID;
            Fecha = fecha;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
