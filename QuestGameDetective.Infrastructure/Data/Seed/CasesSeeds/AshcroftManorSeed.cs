//using QuestGameDetective.Domain.Entities;
//using QuestGameDetective.Domain.Enums;

//namespace QuestGameDetective.Infrastructure.Data.Seed.CaseSeeds
//{
//    public static class AshcroftManorSeed
//    {
//        public static readonly Guid CaseId =
//            Guid.Parse("22222222-2222-2222-2222-222222222222");

//        public static readonly MurderCase Case = new()
//        {
//            Id = CaseId,

//            Priority = CasePriority.High,

//            Title = "Midnattstragedin på Ashcroft Manor",

//            ShortSummary =
//                "Under en stormig kväll kollapsar Lord Percival Ashcroft mitt under en middag på familjens herrgård.",

//            Victim = "Lord Percival Ashcroft",

//            VictimImg = "victim.png",

//            Place =
//                "Offret återfanns död vid matsalsbordet på Ashcroft Manor under familjens privata middagsbjudning.",

//            CauseOfDeath =
//                "Arsenikförgiftning.",

//            Weapon =
//                "Ett kristallglas innehållande spår av arsenik.",

//            CrimeSceneImg = "crimescene.png",

//            ClueImg = "manormap.png",

//            CrimeSceneDescription =
//                "En kraftig storm rasade över Ashcroft Manor under kvällen och telefonlinjerna hade slagits ut av åskan.\n\n" +

//                "Lord Ashcroft kollapsade plötsligt under middagen framför flera vittnen.\n\n" +

//                "Vid offrets plats återfanns ett kristallglas med tydliga spår av arsenik.\n\n" +

//                "Måltiden hade serverats av hushållets personal och inga främmande personer tycks ha besökt herrgården under kvällen.\n\n" +

//                "Trots det verkar flera av gästerna bära på egna konflikter och hemligheter kopplade till offret.",

//            SolutionText =
//                "Lady Imogen Ashcroft mördade sin make genom att blanda arsenik i hans vin under middagen.\n\n" +

//                "Under förhören försökte hon framstå som chockad och hjälplös, samtidigt som hon upprepade gånger betonade offrets svaga hälsa.\n\n" +

//                "Flera vittnen uppgav dock att Lord Ashcroft varit vid god vigör tidigare under dagen.\n\n" +

//                "Den avgörande ledtråden återfanns på Lady Ashcrofts klänning vars nederkant fortfarande var blöt efter stormen.\n\n" +

//                "Trots att hon hävdade att hon aldrig lämnat matsalen hade hon i hemlighet gått till förrådsrummet där arseniken förvarades.\n\n" +

//                "När motsägelserna blev för många bröt Lady Ashcroft slutligen samman och erkände mordet.",

//            KillerIndex = 0
//        };

//        public static readonly Suspect[] Suspects =
//        {
//            new Suspect // Killer
//            {
//                Id = Guid.Parse("bbbbbbbb-1111-1111-1111-111111111111"),

//                MurderCaseId = CaseId,

//                Name = "Lady Imogen Ashcroft",

//                Role = "Änkan",

//                SuspectImg = "widow.png",

//                Statement =
//                    "Förhörsrapport:\n\n" +

//                    "\"Min make var inte en lätt man att leva med, men jag skulle aldrig skada honom.\n\n" +

//                    "Han hade varit stressad och utmattad under en längre tid. Jag fruktade ofta att hans hjärta inte skulle orka mycket längre.\n\n" +

//                    "Under middagen lämnade jag endast bordet för ett kort ögonblick för att hämta frisk luft efter åskan.\n\n" +

//                    "När jag återvände kollapsade Percival nästan omedelbart framför oss alla.\"",


//                InInvestigatorsNotes =
//                    "Lady Ashcroft uppträder samlat men verkar ovanligt fokuserad på att beskriva offrets hälsa som svag och instabil."
//            },

//            new Suspect
//            {
//                Id = Guid.Parse("bbbbbbbb-2222-2222-2222-222222222222"),

//                MurderCaseId = CaseId,

//                Name = "Dr. Lionel Graves",

//                Role = "Familjeläkaren",

//                SuspectImg = "doctor.png",

//                Statement =
//                    "Förhörsrapport:\n\n" +

//                    "\"Lord Ashcroft hade vissa hälsoproblem men inget som tydde på att döden var nära förestående.\n\n" +

//                    "Jag lämnade matsalen under några minuter för att hämta min läkarväska från arbetsrummet.\n\n" +

//                    "När jag återvände hade Lord Ashcroft redan kollapsat och gästerna var i fullständig panik.\"",


//                InInvestigatorsNotes =
//                    "Dr. Graves verkar professionell och behärskad men undviker frågor om familjens interna konflikter."
//            },

//            new Suspect
//            {
//                Id = Guid.Parse("bbbbbbbb-3333-3333-3333-333333333333"),

//                MurderCaseId = CaseId,

//                Name = "Colonel Barnaby Holt",

//                Role = "Familjevännen",

//                SuspectImg = "colonel.png",

//                Statement =
//                    "Förhörsrapport:\n\n" +

//                    "\"Jag tog min cigarr till vinterträdgården efter huvudrätten. Stormen var så kraftig att man knappt kunde höra sina egna tankar.\n\n" +

//                    "Percival hade många fiender genom åren men jag hade aldrig trott att det skulle sluta på detta sätt.\n\n" +

//                    "När jag hörde skriken från matsalen sprang jag tillbaka omedelbart.\"",


//                InInvestigatorsNotes =
//                    "Översten verkar uppriktigt skakad men verkar samtidigt känna till mer om offrets affärer än han först vill erkänna."
//            },

//            new Suspect
//            {
//                Id = Guid.Parse("bbbbbbbb-4444-4444-4444-444444444444"),

//                MurderCaseId = CaseId,

//                Name = "Miss Clara Whitfield",

//                Role = "Guvernanten",

//                SuspectImg = "governess.png",

//                Statement =
//                    "Förhörsrapport:\n\n" +

//                    "\"Jag befann mig på övervåningen tillsammans med barnen när allt inträffade.\n\n" +

//                    "Tjänstefolket kom springande kort därefter och berättade att Lord Ashcroft blivit sjuk.\n\n" +

//                    "Huset har känts spänt i flera veckor. Det har varit fler gräl än vanligt mellan herrskapet.\"",


//                InInvestigatorsNotes =
//                    "Miss Whitfield verkar nervös men samarbetsvillig. Hon verkar särskilt obekväm när Lady Ashcroft nämns."
//            }
//        };
//    }
//}