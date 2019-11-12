using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacaoTech.Entidades
{
    public class Recepciones
    {
        public int RecepcionID { get; set; }
        public DateTime Fecha { get; set; }
        public int ProductorID { get; set; }
        [ForeignKey("ProductorID")]
        public virtual Productores Productor { get; set; }
        public int CacaoID { get; set; }
        [ForeignKey("CacaoID")]
        public virtual Cacao Cacao { get; set; }
        public decimal Cantidad { get; set; }

        public Recepciones(int recepcionID, DateTime fecha, int cacaoID, Cacao cacao, decimal cantidad)
        {
            RecepcionID = recepcionID;
            Fecha = fecha;
            CacaoID = cacaoID;
            Cacao = cacao ?? throw new ArgumentNullException(nameof(cacao));
            Cantidad = cantidad;
        }

        public Recepciones()
        {

        }
    }
}
