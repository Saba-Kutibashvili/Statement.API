using MediatR;
using Microsoft.EntityFrameworkCore;
using Statements.Persistance.Context;

namespace Statements.Application.Statements.Remove
{
    public class RemoveStatementsCommandHandler : IRequestHandler<RemoveStatementsCommand, RemoveStatementResponse>
    {
        private readonly StatementContext _context;

        public RemoveStatementsCommandHandler(StatementContext context)
        {
            _context = context; 
        }

        public async Task<RemoveStatementResponse> Handle(RemoveStatementsCommand request, CancellationToken token)
        {
            _context.Statements.Remove(await _context.Statements.FirstOrDefaultAsync(x => x.Id == request.Id, token));

            await _context.SaveChangesAsync(token);

            return new RemoveStatementResponse();
        }
    }
}
