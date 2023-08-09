using MediatR;

namespace Statements.Application.StatementTypes.Remove
{
    public class RemoveStatementTypesCommand : IRequest<RemoveStatementTypesResponse>
    {
        public string Id { get; set; }
    }
}
