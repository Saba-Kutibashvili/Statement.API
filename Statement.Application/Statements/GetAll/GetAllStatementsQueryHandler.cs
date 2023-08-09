using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Statements.Domain;
using Statements.Persistance.Context;
using static Statements.Application.Statements.GetAll.GetAllStatementsQuery;

namespace Statements.Application.Statements.GetAll
{
    public class GetAllStatementsQueryHandler : IRequestHandler<GetAllStatementsQuery, PaginatedList<GetAllStatementsResponse>>
    {
        private readonly StatementContext _context;
        private readonly IMapper _mapper;

        public GetAllStatementsQueryHandler(StatementContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<GetAllStatementsResponse>> Handle(GetAllStatementsQuery request, CancellationToken token)
        {
            var result = await _context.Statements.ProjectTo<GetAllStatementsResponse>(_mapper.ConfigurationProvider)
                .ToListAsync(token);

            if (!String.IsNullOrEmpty(request.SearchString))
            {
                result = result.Where(x => x.Title.Contains(request.SearchString)).ToList();
            }

            switch (request.SortOrder)
            {
                case OrderStatements.AphabeticalByTitle:
                    result = result.OrderBy(x => x.Title).ToList();
                    break;
                case OrderStatements.AphabeticalByDescription:
                    result = result.OrderBy(x => x.Description).ToList();
                    break;
                default:
                    break;
            }

            return await PaginatedList<GetAllStatementsResponse>.CreateAsync(result, request.PageIndex, 5);
        }
    }
}
