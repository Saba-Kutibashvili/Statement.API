using MediatR;

namespace Statements.Application.Statements.Update
{
    public class UpdateStatementsCommand : IRequest<UpdateStatementResponse>
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TypeId { get; set; }
    }
}
