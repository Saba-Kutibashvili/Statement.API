using AutoMapper;
using Statements.Domain.Statements;

namespace Statements.Application.Statements.Create
{
    public class CreateStatementMapper : Profile
    {
        public CreateStatementMapper()
        {
            CreateMap<CreateStatementCommand, Statement>();
        }
    }
}
