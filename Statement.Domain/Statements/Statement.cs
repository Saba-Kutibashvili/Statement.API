using Statements.Domain.StatementTypes;

namespace Statements.Domain.Statements
{
    public class Statement : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string TypeId { get; set; }

        // Navigation Properties
        public StatementType Type { get; set; }

        public Statement() : base()
        {
        }
    }
}
