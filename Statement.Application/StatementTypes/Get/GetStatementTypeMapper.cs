using AutoMapper;
using Statements.Domain.StatementTypes;

namespace Statements.Application.StatementTypes.Get
{
    public class GetStatementTypeMapper : Profile
    {
        public GetStatementTypeMapper()
        {
            CreateMap<StatementType, GetStatementTypeResponse>();
        }
    }
}
