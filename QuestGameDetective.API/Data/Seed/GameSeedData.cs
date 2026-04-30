using QuestGameDetective.Domain.Entities;
using QuestGameDetective.Domain.Enums;



namespace QuestGameDetective.API.Data.Seed
{
    public static class GameSeedData
    {
        public static readonly Guid Case1Id = Guid.Parse("11111111-1111-1111-1111-111111111111");
        public static readonly Guid Case2Id = Guid.Parse("22222222-2222-2222-2222-222222222222");
        public static readonly Guid Case3Id = Guid.Parse("33333333-3333-3333-3333-333333333333");

        public static readonly Guid Suspect1Id = Guid.Parse("aaaaaaaa-1111-1111-1111-111111111111");
        public static readonly Guid Suspect2Id = Guid.Parse("aaaaaaaa-2222-2222-2222-222222222222");
        public static readonly Guid Suspect3Id = Guid.Parse("aaaaaaaa-3333-3333-3333-333333333333");
        public static readonly Guid Suspect4Id = Guid.Parse("aaaaaaaa-4444-4444-4444-444444444444");

        public static readonly Guid Suspect5Id = Guid.Parse("bbbbbbbb-1111-1111-1111-111111111111");
        public static readonly Guid Suspect6Id = Guid.Parse("bbbbbbbb-2222-2222-2222-222222222222");
        public static readonly Guid Suspect7Id = Guid.Parse("bbbbbbbb-3333-3333-3333-333333333333");
        public static readonly Guid Suspect8Id = Guid.Parse("bbbbbbbb-4444-4444-4444-444444444444");

        public static readonly Guid Suspect9Id = Guid.Parse("cccccccc-1111-1111-1111-111111111111");
        public static readonly Guid Suspect10Id = Guid.Parse("cccccccc-2222-2222-2222-222222222222");
        public static readonly Guid Suspect11Id = Guid.Parse("cccccccc-3333-3333-3333-333333333333");
        public static readonly Guid Suspect12Id = Guid.Parse("cccccccc-4444-4444-4444-444444444444");

        public static readonly MurderCase[] MurderCases =
        {
            new MurderCase
            {
                Id = Case1Id,
                Priority = CasePriority.Medium,
                Title = "The Library Murder on Kensington Row",
                ShortSummary = "A wealthy gentleman is found dead in his private library. Four individuals were inside the house that evening.",
                Victim = "Sir Reginald Blackwood",
                Place = "His private library on Kensington Row",
                CauseOfDeath = "A gunshot wound to the head",
                Weapon = "A small revolver found near his right hand.",
                CrimeSceneDescription =
                    "The library is panelled in dark oak, its tall bookshelves stretching up toward the ceiling.\n" +
                    "A dying fire crackles faintly in the hearth. Sir Reginald sits slumped in his leather armchair,\n" +
                    "a revolver near his right hand and a half-finished glass of whisky on the side table.\n" +
                    "Rain patters rhythmically against the tall window overlooking the quiet street.",
                KillerIndex = 1,
                SolutionText =
                    "The revolver in the wrong hand makes suicide unlikely from the start. Several suspects tell small lies, but only one has a true motive.\n\n" +
                    "Edmund's story about writing letters collapses under scrutiny; he cannot recall simple details, and no such letter is found.\n" +
                    "Faced with the inconsistencies, he finally confesses — he shot Sir Reginald in the library to secure his inheritance."
            },
            new MurderCase
            {
                Id = Case2Id,
                Priority = CasePriority.High,
                Title = "The Midnight Tragedy at Ashcroft Manor",
                ShortSummary = "During a stormy night at the remote Ashcroft Manor, the master of the house dies during his own dinner party. Four guests remain under suspicion.",
                Victim = "Lord Percival Ashcroft",
                Place = "The dining hall of Ashcroft Manor",
                CauseOfDeath = "Poisoning",
                Weapon = "A crystal glass containing traces of arsenic",
                CrimeSceneDescription =
                    "Thunder shakes the old manor as candles flicker along the long dining hall.\n" +
                    "Lord Ashcroft lies collapsed at the head of the table, his untouched dessert before him.\n" +
                    "Rain lashes against the tall windows, and the storm has knocked out the telephone lines.\n" +
                    "The guests — all visibly shaken — stand gathered near the fireplace, each avoiding the others’ gaze.",
                KillerIndex = 0,
                SolutionText =
                    "The wet hem of Lady Ashcroft’s dress contradicts her claim of staying inside the dining hall.\n" +
                    "She slipped out during a clap of thunder, mixed arsenic into her husband’s wine, and returned unnoticed.\n" +
                    "Dr. Graves could not have poisoned the wine from the study, and the Colonel and Miss Whitfield had no opportunity.\n" +
                    "With mounting evidence and no alibi left standing, Lady Ashcroft ultimately confesses to the crime."
            },
            new MurderCase
            {
                Id = Case3Id,
                Priority = CasePriority.Low,
                Title = "The Clockmaker’s Last Hour in Covent Garden",
                ShortSummary = "A famous clockmaker is found dead in his workshop among shattered gears and ticking mechanisms. Four individuals had business with him that evening.",
                Victim = "Mr. Tobias Wren",
                Place = "His clockmaking shop in Covent Garden",
                CauseOfDeath = "Blunt force trauma",
                Weapon = "A heavy brass gear found on the floor beside the body",
                CrimeSceneDescription =
                    "The workshop is cluttered with intricate devices, the air filled with the steady ticking of dozens of clocks.\n" +
                    "Tobias Wren lies face-down beside his workbench, a large brass gear stained with blood nearby.\n" +
                    "Shards of glass cover the floor, and a single pocket watch ticks loudly from the victim’s hand.",
                KillerIndex = 3,
                SolutionText =
                    "The workshop door being locked suggests the killer exited through the back window.\n" +
                    "Mrs. Finch insisted she was not present, yet brass dust on her gloves proves she had been inside the workshop.\n" +
                    "Her motive — unpaid rent — is the strongest among the suspects, and the tampered pocket watch was staged to mimic a struggle.\n" +
                    "Confronted with the inconsistencies, Mrs. Finch breaks down and confesses."
            }
        };

        public static readonly Suspect[] Suspects =
        {
            new Suspect
            {
                Id = Suspect1Id,
                MurderCaseId = Case1Id,
                Name = "Mr. Hargreaves",
                Label = "the butler",
                Statement = "\"I was in the kitchen, sir, listening to the wireless when the shot rang out — or so they tell me. I heard nothing at all.\""
            },
            new Suspect
            {
                Id = Suspect2Id,
                MurderCaseId = Case1Id,
                Name = "Edmund Blackwood",
                Label = "the nephew",
                Statement = "\"I spent the evening in the guest room, writing letters. I never left the room, I assure you.\""
            },
            new Suspect
            {
                Id = Suspect3Id,
                MurderCaseId = Case1Id,
                Name = "Mrs. Beatrice Bloom",
                Label = "the housekeeper",
                Statement = "\"I was polishing the silver in the dining room. I did not go near the library, not once.\""
            },
            new Suspect
            {
                Id = Suspect4Id,
                MurderCaseId = Case1Id,
                Name = "Mrs. Evelyn Ashdown",
                Label = "the neighbour",
                Statement = "\"I left before the rain began. I heard nothing unusual, and the gentleman was quite well when I saw him last.\""
            },

            new Suspect
            {
                Id = Suspect5Id,
                MurderCaseId = Case2Id,
                Name = "Lady Imogen Ashcroft",
                Label = "the widow",
                Statement = "\"Percival was in good health, I assure you. I only poured his wine, as I always do.\""
            },
            new Suspect
            {
                Id = Suspect6Id,
                MurderCaseId = Case2Id,
                Name = "Dr. Lionel Graves",
                Label = "the family physician",
                Statement = "\"I stepped out to the study to fetch my medical kit. I returned only when I heard Lady Ashcroft scream.\""
            },
            new Suspect
            {
                Id = Suspect7Id,
                MurderCaseId = Case2Id,
                Name = "Colonel Barnaby Holt",
                Label = "the old friend",
                Statement = "\"I was smoking in the conservatory. The thunder was so loud I heard nothing of the commotion inside.\""
            },
            new Suspect
            {
                Id = Suspect8Id,
                MurderCaseId = Case2Id,
                Name = "Miss Clara Whitfield",
                Label = "the governess",
                Statement = "\"I was preparing the children for bed and only came down when the staff called for me.\""
            },

            new Suspect
            {
                Id = Suspect9Id,
                MurderCaseId = Case3Id,
                Name = "Madame Valérie DuPont",
                Label = "the client",
                Statement = "\"I came to collect my repaired watch, but Mr. Wren told me it wasn’t ready. I left immediately.\""
            },
            new Suspect
            {
                Id = Suspect10Id,
                MurderCaseId = Case3Id,
                Name = "Arthur Bellamy",
                Label = "the apprentice",
                Statement = "\"I stepped out for a smoke. When I returned, the door was locked from the inside.\""
            },
            new Suspect
            {
                Id = Suspect11Id,
                MurderCaseId = Case3Id,
                Name = "Inspector Harold Briggs",
                Label = "the officer",
                Statement = "\"I arrived to question Wren regarding a stolen heirloom. When I knocked, no one answered.\""
            },
            new Suspect
            {
                Id = Suspect12Id,
                MurderCaseId = Case3Id,
                Name = "Mrs. Adelaide Finch",
                Label = "the landlord",
                Statement = "\"He owed me two months’ rent, but I did not come here tonight. I was visiting my sister.\""
            }
        };
    }
}