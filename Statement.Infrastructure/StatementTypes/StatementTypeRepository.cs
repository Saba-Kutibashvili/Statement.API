using Microsoft.EntityFrameworkCore;
using Statements.Domain.StatementTypes;

namespace Statements.Infrastructure.StatementTypes
{
    public class StatementTypeRepository : BaseRepository<StatementType>, IStatementTypeRepository
    {
        public StatementTypeRepository(DbContext context) : base(context)
        {
        }
    }
}
