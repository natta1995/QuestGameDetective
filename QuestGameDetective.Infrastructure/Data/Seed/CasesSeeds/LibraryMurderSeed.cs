using QuestGameDetective.Domain.Entities;
using QuestGameDetective.Domain.Enums;

namespace QuestGameDetective.Infrastructure.Data.Seed.CaseSeeds
{
    public static class LibraryMurderSeed
    {
        public static readonly Guid CaseId =
            Guid.Parse("11111111-1111-1111-1111-111111111111");

        public static readonly MurderCase Case = new()
        {
            Id = CaseId,
            Priority = CasePriority.Medium,
            Title = "The Library Murder on Kensington Row",
            ShortSummary = "A wealthy gentleman is found dead in his private library.",
            Victim = "Sir Reginald Blackwood",
            Place = "His private library on Kensington Row",
            CauseOfDeath = "A gunshot wound to the head",
            Weapon = "A small revolver found near his right hand.",
            CrimeSceneDescription =
                "The library is panelled in dark oak...",
            KillerIndex = 1,
            SolutionText =
                "The revolver in the wrong hand makes suicide unlikely..."
        };

        public static readonly Suspect[] Suspects =
        {
            new Suspect
            {
                Id = Guid.Parse("aaaaaaaa-1111-1111-1111-111111111111"),
                MurderCaseId = CaseId,
                Name = "Mr. Hargreaves",
                Label = "the butler",
                Statement = "..."
            },

            new Suspect // Killer
            {
                Id = Guid.Parse("aaaaaaaa-2222-2222-2222-222222222222"),
                MurderCaseId = CaseId,
                Name = "Edmund Blackwood",
                Label = "the nephew",
                Statement = "..."
            },

            new Suspect
            {
                Id = Guid.Parse("aaaaaaaa-3333-3333-3333-333333333333"),
                MurderCaseId = CaseId,
                Name = "Mrs. Beatrice Bloom",
                Label = "the housekeeper",
                Statement = "..."
            },

            new Suspect
            {
                Id = Guid.Parse("aaaaaaaa-4444-4444-4444-444444444444"),
                MurderCaseId = CaseId,
                Name = "Mrs. Evelyn Ashdown",
                Label = "the neighbour",
                Statement = "..."
            }
        };
    }
}