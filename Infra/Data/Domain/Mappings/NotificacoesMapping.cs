using ColaboreApi.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColaboreApi.Infra.Data.Domain.Mappings
{
    public class NotificacoesMapping : IEntityTypeConfiguration<Notificacoes>
    {
        public void Configure(EntityTypeBuilder<Notificacoes> builder)
        {
            throw new NotImplementedException();
        }
    }
}