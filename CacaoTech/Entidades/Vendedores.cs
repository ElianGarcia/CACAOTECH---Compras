using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacaoTech.Entidades
{
    public class Vendedores {
        [Key]
        public int VendedorID { get; set; }
        public int ContratoID { get; set; }
        [ForeignKey("ContratoID")]
        public virtual Contratos Contrato { get; set; }

        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public Vendedores(int vendedorID, int contratoID, string nombre, string apellidos, string direccion, string cedula, string telefono, string celular, string email)
        {
            VendedorID = vendedorID;
            ContratoID = contratoID;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Apellidos = apellidos ?? throw new ArgumentNullException(nameof(apellidos));
            Direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
            Cedula = cedula ?? throw new ArgumentNullException(nameof(cedula));
            Telefono = telefono ?? throw new ArgumentNullException(nameof(telefono));
            Celular = celular ?? throw new ArgumentNullException(nameof(celular));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }

        public Vendedores()
        {

        }
    }
}