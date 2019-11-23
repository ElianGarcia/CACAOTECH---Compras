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
        [Key]
        public int RecepcionID { get; set; }
        public DateTime Fecha { get; set; }
        public int ProductorID { get; set; }
        [ForeignKey("ProductorID")]
        public virtual Productores productor { get; set; }
        public int CacaoID { get; set; }
        [ForeignKey("CacaoID")]
        public virtual Cacao cacao { get; set; }
        public decimal Cantidad { get; set; }
        public int UsuarioID { get; set; }

        public Recepciones(int recepcionID, DateTime fecha, int cacaoID, decimal cantidad)
        {
            RecepcionID = recepcionID;
            Fecha = fecha;
            CacaoID = cacaoID;
            Cantidad = cantidad;
        }

        public Recepciones()
        {

        }
    }
}
