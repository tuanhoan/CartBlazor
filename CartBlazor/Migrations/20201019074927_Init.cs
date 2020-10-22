using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CartBlazor.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CardId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imgText = table.Column<string>(maxLength: 1000, nullable: true),
                    money = table.Column<double>(nullable: false),
                    count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.CardId);
                });

            migrationBuilder.CreateTable(
                name: "CartImg",
                columns: table => new
                {
                    CartImgId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CartImgSrc = table.Column<string>(maxLength: 1000, nullable: true),
                    CardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartImg", x => x.CartImgId);
                    table.ForeignKey(
                        name: "FK_CartImg_Cart_CardId",
                        column: x => x.CardId,
                        principalTable: "Cart",
                        principalColumn: "CardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartImg_CardId",
                table: "CartImg",
                column: "CardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartImg");

            migrationBuilder.DropTable(
                name: "Cart");
        }
    }
}
