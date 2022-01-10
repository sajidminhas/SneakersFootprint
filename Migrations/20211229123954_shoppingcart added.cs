using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakersFootprint.Migrations
{
    public partial class shoppingcartadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCardItems_Sneakers_SneakerId",
                table: "ShoppingCardItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCardItems",
                table: "ShoppingCardItems");

            migrationBuilder.RenameTable(
                name: "ShoppingCardItems",
                newName: "ShoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCardItems_SneakerId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_SneakerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Sneakers_SneakerId",
                table: "ShoppingCartItems",
                column: "SneakerId",
                principalTable: "Sneakers",
                principalColumn: "SneakerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Sneakers_SneakerId",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItems",
                newName: "ShoppingCardItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_SneakerId",
                table: "ShoppingCardItems",
                newName: "IX_ShoppingCardItems_SneakerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCardItems",
                table: "ShoppingCardItems",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCardItems_Sneakers_SneakerId",
                table: "ShoppingCardItems",
                column: "SneakerId",
                principalTable: "Sneakers",
                principalColumn: "SneakerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
