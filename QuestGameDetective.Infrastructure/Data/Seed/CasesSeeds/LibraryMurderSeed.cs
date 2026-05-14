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

            Title = "Mordet i biblioteket på Kensington Row",

            ShortSummary =
                "Den förmögne affärsmannen Sir Cedric Blackwood hittas död på golvet i sitt privata bibliotek under fredagskvällen.",

            Victim = "Sir Cedric Blackwood",

            VictimImg = "victim.png",

            Place =
                "Sir Cedric återfanns död i sitt privata bibliotek på Kensington Row strax efter klockan 18 av husets butler.",

            CauseOfDeath =
                "En skottskada mot högra sidan av huvudet.",

            Weapon =
                "En liten revolver återfunnen nära offrets högra hand.",

            CrimeSceneImg = "crimescene.png",

            ClueImg = "housemap.png",

            CrimeSceneDescription =
                "Efter en noggrann undersökning kunde polisen inte finna några tecken på inbrott eller att någon obehörig tagit sig in i huset.\n\n" +

                "Vapnet identifierades snabbt som Sir Cedrics egen revolver. En tillhörande vapenkassett återfanns i skrivbordslådan.\n\n" +

                "Trots detta kunde inget avskedsbrev eller annan förklaring till ett möjligt självmord hittas i vare sig biblioteket eller resten av fastigheten.\n\n" +

                "Inga värdesaker tycks heller ha försvunnit enligt tjänstefolket, och biblioteket visar inga tydliga spår av kamp eller genomsökning.\n\n" +

                "Vid första anblick framstår dödsfallet nästan som arrangerat.",

            SolutionText =
                "Sir Cedric Blackwood mördades av sin brorson Edmund Blackwood, som var svårt skuldsatt och desperat i behov av pengar.\n\n" +

                "Edmund hade nyligen flyttat in i herrgårdens gästrum efter att ha lyckats vinna sin farbrors förtroende.\n\n" +

                "Under förhören försökte Edmund beskriva den gamle mannen som trött, sjuklig och nedbruten, nästan som om han ville plantera tanken om självmord hos polisen.\n\n" +

                "Tjänstefolket motsäger dock detta och beskriver istället Sir Cedric som arbetsam och ovanligt skärpt för sin ålder.\n\n" +

                "Den avgörande detaljen återfinns på brottsplatsen. Revolvern ligger vid offrets högra hand och skottskadan sitter på höger sida av huvudet.\n\n" +

                "Men på skrivbordets vänstra sida ligger både penna och tekopp placerade på ett sätt som tydligt visar att Sir Cedric var vänsterhänt.\n\n" +

                "Edmund, som endast bott i huset en kortare tid, kände aldrig till detta.",

            KillerIndex = 1
        };

        public static readonly Suspect[] Suspects =
        {
            new Suspect
            {
                Id = Guid.Parse("aaaaaaaa-1111-1111-1111-111111111111"),

                MurderCaseId = CaseId,

                Name = "Mr. Hargreaves",

                Role = "Butlern",

                SuspectImg = "butler.png",

                Statement =
                    "Förhörsrapport:\n\n" +

                    "\"Jag befann mig i mitt rum på nedre våningen större delen av kvällen, sir. På fredagar brukar jag få några timmar ledigt.\n\n" +

                    "Jag lyssnade på radion och hörde varken något skott eller något bråk. Ingen besökare kom heller till huset vad jag vet.\n\n" +

                    "Sir Cedric brukade sitta ensam i biblioteket om kvällarna. Vid sextiden serverade jag honom som vanligt te — svart, utan socker.\"",


                InInvestigatorsNotes =
                    "Butlern uppträder korrekt och behärskat men blir märkbart obekväm när frågor om arv och familjekonflikter nämns."
            },

            new Suspect // Killer
            {
                Id = Guid.Parse("aaaaaaaa-2222-2222-2222-222222222222"),

                MurderCaseId = CaseId,

                Name = "Edmund Blackwood",

                Role = "Brorsonen",

                SuspectImg = "nephew.png",

                Statement =
                    "Förhörsrapport:\n\n" +

                    "\"Jag tillbringade större delen av kvällen i gästrummet där jag skrev brev och försökte ordna mina affärer.\n\n" +

                    "Min farbror och jag hade naturligtvis våra meningsskiljaktigheter, men det hade nog vem som helst haft med en man som Sir Cedric.\n\n" +

                    "Han var gammal, envis och arbetade långt mer än vad hans hälsa tillät honom.\n\n" +

                    "Jag vet inte om någon mördat honom eller om han själv valde att avsluta sitt liv.\n\n" +

                    "Men hushållerskan och min farbror grälade ofta. Jag hörde själv höjda röster tidigare samma morgon.\"",


                InInvestigatorsNotes =
                    "Edmund försöker framstå som lugn och hjälpsam men svarar undvikande på frågor om sin ekonomi och de brev han påstår sig ha skrivit."
            },

            new Suspect
            {
                Id = Guid.Parse("aaaaaaaa-3333-3333-3333-333333333333"),

                MurderCaseId = CaseId,

                Name = "Mrs. Beatrice Bloom",

                Role = "Hushållerskan",

                SuspectImg = "housekeeper.png",

                Statement =
                    "Förhörsrapport:\n\n" +

                    "\"Jag förstår fortfarande inte varför jag behövde tas hit till polisstationen. Folk kommer börja prata.\n\n" +

                    "Ja, Sir Cedric kunde vara svår att ha att göra med, men det betyder inte att jag önskade livet ur honom.\n\n" +

                    "Han klagade på maten nästan varje dag trots att jag lagat mat åt fina familjer i över tjugo år.\n\n" +

                    "Bönor och bacon ville han ha till förbannelse. Inte uppskattade han min korvomelett heller.\n\n" +

                    "Men arbete — det kunde den mannen. Inte ens åldern verkade få honom att sakta ner.\"",


                InInvestigatorsNotes =
                    "Hushållerskan verkar mer irriterad över polisförhöret än över själva dödsfallet. Samtidigt beskriver hon offret med oväntad uppriktighet."
            },

            new Suspect
            {
                Id = Guid.Parse("aaaaaaaa-4444-4444-4444-444444444444"),

                MurderCaseId = CaseId,

                Name = "Sir Cedric Blackwood",

                Role = "Offret",

                SuspectImg = "victim.png",

                Statement =
                    "Polisens anteckningar:\n\n" +

                    "Kan Sir Cedric Blackwood ha tagit sitt eget liv?\n\n" +

                    "Något avskedsbrev har inte återfunnits och inget på brottsplatsen tyder på desperation eller förberedelser inför självmord.\n\n" +

                    "Offrets husläkare uppger att Sir Cedric nyligen sökt vård för åldersrelaterade besvär och försämrad hälsa, men ingen allvarlig diagnos hade fastställts.\n\n" +

                    "Trots sitt tillbakadragna sätt beskrivs han av tjänstefolket som disciplinerad, skarp och starkt fäst vid sitt arbete.\n\n" +

                    "Samtliga personer som bott under Sir Cedrics tak tycks bära på egna konflikter, ekonomiska problem eller personliga hemligheter.",


                InInvestigatorsNotes =
                    "Det framstår som osannolikt att Sir Cedric frivilligt skulle avsluta sitt liv utan tydligare motiv eller avsked."
            }
        };
    }
}