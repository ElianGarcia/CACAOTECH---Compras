using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacaoTech.Entidades
{
    public class Cacao
    {
        [Key]
        public int CacaoID { get; set; }
        public string Tipo { get; set; }
        public string Precio { get; set; }

        public Cacao()
        {

        }

        public Cacao(int cacaoID, string tipo, string precio)
        {
            CacaoID = cacaoID;
            Tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
            Precio = precio ?? throw new ArgumentNullException(nameof(precio));
        }
    }
}
