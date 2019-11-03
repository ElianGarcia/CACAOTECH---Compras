using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int CantidadCacao { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Contratos(int contratoID, int cacaoID, int cantidadCacao, DateTime fechaInicio, DateTime fechaFin)
        {
            ContratoID = contratoID;
            CacaoID = cacaoID;
            CantidadCacao = cantidadCacao;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        public Contratos()
        {

        }
    }
}
