using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuestGameDetective.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedFamilyDinnerCase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MurderCases",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "KillerIndex",
                value: 3);

            migrationBuilder.InsertData(
                table: "MurderCases",
                columns: new[] { "Id", "CauseOfDeath", "ClueImg", "CrimeSceneDescription", "CrimeSceneImg", "KillerIndex", "Place", "Priority", "ShortSummary", "SolutionText", "Title", "Victim", "VictimImg", "Weapon" },
                values: new object[] { new Guid("44444444-4444-4444-4444-444444444444"), "Akut arsenikförgiftning.", "tablebedroom.png", "Den vanliga söndagsmiddagen ägde rum i den stora matsalen på Ravenshire Manor.\n\nNär huvudrätten serverades tog Charlotte Ashbourne några klunkar ur sitt vinglas innan hon plötsligt tappade andan och föll ihop över bordet.\n\nFamiljens läkare, som anlände kort därefter, kunde snabbt konstatera att döden orsakats av arsenik.\n\nPolisen fann inga tecken på att giftet funnits i maten. Endast offrets vinglas innehöll spår av arsenik.\n\nVid bordet satt offrets föräldrar, hennes två systrar, hennes bror, offrets fästman samt systern Eleanors fästman, som var sen till middagen.\n\nFlera av de medverkande vid bordet kunde strykas som misstänkta direkt på plats.\n\nIngen i familjen beskriver middagen som särskilt konfliktfylld — men nästan samtliga medger att relationen till Charlotte stundtals varit komplicerad.", "familydinnercrime.png", 1, "Charlotte Ashbourne avled vid middagsbordet i familjens herrgård strax efter att huvudrätten serverats.", 2, "Under en stillsam familjemiddag faller den yngsta dottern plötsligt död ner efter att ha druckit ur sitt vinglas.", "Charlotte Ashbourne mördades av sin syster Eleanor Ashbourne.\n\nEleanor hade levt ett helt liv i skuggan av sin syster, som alltid varit familjens favorit och faderns ögonsten.\n\nMen när Charlotte inledde en relation med Arthur och planerade att rymma ihop, fick Eleanor nog och inskaffade arsenik.\n\nPå Eleanors finger upptäcktes en ring med ett dolt fack där hon förvarat giftet. Redan innan middagen smet hon förbi och hällde pulvret i systerns glas.\n\nCharlotte drack av vinet först när köträtten serverades.\n\nI Charlottes rum syntes tydliga tecken på att hon planerat att lämna familjens herrgård.\n\nPå Arthurs skjortkrage återfanns spår av samma röda läppstift som Charlotte bar under kvällen.\n\nUnder det avslutande förhöret bröt Eleanor slutligen samman och erkände mordet.", "Familjemiddags mordet på Ravenshire Manor", "Charlotte Ashbourne", "youngsistervictim.png", "Förgiftning - Arsenik blandat i offrets vinglas." });

            migrationBuilder.InsertData(
                table: "Suspects",
                columns: new[] { "Id", "InInvestigatorsNotes", "MurderCaseId", "Name", "Role", "Statement", "SuspectImg" },
                values: new object[,]
                {
                    { new Guid("dddddddd-1111-1111-1111-111111111111"), "Jonathan uppträder arrogant men verkar samtidigt genuint chockad över systerns död.", new Guid("44444444-4444-4444-4444-444444444444"), "Jonathan Ashbourne", "Brodern", "Förhörsrapport:\n\n\"Charlotte och jag stod aldrig varandra särskilt nära. Hon var yngst. Kom undan med allt. Allt hon pekade på skulle hon ha.\n\nHon har alltid varit mors favorit, och far skall vi inte prata om. Han dyrkade marken hon gick på. Jag vill inte ens veta hur mycket pengar han slängt på henne.\n\nMina föräldrar är redan gamla och sjuka, detta kommer väl ta livet av dem.\n\nJag? Mörda henne? Vad skulle jag vinna på det? Förresten reste jag mig aldrig från bordet under middagen och jag rörde inte hennes glas.\n\nJa, jag spelar ibland. Men det betyder inte att jag är en mördare.\"", "dinnerbrother.png" },
                    { new Guid("dddddddd-2222-2222-2222-222222222222"), "Eleanor framstår som känslomässigt instabil men saklig. Hon mjuknar när hon pratar om sin far.", new Guid("44444444-4444-4444-4444-444444444444"), "Eleanor Ashbourne", "Mellersta systern", "Förhörsrapport:\n\n\"Charlotte hade ett sätt att alltid få allt att handla om henne.\n\nMor och far avgudade henne nästan. Det är nästan skrattretande hur de kunde se henne som någon slags ängel.\n\nMen trots våra meningsskiljaktigheter var hon fortfarande min syster.\n\nJag gick visserligen bort mot serveringsbordet under middagen men bara för att hämta mer vin.\n\nNär jag kom tillbaka började far hosta igen och sedan… sedan föll Charlotte ihop.\"", "sister1.png" },
                    { new Guid("dddddddd-3333-3333-3333-333333333333"), "Thomas verkar uppriktigt skakad men flera familjemedlemmar beskriver relationen som mindre lycklig än han själv påstår.", new Guid("44444444-4444-4444-4444-444444444444"), "Thomas Whitmore", "Fästmannen", "Förhörsrapport:\n\n\"Charlotte och jag skulle gifta oss innan årets slut, det var tanken i alla fall.\n\nVi har grälat en del det sista. Jag tycker hon trycker bort mig. Ibland vet jag inte vad hon vill.\n\nMen jag älskade verkligen Charlotte. Jag vet inte om jag kan leva vidare utan henne i denna värld. Jag skulle aldrig göra henne illa.\n\nJag satt intill henne hela middagen. Men jag såg ingen lägga något i hennes glas. Men det är ju inte heller sådant man tänker på i vanliga fall.\n\nJag vet bara att hon plötsligt började hosta. Det gick så fort och sedan var hon bara död.\"", "tablefiance.png" },
                    { new Guid("dddddddd-4444-4444-4444-444444444444"), "Margaret verkar nervös men hennes berättelse förblir konsekvent genom hela utredningen.", new Guid("44444444-4444-4444-4444-444444444444"), "Margaret Ashbourne", "Äldre systern", "Förhörsrapport:\n\n\"Jag vill bara att det här skall vara över. Charlotte kunde vara hård men hon förtjänade inte det här.\n\nBortskämd? Ja, det kan man väl säga. Hon fick vad hon pekade på. Men det var mer mina föräldrars fel än hennes i så fall.\n\nJag såg Eleanor lämna bordet en kort stund. Hon sade att hon skulle hämta vin men jag tror snarare att hon var upprörd och hade svårt att sitta still.\n\nHennes fästman Arthur skulle varit med, men han var sen. Inte förrän vi börjat äta huvudrätten kom han in genom dörren.\n\nIngen av mina systrar tycks vara särskilt lyckliga i sina kärleksrelationer. Och folk frågar varför jag vill förbli ogift.\"", "bigsister2.png" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Suspects",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Suspects",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Suspects",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Suspects",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "MurderCases",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.UpdateData(
                table: "MurderCases",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "KillerIndex",
                value: 0);
        }
    }
}
