using MediatR;
using Statements.Domain;
using Statements.Domain.Statements;

namespace Statements.Application.Statements.Get
{
    public class GetStatementsQuery : IRequest<GetStatementResponse>
    {
        public string Id { get; set; }
    }
}
