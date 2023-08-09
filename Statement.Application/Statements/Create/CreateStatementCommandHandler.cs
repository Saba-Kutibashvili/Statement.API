using AutoMapper;
using MediatR;
using Statements.Domain.Statements;
using Statements.Persistance.Context;

namespace Statements.Application.Statements.Create
{
    public class CreateStatementCommandHandler : IRequestHandler<CreateStatementCommand, CreateStatementResponse>
    {
        private readonly StatementContext _context;
        private readonly IMapper _mapper;

        public CreateStatementCommandHandler(StatementContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CreateStatementResponse> Handle(CreateStatementCommand request, CancellationToken token)
        {
            _context.Statements.Add(_mapper.Map<Statement>(request));

            await _context.SaveChangesAsync(token);

            return new CreateStatementResponse();
        }
    }
}
