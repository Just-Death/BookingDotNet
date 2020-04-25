using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingDotNet.Migrations
{
    public partial class SeedDataUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "LastName", "Name", "Password", "PhoneNumber" },
                values: new object[] { 1, "bkazhi@gmail.com", "Kazhi", "Berik", "123", "87771119966" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);
        }
    }
}
