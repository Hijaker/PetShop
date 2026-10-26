using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Migrations
{
    /// <inheritdoc />
    public partial class NamingUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Animals_AnimalId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "AnimalId",
                table: "OrderDetails",
                newName: "AnimalID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_AnimalId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_AnimalID");

            migrationBuilder.RenameColumn(
                name: "AnimalId",
                table: "Animals",
                newName: "AnimalID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Animals_AnimalID",
                table: "OrderDetails",
                column: "AnimalID",
                principalTable: "Animals",
                principalColumn: "AnimalID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Animals_AnimalID",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "AnimalID",
                table: "OrderDetails",
                newName: "AnimalId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_AnimalID",
                table: "OrderDetails",
                newName: "IX_OrderDetails_AnimalId");

            migrationBuilder.RenameColumn(
                name: "AnimalID",
                table: "Animals",
                newName: "AnimalId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Animals_AnimalId",
                table: "OrderDetails",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "AnimalId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
