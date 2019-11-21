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
        public int PrestamoID { get; set; }
        [ForeignKey("PrestamoID")]
        public virtual Prestamos Prestamos { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Balance { get; set; }
        public decimal Pagado { get; set; }

        public PagosDetalle(int prestamoID, DateTime fecha, decimal balance, decimal pagado)
        {
            PrestamoID = prestamoID;
            Fecha = fecha;
            Balance = balance;
            Pagado = pagado;
        }

        public PagosDetalle()
        {

        }

        public PagosDetalle(int PagosDetalleID, DateTime fecha, decimal monto)
        {
            this.PagosDetalleID = PagosDetalleID;
            Fecha = fecha;
        }
    }
}