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
        public int ProductorID { get; set; }
        [ForeignKey("ProductorID")]
        public virtual Productores productores { get; set; }
        public decimal Cantidad { get; set; }
    }
}
