using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Statements.Persistance.Context;

namespace Statements.Application.Statements.Get
{
    public class GetStatementsQueryHandler : IRequestHandler<GetStatementsQuery, GetStatementResponse>
    {
        private readonly StatementContext _context;
        private readonly IMapper _mapper;

        public GetStatementsQueryHandler(StatementContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetStatementResponse> Handle(GetStatementsQuery request, CancellationToken token)
        {
            return await _context.Statements.ProjectTo<GetStatementResponse>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(x => x.Id == request.Id);
        }
    }
}
