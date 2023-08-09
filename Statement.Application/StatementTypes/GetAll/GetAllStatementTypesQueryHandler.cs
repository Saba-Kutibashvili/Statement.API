using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Statements.Domain;
using Statements.Persistance.Context;
using static Statements.Application.StatementTypes.GetAll.GetAllStatementTypesQuery;

namespace Statements.Application.StatementTypes.GetAll
{
    public class GetAllStatementTypesQueryHandler : IRequestHandler<GetAllStatementTypesQuery, PaginatedList<GetAllStatementTypeResponse>>
    {
        private readonly StatementContext _context;
        private readonly IMapper _mapper;

        public GetAllStatementTypesQueryHandler(StatementContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<GetAllStatementTypeResponse>> Handle(GetAllStatementTypesQuery request, CancellationToken token)
        {
            var result = await _context.StatementTypes.ProjectTo<GetAllStatementTypeResponse>(_mapper.ConfigurationProvider).ToListAsync(token);

            if (!String.IsNullOrEmpty(request.SearchString))
            {
                result = result.Where(x => x.Type.Contains(request.SearchString)).ToList();
            }

            switch (request.SortOrder)
            {
                case OrderStatementTypes.AphabeticalByType:
                    result = result.OrderBy(x => x.Type).ToList();
                    break;
                default:
                    break;
            }

            return await PaginatedList<GetAllStatementTypeResponse>.CreateAsync(result, request.PageIndex, 5);
        }
    }
}
