using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuestGameDetective.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MurderCases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Victim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VictimAge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VictimJob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VictimLifeSituation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CauseOfDeath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weapon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CrimeSceneDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SolutionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SolutionClues = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VictimImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CrimeSceneImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CrimeSceneImgText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClueImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClueImgText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondClueImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondClueImgText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    KillerIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MurderCases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MurderCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<int>(type: "int", nullable: false),
                    AcceptedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Reminder20hSent = table.Column<bool>(type: "bit", nullable: false),
                    Reminder1hSent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quests_MurderCases_MurderCaseId",
                        column: x => x.MurderCaseId,
                        principalTable: "MurderCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suspects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LifeSituation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuspectImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InInvestigatorsNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MurderCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suspects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suspects_MurderCases_MurderCaseId",
                        column: x => x.MurderCaseId,
                        principalTable: "MurderCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MurderCases",
                columns: new[] { "Id", "CauseOfDeath", "ClueImg", "ClueImgText", "CrimeSceneDescription", "CrimeSceneImg", "CrimeSceneImgText", "KillerIndex", "Place", "Priority", "SecondClueImg", "SecondClueImgText", "ShortSummary", "SolutionClues", "SolutionText", "Title", "Victim", "VictimAge", "VictimImg", "VictimJob", "VictimLifeSituation", "Weapon" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "En skottskada mot sidan av huvudet. Offret avled omedelbart.", "housemap.png", "Planlösning över fastigheten", "Lord Cedric Blackwood påträffades död i sitt privata bibliotek av husets butler omkring halv nio på aftonen. Polisen anlände till herrgården kort därefter.\nDen avlidne låg livlös vid sitt skrivbord med en skottskada mot huvudet. Intill offrets högra hand återfanns en revolver, senare identifierad som tillhörande Lord Blackwood själv. (Se brottsplatsfotografi.)\nVapnets hölster återfanns i den översta byrålådan i biblioteket, vilket antyder att revolvern nyligen tagits fram.\nBiblioteket uppvisade inga tydliga tecken på strid, inbrott eller annan våldsam oordning. Detsamma gällde övriga delar av bostaden.\nPå golvet bakom skrivbordet återfanns dessutom ett handskrivet brev, vilket vid första anblick förefaller vara ett självmordsbrev. (Se fotografi — bevismaterial.)\nTrots detta framstår flera detaljer på brottsplatsen som märkligt arrangerade, vilket väcker misstanke om att dödsfallet inte är fullt så enkelt som det först verkar.", "crimescene.png", "Brottsplatsfotografi – Biblioteket", 1, "Brottet begicks i offrets egen bostad, närmare bestämt i biblioteket.", 1, "LibraryMurder-Letter.png", "Självmordsbrevet som hittades på brottsplatsen", "Den förmögne affärsmannen Lord Cedric Blackwood hittas död på golvet i sitt privata bibliotek en fredagskväll.", "• På flera fotografier syns att Lord Blackwood konsekvent använde vänster hand vid skrivande och tedrickande.\n• På brottsplatsfotografiet återfanns revolvern placerad nära offrets högra hand trots att offret var vänsterhänt.\n• Självmordsbrevet uppvisar tydliga drag av att ha skrivits av en högerhänt person.\n• De övriga misstänkta hade känt Lord Blackwood i många år och var väl medvetna om hans vänsterhänthet.\n• Edmund Blackwood hade endast vistats i huset under en kortare tid och saknade samma kännedom om offrets vanor.", "Lord Cedric Blackwood mördades av sin brorson Edmund Blackwood, som under en längre tid dragit på sig betydande skulder och såg sin farbror som sin sista möjlighet till ekonomisk räddning.\nUtredningen tog en avgörande vändning när det framkom att Lord Blackwood var vänsterhänt. På både skrivbordet och i övriga delar av biblioteket återfanns personliga föremål konsekvent placerade till vänster om honom.\nTrots detta återfanns revolvern intill offrets högra hand, och skottskadan tydde på att vapnet avfyrats från höger sida.\nDet handskrivna självmordsbrevet visade dessutom tydliga tecken på att ha skrivits av någon som använt höger hand.\nDe övriga misstänkta hade alla arbetat eller levt nära Lord Blackwood under många års tid och kände väl till hans vänsterhänthet. Edmund däremot hade endast vistats i huset under en kortare period.\nSammantaget pekar bevisningen mot att brottsplatsen medvetet arrangerats för att efterlikna ett självmord.", "Mordet i biblioteket på Kensington Row", "Sir Cedric Blackwood", "69 år", "victim.png", "Affärsman - Delägare", "Levde i stor villa tillsammans med tjänstefolk och sin brorson. Mycket förmögen. Ogift och utan barn. Enda kvarvarande familj är hans bror och brorsbarn.", "Revolver som återfinns på brottsplatsen" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Andningsstillestånd orsakat av en kraftig överdos av morfinbaserat smärtstillande medel.", "trainbag.png", "Innehållet i offrets väska", "Arthur Miller påträffades död strax före gryningen av konduktören under nattågets färd mot Edinburgh.\nKupédörren hade varit låst från insidan större delen av natten och inga vittnen hade sett någon lämna eller beträda kupén efter att tåget lämnat London.\nEndast tre andra personer befann sig i förstaklasskupén under resan: Lady Eleanor Whitmore, hennes tjänsteflicka Clara Bennett samt den pensionerade handelsmannen Harold Finch.\nOffret satt tillbakalutad i sin sittplats och såg vid första anblick ut att ha somnat. Först när konduktören försökte väcka mannen upptäcktes att han var avliden.\nEn mindre injektionsspruta återfanns senare under offrets säte. På offrets högra arm kunde dessutom ett mindre stickmärke observeras.\nTrots den ovanliga situationen återfanns inga tydliga tecken på kamp eller våld inne i kupén.\nFlera passagerare uppgav däremot att offret under kvällen luktat kraftigt av alkohol och verkat ovanligt avslappnad trots sin enkla klädsel och det dyra resesällskapet.", "traincrime.png", "Brottsplatsfotografi – Förstaklasskupén", 4, "Brottet ägde rum ombord på nattåget mellan London och Edinburgh, i en låst förstaklasskupé.", 1, "doctorLetter.png", "Medicinsk handling hittas på offrets köksbord", "En man återfinns död i en låst förstaklasskupé under nattresan mellan London och Edinburgh.", "• En medicinsk spruta återfanns på golvet intill offret.\n• Ett läkarintyg återfanns bland offrets tillhörigheter som visade att han led av obotlig cancer.\n• Offret reste ensam i en förstaklasskupé trots att han vid första anblick verkade vara en man med mycket begränsade tillgångar.\n• På fotografiet av offrets resväska syns endast ett fåtal ägodelar: en dyr flaska whisky, flera kriminalromaner, mediciner samt ett mycket litet antal mynt.\n• Väskan var ovanligt sparsamt packad för en längre resa.", "Arthur Miller mördades inte av någon av de övriga passagerarna. Mannen tog sitt eget liv någon gång under natten.\nUtredningen tog en avgörande vändning när polisens läkare kunde koppla den återfunna sprutan till ett kraftigt morfinbaserat läkemedel.\nVid vidare undersökning framkom att Arthur Miller endast två veckor tidigare diagnostiserats med en dödlig sjukdom och enligt läkarna hade mycket kort tid kvar att leva.\nI offrets bagage återfanns både medicinska dokument och smärtstillande preparat utskrivna i hans eget namn.\nArthur Miller var dessutom känd av sin arbetsgivare som en stor beundrare av kriminalromaner och verkliga mordutredningar.\nPolisen drog därför slutsatsen att mannen medvetet iscensatt sin egen död som ett till synes omöjligt mord ombord på nattåget.\nEfter att de övriga passagerarna somnat injicerade han själv läkemedlet, dolde sprutan under sätet och inväntade därefter döden.", "Mysteriet på nattåget till Edinburgh", "Arthur Miller", "43 år", "victim_train.png", "Butiksbiträde i bokhandel", "Levde ensam i en mindre enrummare utanför London. Hade få nära relationer och mycket begränsad ekonomi.", "Medicinsk injektionsspruta återfunnen under offrets säte." },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Akut arsenikförgiftning.", "tablebedroom.png", "Fotografi från Charlottes sovrum", "Den traditionella söndagsmiddagen hölls i den stora matsalen på Ravenshire Manor.\nNär huvudrätten serverades tog Charlotte Ashbourne några klunkar ur sitt vinglas innan hon plötsligt började hosta våldsamt och föll ihop över bordet.\nFamiljens läkare anlände kort därefter och kunde endast konstatera att den unga kvinnan redan var avliden.\nVid senare undersökning återfanns tydliga spår av arsenik i offrets vinglas. Inga övriga glas eller maträtter visade däremot tecken på förgiftning.\nVid middagsbordet befann sig offrets föräldrar, hennes två systrar, brodern Jonathan Ashbourne, Charlottes fästman Thomas Fairford samt systern Helenas fästman Julian Pembroke, som anlände sent till middagen.\nTrots familjens försök att beskriva relationerna som goda framkommer det snabbt under förhören att flera familjemedlemmar hyst stark bitterhet gentemot Charlotte under en längre tid.", "familydinnercrime.png", "Brottsplatsfotografi – Middagsbordet efter dödsfallet", 1, "Ravenshire Manor, strax utanför London.", 2, "charlottediary.png", "Dagboks hittad under offrets säng", "Under en till synes stillsam familjemiddag faller den yngsta dottern plötsligt död ner efter att ha druckit ur sitt vinglas.", "• Endast Charlottes vinglas innehöll spår av arsenik.\n• Helena Ashbourne lämnade bordet ensam under middagen under förevändning att hämta mer vin.\n• På fotografiet från Charlottes sovrum syns en halvpackad resväska samt ett porträtt av Thomas Fairford.\n• Dagboksanteckningar återfunna i offrets rum visar att Charlotte planerade att bryta sin förlovning och rymma följande morgon.\n• På Helenas ring upptäcktes senare ett dolt fack innehållande rester av arsenik.", "Charlotte Ashbourne mördades av sin syster Helena Ashbourne.\nUnder större delen av sitt liv hade Helena levt i skuggan av sin yngre syster, som ständigt behandlades som familjens favorit.\nNär Charlotte dessutom planerade att lämna Ravenshire Manor tillsammans med Thomas Fairford växte Helenas bitterhet till hat.\nHelena hade sedan flera veckor tillbaka införskaffat arsenik som hon gömde i ett dolt fack i sin ring.\nUnder middagen lämnade hon bordet under förevändning att hämta mer vin och passade då på att hälla giftet i Charlottes glas.\nCharlotte drack först av vinet när huvudrätten serverades.\nI Charlottes sovrum återfanns en halvpackad resväska, privata brev samt dagboksanteckningar som tydligt visade att hon planerade att rymma följande morgon.\nUnder det avslutande förhöret bröt Helena slutligen samman och erkände mordet.", "Familjemiddagsmordet på Ravenshire Manor", "Charlotte Ashbourne", "23 år", "youngsistervictim.png", "Överklassdam", "Yngsta dottern i familjen Ashbourne. Levde ett skyddat liv på Ravenshire Manor men planerade i hemlighet att lämna familjens herrgård.", "Arsenik blandat i offrets vinglas." }
                });

            migrationBuilder.InsertData(
                table: "Suspects",
                columns: new[] { "Id", "Age", "InInvestigatorsNotes", "Job", "LifeSituation", "MurderCaseId", "Name", "Role", "Statement", "SuspectImg" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-1111-1111-1111-111111111111"), "52 år", "Mr. Hargreaves verkar skakad, men blir märkbart upprörd när samtalet kommer in på hans syster.", "Arbetat som butler hela livet, de senaste 24 åren hos Lord Cedric Blackwood", "Aldrig gift, inga barn och bor i ett litet rum på nedervåningen. Enda familjen är en sjuk syster i Brighton.", new Guid("11111111-1111-1111-1111-111111111111"), "Mr. Hargreaves", "Offrets butler", "Förhörsrapport:\n\"Jag befann mig i mitt rum på nedre våningen större delen av aftonen, sir. På fredagar brukar jag erhålla några timmars ledighet.\nI vanliga fall hade jag tagit mig en promenad till den lokala puben, men sedan min syster insjuknade går större delen av min lön till hennes uppehälle.\nHon blev änka tidigare i år, och inte långt därefter stupade hennes ende son i kriget. Nu är hon så svag att hon knappt förmår lämna sin säng.\nJag hade önskat flytta ned till Brighton för att finna arbete där och ta hand om henne, men Lord Blackwood vägrar låta mig lämna min tjänst.\nUtan ett ordentligt rekommendationsbrev från min arbetsgivare lär ingen vilja anställa mig.\nMen kanske nu… efter alla dessa år i hans tjänst. Kanske kommer min lojalitet äntligen att betyda något.\nMörda honom? Nej, sir — absolut inte. Lord Blackwood må ha varit en egendomlig herre, men någon ond man var han inte.\nJa, det var jag som fann honom. Eftersom jag ändå stannade inne den kvällen gick jag upp till biblioteket med en kopp te vid halv åtta.\nOch där låg han redan död.\nJag hörde inget skott under aftonen, men radion stod på större delen av eftermiddagen. Dessutom är huset mycket väl ljudisolerat.\"", "butler.png" },
                    { new Guid("aaaaaaaa-2222-2222-2222-222222222222"), "26 år", "Edmund försöker framstå som lugn och hjälpsam men svarar undvikande på frågor om sin ekonomi och de brev han påstår sig ha skrivit.", "Arbetslös", "Blev utslängd av sin far för tre veckor sedan. Hans farbror Lord Cedric Blackwood tog in honom i sitt hem och lät honom bo i gästrummet.", new Guid("11111111-1111-1111-1111-111111111111"), "Edmund Blackwood", "Offrets brorson", "Förhörsrapport:\n\"Jag tillbringade större delen av aftonen i mitt rum, där jag skrev brev och ordnade vissa personliga angelägenheter.\nInte för att det egentligen angår er, sir, men jag har flera betydande affärer under uppsegling. Min far, liksom min farfar före honom, var båda framstående män inom affärsvärlden.\nVem jag skrev till är av privat natur och har inget med denna utredning att göra.\nAtt jag skulle ha mördat min farbror är fullständigt befängt. Lord Cedric tog emot mig i sitt hem efter att relationen mellan min far och mig blivit... ansträngd.\nDäremot kan jag inte förneka att både butlern och hushållerskan vid flera tillfällen låtit sin bitterhet över honom komma till uttryck när de trott sig vara ensamma.\nVad jag själv tror? Självmord.\nJag råkade överhöra några av polismännen tala om ett brev som påträffats i biblioteket. Ett självmordsbrev, om jag förstod saken rätt.\nMin farbror började bli en gammal man. Hälsan svek honom allt mer för varje månad som gick, och relationerna inom hushållet hade länge varit ansträngda.\nDet är en tragisk historia, sir. Men jag fruktar att hans dalande liv till sist blev för mycket för farbror.\"", "nephew.png" },
                    { new Guid("aaaaaaaa-3333-3333-3333-333333333333"), "61 år", "Hushållerskan verkar mest irriterad och arg, men samtidigt uppriktig.", "Hushållerska, arbetat hela livet inom hushållstjänst och de senaste 15 åren hos Lord Cedric Blackwood", "Änka, en vuxen dotter. Bosatt i en liten etta ett stenkast från huset.", new Guid("11111111-1111-1111-1111-111111111111"), "Mrs. Beatrice Bloom", "Offrets hushållerska", "Förhörsrapport:\n\"Jag förstår fortfarande inte varför jag behövde föras hit till polisstationen. Folk kommer börja tala, det är jag övertygad om.\nJa, Sir Cedric kunde stundtals vara en besvärlig herre att arbeta för, men det betyder inte att jag önskade livet ur honom.\nJag var förargad över honom de senaste veckorna. Han klagade ständigt på min mat och påstod att den gjorde honom sjuk. Fullständigt trams, om ni frågar mig.\nNågot skott hörde jag inte, nej. Men jag får medge att jag inte befann mig i huset under hela aftonen.\nVid halv sju höll jag på att förbereda kvällsmaten när jag råkade välta en hel kanna lingondricka över mina kläder.\nSå mellan halv sju och åtta befann jag mig hemma för att byta om. Något jag skäms en aning över att behöva erkänna.\nOch om ni frågar mig har det inte varit annat än bekymmer sedan den där slyngeln Edward flyttade in.\nTidigare under dagen var även Sir Victor Hawthorne där, Lord Blackwoods affärspartner. När jag stod i trappan kunde jag inte undgå att höra hur de grälade i biblioteket.\nHade jag varit i er sits, sir, hade jag tagit mig ett ordentligt samtal med honom också.\"", "housekeeper.png" },
                    { new Guid("aaaaaaaa-4444-4444-4444-444444444444"), "66 år", "Affärspartnern framstår som samlad och vältalig, men samtidigt märkbart skakad över sin gamle väns bortgång.", "Framstående affärsman", "Boende i stor herrgård tillsammans med sin hustru och tjänstefolk. Flera vuxna barn och en handfull barnbarn.", new Guid("11111111-1111-1111-1111-111111111111"), "Sir Victor Hawthorne", "Offrets affärspartner", "Polisens anteckningar:\n\"Ja, det stämmer, konstapeln. Jag besökte Cedric tidigare under dagen. Jag tittade förbi på väg hem från arbetet.\nCedric brukade emellanåt arbeta hemifrån efter lunchtid, och först tänkte jag att den diskussion vi haft tidigare under dagen kunde vänta till efter helgen.\nMen jag ändrade mig under hemvägen. Cedric ville att vi skulle erbjuda arbete åt hans förbaskade brorson, och det hade jag inga som helst intentioner att gå med på.\nInte nog med att jag tvivlar starkt på att unge Edward någonsin utfört en ärlig dags arbete i hela sitt liv — det hade dessutom skapat problem inom firman.\nJag har nio barn, konstapeln. Tjugotvå barnbarn, varav åtminstone femton är i arbetsför ålder. Hur hade det sett ut om jag började dela ut tjänster enbart på grund av släktskap?\nFirman hade gått under innan året var slut, och det sade jag också till Cedric.\nNär allt väl lagts fram medgav han faktiskt att jag hade en poäng.\nSjälvmord, säger ni? Nej... det har jag svårt att tro.\nCedric var sitt vanliga reserverade jag. Något trött kanske, men fullt samlad. Vi skakade hand, sade att vi skulle ses igen på måndag, och därefter gick jag hem.\nRedan före klockan sex var jag tillbaka i mitt eget hus.\"", "workPartner.png" },
                    { new Guid("bbbbbbbb-1111-1111-1111-111111111111"), "58 år", "Lady Eleanor uppträder kyligt och kontrollerat men verkar genuint obekväm av hela situationen.", "Överklassdam", "Tillhör en gammal aristokratisk familj och reser regelbundet mellan London och Edinburgh för att besöka släktingar.", new Guid("22222222-2222-2222-2222-222222222222"), "Lady Eleanor Whitmore", "Passagerare i kupén", "Förhörsrapport:\n\"Jag reste till Edinburgh för att besöka min syster. Hennes makes bortgång tidigare under året har tagit mycket hårt på henne.\nSova sittandes på ett tåg? Nej, konstapeln. Sådant må andra människor ägna sig åt. Jag vilade möjligen ögonen en stund.\nDen döde mannen hade jag aldrig tidigare sett.\nJag måste dock medge att jag fann det märkligt att en så enkelt klädd person reste i förstaklass.\nNär jag var ung hade människor en betydligt bättre förståelse för sin plats i samhället.\"", "trainlady.png" },
                    { new Guid("bbbbbbbb-2222-2222-2222-222222222222"), "21 år", "Clara verkar nervös men hennes berättelse förblir konsekvent under förhöret.", "Tjänsteflicka", "Arbetar sedan ett år tillbaka åt Lady Eleanor Whitmore. Kommer ursprungligen från Brighton.", new Guid("22222222-2222-2222-2222-222222222222"), "Clara Bennett", "Lady Eleanors tjänsteflicka", "Förhörsrapport:\n\"Jag har arbetat hos Lady Eleanor i ungefär ett år nu.\nInnan dess tjänade jag hos en familj i Brighton.\nJag talade aldrig med den döde mannen. Han läste mest under resan och verkade hålla sig för sig själv.\nLady Eleanor sade åt mig att försöka sova eftersom vi hade en lång resa framför oss.\nJag tror faktiskt att hennes nåd somnade före mig. Hon snarkar lite ibland, förstår ni.\"", "trainmaid.png" },
                    { new Guid("bbbbbbbb-3333-3333-3333-333333333333"), "71 år", "Harold Finch framstår som ovanligt lugn men hans berättelse innehåller inga tydliga motsägelser.", "Pensionerad handelsman", "Änkeman och pensionerad köpman. Bor ensam i utkanten av Edinburgh.", new Guid("22222222-2222-2222-2222-222222222222"), "Harold Finch", "Passagerare i kupén", "Förhörsrapport:\n\"Va? Ni får tala högre, konstapeln. Hörseln är inte vad den en gång var.\nJag sov större delen av resan, precis som jag alltid gör på tåg.\nOberörd? Nej då, men när man nått min ålder är det inte mycket som längre förvånar en.\nJag har överlevt två krig och fyrtio års äktenskap. Då lär man sig hålla huvudet kallt.\nI London besökte jag en gammal vän från ungdomens dagar. Vi gick i skolan tillsammans.\nNej, jag kände inte den döde mannen och knappt någon av de andra passagerarna heller.\"", "oldman.png" },
                    { new Guid("bbbbbbbb-4444-4444-4444-444444444444"), "31 år", "Dr. Charles Mortimer framstår som uppriktigt förfärad över vad som inträffat. Under förhöret uppträder han nervöst men samarbetsvilligt och inga tydliga motsägelser framkommer.", "Läkare", "Gift och far till tre barn. Har praktiserat som läkare i sju år. Känd som ordningsam och har aldrig tidigare varit i kontakt med polisen.", new Guid("22222222-2222-2222-2222-222222222222"), "Dr. Charles Mortimer", "Offrets läkare", "Förhörsrapport:\n\"Ja, det stämmer, konstapeln. Jag var Arthur Millers läkare, även om jag inte behandlat honom särskilt länge.\nMr Miller sökte först vård för återkommande buksmärtor. Efter mina inledande undersökningar remitterade jag honom vidare till en specialistklinik i London.\nDet visade sig dessvärre att han led av långt framskriden cancer.\nSjukdomen hade redan gått mycket långt och läkarna gav honom endast en kort tid kvar att leva.\nJa, jag skrev ut både smärtstillande tabletter och morfininjektioner för att hjälpa honom hantera smärtorna.\nMen jag försäkrar er, konstapeln, att all medicinering skedde helt enligt medicinska rekommendationer för patienter i hans tillstånd.\nDet är en fruktansvärd tragedi alltihop.\nMr Miller verkade visserligen nedstämd vid vårt senaste möte, men jag hade aldrig kunnat föreställa mig något sådant här.\"", "doctor.png" },
                    { new Guid("dddddddd-1111-1111-1111-111111111111"), "31 år", "Jonathan uppträder arrogant men verkar samtidigt genuint skakad över systerns död.", "Arvtagare", "Spelberoende och svårt skuldsatt efter flera misslyckade investeringar.", new Guid("33333333-3333-3333-3333-333333333333"), "Jonathan Ashbourne", "Brodern", "Förhörsrapport:\n\"Charlotte och jag stod aldrig varandra särskilt nära.\nHon var yngst och kom undan med precis allting.\nMor avgudade henne och far behandlade henne som om hon vore någon sorts prinsessa.\nJag vill inte ens veta hur mycket pengar som lagts på hennes nöjen genom åren.\nMen tro inte att det betyder att jag önskade henne död.\nMina föräldrar är gamla och redan svaga. Det här kommer ta livet av dem.\nJag reste mig aldrig från bordet under middagen och jag rörde aldrig hennes glas.\nOch ja, jag spelar ibland. Men spelare och mördare är inte samma sak, konstapeln.\"", "dinnerbrother.png" },
                    { new Guid("dddddddd-2222-2222-2222-222222222222"), "27 år", "Helena framstår som känslomässigt instabil men försöker hela tiden behålla kontrollen över sig själv.", "Överklassdam", "Bor fortfarande kvar på familjens herrgård och lever under sin fars strikta kontroll.", new Guid("33333333-3333-3333-3333-333333333333"), "Helena Ashbourne", "Mellersta systern", "Förhörsrapport:\n\"Charlotte hade ett märkligt sätt att få hela världen att kretsa kring henne.\nMor och far såg henne nästan som någon sorts liten ängel.\nDet är nästan skrattretande när man tänker på det.\nMen trots våra meningsskiljaktigheter var hon fortfarande min syster.\nJa, jag gick bort mot serveringsbordet under middagen men endast för att hämta mer vin.\nNär jag kom tillbaka började far hosta igen och sedan… sedan föll Charlotte ihop.\nAllting gick så fruktansvärt fort.\"", "sister1.png" },
                    { new Guid("dddddddd-3333-3333-3333-333333333333"), "29 år", "Thomas verkar uppriktigt förtvivlad men flera familjemedlemmar beskriver relationen som betydligt mindre lycklig än han själv påstår.", "Banktjänsteman", "Förlovad med Charlotte Ashbourne men relationen beskrivs som turbulent av flera familjemedlemmar.", new Guid("33333333-3333-3333-3333-333333333333"), "Thomas Fairford", "Fästmannen", "Förhörsrapport:\n\"Charlotte och jag planerade att gifta oss innan årets slut.\nÅtminstone var det planen.\nVi har haft våra gräl den senaste tiden men jag älskade henne verkligen.\nJag satt intill henne under hela middagen och jag såg ingen röra hennes glas.\nMen sådant är kanske heller inget man lägger märke till under en vanlig familjemiddag.\nJag vet bara att hon plötsligt började hosta och sedan… sedan var hon borta.\nJag skulle aldrig kunna skada Charlotte. Aldrig.\"", "tablefiance.png" },
                    { new Guid("dddddddd-4444-4444-4444-444444444444"), "35 år", "Margaret verkar nervös men hennes berättelse förblir konsekvent genom hela utredningen.", "Överklassdam", "Äldsta systern i familjen. Har aldrig gift sig och fungerar ofta som medlare mellan familjemedlemmarna.", new Guid("33333333-3333-3333-3333-333333333333"), "Margaret Ashbourne", "Äldre systern", "Förhörsrapport:\n\"Jag vill bara att det här skall vara över.\nCharlotte kunde vara svår ibland men hon förtjänade inte detta.\nBortskämd? Ja, kanske.\nMen det var mer mors och fars fel än hennes.\nJag såg Helena lämna bordet under middagen. Hon sade att hon skulle hämta mer vin men hon verkade snarare upprörd.\nHelenas fästman Julian anlände dessutom sent till middagen.\nIngen av mina systrar tycks ha varit särskilt lyckliga.\nOch folk frågar fortfarande varför jag valt att förbli ogift.\"", "bigsister2.png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Quests_MurderCaseId",
                table: "Quests",
                column: "MurderCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Suspects_MurderCaseId",
                table: "Suspects",
                column: "MurderCaseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Quests");

            migrationBuilder.DropTable(
                name: "Suspects");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MurderCases");
        }
    }
}
