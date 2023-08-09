using AutoMapper;
using Statements.Domain.Statements;

namespace Statements.Application.Statements.Get
{
    public class GetStatementMapper : Profile
    {
        public GetStatementMapper()
        {
            CreateMap<Statement, GetStatementResponse>();
        }
    }
}
