using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Statements.Domain.Statements;

namespace Statements.Persistance.Configurations
{
    public class StatementConfiguration : IEntityTypeConfiguration<Statement>
    {
        public void Configure(EntityTypeBuilder<Statement> builder)
        {
            builder.HasOne(x => x.Type).WithMany(x => x.Statements);
        }
    }
}
