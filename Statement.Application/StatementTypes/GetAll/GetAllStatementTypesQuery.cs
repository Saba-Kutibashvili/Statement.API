using MediatR;
using Statements.Domain;

namespace Statements.Application.StatementTypes.GetAll
{
    public class GetAllStatementTypesQuery : SearchParameters, IRequest<PaginatedList<GetAllStatementTypeResponse>>
    {
        public OrderStatementTypes SortOrder { get; set; }
        public enum OrderStatementTypes
        {
            AphabeticalByType
        }
    }
}
