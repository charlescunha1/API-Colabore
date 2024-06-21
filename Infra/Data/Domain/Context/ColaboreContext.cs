using ColaboreApi.Domain.Model;
using ColaboreApi.Infra.Data.Domain.Mappings;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace ColaboreApi.Infra.Data.Domain.Context;

public class ColaboreContext : DbContext
{
    public DbSet<Usuarios> Usuarios { get; set; }
    public DbSet<Projetos> Projetos { get; set; }
    public DbSet<Tarefas> Tarefas { get; set; }
    public DbSet<SubTarefas> SubTarefas { get; set; }
    public DbSet<ProjetosUsuarios> ProjetosUsuarios { get; set; }
    public DbSet<Comentarios> Comentarios { get; set; }
    public DbSet<Notificacoes> Notificacoes { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UsuariosMapping());
        modelBuilder.ApplyConfiguration(new ProjetosMapping());
        modelBuilder.ApplyConfiguration(new TarefasMapping());
        modelBuilder.ApplyConfiguration(new SubTarefasMapping());
        modelBuilder.ApplyConfiguration(new ProjetosUsuariosMapping());
        modelBuilder.ApplyConfiguration(new ComentariosMapping());
        modelBuilder.ApplyConfiguration(new NotificacoesMapping());

        base.OnModelCreating(modelBuilder);
    }
}
