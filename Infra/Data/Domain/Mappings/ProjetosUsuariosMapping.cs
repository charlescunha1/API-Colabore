using ColaboreApi.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColaboreApi.Infra.Data.Domain.Mappings
{
    public class ProjetosUsuariosMapping : IEntityTypeConfiguration<ProjetosUsuarios>
    {
        public void Configure(EntityTypeBuilder<ProjetosUsuarios> builder)
        {
            throw new NotImplementedException();
        }
    }
}