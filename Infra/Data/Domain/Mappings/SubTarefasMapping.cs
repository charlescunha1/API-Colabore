using ColaboreApi.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColaboreApi.Infra.Data.Domain.Mappings
{
    public class SubTarefasMapping : IEntityTypeConfiguration<SubTarefas>
    {
        public void Configure(EntityTypeBuilder<SubTarefas> builder)
        {
            throw new NotImplementedException();
        }
    }
}