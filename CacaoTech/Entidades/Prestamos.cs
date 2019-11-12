using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacaoTech.Entidades
{
    public class Prestamos
    {
        [Key]
        public int PrestamoID { get; set; }
        public int ProductorID { get; set; }
        [ForeignKey("ProductorID")]
        public virtual Productores Productor { get; set; }
        public decimal Monto { get; set; }
        public decimal Balance { get; set; }

        public Prestamos(int prestamoID, int productorID, Productores productor, decimal monto, decimal balance)
        {
            PrestamoID = prestamoID;
            ProductorID = productorID;
            Productor = productor ?? throw new ArgumentNullException(nameof(productor));
            Monto = monto;
            Balance = balance;
        }

        public Prestamos()
        {

        }
    }
}
