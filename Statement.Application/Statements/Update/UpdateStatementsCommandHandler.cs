using AutoMapper;
using MediatR;
using Statements.Domain.Statements;
using Statements.Persistance.Context;

namespace Statements.Application.Statements.Update
{
    public class UpdateStatementsCommandHandler : IRequestHandler<UpdateStatementsCommand, UpdateStatementResponse>
    {
        private readonly StatementContext _context;
        private readonly IMapper _mapper;

        public UpdateStatementsCommandHandler(StatementContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UpdateStatementResponse> Handle(UpdateStatementsCommand request, CancellationToken token)
        {
            _context.Statements.Update(_mapper.Map<Statement>(request));

            await _context.SaveChangesAsync(token);

            return new UpdateStatementResponse();
        }
    }
}
