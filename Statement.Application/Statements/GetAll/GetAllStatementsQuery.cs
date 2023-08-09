using MediatR;
using Statements.Domain;
using Statements.Domain.Statements;

namespace Statements.Application.Statements.GetAll
{
    public class GetAllStatementsQuery : SearchParameters, IRequest<PaginatedList<GetAllStatementsResponse>>
    {
        public OrderStatements SortOrder { get; set; }
        public enum OrderStatements
        {
            AphabeticalByTitle,
            AphabeticalByDescription
        }
    }
}
