using MediatR;

namespace Statements.Application.StatementTypes.Update
{
    public class UpdateStatementTypesCommand : IRequest<UpdateStatementTypesResponse>
    {
        public string Id { get; set; }
        public string Type { get; set; }
    }
}
