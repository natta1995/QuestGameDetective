using Microsoft.EntityFrameworkCore;
using QuestGameDetective.Domain.Entities;
using QuestGameDetective.Domain.Interfaces;
using QuestGameDetective.Infrastructure.Data;

namespace QuestGameDetective.Infrastructure.Repository
{
    public class MurderCaseRepository : IMurderCaseRepository
    {
        private readonly AppDbContext _context;

        public MurderCaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<MurderCase>> GetAllAsync()
        {
            return await _context.MurderCases.ToListAsync();
        }

        public async Task<MurderCase?> GetByIdAsync(Guid id)
        {
            return await _context.MurderCases.FindAsync(id);
        }
    }
}