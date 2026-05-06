using QuestGameDetective.Application.Cases.Queries.GetAllCases;
using QuestGameDetective.Application.Cases.Queries.GetCaseById;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MediatR;


namespace QuestGameDetective.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CasesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CasesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet] // Hämta alla fall 
        public async Task<IActionResult> GetAllCases()
        {
            var cases = await _mediator.Send(new GetAllCasesQuery());

            return Ok(cases);
        }

        [HttpGet("{id}")] // Hämta just det här fallet
        public async Task<IActionResult> GetCaseById(Guid id)
        {
            var murderCase = await _mediator.Send(new GetCaseByIdQuery(id));

            if (murderCase == null)
                return NotFound();

            return Ok(murderCase);
        }
    }
}
