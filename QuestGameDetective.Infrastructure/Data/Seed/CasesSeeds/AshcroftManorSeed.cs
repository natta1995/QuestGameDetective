using QuestGameDetective.Domain.Entities;
using QuestGameDetective.Domain.Enums;

namespace QuestGameDetective.Infrastructure.Data.Seed.CaseSeeds
{
    public static class AshcroftManorSeed
    {
        public static readonly Guid CaseId =
            Guid.Parse("22222222-2222-2222-2222-222222222222");

        public static readonly MurderCase Case = new()
        {
            Id = CaseId,
            Priority = CasePriority.High,
            Title = "The Midnight Tragedy at Ashcroft Manor",
            ShortSummary = "During a stormy night...",
            Victim = "Lord Percival Ashcroft",
            Place = "The dining hall of Ashcroft Manor",
            CauseOfDeath = "Poisoning",
            Weapon = "A crystal glass containing traces of arsenic",
            CrimeSceneDescription = "...",
            KillerIndex = 0,
            SolutionText = "..."
        };

        public static readonly Suspect[] Suspects =
        {
            new Suspect // Killer
            {
                Id = Guid.Parse("bbbbbbbb-1111-1111-1111-111111111111"),
                MurderCaseId = CaseId,
                Name = "Lady Imogen Ashcroft",
                Label = "the widow",
                Statement = "..."
            },

            new Suspect
            {
                Id = Guid.Parse("bbbbbbbb-2222-2222-2222-222222222222"),
                MurderCaseId = CaseId,
                Name = "Dr. Lionel Graves",
                Label = "the family physician",
                Statement = "..."
            },

            new Suspect
            {
                Id = Guid.Parse("bbbbbbbb-3333-3333-3333-333333333333"),
                MurderCaseId = CaseId,
                Name = "Colonel Barnaby Holt",
                Label = "the old friend",
                Statement = "..."
            },

            new Suspect
            {
                Id = Guid.Parse("bbbbbbbb-4444-4444-4444-444444444444"),
                MurderCaseId = CaseId,
                Name = "Miss Clara Whitfield",
                Label = "the governess",
                Statement = "..."
            }
        };
    }
}
