using MediatR;
using Microsoft.AspNetCore.Mvc;
using Statements.Application.Statements.Get;
using Statements.Application.StatementTypes.Create;
using Statements.Application.StatementTypes.Get;
using Statements.Application.StatementTypes.GetAll;
using Statements.Application.StatementTypes.Remove;
using Statements.Application.StatementTypes.Update;
using Statements.Domain;
using Statements.Domain.StatementTypes;

namespace Statements.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatementTypeController : ControllerBase
    {
        private IMediator _mediator { get; set; }
        public StatementTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<StatementController>
        [HttpGet]
        public async Task<PaginatedList<GetAllStatementTypeResponse>> GetAll([FromQuery] GetAllStatementTypesQuery request)
        {
            return await _mediator.Send(request);
        }

        // GET api/<StatementController>/5
        [HttpGet("Id")]
        public async Task<GetStatementTypeResponse> Get([FromQuery]GetStatementTypesQuery request)
        {
            return await _mediator.Send(request);
        }

        // POST api/<StatementController>
        [HttpPost]
        public async Task<CreateStatementTypeResponse> Create(CreateStatementTypeCommand payload)
        {
            return await _mediator.Send(payload);
        }

        // PUT api/<StatementController>/5
        [HttpPut]
        public async Task<UpdateStatementTypesResponse> Update(UpdateStatementTypesCommand payload)
        {
            return await _mediator.Send(payload);
        }

        // DELETE api/<StatementController>/5
        [HttpDelete("Id")]
        public async Task<RemoveStatementTypesResponse> Delete([FromQuery] RemoveStatementTypesCommand payload)
        {
            return await _mediator.Send(payload);
        }
    }
}
