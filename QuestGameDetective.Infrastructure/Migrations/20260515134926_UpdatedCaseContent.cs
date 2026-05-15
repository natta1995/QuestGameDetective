using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuestGameDetective.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCaseContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MurderCases",
                columns: new[] { "Id", "CauseOfDeath", "ClueImg", "CrimeSceneDescription", "CrimeSceneImg", "KillerIndex", "Place", "Priority", "ShortSummary", "SolutionText", "Title", "Victim", "VictimImg", "Weapon" },
                values: new object[] { new Guid("22222222-2222-2222-2222-222222222222"), "Förgiftning genom ett starkt sömnmedel som orsakat andningsstillestånd.", "trainbag.png", "Kupédörren hade varit låst från insidan under större delen av natten och inga vittnen har sett någon lämna eller komma in.\n\nEndast fyra personer befann sig i kupén under resan: offret, Lady Eleanor Whitmore, hennes tjänsteflicka Clara Bennett samt den äldre pensionerade handelsmannen Harold Finch.\n\nOffret skall ha varit först i kupen och då luktat starkt av alkohol, han var då vi liv och hälsade men anningen sluddrigt när de andra klev in.\n\nTrots offrets enkla klädsel reste han i förstaklass, något flera vittnen på tåget beskrivit som ovanligt.\n\nIngen av de närvarande tycks känna offret sedan tidigare och samtliga hävdar att mannen var talförd och satt och läste tidningen när tåget lämnade London.", "traincrime.png", 0, "Arthur Miller återfanns livlös i sin sittplats ombord på nattåget mot Edinburgh strax före gryningen.", 2, "En man återfinns död i en förstaklasskupé under nattresan mellan London och Skottland.", "Arthur Miller mördades av ... Arthur Miller. Mr Miller tog sitt eget liv vad polisen tror någon gång vid två på natten. \n\nIngen av de andra i hytten hade träffat offret sedan tidigare och hade såvidare inget med mannens död att göra.\n\nBara två veckor innan hade Mr Miller sökt vård för kraftiga smärtor i buken. Det visade sig att han var döende, läkaren gav honom knappt tre månader.\n\nI ett frösök att dämpa smärtorna som blev allt värre, snabbt fick han både smärtstillande tabletter och injeseringssprutor för när det blev för illa.'\n\nMr Miller som var krimialfantast vägrade att dö på ett så tråkigt sätt som i smärtor på ett sjukhus. Nej han ville lämna som mördad.\n\nHan lånade pengar av en bekant. Det räckte precis till en tågbiljett i första klass och en stor fin flaska wisky.\n\nEfter att alla i kupen somnat var det bara för honom att plocka fram sprutan, injesera sig själv, slänga ner och sparka till sprutan på golvet och luta sig tillbaka.\n\n", "Mysteriet på nattåget till Edinburgh", "Arthur Miller", "victim_train.png", "Gift som injicerats i offrets högra arm." });

            migrationBuilder.InsertData(
                table: "Suspects",
                columns: new[] { "Id", "InInvestigatorsNotes", "MurderCaseId", "Name", "Role", "Statement", "SuspectImg" },
                values: new object[,]
                {
                    { new Guid("bbbbbbbb-1111-1111-1111-111111111111"), "Lady Eleanor uppträder kyligt och kontrollerat men reagerar starkt när frågor om familj och tidigare relationer nämns.", new Guid("22222222-2222-2222-2222-222222222222"), "Lady Eleanor Whitmore", "Överklassdam", "Förhörsrapport:\n\n\"Jag reste mot Edinburgh för att besöka min syster, hennes makes bortgång har tagit mycket hårt på henne\n\nJag sovit? Sitandes? Sånt gör inte en Whitmore. Jag på min höjd blundade lite. Jag blir så åksju i tåg.\n\nDen döde mannen? Nej, jag har aldrig tidigare sett honom.\n\nJag måste dock erkänna att jag fann det märkligt att en så enkelt klädd person reste i förstaklass.\n\nNär jag var ung hade människor betydligt bättre förståelse för sin plats i samhället.\"", "trainlady.png" },
                    { new Guid("bbbbbbbb-2222-2222-2222-222222222222"), "Clara verkar nervös och undviker ögonkontakt. Det framstår mer som rädsla än skuld.", new Guid("22222222-2222-2222-2222-222222222222"), "Clara Bennett", "Tjänsteflicka", "Förhörsrapport:\n\n\"Jag har arbetat hos Lady Eleanor i ungefär ett år nu.\n\nInnan dess tjänade jag hos en familj i Brighton.\n\nJag talade aldrig med den döde mannen. Han läste mest under resan. Sen somnade jag ganska snart.\n\nLady Eleanor bad mig försöka sova eftersom vi hade en lång resa framför oss.\n\nJag tror Elenore somnade förre mig, hon snarkar lite förstår ni.\"", "trainmaid.png" },
                    { new Guid("bbbbbbbb-3333-3333-3333-333333333333"), "Harold Finch verkar ovanligt oberörd av situationen men hans berättelse förblir konsekvent under samtliga förhör.", new Guid("22222222-2222-2222-2222-222222222222"), "Harold Finch", "Pensionerad handelsman", "Förhörsrapport:\n\n\"Va? Ni måste tala högre konstapeln. Jag är nästan döv på höger öra oh ja vänster är väll inte mycket bättre. Jaha, mordet ja.\n\nJag sov större delen av resan, precis som jag alltid gör på tåg. Jag är gift förstår ni, så jag passar alltid på med att få vila när jag har chansen\n\nOberörd? Jag? Ja, när man nått mon åldern konstapeln så är det inte längre mycket som förvånar än. Jag har överlevt två världskrig och ett 40 årigt äktenskap. Då är det inte längre mycekt som får än att höja pulsen\n\nI London? Jag hade varit i London och hälsat på en gammal vän ifrån ungdomens dagar. Vi gick i skolan tillsammans.\n\nNej, jag känner ingen av de andra passagerarna. Tror knappt jag hört hälften av vad de sagt heller och nog är det likabra de.\"", "oldman.png" },
                    { new Guid("bbbbbbbb-4444-4444-4444-444444444444"), "Offret framstår vid första anblick som obetydlig men flera detaljer antyder en dold koppling till någon i kupén.", new Guid("22222222-2222-2222-2222-222222222222"), "Arthur Miller", "Offret", "Polisens anteckningar:\n\nArthur Miller bodde ensam i en mindre enrummare utanför London och arbetade sen en tid tillbaka i en bokaffär.\n\nHans ekomomi var mycket stram och gav inga möjligheter till annant än det nödvänigaste\n\nI hemmet återfanns knappa personliga tillhörigheter men ett stor antal böcker, uppskattningsvis 20-30 stycken fanns under hans säng.\n\nEfter samtal med en mycket upprörd arbetsgivare visade det sig att samtliga böcker tagits ifrån hans affär under loppet av fyra år.\n\nNästan alla böckerna var deckare, eller fackliteratur för krimonolgogi i olika former. Inga pengar hittades i bostade.", "victim_train.png" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Suspects",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Suspects",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Suspects",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Suspects",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "MurderCases",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));
        }
    }
}
