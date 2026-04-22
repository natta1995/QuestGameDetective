using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestGameDetective.API.Data;
using QuestGameDetective.API.Models;
using QuestGameDetective.API.Models.Enums;

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
                .ToListAsync();

            return Ok(myQuests);
        }
    }
}