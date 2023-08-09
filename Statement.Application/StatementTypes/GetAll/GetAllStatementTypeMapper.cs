using AutoMapper;
using Statements.Domain.StatementTypes;

namespace Statements.Application.StatementTypes.GetAll
{
    public class GetAllStatementTypeMapper : Profile
    {
        public GetAllStatementTypeMapper()
        {
            CreateMap<StatementType, GetAllStatementTypeResponse>();
        }
    }
}
