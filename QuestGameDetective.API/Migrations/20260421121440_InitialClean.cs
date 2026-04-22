using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuestGameDetective.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialClean : Migration
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
                    Priority = table.Column<int>(type: "int", nullable: false),
                    KillerIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MurderCases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MurderCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<int>(type: "int", nullable: false),
                    AcceptedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Reminder20hSent = table.Column<bool>(type: "bit", nullable: false),
                    Reminder1hSent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quests", x => x.Id);
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
                name: "Suspects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statement = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                columns: new[] { "Id", "CauseOfDeath", "CrimeSceneDescription", "KillerIndex", "Place", "Priority", "ShortSummary", "SolutionText", "Title", "Victim", "Weapon" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "A gunshot wound to the head", "The library is panelled in dark oak, its tall bookshelves stretching up toward the ceiling.\nA dying fire crackles faintly in the hearth. Sir Reginald sits slumped in his leather armchair,\na revolver near his right hand and a half-finished glass of whisky on the side table.\nRain patters rhythmically against the tall window overlooking the quiet street.", 1, "His private library on Kensington Row", 1, "A wealthy gentleman is found dead in his private library. Four individuals were inside the house that evening.", "The revolver in the wrong hand makes suicide unlikely from the start. Several suspects tell small lies, but only one has a true motive.\n\nEdmund's story about writing letters collapses under scrutiny; he cannot recall simple details, and no such letter is found.\nFaced with the inconsistencies, he finally confesses — he shot Sir Reginald in the library to secure his inheritance.", "The Library Murder on Kensington Row", "Sir Reginald Blackwood", "A small revolver found near his right hand." },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Poisoning", "Thunder shakes the old manor as candles flicker along the long dining hall.\nLord Ashcroft lies collapsed at the head of the table, his untouched dessert before him.\nRain lashes against the tall windows, and the storm has knocked out the telephone lines.\nThe guests — all visibly shaken — stand gathered near the fireplace, each avoiding the others’ gaze.", 0, "The dining hall of Ashcroft Manor", 2, "During a stormy night at the remote Ashcroft Manor, the master of the house dies during his own dinner party. Four guests remain under suspicion.", "The wet hem of Lady Ashcroft’s dress contradicts her claim of staying inside the dining hall.\nShe slipped out during a clap of thunder, mixed arsenic into her husband’s wine, and returned unnoticed.\nDr. Graves could not have poisoned the wine from the study, and the Colonel and Miss Whitfield had no opportunity.\nWith mounting evidence and no alibi left standing, Lady Ashcroft ultimately confesses to the crime.", "The Midnight Tragedy at Ashcroft Manor", "Lord Percival Ashcroft", "A crystal glass containing traces of arsenic" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Blunt force trauma", "The workshop is cluttered with intricate devices, the air filled with the steady ticking of dozens of clocks.\nTobias Wren lies face-down beside his workbench, a large brass gear stained with blood nearby.\nShards of glass cover the floor, and a single pocket watch ticks loudly from the victim’s hand.", 3, "His clockmaking shop in Covent Garden", 0, "A famous clockmaker is found dead in his workshop among shattered gears and ticking mechanisms. Four individuals had business with him that evening.", "The workshop door being locked suggests the killer exited through the back window.\nMrs. Finch insisted she was not present, yet brass dust on her gloves proves she had been inside the workshop.\nHer motive — unpaid rent — is the strongest among the suspects, and the tampered pocket watch was staged to mimic a struggle.\nConfronted with the inconsistencies, Mrs. Finch breaks down and confesses.", "The Clockmaker’s Last Hour in Covent Garden", "Mr. Tobias Wren", "A heavy brass gear found on the floor beside the body" }
                });

            migrationBuilder.InsertData(
                table: "Suspects",
                columns: new[] { "Id", "Label", "MurderCaseId", "Name", "Statement" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-1111-1111-1111-111111111111"), "the butler", new Guid("11111111-1111-1111-1111-111111111111"), "Mr. Hargreaves", "\"I was in the kitchen, sir, listening to the wireless when the shot rang out — or so they tell me. I heard nothing at all.\"" },
                    { new Guid("aaaaaaaa-2222-2222-2222-222222222222"), "the nephew", new Guid("11111111-1111-1111-1111-111111111111"), "Edmund Blackwood", "\"I spent the evening in the guest room, writing letters. I never left the room, I assure you.\"" },
                    { new Guid("aaaaaaaa-3333-3333-3333-333333333333"), "the housekeeper", new Guid("11111111-1111-1111-1111-111111111111"), "Mrs. Beatrice Bloom", "\"I was polishing the silver in the dining room. I did not go near the library, not once.\"" },
                    { new Guid("aaaaaaaa-4444-4444-4444-444444444444"), "the neighbour", new Guid("11111111-1111-1111-1111-111111111111"), "Mrs. Evelyn Ashdown", "\"I left before the rain began. I heard nothing unusual, and the gentleman was quite well when I saw him last.\"" },
                    { new Guid("bbbbbbbb-1111-1111-1111-111111111111"), "the widow", new Guid("22222222-2222-2222-2222-222222222222"), "Lady Imogen Ashcroft", "\"Percival was in good health, I assure you. I only poured his wine, as I always do.\"" },
                    { new Guid("bbbbbbbb-2222-2222-2222-222222222222"), "the family physician", new Guid("22222222-2222-2222-2222-222222222222"), "Dr. Lionel Graves", "\"I stepped out to the study to fetch my medical kit. I returned only when I heard Lady Ashcroft scream.\"" },
                    { new Guid("bbbbbbbb-3333-3333-3333-333333333333"), "the old friend", new Guid("22222222-2222-2222-2222-222222222222"), "Colonel Barnaby Holt", "\"I was smoking in the conservatory. The thunder was so loud I heard nothing of the commotion inside.\"" },
                    { new Guid("bbbbbbbb-4444-4444-4444-444444444444"), "the governess", new Guid("22222222-2222-2222-2222-222222222222"), "Miss Clara Whitfield", "\"I was preparing the children for bed and only came down when the staff called for me.\"" },
                    { new Guid("cccccccc-1111-1111-1111-111111111111"), "the client", new Guid("33333333-3333-3333-3333-333333333333"), "Madame Valérie DuPont", "\"I came to collect my repaired watch, but Mr. Wren told me it wasn’t ready. I left immediately.\"" },
                    { new Guid("cccccccc-2222-2222-2222-222222222222"), "the apprentice", new Guid("33333333-3333-3333-3333-333333333333"), "Arthur Bellamy", "\"I stepped out for a smoke. When I returned, the door was locked from the inside.\"" },
                    { new Guid("cccccccc-3333-3333-3333-333333333333"), "the officer", new Guid("33333333-3333-3333-3333-333333333333"), "Inspector Harold Briggs", "\"I arrived to question Wren regarding a stolen heirloom. When I knocked, no one answered.\"" },
                    { new Guid("cccccccc-4444-4444-4444-444444444444"), "the landlord", new Guid("33333333-3333-3333-3333-333333333333"), "Mrs. Adelaide Finch", "\"He owed me two months’ rent, but I did not come here tonight. I was visiting my sister.\"" }
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
