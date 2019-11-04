using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacaoTech.Entidades
{
    public class Depositos
    {
        [Key]
        public int DepositoID { get; set; }
        public DateTime Fecha { get; set; }
        public int VendedorID { get; set; }
        [ForeignKey("VendedorID")]
        public Vendedores Vendedor { get; set; }
    }
}
