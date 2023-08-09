using MediatR;
using Statements.Domain.StatementTypes;

namespace Statements.Application.Statements.Create
{
    public class CreateStatementCommand : IRequest<CreateStatementResponse>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string TypeId { get; set; }
    }
}
