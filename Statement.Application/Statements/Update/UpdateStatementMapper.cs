using AutoMapper;
using Statements.Domain.Statements;

namespace Statements.Application.Statements.Update
{
    public class UpdateStatementMapper : Profile
    {
        public UpdateStatementMapper()
        {
            CreateMap<UpdateStatementsCommand, Statement>();
        }
    }
}
