using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacaoTech.Entidades
{
    public class DepositosDetalle
    {
        [Key]
        public int DepositosDetalleID { get; set; }
        public int CacaoID { get; set; }
        [ForeignKey("CacaoID")]
        public Cacao Cacao { get; set; }
        public decimal Cantidad { get; set; }

        public DepositosDetalle(int depositosDetalleID, int cacaoID, Cacao cacao, decimal cantidad)
        {
            DepositosDetalleID = depositosDetalleID;
            CacaoID = cacaoID;
            Cacao = cacao ?? throw new ArgumentNullException(nameof(cacao));
            Cantidad = cantidad;
        }

        public DepositosDetalle(int cacaoID, Cacao cacao, decimal cantidad)
        {
            CacaoID = cacaoID;
            Cacao = cacao ?? throw new ArgumentNullException(nameof(cacao));
            Cantidad = cantidad;
        }
    }
}
