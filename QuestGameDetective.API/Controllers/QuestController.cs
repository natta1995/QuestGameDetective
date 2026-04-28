using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestGameDetective.API.Data;
using QuestGameDetective.API.Models;
using QuestGameDetective.API.Models.Enums;
using QuestGameDetective.API.Dtos.Quest;

namespace QuestGameDetective.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class QuestsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public QuestsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("accept/{caseId}")]
        public async Task<IActionResult> AcceptQuest(Guid caseId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("User id not found in token.");
            }

            var murderCase = await _context.MurderCases.FindAsync(caseId);

            if (murderCase == null)
            {
                return NotFound("Case not found.");
            }

            var existingQuest = await _context.Quests
                .FirstOrDefaultAsync(q => q.UserId == userId && q.MurderCaseId == caseId);

            if (existingQuest != null)
            {
                return BadRequest("You have already accepted this case.");
            }

            var quest = new Quest
            {
                UserId = userId,
                MurderCaseId = caseId,
                Status = QuestStatus.Accepted,
                Result = QuestResult.None,
                AcceptedAt = DateTime.UtcNow,
                ExpiresAt = DateTime.UtcNow.AddHours(24),
                Reminder20hSent = false,
                Reminder1hSent = false
            };

            _context.Quests.Add(quest);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Quest accepted.",
                quest
            });
        }

        [HttpGet("mine")]
        public async Task<IActionResult> GetMyQuests()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            Console.WriteLine("Detta är ett test");
            Console.WriteLine(userId);

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("User id not found in token.");
            }

                    var myQuests = await _context.Quests
             .Where(q => q.UserId == userId)
             .Select(q => new QuestReadDto
             {
                 Id = q.Id,
                 Status = q.Status,
                 Result = q.Result,
                 AcceptedAt = q.AcceptedAt,
                 //CompletedAt = q.CompletedAt
             })
             .ToListAsync();

                    return Ok(myQuests);
        }

        [HttpPut("{id}/result")]
        public async Task<IActionResult> UpdateQuestResult(Guid id, [FromBody] string result)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            if (userId == null)
                return Unauthorized();

            var quest = await _context.Quests
                .FirstOrDefaultAsync(q => q.Id == id && q.UserId == userId);

            if (quest == null)
                return NotFound("Quest not found.");

            if (quest.Result != QuestResult.None)
                return BadRequest("Quest result is already set.");

            if (!Enum.TryParse<QuestResult>(result, true, out var newResult))
                return BadRequest("Invalid result.");

            if (newResult == QuestResult.None)
                return BadRequest("Result cannot be None.");

            quest.Result = newResult;

            await _context.SaveChangesAsync();

            return Ok(quest);
        }
    }
}