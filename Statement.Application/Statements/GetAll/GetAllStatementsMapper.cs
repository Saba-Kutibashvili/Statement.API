using AutoMapper;
using Statements.Domain.Statements;

namespace Statements.Application.Statements.GetAll
{
    public class GetAllStatementsMapper : Profile
    {
        public GetAllStatementsMapper()
        {
            CreateMap<Statement, GetAllStatementsResponse>();
        }
    }
}
