using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Statements.Domain.StatementTypes;
using Statements.Persistance.Context;

namespace Statements.Application.StatementTypes.Get
{
    public class GetStatementTypeQueryHandler : IRequestHandler<GetStatementTypesQuery, GetStatementTypeResponse>
    {
        private readonly StatementContext _context;
        private readonly IMapper _mapper;

        public GetStatementTypeQueryHandler(StatementContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetStatementTypeResponse> Handle(GetStatementTypesQuery request, CancellationToken token)
        {
            return await _context.StatementTypes.ProjectTo<GetStatementTypeResponse>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(x => x.Id == request.Id);
        }
    }
}
