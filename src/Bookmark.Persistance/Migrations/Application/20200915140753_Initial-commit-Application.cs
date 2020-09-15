using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookmark.Persistance.Migrations.Application
{
    public partial class InitialcommitApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    DisplayIcon = table.Column<string>(nullable: true),
                    ExpireDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardFavorite",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CardsId = table.Column<Guid>(nullable: true),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardFavorite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardFavorite_Cards_CardsId",
                        column: x => x.CardsId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupShared",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CardsId = table.Column<Guid>(nullable: true),
                    GroupsId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupShared", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupShared_Cards_CardsId",
                        column: x => x.CardsId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupShared_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "DisplayIcon", "ExpireDate", "LastModified", "LastModifiedBy", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("acf5ad7b-5641-41d8-a832-aa31dae1f078"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Github account", "Bookmark", null, null, null, "Github Project Onion Architecture", "https://github.com/Amitpnk" },
                    { new Guid("0bee4cae-fdc7-43ba-aa15-687c4c0588fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Github account", "Bookmark", null, null, null, "Github Project Clean Architecture", "https://github.com/Amitpnk" },
                    { new Guid("f2e60eac-de02-4d91-8b99-f85768b1f1ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Github account", "Bookmark", null, null, null, "Github account", "https://github.com/Amitpnk" },
                    { new Guid("5a2508d8-6f0a-485e-8c4f-604d915d467f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Github account", "Bookmark", null, null, null, "Github account", "https://github.com/Amitpnk" },
                    { new Guid("c65b47ac-3ce7-4cbf-b398-946e681f2470"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Github account", "Bookmark", null, null, null, "Github account", "https://github.com/Amitpnk" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardFavorite_CardsId",
                table: "CardFavorite",
                column: "CardsId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupShared_CardsId",
                table: "GroupShared",
                column: "CardsId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupShared_GroupsId",
                table: "GroupShared",
                column: "GroupsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardFavorite");

            migrationBuilder.DropTable(
                name: "GroupShared");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
