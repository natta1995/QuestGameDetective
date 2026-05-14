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
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CauseOfDeath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weapon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CrimeSceneDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SolutionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VictimImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CrimeSceneImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClueImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                columns: new[] { "Id", "CauseOfDeath", "ClueImg", "CrimeSceneDescription", "CrimeSceneImg", "KillerIndex", "Place", "Priority", "ShortSummary", "SolutionText", "Title", "Victim", "VictimImg", "Weapon" },
                values: new object[] { new Guid("11111111-1111-1111-1111-111111111111"), "En skottskada mot högra sidan av huvudet.", "housemap.png", "Efter en noggrann undersökning kunde polisen inte finna några tecken på inbrott eller att någon obehörig tagit sig in i huset.\n\nVapnet identifierades snabbt som Sir Cedrics egen revolver. En tillhörande vapenkassett återfanns i skrivbordslådan.\n\nTrots detta kunde inget avskedsbrev eller annan förklaring till ett möjligt självmord hittas i vare sig biblioteket eller resten av fastigheten.\n\nInga värdesaker tycks heller ha försvunnit enligt tjänstefolket, och biblioteket visar inga tydliga spår av kamp eller genomsökning.\n\nVid första anblick framstår dödsfallet nästan som arrangerat.", "crimescene.png", 1, "Sir Cedric återfanns död i sitt privata bibliotek på Kensington Row strax efter klockan 18 av husets butler.", 1, "Den förmögne affärsmannen Sir Cedric Blackwood hittas död på golvet i sitt privata bibliotek under fredagskvällen.", "Sir Cedric Blackwood mördades av sin brorson Edmund Blackwood, som var svårt skuldsatt och desperat i behov av pengar.\n\nEdmund hade nyligen flyttat in i herrgårdens gästrum efter att ha lyckats vinna sin farbrors förtroende.\n\nUnder förhören försökte Edmund beskriva den gamle mannen som trött, sjuklig och nedbruten, nästan som om han ville plantera tanken om självmord hos polisen.\n\nTjänstefolket motsäger dock detta och beskriver istället Sir Cedric som arbetsam och ovanligt skärpt för sin ålder.\n\nDen avgörande detaljen återfinns på brottsplatsen. Revolvern ligger vid offrets högra hand och skottskadan sitter på höger sida av huvudet.\n\nMen på skrivbordets vänstra sida ligger både penna och tekopp placerade på ett sätt som tydligt visar att Sir Cedric var vänsterhänt.\n\nEdmund, som endast bott i huset en kortare tid, kände aldrig till detta.", "Mordet i biblioteket på Kensington Row", "Sir Cedric Blackwood", "victim.png", "En liten revolver återfunnen nära offrets högra hand." });

            migrationBuilder.InsertData(
                table: "Suspects",
                columns: new[] { "Id", "InInvestigatorsNotes", "MurderCaseId", "Name", "Role", "Statement", "SuspectImg" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-1111-1111-1111-111111111111"), "Butlern uppträder korrekt och behärskat men blir märkbart obekväm när frågor om arv och familjekonflikter nämns.", new Guid("11111111-1111-1111-1111-111111111111"), "Mr. Hargreaves", "Butlern", "Förhörsrapport:\n\n\"Jag befann mig i mitt rum på nedre våningen större delen av kvällen, sir. På fredagar brukar jag få några timmar ledigt.\n\nJag lyssnade på radion och hörde varken något skott eller något bråk. Ingen besökare kom heller till huset vad jag vet.\n\nSir Cedric brukade sitta ensam i biblioteket om kvällarna. Vid sextiden serverade jag honom som vanligt te — svart, utan socker.\"", "butler.png" },
                    { new Guid("aaaaaaaa-2222-2222-2222-222222222222"), "Edmund försöker framstå som lugn och hjälpsam men svarar undvikande på frågor om sin ekonomi och de brev han påstår sig ha skrivit.", new Guid("11111111-1111-1111-1111-111111111111"), "Edmund Blackwood", "Brorsonen", "Förhörsrapport:\n\n\"Jag tillbringade större delen av kvällen i gästrummet där jag skrev brev och försökte ordna mina affärer.\n\nMin farbror och jag hade naturligtvis våra meningsskiljaktigheter, men det hade nog vem som helst haft med en man som Sir Cedric.\n\nHan var gammal, envis och arbetade långt mer än vad hans hälsa tillät honom.\n\nJag vet inte om någon mördat honom eller om han själv valde att avsluta sitt liv.\n\nMen hushållerskan och min farbror grälade ofta. Jag hörde själv höjda röster tidigare samma morgon.\"", "nephew.png" },
                    { new Guid("aaaaaaaa-3333-3333-3333-333333333333"), "Hushållerskan verkar mer irriterad över polisförhöret än över själva dödsfallet. Samtidigt beskriver hon offret med oväntad uppriktighet.", new Guid("11111111-1111-1111-1111-111111111111"), "Mrs. Beatrice Bloom", "Hushållerskan", "Förhörsrapport:\n\n\"Jag förstår fortfarande inte varför jag behövde tas hit till polisstationen. Folk kommer börja prata.\n\nJa, Sir Cedric kunde vara svår att ha att göra med, men det betyder inte att jag önskade livet ur honom.\n\nHan klagade på maten nästan varje dag trots att jag lagat mat åt fina familjer i över tjugo år.\n\nBönor och bacon ville han ha till förbannelse. Inte uppskattade han min korvomelett heller.\n\nMen arbete — det kunde den mannen. Inte ens åldern verkade få honom att sakta ner.\"", "housekeeper.png" },
                    { new Guid("aaaaaaaa-4444-4444-4444-444444444444"), "Det framstår som osannolikt att Sir Cedric frivilligt skulle avsluta sitt liv utan tydligare motiv eller avsked.", new Guid("11111111-1111-1111-1111-111111111111"), "Sir Cedric Blackwood", "Offret", "Polisens anteckningar:\n\nKan Sir Cedric Blackwood ha tagit sitt eget liv?\n\nNågot avskedsbrev har inte återfunnits och inget på brottsplatsen tyder på desperation eller förberedelser inför självmord.\n\nOffrets husläkare uppger att Sir Cedric nyligen sökt vård för åldersrelaterade besvär och försämrad hälsa, men ingen allvarlig diagnos hade fastställts.\n\nTrots sitt tillbakadragna sätt beskrivs han av tjänstefolket som disciplinerad, skarp och starkt fäst vid sitt arbete.\n\nSamtliga personer som bott under Sir Cedrics tak tycks bära på egna konflikter, ekonomiska problem eller personliga hemligheter.", "victim.png" }
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
