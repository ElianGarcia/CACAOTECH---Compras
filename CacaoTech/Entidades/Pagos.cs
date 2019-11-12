using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacaoTech.Entidades
{
    public class Pagos
    {
        [Key]
        public int PagoID { get; set; }
        public DateTime Fecha { get; set; }
        public virtual List<PagosDetalle> PagosDetalle { get; set; }
    }
}
