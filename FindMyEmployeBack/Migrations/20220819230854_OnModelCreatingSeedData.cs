using Microsoft.EntityFrameworkCore.Migrations;

namespace FindMyEmployeBack.Migrations
{
    public partial class OnModelCreatingSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LocalizationType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Grenoble" },
                    { 2, "Paris" },
                    { 3, "Toulouse" },
                    { 4, "Marseille" },
                    { 5, "Lyon" },
                    { 6, "Perpignan" },
                    { 7, "Lille" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocalizationType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LocalizationType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LocalizationType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LocalizationType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LocalizationType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LocalizationType",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LocalizationType",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
