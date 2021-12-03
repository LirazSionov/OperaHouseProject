using Microsoft.EntityFrameworkCore.Migrations;

namespace OperaHouseMidProject.Migrations
{
    public partial class CreateAllClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fluent_artists",
                columns: table => new
                {
                    ArtistId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    BirthDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    City = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Fluent_concerts",
                columns: table => new
                {
                    ConcertId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InstanceName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ConductorName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Hour = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    HallName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HallNum = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Cost = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_concerts", x => x.ConcertId);
                });

            migrationBuilder.CreateTable(
                name: "Fluent_conductors",
                columns: table => new
                {
                    ArtistId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    BirthDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    City = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SpecializationType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_conductors", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Fluent_guests",
                columns: table => new
                {
                    GuestId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GuestName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcertName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HallName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateConcert = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hour = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_guests", x => x.GuestId);
                });

            migrationBuilder.CreateTable(
                name: "Fluent_halls",
                columns: table => new
                {
                    HallId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HallName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SeatsNum = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_halls", x => x.HallId);
                });

            migrationBuilder.CreateTable(
                name: "Fluent_InstanceType",
                columns: table => new
                {
                    InstanceID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Composer = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Writer = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    DateWriting = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_InstanceType", x => x.InstanceID);
                });

            migrationBuilder.CreateTable(
                name: "Fluent_players",
                columns: table => new
                {
                    ArtistId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    BirthDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    City = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    MusicalInstrument = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_players", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Fluent_users",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fluent_artists");

            migrationBuilder.DropTable(
                name: "Fluent_concerts");

            migrationBuilder.DropTable(
                name: "Fluent_conductors");

            migrationBuilder.DropTable(
                name: "Fluent_guests");

            migrationBuilder.DropTable(
                name: "Fluent_halls");

            migrationBuilder.DropTable(
                name: "Fluent_InstanceType");

            migrationBuilder.DropTable(
                name: "Fluent_players");

            migrationBuilder.DropTable(
                name: "Fluent_users");
        }
    }
}
