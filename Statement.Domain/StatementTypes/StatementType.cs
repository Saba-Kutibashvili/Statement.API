using Statements.Domain.Statements;

namespace Statements.Domain.StatementTypes
{
    public class StatementType : BaseEntity
    {
        public string Type { get; set; }

        // Navigation Property
        public List<Statement> Statements { get; set; }

        public StatementType() : base()
        {
        }
    }
}
