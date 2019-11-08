using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacaoTech.Entidades
{
    public class Contratos
    {
        [Key]
        public int ContratoID { get; set; }
        public int CacaoID { get; set; }
        [ForeignKey("CacaoID")]
        public virtual Cacao Cacao { get; set; }
        public int VendedorID { get; set; }
        [ForeignKey("VendedorID")]
        public virtual Vendedores Vendedor { get; set; }
        public int CantidadCacao { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public virtual List<ContratosDetalle> ContratosDetalle { get; set; }

        public Contratos(int contratoID, int cantidadCacao, DateTime fechaInicio, DateTime fechaFin)
        {
            ContratoID = contratoID;
            CantidadCacao = cantidadCacao;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        public Contratos()
        {

        }
    }
}
