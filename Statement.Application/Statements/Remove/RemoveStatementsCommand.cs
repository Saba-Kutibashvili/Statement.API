using MediatR;
using Statements.Domain;
using Statements.Domain.Statements;

namespace Statements.Application.Statements.Remove
{
    public class RemoveStatementsCommand : IRequest<RemoveStatementResponse>
    {
        public string Id { get; set; }
    }
}
