using Microsoft.EntityFrameworkCore.Migrations;

namespace TheaterApp.Client.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    EMailAddress = table.Column<string>(nullable: true),
                    MailingAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    SeatingPreference = table.Column<string>(nullable: true),
                    IsSeasonTicketHolder = table.Column<bool>(nullable: false),
                    HasFoodAlergey = table.Column<bool>(nullable: false),
                    FoodAlergey = table.Column<string>(nullable: true),
                    EmergencyContactFullName = table.Column<string>(nullable: true),
                    EmergencyContactPhone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
