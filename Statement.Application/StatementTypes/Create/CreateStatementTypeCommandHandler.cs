using AutoMapper;
using MediatR;
using Statements.Domain.StatementTypes;
using Statements.Persistance.Context;

namespace Statements.Application.StatementTypes.Create
{
    public class CreateStatementTypeCommandHandler : IRequestHandler<CreateStatementTypeCommand, CreateStatementTypeResponse>
    {
        private readonly StatementContext _context;
        private readonly IMapper _mapper;

        public CreateStatementTypeCommandHandler(StatementContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CreateStatementTypeResponse> Handle(CreateStatementTypeCommand request, CancellationToken token)
        {
            _context.StatementTypes.Add(_mapper.Map<StatementType>(request));

            await _context.SaveChangesAsync(token);

            return new CreateStatementTypeResponse();
        }
    }
}
