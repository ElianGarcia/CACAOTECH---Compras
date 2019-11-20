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
        public int ProductorID { get; set; }
        [ForeignKey("ProductorID")]
        public virtual Productores productores { get; set; }
        public int PrestamoID { get; set; }
        public virtual List<PagosDetalle> PagosDetalle { get; set; }
        public int UsuarioID { get; set; }
        [ForeignKey("UsuarioID")]
        public virtual Usuarios Usuarios { get; set; }

        public Pagos(int pagoID, int productorID, Productores productores, List<PagosDetalle> pagosDetalle)
        {
            PagoID = pagoID;
            ProductorID = productorID;
            this.productores = productores ?? throw new ArgumentNullException(nameof(productores));
            PagosDetalle = pagosDetalle ?? throw new ArgumentNullException(nameof(pagosDetalle));
        }

        public Pagos()
        {

        }
    }
}