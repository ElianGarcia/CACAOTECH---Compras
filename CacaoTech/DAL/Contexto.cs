using CacaoTech.Entidades;
using System.Data.Entity;

namespace CacaoTech.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Vendedores> Vendedor { get; set; }
        public DbSet<Cacao> Cacao { get; set; }
        public DbSet<Contratos> Contrato { get; set; }
        public DbSet<Depositos> Deposito { get; set; }
        public Contexto() : base("ConStr")
        {
        }
    }
}
