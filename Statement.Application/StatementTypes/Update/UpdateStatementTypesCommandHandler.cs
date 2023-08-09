using AutoMapper;
using MediatR;
using Statements.Domain.StatementTypes;
using Statements.Persistance.Context;

namespace Statements.Application.StatementTypes.Update
{
    public class UpdateStatementTypesCommandHandler : IRequestHandler<UpdateStatementTypesCommand, UpdateStatementTypesResponse>
    {
        private readonly StatementContext _context;
        private readonly IMapper _mapper;

        public UpdateStatementTypesCommandHandler(StatementContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UpdateStatementTypesResponse> Handle(UpdateStatementTypesCommand request, CancellationToken token)
        {
            _context.StatementTypes.Update(_mapper.Map<StatementType>(request));

            await _context.SaveChangesAsync(token);

            return new UpdateStatementTypesResponse();
        }
    }
}
