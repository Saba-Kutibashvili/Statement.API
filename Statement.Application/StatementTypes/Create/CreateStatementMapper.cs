using AutoMapper;
using Statements.Domain.StatementTypes;

namespace Statements.Application.StatementTypes.Create
{
    public class CreateStatementTypeMapper : Profile
    {
        public CreateStatementTypeMapper()
        {
            CreateMap<CreateStatementTypeCommand, StatementType>();
        }
    }
}
