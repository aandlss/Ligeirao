using Microsoft.EntityFrameworkCore;

namespace ligeirao.models
{
    public partial class LigeiraoContext : DbContext
    {
        public LigeiraoContext()
        {
        }
        public LigeiraoContext(DbContextOptions<LigeiraoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LocalizacaoVeiculo> LocalizacaoVeiculo { get; set; }
        public virtual DbSet<Veiculo> Veiculo { get; set; }
        public virtual DbSet<PontoReferencia> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=10.1.1.3;Initial Catalog=mTeste;User Id=sa;Password=@npd.2020");
                optionsBuilder.UseSqlServer("Data Source=server;Initial Catalog=mTeste;User ID=login;Password=senha;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocalizacaoVeiculo>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasOne(d => d.Veiculo)
                    .WithMany(p => p.LocalizacoesVeiculo)
                    .HasForeignKey(d => d.IdVeiculo);
            });

            modelBuilder.Entity<Veiculo>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<PontoReferencia>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
