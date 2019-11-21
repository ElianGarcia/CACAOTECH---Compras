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
        internal List<PagosDetalle> PagosDetalle;

        [Key]
        public int PagoID { get; set; }
        public int ProductorID { get; set; }
        [ForeignKey("ProductorID")]
        public virtual Productores productores { get; set; }
        public int PrestamoID { get; set; }
        public int UsuarioID { get; set; }
        [ForeignKey("UsuarioID")]
        public virtual Usuarios Usuarios { get; set; }

        public Pagos(int pagoID, int productorID, Productores productores)
        {
            PagoID = pagoID;
            ProductorID = productorID;
            this.productores = productores ?? throw new ArgumentNullException(nameof(productores));
        }

        public Pagos()
        {

        }
    }
}