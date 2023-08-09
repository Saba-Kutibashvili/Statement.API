using MediatR;
using Statements.Domain.StatementTypes;

namespace Statements.Application.StatementTypes.Get
{
    public class GetStatementTypesQuery : IRequest<GetStatementTypeResponse>
    {
        public string Id { get; set; }
    }
}
