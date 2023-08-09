using MediatR;
using Microsoft.EntityFrameworkCore;
using Statements.Persistance.Context;

namespace Statements.Application.StatementTypes.Remove
{
    public class RemoveStatementTypesCommandHandler : IRequestHandler<RemoveStatementTypesCommand, RemoveStatementTypesResponse>
    {
        private readonly StatementContext _context;

        public RemoveStatementTypesCommandHandler(StatementContext context)
        {
            _context = context; 
        }

        public async Task<RemoveStatementTypesResponse> Handle(RemoveStatementTypesCommand request, CancellationToken token)
        {
            _context.StatementTypes.Remove(await _context.StatementTypes.FirstOrDefaultAsync(x => x.Id == request.Id, token));

            await _context.SaveChangesAsync(token);

            return new RemoveStatementTypesResponse();
        }
    }
}
