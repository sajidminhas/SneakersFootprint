using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakersFootprint.Migrations
{
    public partial class seeded4thitem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 1,
                column: "Price",
                value: 1199.95m);

            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 2,
                column: "Price",
                value: 779.95m);

            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 3,
                column: "Price",
                value: 499.95m);

            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "SneakerId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "Sale", "ShortDescription" },
                values: new object[] { 4, 1, "~/Images/loparskor-flex-runner-sTBg4T", "~/Images/loparskor-flex-runner-sTBg4T", true, "Precision-made, seamless zones combine strength and function with smooth comfort to ensure interference-free movements.Color shown: Core Black. Product code: FY9121", "Adidas", 1299.95m, false, "ULTRABOOST 4.0 DNA!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 1,
                column: "Price",
                value: 129.95m);

            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 2,
                column: "Price",
                value: 79.95m);

            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 3,
                column: "Price",
                value: 49.95m);
        }
    }
}
