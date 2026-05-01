using QuestGameDetective.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGameDetective.Domain.Interfaces
{
    public interface IMurderCaseRepository
    {
        Task<List<MurderCase>> GetAllAsync();
        Task<MurderCase?> GetByIdAsync(Guid id);
    }
}
