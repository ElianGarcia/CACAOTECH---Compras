using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacaoTech.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioID { get; set; }
        public string Nombres { get; set; }
        public string Contraseña { get; set; }

        public Usuarios()
        {
        }

        public Usuarios(int usuarioID, string nombres, string contraseña)
        {
            UsuarioID = usuarioID;
            Nombres = nombres ?? throw new ArgumentNullException(nameof(nombres));
            Contraseña = contraseña ?? throw new ArgumentNullException(nameof(contraseña));
        }
    }
}