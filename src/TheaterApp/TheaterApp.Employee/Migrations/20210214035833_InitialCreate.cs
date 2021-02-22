using Microsoft.EntityFrameworkCore.Migrations;

namespace TheaterApp.Employee.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    EMailAddress = table.Column<string>(type: "TEXT", nullable: true),
                    MailingAddress = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    SeatingPreference = table.Column<string>(type: "TEXT", nullable: true),
                    IsSeasonTicketHolder = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasFoodAlergey = table.Column<bool>(type: "INTEGER", nullable: false),
                    FoodAlergey = table.Column<string>(type: "TEXT", nullable: true),
                    EmergencyContactFullName = table.Column<string>(type: "TEXT", nullable: true),
                    EmergencyContactPhone = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
