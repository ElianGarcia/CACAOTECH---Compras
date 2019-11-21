using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public decimal Precio { get; set; }
        public decimal Existencia { get; set; }
        public int UsuarioID { get; set; }
        [ForeignKey("UsuarioID")]
        public virtual Usuarios Usuarios { get; set; }

        public Cacao()
        {

        }

        public Cacao(int cacaoID, string tipo, decimal precio, int usuario)
        {
            CacaoID = cacaoID;
            Tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
            Precio = precio;
            UsuarioID = usuario;
        }
    }
}
