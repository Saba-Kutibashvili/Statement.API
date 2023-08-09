using AutoMapper;
using Statements.Domain.Statements;
using Statements.Domain.StatementTypes;

namespace Statements.Application.StatementTypes.Update
{
    public class UpdateStatementTypesMapper : Profile
    {
        public UpdateStatementTypesMapper()
        {
            CreateMap<UpdateStatementTypesCommand, StatementType>();
        }
    }
}
