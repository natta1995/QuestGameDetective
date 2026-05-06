using MediatR;
using QuestGameDetective.Application.Quests.Queries.GetMyQuests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestGameDetective.Application.Dtos.Cases;
using QuestGameDetective.Application.Dtos.Quest;
using QuestGameDetective.Application.Dtos.Quests;
using QuestGameDetective.Domain.Entities;
using QuestGameDetective.Domain.Enums;
using QuestGameDetective.Infrastructure.Data;
using System.Security.Claims;
using QuestGameDetective.Application.Quests.Commands.AcceptQuest;

namespace QuestGameDetective.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class QuestsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMediator _mediator;

        public QuestsController(AppDbContext context, IMediator mediator)
        {
            _context = context;
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

            var quest = await _context.Quests
                .Include(q => q.MurderCase)
                    .ThenInclude(m => m.Suspects)
                .FirstOrDefaultAsync(q => q.Id == id && q.UserId == userId);

            if (quest == null)
                return NotFound("Quest not found.");

            var dto = new QuestCaseDetailDto
            {
                QuestId = quest.Id,
                MurderCaseId = quest.MurderCaseId,
                Title = quest.MurderCase.Title,
                ShortSummary = quest.MurderCase.ShortSummary,
                Victim = quest.MurderCase.Victim,
                Place = quest.MurderCase.Place,
                CauseOfDeath = quest.MurderCase.CauseOfDeath,
                Weapon = quest.MurderCase.Weapon,
                CrimeSceneDescription = quest.MurderCase.CrimeSceneDescription,
                Status = quest.Status,
                Result = quest.Result,
                Suspects = quest.MurderCase.Suspects.Select(s => new SuspectDto
                {
                    Name = s.Name,
                    Statement = s.Statement
                }).ToList()
            };

            return Ok(dto);
        }

        [HttpPut("{id}/result")]
        public async Task<IActionResult> UpdateQuestResult(Guid id, [FromBody] UpdateQuestResultDto dto)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (dto == null || string.IsNullOrWhiteSpace(dto.Result))
                return BadRequest("Result is required.");

            if (userId == null)
                return Unauthorized();

            var quest = await _context.Quests
                .FirstOrDefaultAsync(q => q.Id == id && q.UserId == userId);

            if (quest == null)
                return NotFound("Quest not found.");

            if (quest.Result != QuestResult.None)
                return BadRequest("Quest result is already set.");

            if (!Enum.TryParse<QuestResult>(dto.Result, true, out var newResult))
                return BadRequest("Invalid result.");

            if (newResult == QuestResult.None)
                return BadRequest("Result cannot be None.");

            quest.Result = newResult;

            await _context.SaveChangesAsync();

            var resultDto = new QuestReadDto
            {
                Id = quest.Id,
                Status = quest.Status,
                Result = quest.Result,
                AcceptedAt = quest.AcceptedAt
            };

            return Ok(resultDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuest(Guid id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("User id not found in token.");
            }

            var quest = await _context.Quests
                .FirstOrDefaultAsync(q => q.Id == id && q.UserId == userId);

            if (quest == null)
            {
                return NotFound("Quest not found.");
            }

            _context.Quests.Remove(quest);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}