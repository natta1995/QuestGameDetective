using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestGameDetective.API.Data;
using QuestGameDetective.API.Dtos.Cases;

namespace QuestGameDetective.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CasesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CasesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCases()
        {
            var cases = await _context.MurderCases
                .Include(c => c.Suspects)
                .Select(c => new CaseReadDto
                {
                    Id = c.Id,
                    Title = c.Title,
                    ShortSummary = c.ShortSummary,
                    Victim = c.Victim,
                    Place = c.Place,
                    CauseOfDeath = c.CauseOfDeath,
                    Weapon = c.Weapon,
                    CrimeSceneDescription = c.CrimeSceneDescription,
                    Priority = c.Priority,
                    Suspects = c.Suspects.Select(s => new SuspectDto
                    {
                        Name = s.Name,
                        Statement = s.Statement
                    }).ToList()
                })
                .ToListAsync();

            return Ok(cases);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCaseById(Guid id)
        {
            var murderCase = await _context.MurderCases
                .Include(c => c.Suspects)
                .Where(c => c.Id == id)
                .Select(c => new CaseReadDto
                {
                    Id = c.Id,
                    Title = c.Title,
                    ShortSummary = c.ShortSummary,
                    Victim = c.Victim,
                    Place = c.Place,
                    CauseOfDeath = c.CauseOfDeath,
                    Weapon = c.Weapon,
                    CrimeSceneDescription = c.CrimeSceneDescription,
                    Priority = c.Priority,
                    Suspects = c.Suspects.Select(s => new SuspectDto
                    {
                        Name = s.Name,
                        Statement = s.Statement
                    }).ToList()
                })
                .FirstOrDefaultAsync();

            if (murderCase == null)
                return NotFound();

            return Ok(murderCase);
        }
    }
}
