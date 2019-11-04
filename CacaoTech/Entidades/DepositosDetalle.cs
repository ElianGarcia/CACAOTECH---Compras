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
    }
}
