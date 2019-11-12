using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacaoTech.Entidades
{
    public class Productores {

        [Key]
        public int ProductorID { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public bool Tipo { get; set; }
        public decimal Balance { get; set; }

        public Productores(int productorID, DateTime fecha, string nombres, string apellidos, string direccion, string cedula, string telefono, string celular, string email, bool tipo)
        {
            ProductorID = productorID;
            Fecha = fecha;
            Nombres = nombres ?? throw new ArgumentNullException(nameof(nombres));
            Apellidos = apellidos ?? throw new ArgumentNullException(nameof(apellidos));
            Direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
            Cedula = cedula ?? throw new ArgumentNullException(nameof(cedula));
            Telefono = telefono ?? throw new ArgumentNullException(nameof(telefono));
            Celular = celular ?? throw new ArgumentNullException(nameof(celular));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Tipo = tipo;
        }

        public Productores()
        {

        }
    }
}