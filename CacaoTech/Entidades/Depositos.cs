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
        public virtual Vendedores Vendedor { get; set; }
        public virtual List<DepositosDetalle> DepositosDetalle { get; set; }

        public Depositos(int depositoID, DateTime fecha, int vendedorID, Vendedores vendedor, List<DepositosDetalle> depositosDetalle)
        {
            DepositoID = depositoID;
            Fecha = fecha;
            VendedorID = vendedorID;
            Vendedor = vendedor ?? throw new ArgumentNullException(nameof(vendedor));
            DepositosDetalle = new List<DepositosDetalle>();
        }

        public Depositos()
        {
        }
    }
}
