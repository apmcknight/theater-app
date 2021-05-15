using Microsoft.EntityFrameworkCore.Migrations;

namespace TheaterApp.Employee.Migrations.Reservation
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReservationShow = table.Column<string>(type: "TEXT", nullable: true),
                    ReservationDate = table.Column<string>(type: "TEXT", nullable: true),
                    ReservationTime = table.Column<string>(type: "TEXT", nullable: true),
                    IsGroupSale = table.Column<bool>(type: "INTEGER", nullable: false),
                    ReservationGuestAmount = table.Column<int>(type: "INTEGER", nullable: false),
                    ReservationGuestNames = table.Column<string>(type: "TEXT", nullable: true),
                    ReservationGuestAlergey = table.Column<string>(type: "TEXT", nullable: true),
                    ReservationSeatingPreference = table.Column<string>(type: "TEXT", nullable: true),
                    ReservationCustomerName = table.Column<string>(type: "TEXT", nullable: true),
                    AddBirthdayPackage = table.Column<bool>(type: "INTEGER", nullable: false),
                    AddAnniversaryPackage = table.Column<bool>(type: "INTEGER", nullable: false),
                    WasReservationPrePaid = table.Column<bool>(type: "INTEGER", nullable: false),
                    ReservationPaymentDetails = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservation");
        }
    }
}
