using QuestGameDetective.Domain.Entities;
using QuestGameDetective.Domain.Enums;

namespace QuestGameDetective.Infrastructure.Data.Seed.CaseSeeds
{
    public static class NightTrainMurderSeed
    {
        public static readonly Guid CaseId =
            Guid.Parse("22222222-2222-2222-2222-222222222222");

        public static readonly MurderCase Case = new()
        {
            Id = CaseId,

            Priority = CasePriority.High,

            Title = "Mysteriet på nattåget till Edinburgh",

            ShortSummary =
                "En man återfinns död i en förstaklasskupé under nattresan mellan London och Skottland.",

            Victim = "Arthur Miller",

            VictimImg = "victim_train.png",

            Place =
                "Arthur Miller återfanns livlös i sin sittplats ombord på nattåget mot Edinburgh strax före gryningen.",

            CauseOfDeath =
                "Förgiftning genom ett starkt sömnmedel som orsakat andningsstillestånd.",

            Weapon =
                "Gift som injicerats i offrets högra arm.",

            CrimeSceneImg = "traincrime.png",

            ClueImg = "trainbag.png",

            CrimeSceneDescription =
                "Kupédörren hade varit låst från insidan under större delen av natten och inga vittnen har sett någon lämna eller komma in.\n\n" +

                "Endast fyra personer befann sig i kupén under resan: offret, Lady Eleanor Whitmore, hennes tjänsteflicka Clara Bennett samt den äldre pensionerade handelsmannen Harold Finch.\n\n" +

                "Offret skall ha varit först i kupen och då luktat starkt av alkohol, han var då vi liv och hälsade men anningen sluddrigt när de andra klev in.\n\n" +

                "Trots offrets enkla klädsel reste han i förstaklass, något flera vittnen på tåget beskrivit som ovanligt.\n\n" +

                "Ingen av de närvarande tycks känna offret sedan tidigare och samtliga hävdar att mannen var talförd och satt och läste tidningen när tåget lämnade London.",

            SolutionText =
                "Arthur Miller mördades av ... Arthur Miller. Mr Miller tog sitt eget liv vad polisen tror någon gång vid två på natten. \n\n" +

                "Ingen av de andra i hytten hade träffat offret sedan tidigare och hade såvidare inget med mannens död att göra.\n\n" +

                "Bara två veckor innan hade Mr Miller sökt vård för kraftiga smärtor i buken. Det visade sig att han var döende, läkaren gav honom knappt tre månader.\n\n" +

                "I ett frösök att dämpa smärtorna som blev allt värre, snabbt fick han både smärtstillande tabletter och injeseringssprutor för när det blev för illa.'\n\n" +

                "Mr Miller som var krimialfantast vägrade att dö på ett så tråkigt sätt som i smärtor på ett sjukhus. Nej han ville lämna som mördad.\n\n" +

                "Han lånade pengar av en bekant. Det räckte precis till en tågbiljett i första klass och en stor fin flaska wisky.\n\n" +

                "Efter att alla i kupen somnat var det bara för honom att plocka fram sprutan, injesera sig själv, slänga ner och sparka till sprutan på golvet och luta sig tillbaka.\n\n" ,

                

            KillerIndex = 0
        };

        public static readonly Suspect[] Suspects =
        {
            new Suspect // Killer
            {
                Id = Guid.Parse("bbbbbbbb-1111-1111-1111-111111111111"),

                MurderCaseId = CaseId,

                Name = "Lady Eleanor Whitmore",

                Role = "Överklassdam",

                SuspectImg = "trainlady.png",

                Statement =
                    "Förhörsrapport:\n\n" +

                    "\"Jag reste mot Edinburgh för att besöka min syster, hennes makes bortgång har tagit mycket hårt på henne\n\n" +

                    "Jag sovit? Sitandes? Sånt gör inte en Whitmore. Jag på min höjd blundade lite. Jag blir så åksju i tåg.\n\n" +

                    "Den döde mannen? Nej, jag har aldrig tidigare sett honom.\n\n" +

                    "Jag måste dock erkänna att jag fann det märkligt att en så enkelt klädd person reste i förstaklass.\n\n" +

                    "När jag var ung hade människor betydligt bättre förståelse för sin plats i samhället.\"",


                InInvestigatorsNotes =
                    "Lady Eleanor uppträder kyligt och kontrollerat men reagerar starkt när frågor om familj och tidigare relationer nämns."
            },

            new Suspect
            {
                Id = Guid.Parse("bbbbbbbb-2222-2222-2222-222222222222"),

                MurderCaseId = CaseId,

                Name = "Clara Bennett",

                Role = "Tjänsteflicka",

                SuspectImg = "trainmaid.png",

                Statement =
                    "Förhörsrapport:\n\n" +

                    "\"Jag har arbetat hos Lady Eleanor i ungefär ett år nu.\n\n" +

                    "Innan dess tjänade jag hos en familj i Brighton.\n\n" +

                    "Jag talade aldrig med den döde mannen. Han läste mest under resan. Sen somnade jag ganska snart.\n\n" +

                    "Lady Eleanor bad mig försöka sova eftersom vi hade en lång resa framför oss.\n\n" +

                    "Jag tror Elenore somnade förre mig, hon snarkar lite förstår ni.\"",


                InInvestigatorsNotes =
                    "Clara verkar nervös och undviker ögonkontakt. Det framstår mer som rädsla än skuld."
            },

            new Suspect
            {
                Id = Guid.Parse("bbbbbbbb-3333-3333-3333-333333333333"),

                MurderCaseId = CaseId,

                Name = "Harold Finch",

                Role = "Pensionerad handelsman",

                SuspectImg = "oldman.png",

                Statement =
                    "Förhörsrapport:\n\n" +

                    "\"Va? Ni måste tala högre konstapeln. Jag är nästan döv på höger öra oh ja vänster är väll inte mycket bättre. Jaha, mordet ja.\n\n" +

                    "Jag sov större delen av resan, precis som jag alltid gör på tåg. Jag är gift förstår ni, så jag passar alltid på med att få vila när jag har chansen\n\n" +

                    "Oberörd? Jag? Ja, när man nått mon åldern konstapeln så är det inte längre mycket som förvånar än. Jag har överlevt två världskrig och ett 40 årigt äktenskap. Då är det inte längre mycekt som får än att höja pulsen\n\n" +

                    "I London? Jag hade varit i London och hälsat på en gammal vän ifrån ungdomens dagar. Vi gick i skolan tillsammans.\n\n" +

                    "Nej, jag känner ingen av de andra passagerarna. Tror knappt jag hört hälften av vad de sagt heller och nog är det likabra de.\"",


                InInvestigatorsNotes =
                    "Harold Finch verkar ovanligt oberörd av situationen men hans berättelse förblir konsekvent under samtliga förhör."
            },

            new Suspect
            {
                Id = Guid.Parse("bbbbbbbb-4444-4444-4444-444444444444"),

                MurderCaseId = CaseId,

                Name = "Arthur Miller",

                Role = "Offret",

                SuspectImg = "victim_train.png",

                Statement =
                    "Polisens anteckningar:\n\n" +

                    "Arthur Miller bodde ensam i en mindre enrummare utanför London och arbetade sen en tid tillbaka i en bokaffär.\n\n" +

                    "Hans ekomomi var mycket stram och gav inga möjligheter till annant än det nödvänigaste\n\n" +

                    "I hemmet återfanns knappa personliga tillhörigheter men ett stor antal böcker, uppskattningsvis 20-30 stycken fanns under hans säng.\n\n" +

                    "Efter samtal med en mycket upprörd arbetsgivare visade det sig att samtliga böcker tagits ifrån hans affär under loppet av fyra år.\n\n" +

                    "Nästan alla böckerna var deckare, eller fackliteratur för krimonolgogi i olika former. Inga pengar hittades i bostade.",


                InInvestigatorsNotes =
                    "Offret framstår vid första anblick som obetydlig men flera detaljer antyder en dold koppling till någon i kupén."
            }
        };
    }
}
