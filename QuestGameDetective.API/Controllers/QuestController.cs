using QuestGameDetective.Application.Quests.Commands.AcceptQuest;
using QuestGameDetective.Application.Quests.Queries.GetQuestDetails;
using QuestGameDetective.Application.Quests.Commands.UpdateQuestResult;
using QuestGameDetective.Application.Quests.Commands.DeleteQuest;
using QuestGameDetective.Application.Quests.Queries.GetMyQuests;
using QuestGameDetective.Application.Dtos.Quest;
using QuestGameDetective.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using MediatR;
using QuestGameDetective.Application.Dtos.Quests;



namespace QuestGameDetective.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class QuestsController : ControllerBase
    {
       
        private readonly IMediator _mediator;

        public QuestsController(AppDbContext context, IMediator mediator)
        {
          
            _mediator = mediator;
        }

        [HttpPost("accept/{caseId}")]
        public async Task<IActionResult> AcceptQuest(Guid caseId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("User id not found in token.");
            }

            try
            {
                var result = await _mediator.Send(
                    new AcceptQuestCommand(caseId, userId));

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("mine")]
        public async Task<IActionResult> GetMyQuests()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("User id not found in token.");
            }

            var myQuests = await _mediator.Send(new GetMyQuestsQuery(userId));

            return Ok(myQuests);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuestDetails(Guid id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var quest = await _mediator.Send(new GetQuestDetailsQuery(id, userId));

            if (quest == null)
                return NotFound("Quest not found.");

            return Ok(quest);
        }
        [HttpPut("{id}/accuse")]
        public async Task<IActionResult> UpdateQuestResult(Guid id, [FromBody] AccuseSuspectDto dto)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            try
            {
                var result = await _mediator.Send(
                    new UpdateQuestResultCommand(id, userId, dto.SuspectIndex));

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuest(Guid id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("User id not found in token.");
            }

            try
            {
                await _mediator.Send(new DeleteQuestCommand(id, userId));

                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}