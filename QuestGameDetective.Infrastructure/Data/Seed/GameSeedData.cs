using QuestGameDetective.Domain.Entities;
using QuestGameDetective.Infrastructure.Data.Seed.CaseSeeds;

namespace QuestGameDetective.Infrastructure.Data.Seed
{
    public static class GameSeedData
    {
        public static readonly MurderCase[] MurderCases =
        {
            LibraryMurderSeed.Case,
            AshcroftManorSeed.Case,
            ClockmakerSeed.Case
        };

        public static readonly Suspect[] Suspects =
            LibraryMurderSeed.Suspects
                .Concat(AshcroftManorSeed.Suspects)
                .Concat(ClockmakerSeed.Suspects)
                .ToArray();
    }
}