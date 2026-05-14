//using QuestGameDetective.Domain.Entities;
//using QuestGameDetective.Domain.Enums;

//namespace QuestGameDetective.Infrastructure.Data.Seed.CaseSeeds
//{
//    public static class ClockmakerSeed
//    {
//        public static readonly Guid CaseId =
//            Guid.Parse("33333333-3333-3333-3333-333333333333");

//        public static readonly MurderCase Case = new()
//        {
//            Id = CaseId,

//            Priority = CasePriority.Low,

//            Title = "Urmakarens sista timme i Covent Garden",

//            ShortSummary =
//                "Den välkände urmakaren Tobias Wren hittas död i sin verkstad sent under torsdagskvällen.",

//            Victim = "Mr. Tobias Wren",

//            VictimImg = "victim.png",

//            Place =
//                "Offret återfanns i sin urmakarverkstad i Covent Garden omgiven av krossat glas och sönderslagna urdelar.",

//            CauseOfDeath =
//                "Trubbigt våld mot huvudet.",

//            Weapon =
//                "Ett tungt kugghjul av mässing återfunnet bredvid kroppen.",

//            CrimeSceneImg = "crimescene.png",

//            ClueImg = "workshopmap.png",

//            CrimeSceneDescription =
//                "Verkstaden är fylld av tickande klockor och halvfärdiga mekaniska konstruktioner.\n\n" +

//                "Tobias Wren återfanns liggande bredvid sitt arbetsbord med omfattande huvudskador.\n\n" +

//                "Golvet är täckt av glassplitter och flera lådor verkar ha dragits ut under tumultet.\n\n" +

//                "Trots detta verkar inga pengar eller värdesaker ha stulits från lokalen.\n\n" +

//                "Bakdörren stod på glänt när polisen anlände, medan huvudingången fortfarande var låst från insidan.",

//            SolutionText =
//                "Mrs. Adelaide Finch mördade Tobias Wren efter månader av ekonomiska konflikter och obetalda hyror.\n\n" +

//                "Under förhören försökte hon övertyga polisen om att hon aldrig besökt verkstaden under kvällen.\n\n" +

//                "Vid en närmare undersökning återfanns dock mässingsdamm på hennes handskar — samma typ av damm som täckte arbetsbänken och mordvapnet.\n\n" +

//                "Mrs. Finch hade dessutom detaljerad kännedom om verkstadens bakdörr, något endast personer med regelbunden tillgång till byggnaden rimligen borde känna till.\n\n" +

//                "Kugghjulet användes i vredesmod under ett häftigt gräl om hyran.\n\n" +

//                "För att förvilla utredningen arrangerades brottsplatsen så att det skulle framstå som ett rån eller ett inbrott som gått fel.",

//            KillerIndex = 3
//        };

//        public static readonly Suspect[] Suspects =
//        {
//            new Suspect
//            {
//                Id = Guid.Parse("cccccccc-1111-1111-1111-111111111111"),

//                MurderCaseId = CaseId,

//                Name = "Madame Valérie DuPont",

//                Role = "Kunden",

//                SuspectImg = "client.png",

//                Statement =
//                    "Förhörsrapport:\n\n" +

//                    "\"Jag besökte endast verkstaden för att hämta mitt fickur. Mr. Wren sade att reparationen ännu inte var färdig.\n\n" +

//                    "Han verkade stressad och bad mig återkomma dagen därpå.\n\n" +

//                    "Jag lämnade platsen nästan omedelbart därefter och såg ingen annan i butiken vid tillfället.\"",


//                InInvestigatorsNotes =
//                    "Madame DuPont uppträder lugnt och elegant men verkar angelägen om att snabbt lämna polisstationen."
//            },

//            new Suspect
//            {
//                Id = Guid.Parse("cccccccc-2222-2222-2222-222222222222"),

//                MurderCaseId = CaseId,

//                Name = "Arthur Bellamy",

//                Role = "Lärlingen",

//                SuspectImg = "apprentice.png",

//                Statement =
//                    "Förhörsrapport:\n\n" +

//                    "\"Jag arbetade i verkstaden större delen av dagen men gick ut en stund under kvällen för att röka.\n\n" +

//                    "När jag kom tillbaka var dörren låst och inga lampor syntes längre genom fönstret.\n\n" +

//                    "Mr. Wren hade varit på dåligt humör hela veckan. Han grälade med flera personer om pengar och leveranser.\"",


//                InInvestigatorsNotes =
//                    "Arthur verkar genuint skakad men döljer möjligen information om offrets ekonomiska problem."
//            },

//            new Suspect
//            {
//                Id = Guid.Parse("cccccccc-3333-3333-3333-333333333333"),

//                MurderCaseId = CaseId,

//                Name = "Inspector Harold Briggs",

//                Role = "Polisinspektören",

//                SuspectImg = "officer.png",

//                Statement =
//                    "Förhörsrapport:\n\n" +

//                    "\"Jag hade tidigare under veckan kontakt med Mr. Wren angående ett stulet familjearvegods.\n\n" +

//                    "När jag anlände till verkstaden under torsdagskvällen fick jag inget svar trots upprepade knackningar.\n\n" +

//                    "Jag noterade dock att bakdörren inte verkade ordentligt stängd när jag lämnade platsen.\"",


//                InInvestigatorsNotes =
//                    "Inspektören samarbetar fullt ut men verkar irriterad över att själv behöva förhöras."
//            },

//            new Suspect // Killer
//            {
//                Id = Guid.Parse("cccccccc-4444-4444-4444-444444444444"),

//                MurderCaseId = CaseId,

//                Name = "Mrs. Adelaide Finch",

//                Role = "Hyresvärden",

//                SuspectImg = "landlady.png",

//                Statement =
//                    "Förhörsrapport:\n\n" +

//                    "\"Mr. Wren var flera månader sen med hyran, men jag hade inga planer på att skada honom.\n\n" +

//                    "Jag tillbringade kvällen hos min syster och besökte aldrig verkstaden.\n\n" +

//                    "Om Tobias hade ekonomiska problem så var det knappast mitt ansvar. Mannen kunde knappt hålla ordning på sina egna affärer längre.\"",


//                InInvestigatorsNotes =
//                    "Mrs. Finch uppträder defensivt och blir märkbart spänd när frågor om verkstadens bakdörr och hennes ekonomi nämns."
//            }
//        };
//    }
//}
