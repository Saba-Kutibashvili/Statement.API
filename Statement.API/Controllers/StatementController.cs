using MediatR;
using Microsoft.AspNetCore.Mvc;
using Statements.Application.Statements.Create;
using Statements.Application.Statements.Get;
using Statements.Application.Statements.GetAll;
using Statements.Application.Statements.Remove;
using Statements.Application.Statements.Update;
using Statements.Domain;

namespace Statements.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatementController : ControllerBase
    {
        private IMediator _mediator { get; set; }
        public StatementController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<StatementController>
        [HttpGet]
        public async Task<PaginatedList<GetAllStatementsResponse>> GetAll([FromQuery] GetAllStatementsQuery request)
        {
            return await _mediator.Send(request);
        }

        // GET api/<StatementController>/5
        [HttpGet("Id")]
        public async Task<GetStatementResponse> Get([FromQuery]GetStatementsQuery request)
        {
            return await _mediator.Send(request);
        }

        // POST api/<StatementController>
        [HttpPost]
        public async Task<CreateStatementResponse> Create(CreateStatementCommand payload)
        {
            return await _mediator.Send(payload);
        }

        // PUT api/<StatementController>/5
        [HttpPut]
        public async Task<UpdateStatementResponse> Update(UpdateStatementsCommand payload)
        {
            return await _mediator.Send(payload);
        }

        // DELETE api/<StatementController>/5
        [HttpDelete("Id")]
        public async Task<RemoveStatementResponse> Delete([FromQuery]RemoveStatementsCommand payload)
        {
            return await _mediator.Send(payload);
        }
    }
}
