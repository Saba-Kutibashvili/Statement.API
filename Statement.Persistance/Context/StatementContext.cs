using Microsoft.EntityFrameworkCore;
using Statements.Domain.Statements;
using Statements.Domain.StatementTypes;

namespace Statements.Persistance.Context
{
    public class StatementContext : DbContext
    {
        public StatementContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Statement> Statements { get; set; }
        public DbSet<StatementType> StatementTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
