using Microsoft.EntityFrameworkCore.Migrations;

namespace NFL.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conference",
                columns: table => new
                {
                    ConferenceId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conference", x => x.ConferenceId);
                });

            migrationBuilder.CreateTable(
                name: "Division",
                columns: table => new
                {
                    DivisionId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division", x => x.DivisionId);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ConferenceId = table.Column<string>(nullable: true),
                    DivisionId = table.Column<string>(nullable: true),
                    LogoImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Team_Conference_ConferenceId",
                        column: x => x.ConferenceId,
                        principalTable: "Conference",
                        principalColumn: "ConferenceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Team_Division_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Division",
                        principalColumn: "DivisionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Conference",
                columns: new[] { "ConferenceId", "Name" },
                values: new object[,]
                {
                    { "afc", "AFC" },
                    { "nfc", "NFC" }
                });

            migrationBuilder.InsertData(
                table: "Division",
                columns: new[] { "DivisionId", "Name" },
                values: new object[,]
                {
                    { "north", "North" },
                    { "south", "South" },
                    { "east", "East" },
                    { "west", "West" }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "ConferenceId", "DivisionId", "LogoImage", "Name" },
                values: new object[,]
                {
                    { "bal", "afc", "north", "BAL.png", "Baltimore Ravens" },
                    { "oak", "afc", "west", "OAK.png", "Oakland RaIders" },
                    { "lar", "nfc", "west", "LAR.png", "Los Angeles Rams" },
                    { "lac", "afc", "west", "LAC.png", "Los Angeles Chargers" },
                    { "kc", "afc", "west", "KC.png", "Kansas City Chiefs" },
                    { "den", "afc", "west", "DEN.png", "Denver Broncos" },
                    { "ari", "nfc", "west", "ARI.png", "Arizona Cardinals" },
                    { "was", "nfc", "east", "WAS.png", "Washington Redskins" },
                    { "phi", "nfc", "east", "PHI.png", "Philadelphia Eagles" },
                    { "nyj", "afc", "east", "NYJ.png", "New York Jets" },
                    { "nyg", "nfc", "east", "NYG.png", "New York Giants" },
                    { "ne", "afc", "east", "NE.png", "New England Patriots" },
                    { "mia", "afc", "east", "MIA.png", "Miami Dolphins" },
                    { "dal", "nfc", "east", "DAL.png", "Dallas Cowboys" },
                    { "buf", "afc", "east", "BUF.png", "Buffalo Bills" },
                    { "ten", "afc", "south", "TEN.png", "Tennessee Titans" },
                    { "tb", "nfc", "south", "TB.png", "Tampa Bay Buccaneers" },
                    { "no", "nfc", "south", "NO.png", "New Orleans Saints" },
                    { "jax", "afc", "south", "JAX.png", "Jacksonville Jaguars" },
                    { "ind", "afc", "south", "IND.png", "Indianapolis Colts" },
                    { "hou", "afc", "south", "HOU.png", "Houston Texans" },
                    { "car", "nfc", "south", "CAR.png", "Carolina Panthers" },
                    { "atl", "nfc", "south", "ATL.png", "Atlanta Falcons" },
                    { "pit", "afc", "north", "PIT.png", "Pittsburgh Steelers" },
                    { "min", "nfc", "north", "MIN.png", "Minnesota Vikings" },
                    { "gb", "nfc", "north", "GB.png", "Green Bay Packers" },
                    { "det", "nfc", "north", "DET.png", "Detroit Lions" },
                    { "cle", "afc", "north", "CLE.png", "Cleveland Browns" },
                    { "cin", "afc", "north", "CIN.png", "Cincinnati Bengals" },
                    { "chi", "nfc", "north", "CHI.png", "Chicago Bears" },
                    { "sea", "nfc", "west", "SEA.png", "Seattle Seahawks" },
                    { "sf", "nfc", "west", "SF.png", "San Francisco 49ers" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Team_ConferenceId",
                table: "Team",
                column: "ConferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_DivisionId",
                table: "Team",
                column: "DivisionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Conference");

            migrationBuilder.DropTable(
                name: "Division");
        }
    }
}
