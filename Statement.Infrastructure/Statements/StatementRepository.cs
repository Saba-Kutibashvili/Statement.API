using Microsoft.EntityFrameworkCore;
using Statements.Domain.Statements;

namespace Statements.Infrastructure.Statements
{
    public class StatementRepository : BaseRepository<Statement>, IStatementRepository
    {
        public StatementRepository(DbContext context) : base(context)
        {
        }
    }
}
