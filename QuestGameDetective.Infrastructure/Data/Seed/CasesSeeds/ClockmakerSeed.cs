using QuestGameDetective.Domain.Entities;
using QuestGameDetective.Domain.Enums;

namespace QuestGameDetective.Infrastructure.Data.Seed.CaseSeeds
{
    public static class ClockmakerSeed
    {
        public static readonly Guid CaseId =
            Guid.Parse("33333333-3333-3333-3333-333333333333");

        public static readonly MurderCase Case = new()
        {
            Id = CaseId,
            Priority = CasePriority.Low,
            Title = "The Clockmaker’s Last Hour in Covent Garden",
            ShortSummary = "A famous clockmaker is found dead...",
            Victim = "Mr. Tobias Wren",
            Place = "His clockmaking shop in Covent Garden",
            CauseOfDeath = "Blunt force trauma",
            Weapon = "A heavy brass gear found on the floor beside the body",
            CrimeSceneDescription = "...",
            KillerIndex = 3,
            SolutionText = "..."
        };

        public static readonly Suspect[] Suspects =
        {
            new Suspect
            {
                Id = Guid.Parse("cccccccc-1111-1111-1111-111111111111"),
                MurderCaseId = CaseId,
                Name = "Madame Valérie DuPont",
                Label = "the client",
                Statement = "..."
            },

            new Suspect
            {
                Id = Guid.Parse("cccccccc-2222-2222-2222-222222222222"),
                MurderCaseId = CaseId,
                Name = "Arthur Bellamy",
                Label = "the apprentice",
                Statement = "..."
            },

            new Suspect
            {
                Id = Guid.Parse("cccccccc-3333-3333-3333-333333333333"),
                MurderCaseId = CaseId,
                Name = "Inspector Harold Briggs",
                Label = "the officer",
                Statement = "..."
            },

            new Suspect // Killer
            {
                Id = Guid.Parse("cccccccc-4444-4444-4444-444444444444"),
                MurderCaseId = CaseId,
                Name = "Mrs. Adelaide Finch",
                Label = "the landlord",
                Statement = "..."
            }
        };
    }
}
