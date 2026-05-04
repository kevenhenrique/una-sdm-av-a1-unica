using Microsoft.EntityFrameworkCore;
using ValeAtivos325219722.Models;

namespace ValeAtivos325219722.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Equipamento> Equipamentos => Set<Equipamento>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Equipamento>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(150);

            entity.Property(e => e.Tipo)
                .IsRequired()
                .HasMaxLength(80);

            entity.Property(e => e.Localizacao)
                .IsRequired()
                .HasMaxLength(120);

            entity.Property(e => e.CapacidadeProcessamento)
                .IsRequired();

            entity.Property(e => e.DataUltimaManutencao)
                .IsRequired();

            entity.Property(e => e.EmOperacao)
                .IsRequired();
        });
    }
}
