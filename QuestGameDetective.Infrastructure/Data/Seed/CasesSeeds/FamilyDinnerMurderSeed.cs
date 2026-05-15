using QuestGameDetective.Domain.Entities;
using QuestGameDetective.Domain.Enums;

namespace QuestGameDetective.Infrastructure.Data.Seed.CaseSeeds
{
    public static class FamilyDinnerMurderSeed
    {
        public static readonly Guid CaseId =
            Guid.Parse("44444444-4444-4444-4444-444444444444");

        public static readonly MurderCase Case = new()
        {
            Id = CaseId,

            Priority = CasePriority.High,

            Title = "Familjemiddags mordet på Ravenshire Manor",

            ShortSummary =
                "Under en stillsam familjemiddag faller den yngsta dottern plötsligt död ner efter att ha druckit ur sitt vinglas.",

            Victim = "Charlotte Ashbourne",

            VictimImg = "youngsistervictim.png",

            Place =
                "Charlotte Ashbourne avled vid middagsbordet i familjens herrgård strax efter att huvudrätten serverats.",

            CauseOfDeath =
                "Akut arsenikförgiftning.",

            Weapon =
                "Förgiftning - Arsenik blandat i offrets vinglas.",

            CrimeSceneImg = "familydinnercrime.png",

            ClueImg = "tablebedroom.png",

            CrimeSceneDescription =
                "Den vanliga söndagsmiddagen ägde rum i den stora matsalen på Ravenshire Manor.\n\n" +

                "När huvudrätten serverades tog Charlotte Ashbourne några klunkar ur sitt vinglas innan hon plötsligt tappade andan och föll ihop över bordet.\n\n" +

                "Familjens läkare, som anlände kort därefter, kunde snabbt konstatera att döden orsakats av arsenik.\n\n" +

                "Polisen fann inga tecken på att giftet funnits i maten. Endast offrets vinglas innehöll spår av arsenik.\n\n" +

                "Vid bordet satt offrets föräldrar, hennes två systrar, hennes bror, offrets fästman samt systern Eleanors fästman, som var sen till middagen.\n\n" +

                "Flera av de medverkande vid bordet kunde strykas som misstänkta direkt på plats.\n\n" +

                "Ingen i familjen beskriver middagen som särskilt konfliktfylld — men nästan samtliga medger att relationen till Charlotte stundtals varit komplicerad.",

            SolutionText =
                "Charlotte Ashbourne mördades av sin syster Eleanor Ashbourne.\n\n" +

                "Eleanor hade levt ett helt liv i skuggan av sin syster, som alltid varit familjens favorit och faderns ögonsten.\n\n" +

                "Men när Charlotte inledde en relation med Arthur och planerade att rymma ihop, fick Eleanor nog och inskaffade arsenik.\n\n" +

                "På Eleanors finger upptäcktes en ring med ett dolt fack där hon förvarat giftet. Redan innan middagen smet hon förbi och hällde pulvret i systerns glas.\n\n" +

                "Charlotte drack av vinet först när köträtten serverades.\n\n" +

                "I Charlottes rum syntes tydliga tecken på att hon planerat att lämna familjens herrgård.\n\n" +

                "På Arthurs skjortkrage återfanns spår av samma röda läppstift som Charlotte bar under kvällen.\n\n" +

                "Under det avslutande förhöret bröt Eleanor slutligen samman och erkände mordet.",

            KillerIndex = 1
        };

        public static readonly Suspect[] Suspects =
        {
            new Suspect
            {
                Id = Guid.Parse("dddddddd-1111-1111-1111-111111111111"),

                MurderCaseId = CaseId,

                Name = "Jonathan Ashbourne",

                Role = "Brodern",

                SuspectImg = "dinnerbrother.png",

                Statement =
                    "Förhörsrapport:\n\n" +

                    "\"Charlotte och jag stod aldrig varandra särskilt nära. Hon var yngst. Kom undan med allt. Allt hon pekade på skulle hon ha.\n\n" +

                    "Hon har alltid varit mors favorit, och far skall vi inte prata om. Han dyrkade marken hon gick på. Jag vill inte ens veta hur mycket pengar han slängt på henne.\n\n" +

                    "Mina föräldrar är redan gamla och sjuka, detta kommer väl ta livet av dem.\n\n" +

                    "Jag? Mörda henne? Vad skulle jag vinna på det? Förresten reste jag mig aldrig från bordet under middagen och jag rörde inte hennes glas.\n\n" +

                    "Ja, jag spelar ibland. Men det betyder inte att jag är en mördare.\"",


                InInvestigatorsNotes =
                    "Jonathan uppträder arrogant men verkar samtidigt genuint chockad över systerns död."
            },

            new Suspect // KILLER
            {
                Id = Guid.Parse("dddddddd-2222-2222-2222-222222222222"),

                MurderCaseId = CaseId,

                Name = "Eleanor Ashbourne",

                Role = "Mellersta systern",

                SuspectImg = "sister1.png",

                Statement =
                    "Förhörsrapport:\n\n" +

                    "\"Charlotte hade ett sätt att alltid få allt att handla om henne.\n\n" +

                    "Mor och far avgudade henne nästan. Det är nästan skrattretande hur de kunde se henne som någon slags ängel.\n\n" +

                    "Men trots våra meningsskiljaktigheter var hon fortfarande min syster.\n\n" +

                    "Jag gick visserligen bort mot serveringsbordet under middagen men bara för att hämta mer vin.\n\n" +

                    "När jag kom tillbaka började far hosta igen och sedan… sedan föll Charlotte ihop.\"",


                InInvestigatorsNotes =
                    "Eleanor framstår som känslomässigt instabil men saklig. Hon mjuknar när hon pratar om sin far."
            },

            new Suspect
            {
                Id = Guid.Parse("dddddddd-3333-3333-3333-333333333333"),

                MurderCaseId = CaseId,

                Name = "Thomas Whitmore",

                Role = "Fästmannen",

                SuspectImg = "tablefiance.png",

                Statement =
                    "Förhörsrapport:\n\n" +

                    "\"Charlotte och jag skulle gifta oss innan årets slut, det var tanken i alla fall.\n\n" +

                    "Vi har grälat en del det sista. Jag tycker hon trycker bort mig. Ibland vet jag inte vad hon vill.\n\n" +

                    "Men jag älskade verkligen Charlotte. Jag vet inte om jag kan leva vidare utan henne i denna värld. Jag skulle aldrig göra henne illa.\n\n" +

                    "Jag satt intill henne hela middagen. Men jag såg ingen lägga något i hennes glas. Men det är ju inte heller sådant man tänker på i vanliga fall.\n\n" +

                    "Jag vet bara att hon plötsligt började hosta. Det gick så fort och sedan var hon bara död.\"",


                InInvestigatorsNotes =
                    "Thomas verkar uppriktigt skakad men flera familjemedlemmar beskriver relationen som mindre lycklig än han själv påstår."
            },

            new Suspect
            {
                Id = Guid.Parse("dddddddd-4444-4444-4444-444444444444"),

                MurderCaseId = CaseId,

                Name = "Margaret Ashbourne",

                Role = "Äldre systern",

                SuspectImg = "bigsister2.png",

                Statement =
                    "Förhörsrapport:\n\n" +

                    "\"Jag vill bara att det här skall vara över. Charlotte kunde vara hård men hon förtjänade inte det här.\n\n" +

                    "Bortskämd? Ja, det kan man väl säga. Hon fick vad hon pekade på. Men det var mer mina föräldrars fel än hennes i så fall.\n\n" +

                    "Jag såg Eleanor lämna bordet en kort stund. Hon sade att hon skulle hämta vin men jag tror snarare att hon var upprörd och hade svårt att sitta still.\n\n" +

                    "Hennes fästman Arthur skulle varit med, men han var sen. Inte förrän vi börjat äta huvudrätten kom han in genom dörren.\n\n" +

                    "Ingen av mina systrar tycks vara särskilt lyckliga i sina kärleksrelationer. Och folk frågar varför jag vill förbli ogift.\"",


                InInvestigatorsNotes =
                    "Margaret verkar nervös men hennes berättelse förblir konsekvent genom hela utredningen."
            }
        };
    }
}