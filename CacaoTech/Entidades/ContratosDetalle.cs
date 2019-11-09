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
        [ForeignKey("CacaoID")]
        public virtual Cacao Cacao { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Monto { get; set; }

        public ContratosDetalle(decimal cantidad, decimal precio)
        {
            Cantidad = cantidad;
            Precio = precio;
        }

        public ContratosDetalle(int contratosDetalleID, int cacaoID, decimal cantidad, decimal precio)
        {
            ContratosDetalleID = contratosDetalleID;
            CacaoID = cacaoID;
            Cantidad = cantidad;
            Precio = precio;
        }

        public ContratosDetalle(string cacao, decimal cantidad, decimal precio, decimal monto)
        {
            Cantidad = cantidad;
            Precio = precio;
            Monto = monto;
        }
    }
}
