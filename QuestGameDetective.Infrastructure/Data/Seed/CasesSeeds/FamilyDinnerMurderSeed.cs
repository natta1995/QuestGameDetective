using QuestGameDetective.Domain.Entities;
using QuestGameDetective.Domain.Enums;

namespace QuestGameDetective.Infrastructure.Data.Seed.CaseSeeds
{
    public static class FamilyDinnerMurderSeed
    {
        public static readonly Guid CaseId =
           
        Guid.Parse("33333333-3333-3333-3333-333333333333");

        public static readonly MurderCase Case = new()
        {
            Id = CaseId,

            Priority = CasePriority.High,

            Title = "Familjemiddagsmordet på Ravenshire Manor",

            ShortSummary =
                "Under en till synes stillsam familjemiddag faller den yngsta dottern plötsligt död ner efter att ha druckit ur sitt vinglas.",

            Victim = "Charlotte Ashbourne",

            VictimAge = "23 år",

            VictimJob = "Överklassdam",

            VictimLifeSituation =
                "Yngsta dottern i familjen Ashbourne. Levde ett skyddat liv på Ravenshire Manor men planerade i hemlighet att lämna familjens herrgård.",

            VictimImg = "youngsistervictim.png",

            Place =
                "Ravenshire Manor, strax utanför London.",

            CauseOfDeath =
                "Akut arsenikförgiftning.",

            Weapon =
                "Arsenik blandat i offrets vinglas.",

            CrimeSceneImg = "familydinnercrime.png",

            CrimeSceneImgText =
                "Brottsplatsfotografi – Middagsbordet efter dödsfallet",

            ClueImg = "tablebedroom.png",

            ClueImgText =
                "Fotografi från Charlottes sovrum",

            SecondClueImg = "charlottediary.png",

            SecondClueImgText =
                "Dagboks hittad under offrets säng",

            CrimeSceneDescription =
                "Den traditionella söndagsmiddagen hölls i den stora matsalen på Ravenshire Manor.\n\n" +

                "När huvudrätten serverades tog Charlotte Ashbourne några klunkar ur sitt vinglas innan hon plötsligt började hosta våldsamt och föll ihop över bordet.\n\n" +

                "Familjens läkare anlände kort därefter och kunde endast konstatera att den unga kvinnan redan var avliden.\n\n" +

                "Vid senare undersökning återfanns tydliga spår av arsenik i offrets vinglas. Inga övriga glas eller maträtter visade däremot tecken på förgiftning.\n\n" +

                "Vid middagsbordet befann sig offrets föräldrar, hennes två systrar, brodern Jonathan Ashbourne, Charlottes fästman Thomas Fairford samt systern Helenas fästman Julian Pembroke, som anlände sent till middagen.\n\n" +

                "Trots familjens försök att beskriva relationerna som goda framkommer det snabbt under förhören att flera familjemedlemmar hyst stark bitterhet gentemot Charlotte under en längre tid.",

            SolutionText =
            "Charlotte Ashbourne mördades av sin syster Helena Ashbourne.\n\n" +

            "Under större delen av sitt liv hade Helena levt i skuggan av sin yngre syster, som ständigt behandlades som familjens favorit.\n\n" +

            "När Charlotte dessutom planerade att lämna Ravenshire Manor tillsammans med Thomas Fairford växte Helenas bitterhet till hat.\n\n" +

            "Helena hade sedan flera veckor tillbaka införskaffat arsenik som hon gömde i ett dolt fack i sin ring.\n\n" +

            "Under middagen lämnade hon bordet under förevändning att hämta mer vin och passade då på att hälla giftet i Charlottes glas.\n\n" +

            "Charlotte drack först av vinet när huvudrätten serverades.\n\n" +

            "I Charlottes sovrum återfanns en halvpackad resväska, privata brev samt dagboksanteckningar som tydligt visade att hon planerade att rymma följande morgon.\n\n" +

            "Under det avslutande förhöret bröt Helena slutligen samman och erkände mordet.",

                    SolutionClues =
            "• Endast Charlottes vinglas innehöll spår av arsenik.\n\n" +

            "• Helena Ashbourne lämnade bordet ensam under middagen under förevändning att hämta mer vin.\n\n" +

            "• På fotografiet från Charlottes sovrum syns en halvpackad resväska samt ett porträtt av Thomas Fairford.\n\n" +

            "• Dagboksanteckningar återfunna i offrets rum visar att Charlotte planerade att bryta sin förlovning och rymma följande morgon.\n\n" +

            "• På Helenas ring upptäcktes senare ett dolt fack innehållande rester av arsenik.",

            KillerIndex = 1
        };

        public static readonly Suspect[] Suspects =
        {
            new Suspect
            {
                Id = Guid.Parse("dddddddd-1111-1111-1111-111111111111"),
                MurderCaseId = CaseId,
                Name = "Jonathan Ashbourne",
                Age = "31 år",
                Job = "Arvtagare",
                LifeSituation =
                    "Spelberoende och svårt skuldsatt efter flera misslyckade investeringar.",
                Role = "Brodern",
                SuspectImg = "dinnerbrother.png",

                Statement =
                    "Förhörsrapport:\n\n" +

                    "\"Charlotte och jag stod aldrig varandra särskilt nära.\n\n" +

                    "Hon var yngst och kom undan med precis allting.\n\n" +

                    "Mor avgudade henne och far behandlade henne som om hon vore någon sorts prinsessa.\n\n" +

                    "Jag vill inte ens veta hur mycket pengar som lagts på hennes nöjen genom åren.\n\n" +

                    "Men tro inte att det betyder att jag önskade henne död.\n\n" +

                    "Mina föräldrar är gamla och redan svaga. Det här kommer ta livet av dem.\n\n" +

                    "Jag reste mig aldrig från bordet under middagen och jag rörde aldrig hennes glas.\n\n" +

                    "Och ja, jag spelar ibland. Men spelare och mördare är inte samma sak, konstapeln.\"",

                InInvestigatorsNotes =
                    "Jonathan uppträder arrogant men verkar samtidigt genuint skakad över systerns död."
            },

            new Suspect
            {
                Id = Guid.Parse("dddddddd-2222-2222-2222-222222222222"),
                MurderCaseId = CaseId,
                Name = "Helena Ashbourne",
                Age = "27 år",
                Job = "Överklassdam",
                LifeSituation =
                    "Bor fortfarande kvar på familjens herrgård och lever under sin fars strikta kontroll.",
                Role = "Mellersta systern",
                SuspectImg = "sister1.png",

                Statement =
                    "Förhörsrapport:\n\n" +

                    "\"Charlotte hade ett märkligt sätt att få hela världen att kretsa kring henne.\n\n" +

                    "Mor och far såg henne nästan som någon sorts liten ängel.\n\n" +

                    "Det är nästan skrattretande när man tänker på det.\n\n" +

                    "Men trots våra meningsskiljaktigheter var hon fortfarande min syster.\n\n" +

                    "Ja, jag gick bort mot serveringsbordet under middagen men endast för att hämta mer vin.\n\n" +

                    "När jag kom tillbaka började far hosta igen och sedan… sedan föll Charlotte ihop.\n\n" +

                    "Allting gick så fruktansvärt fort.\"",

                InInvestigatorsNotes =
                    "Helena framstår som känslomässigt instabil men försöker hela tiden behålla kontrollen över sig själv."
            },

            new Suspect
            {
                Id = Guid.Parse("dddddddd-3333-3333-3333-333333333333"),
                MurderCaseId = CaseId,
                Name = "Thomas Fairford",
                Age = "29 år",
                Job = "Banktjänsteman",
                LifeSituation =
                    "Förlovad med Charlotte Ashbourne men relationen beskrivs som turbulent av flera familjemedlemmar.",
                Role = "Fästmannen",
                SuspectImg = "tablefiance.png",

                Statement =
                    "Förhörsrapport:\n\n" +

                    "\"Charlotte och jag planerade att gifta oss innan årets slut.\n\n" +

                    "Åtminstone var det planen.\n\n" +

                    "Vi har haft våra gräl den senaste tiden men jag älskade henne verkligen.\n\n" +

                    "Jag satt intill henne under hela middagen och jag såg ingen röra hennes glas.\n\n" +

                    "Men sådant är kanske heller inget man lägger märke till under en vanlig familjemiddag.\n\n" +

                    "Jag vet bara att hon plötsligt började hosta och sedan… sedan var hon borta.\n\n" +

                    "Jag skulle aldrig kunna skada Charlotte. Aldrig.\"",

                InInvestigatorsNotes =
                    "Thomas verkar uppriktigt förtvivlad men flera familjemedlemmar beskriver relationen som betydligt mindre lycklig än han själv påstår."
            },

            new Suspect
            {
                Id = Guid.Parse("dddddddd-4444-4444-4444-444444444444"),
                MurderCaseId = CaseId,
                Name = "Margaret Ashbourne",
                Age = "35 år",
                Job = "Överklassdam",
                LifeSituation =
                    "Äldsta systern i familjen. Har aldrig gift sig och fungerar ofta som medlare mellan familjemedlemmarna.",
                Role = "Äldre systern",
                SuspectImg = "bigsister2.png",

                Statement =
                    "Förhörsrapport:\n\n" +

                    "\"Jag vill bara att det här skall vara över.\n\n" +

                    "Charlotte kunde vara svår ibland men hon förtjänade inte detta.\n\n" +

                    "Bortskämd? Ja, kanske.\n\n" +

                    "Men det var mer mors och fars fel än hennes.\n\n" +

                    "Jag såg Helena lämna bordet under middagen. Hon sade att hon skulle hämta mer vin men hon verkade snarare upprörd.\n\n" +

                    "Helenas fästman Julian anlände dessutom sent till middagen.\n\n" +

                    "Ingen av mina systrar tycks ha varit särskilt lyckliga.\n\n" +

                    "Och folk frågar fortfarande varför jag valt att förbli ogift.\"",

                InInvestigatorsNotes =
                    "Margaret verkar nervös men hennes berättelse förblir konsekvent genom hela utredningen."
            }
        };
    }
}