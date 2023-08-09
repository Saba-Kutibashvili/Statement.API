using MediatR;
using Statements.Domain.StatementTypes;

namespace Statements.Application.StatementTypes.Create
{
    public class CreateStatementTypeCommand : IRequest<CreateStatementTypeResponse>
    {
        public string Type { get; set; }
    }
}
