using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace JewelleryMine.Migrations
{
    public partial class InitCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ImageContent = table.Column<byte[]>(nullable: true),
                    SmallPreview = table.Column<byte[]>(nullable: true),
                    BigPreview = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LogMessage = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCollections",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCollections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jewels",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    PhotoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jewels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jewels_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jewels_Images_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Patronymic = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    PhotoId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: true),
                    BrowserType = table.Column<string>(nullable: true),
                    DeviceType = table.Column<string>(nullable: true),
                    DeviceOs = table.Column<int>(nullable: true),
                    IpAddress = table.Column<string>(nullable: true),
                    Locale = table.Column<string>(nullable: true),
                    UtmSource = table.Column<string>(nullable: true),
                    UtmMedium = table.Column<string>(nullable: true),
                    UtmCampaign = table.Column<string>(nullable: true),
                    UtmTerm = table.Column<string>(nullable: true),
                    UtmContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Images_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JewelCollections",
                columns: table => new
                {
                    JewelId = table.Column<Guid>(nullable: false),
                    ProductCollectionId = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JewelCollections", x => new { x.JewelId, x.ProductCollectionId });
                    table.ForeignKey(
                        name: "FK_JewelCollections_Jewels_JewelId",
                        column: x => x.JewelId,
                        principalTable: "Jewels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JewelCollections_ProductCollections_ProductCollectionId",
                        column: x => x.ProductCollectionId,
                        principalTable: "ProductCollections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Brooches" },
                    { 2, "Choker" },
                    { 3, "Pendants" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_JewelCollections_ProductCollectionId",
                table: "JewelCollections",
                column: "ProductCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Jewels_CategoryId",
                table: "Jewels",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Jewels_PhotoId",
                table: "Jewels",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PhotoId",
                table: "Users",
                column: "PhotoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JewelCollections");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Jewels");

            migrationBuilder.DropTable(
                name: "ProductCollections");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
