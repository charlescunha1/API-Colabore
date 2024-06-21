using ColaboreApi.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColaboreApi.Infra.Data.Domain.Mappings
{
    public class UsuariosMapping : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            throw new NotImplementedException();
        }
    }
}