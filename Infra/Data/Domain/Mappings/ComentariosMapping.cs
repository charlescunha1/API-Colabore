using ColaboreApi.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColaboreApi.Infra.Data.Domain.Mappings
{
    public class ComentariosMapping : IEntityTypeConfiguration<Comentarios>
    {
        public void Configure(EntityTypeBuilder<Comentarios> builder)
        {
            builder.Property(x => x.ComentarioId)
                   .HasColumnName("Com_ComentarioId")
                   .IsRequired();

            builder.Property(x => x.Conteudo)
                   .HasColumnName("Com_Conteudo")
                   .IsRequired();
        }
    }
}