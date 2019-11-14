using CacaoTech.Entidades;
using System.Data.Entity;

namespace CacaoTech.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productores> Productor { get; set; }
        public DbSet<Cacao> Cacao { get; set; }
        public DbSet<Prestamos> Prestamo { get; set; }
        public DbSet<Recepciones> Recepcion { get; set; }
        public DbSet<Pagos> Pago { get; set; }

        public Contexto() : base("ConStr")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
