using ColaboreApi.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColaboreApi.Infra.Data.Domain.Mappings
{
    public class ProjetosMapping : IEntityTypeConfiguration<Projetos>
    {
        public void Configure(EntityTypeBuilder<Projetos> builder)
        {
            throw new NotImplementedException();
        }
    }
}